using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormPekerjaan : Form
    {
        // Pengaturan koneksi ke database MySQL (Server, User, DB)
        string connString = "server=localhost;user=root;password=;database=sdpd";
        MySqlConnection conn;

        public FormPekerjaan()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString); // Inisialisasi koneksi
            LoadData(); // Panggil data saat form pertama kali dibuka
        }

        // --- 1. MENAMPILKAN DATA KE TABEL (DATA GRID VIEW) ---
        private void LoadData()
        {
            try
            {
                if (conn.State != ConnectionState.Closed) conn.Close(); // Tutup koneksi jika masih terbuka
                conn.Open(); // Buka koneksi ke database

                string query = "SELECT * FROM pekerjaan"; // Query ambil semua data
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt); // Masukkan data hasil query ke dalam DataTable

                dgvDataPekerjaan.DataSource = dt; // Tampilkan isi DataTable ke DataGridView
                lblAngkatotal.Text = dt.Rows.Count.ToString(); // Hitung total baris data untuk label info
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Pastikan koneksi selalu ditutup setelah selesai
            }
        }

        // --- 2. JEMBATAN UTAMA UNTUK EKSEKUSI DATA (CRUD) ---
        private void ExecuteQuery(string query, string pesan, bool pakaiId, bool pakaiInput)
        {
            try
            {
                if (conn.State != ConnectionState.Closed) conn.Close();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn); // Siapkan perintah SQL

                // Jika query butuh ID (Untuk Proses Ubah & Hapus)
                if (pakaiId)
                {
                    if (dgvDataPekerjaan.CurrentRow != null)
                    {
                        // Ambil ID dari baris tabel yang sedang dipilih user
                        cmd.Parameters.AddWithValue("@id", dgvDataPekerjaan.CurrentRow.Cells["id_pekerjaan"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Pilih data pada tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Jika query butuh teks input (Untuk Proses Tambah & Ubah)
                if (pakaiInput)
                {
                    cmd.Parameters.AddWithValue("@nama", txtNama_pekerjaan.Text); // Ambil teks dari TextBox
                }

                cmd.ExecuteNonQuery(); // Eksekusi perintah SQL ke database
                MessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat eksekusi data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                LoadData(); // Refresh tabel agar data terbaru langsung muncul
                btnReset_Click(null, EventArgs.Empty); // Kosongkan form input otomatis
            }
        }

        // --- 3. TOMBOL TAMBAH DATA ---
        private void btnTambahh_Click(object sender, EventArgs e)
        {
            // Validasi: Cegah simpan jika TextBox kosong
            if (string.IsNullOrEmpty(txtNama_pekerjaan.Text.Trim()))
            {
                MessageBox.Show("Nama pekerjaan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO pekerjaan (nama_pekerjaan) VALUES (@nama)"; // Query tambah data
            ExecuteQuery(query, "Data berhasil ditambah.", false, true); // Eksekusi
        }

        // --- 4. TOMBOL UBAH DATA ---
        private void btnUbah_Click(object sender, EventArgs e)
        {
            // Validasi: Harus pilih data di tabel dulu
            if (dgvDataPekerjaan.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diubah pada tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validasi: Nama baru tidak boleh kosong
            if (string.IsNullOrEmpty(txtNama_pekerjaan.Text.Trim()))
            {
                MessageBox.Show("Nama pekerjaan baru tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "UPDATE pekerjaan SET nama_pekerjaan=@nama WHERE id_pekerjaan=@id"; // Query ubah data
            ExecuteQuery(query, "Data berhasil diubah.", true, true); // Eksekusi
        }

        // --- 5. TOMBOL HAPUS DATA ---
        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Validasi: Harus pilih data di tabel dulu
            if (dgvDataPekerjaan.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus pada tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Munculkan kotak konfirmasi (Yes/No) sebelum benar-benar menghapus
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM pekerjaan WHERE id_pekerjaan=@id"; // Query hapus data
                ExecuteQuery(query, "Data berhasil dihapus.", true, false); // Eksekusi
            }
        }

        // --- 6. TOMBOL RESET (BERSIHKAN FORM) ---
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama_pekerjaan.Clear(); // Kosongkan TextBox nama pekerjaan
            // txtCari.Clear(); // Hilangkan tanda komentar jika kamu punya fitur TextBox pencarian
        }

        // --- 7. EVENT KLIK BARIS TABEL (PINDAH DATA KE TEXTBOX) ---
        private void dgvDataPekerjaan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Memastikan yang diklik baris data, bukan header/judul kolom
            {
                DataGridViewRow row = dgvDataPekerjaan.Rows[e.RowIndex]; // Ambil baris aktif
                if (row.Cells["nama_pekerjaan"].Value != null)
                {
                    txtNama_pekerjaan.Text = row.Cells["nama_pekerjaan"].Value.ToString(); // Lempar string ke TextBox
                }
            }
        }
    }
}