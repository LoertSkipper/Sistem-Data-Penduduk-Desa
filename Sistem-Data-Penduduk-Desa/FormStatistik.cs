using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Sistem_Data_Penduduk_Desa.konfigurasi;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormStatistik : Form
    {
        private Koneksi Koneksi = new Koneksi();

        // ─── Colour palette ───────────────────────────────────────────────────────
        private static readonly Color[] PieColors = new Color[]
        {
            Color.FromArgb( 70, 130, 180),   // SteelBlue
            Color.FromArgb(255, 165,   0),   // Orange
            Color.FromArgb( 46, 139,  87),   // SeaGreen
            Color.FromArgb(220,  20,  60),   // Crimson
            Color.FromArgb(148,   0, 211),   // DarkViolet
            Color.FromArgb(  0, 206, 209),   // DarkTurquoise
            Color.FromArgb(255, 215,   0),   // Gold
            Color.FromArgb(105, 105, 105),   // DimGray
        };

        // ─── Chart background / grid colours ─────────────────────────────────────
        private static readonly Color ChartBg   = Color.White;
        private static readonly Color GridColor = Color.FromArgb(220, 220, 220);
        private static readonly Color TitleColor = Color.FromArgb(31, 73, 125);
        private static readonly Font  TitleFont  = new Font("Segoe UI", 11F, FontStyle.Bold);
        private static readonly Font  AxisFont   = new Font("Segoe UI",  9F, FontStyle.Bold);
        private static readonly Font  LabelFont  = new Font("Segoe UI",  8F, FontStyle.Bold);
        private static readonly Font  TickFont   = new Font("Segoe UI",  8F);

        // =====================================================================
        // CONSTRUCTOR
        // =====================================================================
        public FormStatistik()
        {
            InitializeComponent();
        }

        // =====================================================================
        // FORM LOAD
        // =====================================================================
        private void FormStatistik_Load(object sender, EventArgs e)
        {
            StyleSummaryPanels();
            LoadComboRW();
            LoadStatistik("Semua");
        }

        // =====================================================================
        // STYLE: round corners + drop shadow on the three summary cards
        // =====================================================================
        private void StyleSummaryPanels()
        {
            foreach (Panel p in new[] { panel1, panel2, panel3 })
            {
                p.BackColor   = Color.White;
                p.BorderStyle = BorderStyle.None;
            }
        }

        // =====================================================================
        // LOAD COMBO RW
        // =====================================================================
        private void LoadComboRW()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Semua RW");

            string query =
                "SELECT DISTINCT rw FROM kartu_keluarga " +
                "WHERE rw IS NOT NULL AND rw <> '' ORDER BY rw";

            DataTable dt = Koneksi.eksekusiQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string rw = row["rw"]?.ToString() ?? "";
                if (!string.IsNullOrEmpty(rw))
                    comboBox1.Items.Add(rw);
            }

            comboBox1.SelectedIndex = 0;
        }

        // =====================================================================
        // LOAD STATISTIK UTAMA
        // Memanggil semua method: kartu ringkasan + 4 grafik.
        // rwFilter: "Semua" / "Semua RW" untuk seluruh desa.
        // =====================================================================
        private void LoadStatistik(string rwFilter)
        {
            HitungTotal(rwFilter);
            LoadChartRW(rwFilter);
            LoadChartPendidikan(rwFilter);
            LoadChartPekerjaan(rwFilter);
            LoadChartUmur(rwFilter);
        }

        // =====================================================================
        // HELPER: BUILD WHERE CLAUSE UNTUK FILTER RW
        // =====================================================================
        private string BuildRwWhere(string rwFilter, string alias = "kk")
        {
            if (rwFilter == "Semua" || rwFilter == "Semua RW" || string.IsNullOrEmpty(rwFilter))
                return "";
            // Escape single quote to prevent SQL injection via user input
            string safe = rwFilter.Replace("'", "''");
            return $"AND {alias}.rw = '{safe}'";
        }

        // =====================================================================
        // SAFE INT CONVERSION (handles DBNull)
        // =====================================================================
        private static int SafeInt(object val)
        {
            if (val == null || val is DBNull) return 0;
            return Convert.ToInt32(val);
        }

        // =====================================================================
        // HITUNG TOTAL KARTU RINGKASAN
        // =====================================================================
        private void HitungTotal(string rwFilter)
        {
            string whereRw = BuildRwWhere(rwFilter);

            string query =
                "SELECT " +
                "COALESCE(COUNT(*),0) AS total, " +
                "COALESCE(SUM(CASE WHEN p.jk = 'L' THEN 1 ELSE 0 END),0) AS laki, " +
                "COALESCE(SUM(CASE WHEN p.jk = 'P' THEN 1 ELSE 0 END),0) AS perempuan " +
                "FROM penduduk p " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                $"WHERE 1=1 {whereRw}";

            DataTable dt = Koneksi.eksekusiQuery(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblTotalPenduduk.Text = SafeInt(row["total"]).ToString("N0");
                label2.Text           = SafeInt(row["laki"]).ToString("N0");
                label4.Text           = SafeInt(row["perempuan"]).ToString("N0");
            }
            else
            {
                lblTotalPenduduk.Text = "0";
                label2.Text           = "0";
                label4.Text           = "0";
            }
        }

        // =====================================================================
        // HELPER: RESET CHART
        // =====================================================================
        private void ResetChart(Chart chart)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();
            chart.AntiAliasing            = AntiAliasingStyles.All;
            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;
            chart.BackColor               = ChartBg;
            chart.BorderlineColor         = Color.FromArgb(220, 220, 220);
            chart.BorderlineWidth         = 1;
        }

        // =====================================================================
        // HELPER: CREATE CHART AREA (Column / Bar)
        // =====================================================================
        private ChartArea MakeStandardArea(
            string xTitle, string yTitle,
            float left, float top, float width, float height)
        {
            var ca = new ChartArea("CA");
            ca.BackColor    = ChartBg;
            ca.BorderColor  = Color.Transparent;

            ca.AxisX.Title           = xTitle;
            ca.AxisX.TitleFont       = AxisFont;
            ca.AxisX.LabelStyle.Font = TickFont;
            ca.AxisX.MajorGrid.Enabled = false;
            ca.AxisX.LineColor       = Color.Silver;
            ca.AxisX.LabelStyle.Interval = 1;

            ca.AxisY.Title           = yTitle;
            ca.AxisY.TitleFont       = AxisFont;
            ca.AxisY.LabelStyle.Font = TickFont;
            ca.AxisY.MajorGrid.LineColor     = GridColor;
            ca.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            ca.AxisY.LineColor       = Color.Silver;
            ca.AxisY.Minimum         = 0;

            ca.InnerPlotPosition = new ElementPosition(left, top, width, height);
            return ca;
        }

        // =====================================================================
        // HELPER: ADD TITLE
        // =====================================================================
        private Title MakeTitle(string text)
        {
            var t = new Title(text);
            t.Font      = TitleFont;
            t.ForeColor = TitleColor;
            t.Alignment = ContentAlignment.TopCenter;
            t.Docking   = Docking.Top;
            return t;
        }

        // =====================================================================
        // CHART 1: COLUMN — Kepadatan Penduduk per RW
        // Selalu tampilkan SEMUA RW yang ada di database.
        // Ketika filter RW aktif, satu bar yang dipilih di-highlight.
        // =====================================================================
        private void LoadChartRW(string rwFilter)
        {
            ResetChart(chart1);

            // Chart area
            var ca = MakeStandardArea("RW", "Jumlah Penduduk", 8, 10, 87, 82);
            ca.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            chart1.ChartAreas.Add(ca);

            // Title
            chart1.Titles.Add(MakeTitle("Kepadatan Penduduk per RW"));

            // Series — dibuat sekali, di luar loop
            var series = new Series("RW");
            series.ChartType           = SeriesChartType.Column;
            series.ChartArea           = "CA";
            series.Color               = Color.FromArgb(70, 130, 180);
            series.BorderColor         = Color.FromArgb(45, 95, 140);
            series.BorderWidth         = 1;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor      = TitleColor;
            series.Font                = LabelFont;
            series["PointWidth"]       = "0.55";
            series["LabelStyle"]       = "Top";
            chart1.Series.Add(series);

            // Query: SELALU ambil SEMUA rw dari database
            string query =
                "SELECT kk.rw, COALESCE(COUNT(*),0) AS jumlah " +
                "FROM penduduk p " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                "WHERE kk.rw IS NOT NULL AND kk.rw <> '' " +
                "GROUP BY kk.rw " +
                "ORDER BY kk.rw";

            DataTable dt = Koneksi.eksekusiQuery(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                chart1.Series["RW"].Points.AddXY("Tidak Ada Data", 0);
                return;
            }

            bool isFiltered = (rwFilter != "Semua" && rwFilter != "Semua RW"
                               && !string.IsNullOrEmpty(rwFilter));

            // Clear sekali sebelum loop — jangan panggil di dalam loop
            chart1.Series["RW"].Points.Clear();

            // Satu titik per baris DataRow
            foreach (DataRow row in dt.Rows)
            {
                string rw     = row["rw"]?.ToString() ?? "";
                int    jumlah = SafeInt(row["jumlah"]);

                int idx = chart1.Series["RW"].Points.AddXY("RW " + rw, jumlah);

                // Highlight RW yang dipilih; redup-kan yang lain
                if (isFiltered)
                {
                    if (rw == rwFilter)
                    {
                        chart1.Series["RW"].Points[idx].Color       = Color.FromArgb(70, 130, 180);
                        chart1.Series["RW"].Points[idx].BorderColor = Color.FromArgb(45, 95, 140);
                    }
                    else
                    {
                        chart1.Series["RW"].Points[idx].Color       = Color.FromArgb(180, 200, 220);
                        chart1.Series["RW"].Points[idx].BorderColor = Color.FromArgb(150, 170, 190);
                    }
                }
            }
        }

        // =====================================================================
        // CHART 2: PIE — Statistik Pendidikan
        // Persentase di dalam irisan; legend di kanan; tidak ada label di luar.
        // =====================================================================
        private void LoadChartPendidikan(string rwFilter)
        {
            ResetChart(chart3);

            // Chart area — beri ruang di kanan untuk legend
            var ca = new ChartArea("CA");
            ca.BackColor   = ChartBg;
            ca.BorderColor = Color.Transparent;
            // Pie area: mulai 2% dari kiri, atas 10%, lebar 58%, tinggi 80%
            ca.InnerPlotPosition = new ElementPosition(2, 10, 58, 80);
            chart3.ChartAreas.Add(ca);

            // Title
            chart3.Titles.Add(MakeTitle("Statistik Pendidikan"));

            // Legend di kanan
            var legend = new Legend("LG");
            legend.Docking     = Docking.Right;
            legend.Alignment   = StringAlignment.Center;
            legend.Font        = new Font("Segoe UI", 8F);
            legend.BackColor   = Color.Transparent;
            legend.BorderColor = Color.Transparent;
            legend.LegendStyle = LegendStyle.Column;
            chart3.Legends.Add(legend);

            // Series — dibuat sekali, di luar loop
            var series = new Series("Pendidikan");
            series.ChartType            = SeriesChartType.Pie;
            series.ChartArea            = "CA";
            series.Legend               = "LG";
            series.Label                = "#PERCENT{P0}";
            series["PieLabelStyle"]     = "Inside";
            series["PieStartAngle"]     = "270";
            series["CollectedThreshold"] = "0";
            series.IsValueShownAsLabel  = true;
            series.Font                 = new Font("Segoe UI", 8F, FontStyle.Bold);
            series.LabelForeColor       = Color.White;
            chart3.Series.Add(series);

            // Query
            string whereRw = BuildRwWhere(rwFilter);

            string query =
                "SELECT pd.jenjang, COALESCE(COUNT(*),0) AS jumlah " +
                "FROM penduduk p " +
                "INNER JOIN pendidikan pd ON p.id_pendidikan = pd.id_pendidikan " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                $"WHERE 1=1 {whereRw} " +
                "GROUP BY pd.id_pendidikan, pd.jenjang " +
                "ORDER BY pd.jenjang";

            DataTable dt = Koneksi.eksekusiQuery(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                int i = chart3.Series["Pendidikan"].Points.AddXY("Tidak Ada Data", 1);
                chart3.Series["Pendidikan"].Points[i].Color      = Color.LightGray;
                chart3.Series["Pendidikan"].Points[i].LegendText = "Tidak Ada Data";
                return;
            }

            // Clear sekali sebelum loop — jangan panggil di dalam loop
            chart3.Series["Pendidikan"].Points.Clear();

            // Satu titik per baris DataRow
            int colorIdx = 0;
            foreach (DataRow row in dt.Rows)
            {
                string jenjang = row["jenjang"]?.ToString() ?? "";
                int    jumlah  = SafeInt(row["jumlah"]);
                if (jumlah <= 0) continue;

                int idx = chart3.Series["Pendidikan"].Points.AddXY(jenjang, jumlah);
                chart3.Series["Pendidikan"].Points[idx].LegendText = jenjang;
                chart3.Series["Pendidikan"].Points[idx].Color      = PieColors[colorIdx % PieColors.Length];
                colorIdx++;
            }
        }

        // =====================================================================
        // CHART 3: BAR (Horizontal) — Distribusi Pekerjaan
        // Urut ASC agar bar terbesar tampil di atas pada chart horizontal WinForms.
        // =====================================================================
        private void LoadChartPekerjaan(string rwFilter)
        {
            ResetChart(chart4);

            // Chart area — beri ruang kiri untuk label nama pekerjaan
            var ca = MakeStandardArea("", "Jumlah Penduduk", 25, 3, 70, 94);
            ca.AxisX.Title           = "";   // Pada bar chart, X = kategori vertikal
            ca.AxisX.LabelStyle.Font = TickFont;
            chart4.ChartAreas.Add(ca);

            // Title
            chart4.Titles.Add(MakeTitle("Distribusi Pekerjaan"));

            // Series — dibuat sekali, di luar loop
            var series = new Series("Pekerjaan");
            series.ChartType           = SeriesChartType.Bar;
            series.ChartArea           = "CA";
            series.Color               = Color.FromArgb(91, 155, 213);
            series.BorderColor         = Color.FromArgb(55, 115, 165);
            series.BorderWidth         = 1;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor      = TitleColor;
            series.Font                = LabelFont;
            series["PointWidth"]       = "0.6";
            series["LabelStyle"]       = "Right";
            chart4.Series.Add(series);

            // Query — ORDER BY ASC agar nilai terbesar tampil di bagian atas
            // (WinForms Bar chart: item terakhir = bar paling atas)
            string whereRw = BuildRwWhere(rwFilter);

            string query =
                "SELECT pk.nama_pekerjaan, COALESCE(COUNT(*),0) AS jumlah " +
                "FROM penduduk p " +
                "INNER JOIN pekerjaan pk ON p.id_pekerjaan = pk.id_pekerjaan " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                $"WHERE 1=1 {whereRw} " +
                "GROUP BY pk.id_pekerjaan, pk.nama_pekerjaan " +
                "ORDER BY jumlah ASC";

            DataTable dt = Koneksi.eksekusiQuery(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                chart4.Series["Pekerjaan"].Points.AddXY("Tidak Ada Data", 0);
                return;
            }

            // Clear sekali sebelum loop — jangan panggil di dalam loop
            chart4.Series["Pekerjaan"].Points.Clear();

            // Warna gradasi biru untuk setiap bar
            int total = dt.Rows.Count;
            int idx2  = 0;

            // Satu titik per baris DataRow
            foreach (DataRow row in dt.Rows)
            {
                string pekerjaan = row["nama_pekerjaan"]?.ToString() ?? "";
                int    jumlah    = SafeInt(row["jumlah"]);

                int pt = chart4.Series["Pekerjaan"].Points.AddXY(pekerjaan, jumlah);

                // Gradasi warna: makin besar nilainya, makin gelap birunya
                float ratio = total > 1 ? (float)idx2 / (total - 1) : 1f;
                int   r     = (int)(91  + ratio * (50  - 91));
                int   g     = (int)(155 + ratio * (100 - 155));
                int   b     = (int)(213 + ratio * (160 - 213));
                chart4.Series["Pekerjaan"].Points[pt].Color = Color.FromArgb(
                    Math.Max(0, Math.Min(255, r)),
                    Math.Max(0, Math.Min(255, g)),
                    Math.Max(0, Math.Min(255, b)));
                idx2++;
            }
        }

        // =====================================================================
        // CHART 4: COLUMN — Kelompok Umur
        // Lima kategori: 0-5, 6-17, 18-35, 36-60, >60
        // TIMESTAMPDIFF dari tgl_lahir ke CURDATE().
        // COALESCE pada semua SUM agar NULL → 0.
        // =====================================================================
        private void LoadChartUmur(string rwFilter)
        {
            ResetChart(chart2);

            // Chart area
            var ca = MakeStandardArea("Kelompok Umur", "Jumlah Penduduk", 10, 10, 85, 82);
            ca.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            chart2.ChartAreas.Add(ca);

            // Title
            chart2.Titles.Add(MakeTitle("Kelompok Umur"));

            // Series — dibuat sekali, di luar loop
            var series = new Series("Umur");
            series.ChartType           = SeriesChartType.Column;
            series.ChartArea           = "CA";
            series.Color               = Color.FromArgb(112, 173, 71);
            series.BorderColor         = Color.FromArgb(75, 130, 45);
            series.BorderWidth         = 1;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor      = Color.FromArgb(56, 87, 35);
            series.Font                = LabelFont;
            series["PointWidth"]       = "0.55";
            series["LabelStyle"]       = "Top";
            chart2.Series.Add(series);

            // Definisi 5 kelompok umur
            string[] labels    = { "0 - 5", "6 - 17", "18 - 35", "36 - 60", "> 60" };
            string[] keys      = { "usia_0_5", "usia_6_17", "usia_18_35", "usia_36_60", "usia_gt60" };
            Color[]  ageColors = {
                Color.FromArgb(255, 200,  87),   // 0-5   kuning
                Color.FromArgb(112, 173,  71),   // 6-17  hijau
                Color.FromArgb( 70, 130, 180),   // 18-35 biru
                Color.FromArgb(255, 127,  39),   // 36-60 oranye
                Color.FromArgb(192,  80,  77),   // >60   merah
            };

            // Query — satu baris hasil dengan 5 kolom agregasi, COALESCE agar NULL=0
            string whereRw = BuildRwWhere(rwFilter);

            string query =
                "SELECT " +
                "COALESCE(SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.tgl_lahir, CURDATE()) BETWEEN 0  AND 5  THEN 1 ELSE 0 END),0) AS usia_0_5, " +
                "COALESCE(SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.tgl_lahir, CURDATE()) BETWEEN 6  AND 17 THEN 1 ELSE 0 END),0) AS usia_6_17, " +
                "COALESCE(SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.tgl_lahir, CURDATE()) BETWEEN 18 AND 35 THEN 1 ELSE 0 END),0) AS usia_18_35, " +
                "COALESCE(SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.tgl_lahir, CURDATE()) BETWEEN 36 AND 60 THEN 1 ELSE 0 END),0) AS usia_36_60, " +
                "COALESCE(SUM(CASE WHEN TIMESTAMPDIFF(YEAR, p.tgl_lahir, CURDATE()) > 60           THEN 1 ELSE 0 END),0) AS usia_gt60 " +
                "FROM penduduk p " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                $"WHERE p.tgl_lahir IS NOT NULL {whereRw}";

            DataTable dt = Koneksi.eksekusiQuery(query);

            // Clear sekali sebelum mengisi titik — jangan panggil di dalam loop
            chart2.Series["Umur"].Points.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                // Hasil adalah 1 baris pivot; iterasi 5 kolom untuk 5 titik
                DataRow row = dt.Rows[0];
                for (int i = 0; i < labels.Length; i++)
                {
                    int val = SafeInt(row[keys[i]]);
                    int idx = chart2.Series["Umur"].Points.AddXY(labels[i], val);
                    chart2.Series["Umur"].Points[idx].Color       = ageColors[i];
                    chart2.Series["Umur"].Points[idx].BorderColor = ControlPaint.Dark(ageColors[i]);
                }
            }
            else
            {
                // Tidak ada data — tampilkan 5 kolom dengan nilai 0
                foreach (string lbl in labels)
                    chart2.Series["Umur"].Points.AddXY(lbl, 0);
            }
        }

        // =====================================================================
        // BUTTON TAMPILKAN
        // =====================================================================
        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem?.ToString() ?? "Semua RW";
            LoadStatistik(selected);
        }

        // =====================================================================
        // EVENT KOSONG (pertahankan dari versi lama)
        // =====================================================================
        private void label7_Click(object sender, EventArgs e) { }
        private void dgvWilayah_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void chart3_Click(object sender, EventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
    }
}
