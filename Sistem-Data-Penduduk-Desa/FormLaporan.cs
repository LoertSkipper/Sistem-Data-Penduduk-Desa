using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Sistem_Data_Penduduk_Desa.konfigurasi;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormLaporan : Form
    {
        private Koneksi Koneksi = new Koneksi();

        public FormLaporan()
        {
            InitializeComponent();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void FormLaporan_Load(object sender, EventArgs e)
        {
            LoadComboRW();
            LoadComboPekerjaan();
            LoadData();
        }

        // =========================
        // LOAD COMBO RW
        // Mengambil seluruh data RW dari tabel kartu_keluarga.
        // =========================
        private void LoadComboRW()
        {
            cbxRw.Items.Clear();
            cbxRw.Items.Add("-- Semua RW --");

            string query = "SELECT DISTINCT rw FROM kartu_keluarga WHERE rw IS NOT NULL AND rw <> '' ORDER BY rw";
            DataTable dt = Koneksi.eksekusiQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                cbxRw.Items.Add(row["rw"].ToString());
            }

            cbxRw.SelectedIndex = 0;
        }

        // =========================
        // LOAD COMBO PEKERJAAN
        // Mengambil seluruh data pekerjaan dari database.
        // =========================
        private void LoadComboPekerjaan()
        {
            cbxPekerjaan.Items.Clear();
            cbxPekerjaan.Items.Add("-- Semua Pekerjaan --");

            string query = "SELECT nama_pekerjaan FROM pekerjaan ORDER BY nama_pekerjaan";
            DataTable dt = Koneksi.eksekusiQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                cbxPekerjaan.Items.Add(row["nama_pekerjaan"].ToString());
            }

            cbxPekerjaan.SelectedIndex = 0;
        }

        // =========================
        // LOAD DATA
        // Menampilkan seluruh data penduduk tanpa filter.
        // =========================
        private void LoadData()
        {
            string query =
                "SELECT p.nik, p.nama, p.jk, kk.no_kk, kk.rw, pk.nama_pekerjaan, pd.jenjang " +
                "FROM penduduk p " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                "INNER JOIN pekerjaan pk ON p.id_pekerjaan = pk.id_pekerjaan " +
                "INNER JOIN pendidikan pd ON p.id_pendidikan = pd.id_pendidikan " +
                "ORDER BY p.nama";

            TampilkanData(query);
        }

        // =========================
        // FILTER DATA
        // Filter berdasarkan RW, Pekerjaan, dan/atau Nama.
        // Dapat dikombinasikan secara bebas.
        // =========================
        private void FilterData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                "SELECT p.nik, p.nama, p.jk, kk.no_kk, kk.rw, pk.nama_pekerjaan, pd.jenjang " +
                "FROM penduduk p " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                "INNER JOIN pekerjaan pk ON p.id_pekerjaan = pk.id_pekerjaan " +
                "INNER JOIN pendidikan pd ON p.id_pendidikan = pd.id_pendidikan " +
                "WHERE 1=1 "
            );

            string selectedRw = (cbxRw.SelectedIndex > 0)
                ? cbxRw.SelectedItem?.ToString() ?? ""
                : "";

            string selectedPekerjaan = (cbxPekerjaan.SelectedIndex > 0)
                ? cbxPekerjaan.SelectedItem?.ToString() ?? ""
                : "";

            string cariNama = tbxnama.Text.Trim();

            if (!string.IsNullOrEmpty(selectedRw))
                sb.Append($"AND kk.rw = '{selectedRw}' ");

            if (!string.IsNullOrEmpty(selectedPekerjaan))
                sb.Append($"AND pk.nama_pekerjaan = '{selectedPekerjaan}' ");

            if (!string.IsNullOrEmpty(cariNama))
                sb.Append($"AND p.nama LIKE '%{cariNama}%' ");

            sb.Append("ORDER BY p.nama");

            TampilkanData(sb.ToString());
        }

        // =========================
        // TAMPILKAN DATA
        // Mengeksekusi query dan mengisi DataGridView.
        // =========================
        private void TampilkanData(string query)
        {
            DataTable dt = Koneksi.eksekusiQuery(query);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string jk = row["jk"].ToString() == "L" ? "Laki-Laki" : "Perempuan";

                dataGridView1.Rows.Add(
                    row["nik"],
                    row["nama"],
                    jk,
                    row["no_kk"],
                    row["rw"],
                    row["nama_pekerjaan"],
                    row["jenjang"]
                );
            }

            HitungTotal();
        }

        // =========================
        // HITUNG TOTAL
        // Memperbarui label jumlah baris yang tampil di DataGridView.
        // =========================
        private void HitungTotal()
        {
            label6.Text = dataGridView1.Rows.Count.ToString();
        }

        // =========================
        // EXPORT EXCEL
        // Mengekspor seluruh isi DataGridView ke file .xlsx menggunakan ClosedXML.
        // =========================
        private void ExportExcel()
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.FileName = "Laporan_Data_Penduduk_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Laporan Penduduk");

                // --- Baris Judul ---
                ws.Cell(1, 1).Value = "LAPORAN DATA KEPENDUDUKAN DESA";
                ws.Range(1, 1, 1, 7).Merge();
                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 1).Style.Font.FontSize = 14;
                ws.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                ws.Cell(2, 1).Value = "Tanggal Cetak: " + DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                ws.Range(2, 1, 2, 7).Merge();
                ws.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                ws.Cell(3, 1).Value = $"Total Data: {dataGridView1.Rows.Count} orang";
                ws.Range(3, 1, 3, 7).Merge();
                ws.Cell(3, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                // --- Header Kolom ---
                int headerRow = 5;
                string[] headers = { "NIK", "Nama Lengkap", "Jenis Kelamin", "No KK", "RW", "Pekerjaan", "Pendidikan" };

                for (int i = 0; i < headers.Length; i++)
                {
                    var cell = ws.Cell(headerRow, i + 1);
                    cell.Value = headers[i];
                    cell.Style.Font.Bold = true;
                    cell.Style.Fill.BackgroundColor = XLColor.FromArgb(70, 130, 180);
                    cell.Style.Font.FontColor = XLColor.White;
                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cell.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    cell.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    cell.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                    cell.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                }

                // --- Data Rows ---
                int dataRow = headerRow + 1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        var cell = ws.Cell(dataRow, col + 1);
                        cell.Value = row.Cells[col].Value?.ToString() ?? "";
                        cell.Style.Border.BottomBorder = XLBorderStyleValues.Hair;
                        cell.Style.Border.TopBorder = XLBorderStyleValues.Hair;
                        cell.Style.Border.LeftBorder = XLBorderStyleValues.Hair;
                        cell.Style.Border.RightBorder = XLBorderStyleValues.Hair;

                        // Zebra stripping (baris genap diberi latar biru muda)
                        if ((dataRow % 2) == 0)
                            cell.Style.Fill.BackgroundColor = XLColor.FromArgb(240, 248, 255);
                    }
                    dataRow++;
                }

                // Border luar tabel
                if (dataRow > headerRow + 1)
                {
                    ws.Range(headerRow, 1, dataRow - 1, headers.Length)
                      .Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                }

                ws.Columns().AdjustToContents();

                wb.SaveAs(sfd.FileName);

                MessageBox.Show(
                    $"Export Excel berhasil!\nFile disimpan di:\n{sfd.FileName}",
                    "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal export Excel:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // CETAK PDF
        // Membuat laporan PDF menggunakan iText7.
        // Nomor halaman ditulis pada tahap stamping setelah dokumen selesai dibuat.
        // =========================
        private void CetakPDF()
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files (*.pdf)|*.pdf";
            sfd.FileName = "Laporan_Data_Penduduk_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            if (sfd.ShowDialog() != DialogResult.OK) return;

            // File sementara, nomor halaman akan di-stamp kemudian
            string tempPath = sfd.FileName + ".tmp.pdf";

            try
            {
                // --- TAHAP 1: Buat dokumen utama ---
                using (var writer = new PdfWriter(tempPath))
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4.Rotate());
                    doc.SetMargins(35, 35, 50, 35);

                    PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                    // Judul
                    doc.Add(
                        new Paragraph("LAPORAN DATA KEPENDUDUKAN DESA")
                            .SetFont(fontBold).SetFontSize(16)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetMarginBottom(4)
                    );

                    doc.Add(
                        new Paragraph("Tanggal Cetak: " + DateTime.Now.ToString("dd MMMM yyyy  HH:mm"))
                            .SetFont(fontNormal).SetFontSize(10)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetMarginBottom(4)
                    );

                    doc.Add(
                        new Paragraph($"Total Data: {dataGridView1.Rows.Count} orang")
                            .SetFont(fontNormal).SetFontSize(10)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetMarginBottom(15)
                    );

                    // Tabel
                    string[] headers = { "NIK", "Nama Lengkap", "Jenis Kelamin", "No KK", "RW", "Pekerjaan", "Pendidikan" };
                    float[] colWidths = { 110f, 140f, 90f, 120f, 45f, 110f, 80f };

                    var table = new Table(UnitValue.CreatePointArray(colWidths));
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    DeviceRgb headerBg = new DeviceRgb(70, 130, 180);
                    DeviceRgb headerFg = new DeviceRgb(255, 255, 255);
                    DeviceRgb stripeBg = new DeviceRgb(240, 248, 255);

                    // Header tabel
                    foreach (string header in headers)
                    {
                        table.AddHeaderCell(
                            new Cell()
                                .Add(new Paragraph(header).SetFont(fontBold).SetFontSize(9).SetFontColor(headerFg))
                                .SetBackgroundColor(headerBg)
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetPadding(5)
                        );
                    }

                    // Data rows
                    int rowIdx = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        bool isStripe = (rowIdx % 2 == 1);
                        for (int col = 0; col < headers.Length; col++)
                        {
                            string val = row.Cells[col].Value?.ToString() ?? "";
                            var cell = new Cell()
                                .Add(new Paragraph(val).SetFont(fontNormal).SetFontSize(8))
                                .SetPadding(4);

                            if (isStripe)
                                cell.SetBackgroundColor(stripeBg);

                            table.AddCell(cell);
                        }
                        rowIdx++;
                    }

                    doc.Add(table);
                    doc.Close();
                }

                // --- TAHAP 2: Stamping nomor halaman pada setiap halaman ---
                using (var reader = new PdfReader(tempPath))
                using (var writer2 = new PdfWriter(sfd.FileName))
                using (var pdfStamp = new PdfDocument(reader, writer2))
                {
                    PdfFont fontStamp = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    int totalPages = pdfStamp.GetNumberOfPages();

                    for (int pg = 1; pg <= totalPages; pg++)
                    {
                        PdfPage page = pdfStamp.GetPage(pg);
                        iText.Kernel.Geom.Rectangle pageSize = page.GetPageSize();

                        string pageText = $"Halaman {pg} dari {totalPages}";

                        PdfCanvas canvas = new PdfCanvas(page);
                        canvas.BeginText()
                              .SetFontAndSize(fontStamp, 8)
                              .MoveText(
                                  pageSize.GetWidth() / 2f - 40f,
                                  20f
                              )
                              .ShowText(pageText)
                              .EndText();
                        canvas.Release();
                    }
                }

                // Hapus file sementara
                if (System.IO.File.Exists(tempPath))
                    System.IO.File.Delete(tempPath);

                MessageBox.Show(
                    $"Cetak PDF berhasil!\nFile disimpan di:\n{sfd.FileName}",
                    "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                // Bersihkan file sementara jika ada error
                if (System.IO.File.Exists(tempPath))
                    System.IO.File.Delete(tempPath);

                MessageBox.Show(
                    "Gagal cetak PDF:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // EVENT HANDLERS - TOMBOL
        // =========================
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxRw.SelectedIndex = 0;
            cbxPekerjaan.SelectedIndex = 0;
            tbxnama.Clear();
            LoadData();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            CetakPDF();
        }

        // =========================
        // EVENT KOSONG (pertahankan dari versi lama)
        // =========================
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
