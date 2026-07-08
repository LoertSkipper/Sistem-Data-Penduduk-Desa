namespace Sistem_Data_Penduduk_Desa
{
    partial class FormKK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKK));
            panelinput_kk = new Panel();
            txtProvinsi = new TextBox();
            txtKabupaten_kota = new TextBox();
            txtDesa_kelurahan = new TextBox();
            txtKecamatan = new TextBox();
            btnTambah = new Button();
            txtRW = new TextBox();
            txtRT = new TextBox();
            txtAlamat = new TextBox();
            txtNama_kepala_keluarga = new TextBox();
            txtNoKK = new TextBox();
            lblProvinsi = new Label();
            lblKabupaten_kota = new Label();
            lblDesa_kelurahan = new Label();
            lblKecamatan = new Label();
            lblRW = new Label();
            lblRT = new Label();
            lblAlamat = new Label();
            lblNama_kepala_keluarga = new Label();
            lblNik = new Label();
            paneloutput_kk = new Panel();
            lblCari = new Label();
            txtCari = new TextBox();
            dgvDataKK = new DataGridView();
            btnReset = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            lblJuduul = new Label();
            panelstatistikringkas_kk = new Panel();
            pictureDataBaru = new PictureBox();
            pictureTotalKK = new PictureBox();
            angkadata = new Label();
            angkatotal = new Label();
            lbldata_baru = new Label();
            lblTotalKK = new Label();
            statistik_ringkas = new Label();
            panelinput_kk.SuspendLayout();
            paneloutput_kk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).BeginInit();
            panelstatistikringkas_kk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDataBaru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).BeginInit();
            SuspendLayout();
            // 
            // panelinput_kk
            // 
            panelinput_kk.BackColor = SystemColors.GradientInactiveCaption;
            panelinput_kk.BorderStyle = BorderStyle.FixedSingle;
            panelinput_kk.Controls.Add(txtProvinsi);
            panelinput_kk.Controls.Add(txtKabupaten_kota);
            panelinput_kk.Controls.Add(txtDesa_kelurahan);
            panelinput_kk.Controls.Add(txtKecamatan);
            panelinput_kk.Controls.Add(btnTambah);
            panelinput_kk.Controls.Add(txtRW);
            panelinput_kk.Controls.Add(txtRT);
            panelinput_kk.Controls.Add(txtAlamat);
            panelinput_kk.Controls.Add(txtNama_kepala_keluarga);
            panelinput_kk.Controls.Add(txtNoKK);
            panelinput_kk.Controls.Add(lblProvinsi);
            panelinput_kk.Controls.Add(lblKabupaten_kota);
            panelinput_kk.Controls.Add(lblDesa_kelurahan);
            panelinput_kk.Controls.Add(lblKecamatan);
            panelinput_kk.Controls.Add(lblRW);
            panelinput_kk.Controls.Add(lblRT);
            panelinput_kk.Controls.Add(lblAlamat);
            panelinput_kk.Controls.Add(lblNama_kepala_keluarga);
            panelinput_kk.Controls.Add(lblNik);
            panelinput_kk.Location = new Point(109, 136);
            panelinput_kk.Name = "panelinput_kk";
            panelinput_kk.Size = new Size(938, 355);
            panelinput_kk.TabIndex = 0;
            panelinput_kk.Paint += panelinput_kk_Paint;
            // 
            // txtProvinsi
            // 
            txtProvinsi.Location = new Point(657, 189);
            txtProvinsi.Name = "txtProvinsi";
            txtProvinsi.Size = new Size(239, 31);
            txtProvinsi.TabIndex = 17;
            // 
            // txtKabupaten_kota
            // 
            txtKabupaten_kota.Location = new Point(657, 134);
            txtKabupaten_kota.Name = "txtKabupaten_kota";
            txtKabupaten_kota.Size = new Size(239, 31);
            txtKabupaten_kota.TabIndex = 16;
            // 
            // txtDesa_kelurahan
            // 
            txtDesa_kelurahan.Location = new Point(657, 84);
            txtDesa_kelurahan.Name = "txtDesa_kelurahan";
            txtDesa_kelurahan.Size = new Size(239, 31);
            txtDesa_kelurahan.TabIndex = 15;
            // 
            // txtKecamatan
            // 
            txtKecamatan.Location = new Point(657, 28);
            txtKecamatan.Name = "txtKecamatan";
            txtKecamatan.Size = new Size(239, 31);
            txtKecamatan.TabIndex = 14;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.GradientActiveCaption;
            btnTambah.ForeColor = SystemColors.Desktop;
            btnTambah.Location = new Point(784, 292);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtRW
            // 
            txtRW.Location = new Point(237, 240);
            txtRW.Name = "txtRW";
            txtRW.Size = new Size(94, 31);
            txtRW.TabIndex = 13;
            // 
            // txtRT
            // 
            txtRT.Location = new Point(237, 181);
            txtRT.Name = "txtRT";
            txtRT.Size = new Size(94, 31);
            txtRT.TabIndex = 12;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(237, 131);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(239, 31);
            txtAlamat.TabIndex = 11;
            // 
            // txtNama_kepala_keluarga
            // 
            txtNama_kepala_keluarga.Location = new Point(237, 78);
            txtNama_kepala_keluarga.Name = "txtNama_kepala_keluarga";
            txtNama_kepala_keluarga.Size = new Size(239, 31);
            txtNama_kepala_keluarga.TabIndex = 10;
            // 
            // txtNoKK
            // 
            txtNoKK.Location = new Point(237, 28);
            txtNoKK.Name = "txtNoKK";
            txtNoKK.Size = new Size(239, 31);
            txtNoKK.TabIndex = 9;
            // 
            // lblProvinsi
            // 
            lblProvinsi.AutoSize = true;
            lblProvinsi.Location = new Point(503, 189);
            lblProvinsi.Name = "lblProvinsi";
            lblProvinsi.Size = new Size(74, 25);
            lblProvinsi.TabIndex = 8;
            lblProvinsi.Text = "Provinsi";
            // 
            // lblKabupaten_kota
            // 
            lblKabupaten_kota.AutoSize = true;
            lblKabupaten_kota.Location = new Point(503, 134);
            lblKabupaten_kota.Name = "lblKabupaten_kota";
            lblKabupaten_kota.Size = new Size(140, 25);
            lblKabupaten_kota.TabIndex = 7;
            lblKabupaten_kota.Text = "Kabupaten/Kota";
            // 
            // lblDesa_kelurahan
            // 
            lblDesa_kelurahan.AutoSize = true;
            lblDesa_kelurahan.Location = new Point(503, 84);
            lblDesa_kelurahan.Name = "lblDesa_kelurahan";
            lblDesa_kelurahan.Size = new Size(135, 25);
            lblDesa_kelurahan.TabIndex = 6;
            lblDesa_kelurahan.Text = "Desa/Kelurahan";
            // 
            // lblKecamatan
            // 
            lblKecamatan.AutoSize = true;
            lblKecamatan.Location = new Point(503, 28);
            lblKecamatan.Name = "lblKecamatan";
            lblKecamatan.Size = new Size(98, 25);
            lblKecamatan.TabIndex = 5;
            lblKecamatan.Text = "Kecamatan";
            // 
            // lblRW
            // 
            lblRW.AutoSize = true;
            lblRW.Location = new Point(35, 240);
            lblRW.Name = "lblRW";
            lblRW.Size = new Size(40, 25);
            lblRW.TabIndex = 4;
            lblRW.Text = "RW";
            // 
            // lblRT
            // 
            lblRT.AutoSize = true;
            lblRT.Location = new Point(35, 181);
            lblRT.Name = "lblRT";
            lblRT.Size = new Size(31, 25);
            lblRT.TabIndex = 3;
            lblRT.Text = "RT";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(35, 131);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(68, 25);
            lblAlamat.TabIndex = 2;
            lblAlamat.Text = "Alamat";
            // 
            // lblNama_kepala_keluarga
            // 
            lblNama_kepala_keluarga.AutoSize = true;
            lblNama_kepala_keluarga.Location = new Point(35, 78);
            lblNama_kepala_keluarga.Name = "lblNama_kepala_keluarga";
            lblNama_kepala_keluarga.Size = new Size(189, 25);
            lblNama_kepala_keluarga.TabIndex = 1;
            lblNama_kepala_keluarga.Text = "Nama Kepala Keluarga";
            // 
            // lblNik
            // 
            lblNik.AutoSize = true;
            lblNik.Location = new Point(35, 28);
            lblNik.Name = "lblNik";
            lblNik.Size = new Size(40, 25);
            lblNik.TabIndex = 0;
            lblNik.Text = "NIK";
            // 
            // paneloutput_kk
            // 
            paneloutput_kk.Controls.Add(lblCari);
            paneloutput_kk.Controls.Add(txtCari);
            paneloutput_kk.Controls.Add(dgvDataKK);
            paneloutput_kk.Location = new Point(45, 555);
            paneloutput_kk.Name = "paneloutput_kk";
            paneloutput_kk.Size = new Size(1517, 373);
            paneloutput_kk.TabIndex = 1;
            // 
            // lblCari
            // 
            lblCari.AutoSize = true;
            lblCari.Location = new Point(10, 22);
            lblCari.Name = "lblCari";
            lblCari.Size = new Size(51, 25);
            lblCari.TabIndex = 23;
            lblCari.Text = "CARI";
            lblCari.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCari
            // 
            txtCari.BackColor = SystemColors.GradientActiveCaption;
            txtCari.ForeColor = SystemColors.ActiveCaptionText;
            txtCari.Location = new Point(64, 18);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "-----Masukkan Nik atau Nama-----";
            txtCari.Size = new Size(280, 31);
            txtCari.TabIndex = 22;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // dgvDataKK
            // 
            dgvDataKK.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDataKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataKK.Location = new Point(0, 60);
            dgvDataKK.Name = "dgvDataKK";
            dgvDataKK.RowHeadersWidth = 62;
            dgvDataKK.Size = new Size(1517, 312);
            dgvDataKK.TabIndex = 21;
            dgvDataKK.CellContentClick += dgvDataKK_CellClick;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.GradientActiveCaption;
            btnReset.Location = new Point(1410, 967);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = SystemColors.GradientActiveCaption;
            btnHapus.Location = new Point(1282, 967);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 19;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = SystemColors.GradientActiveCaption;
            btnUbah.Location = new Point(1155, 967);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(112, 34);
            btnUbah.TabIndex = 18;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // lblJuduul
            // 
            lblJuduul.AutoSize = true;
            lblJuduul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJuduul.Location = new Point(589, 47);
            lblJuduul.Name = "lblJuduul";
            lblJuduul.Size = new Size(458, 48);
            lblJuduul.TabIndex = 0;
            lblJuduul.Text = "Pendataan Kartu Keluarga";
            lblJuduul.Click += lblJuduul_Click;
            // 
            // panelstatistikringkas_kk
            // 
            panelstatistikringkas_kk.BackColor = SystemColors.GradientActiveCaption;
            panelstatistikringkas_kk.BackgroundImageLayout = ImageLayout.None;
            panelstatistikringkas_kk.Controls.Add(pictureDataBaru);
            panelstatistikringkas_kk.Controls.Add(pictureTotalKK);
            panelstatistikringkas_kk.Controls.Add(angkadata);
            panelstatistikringkas_kk.Controls.Add(angkatotal);
            panelstatistikringkas_kk.Controls.Add(lbldata_baru);
            panelstatistikringkas_kk.Controls.Add(lblTotalKK);
            panelstatistikringkas_kk.Controls.Add(statistik_ringkas);
            panelstatistikringkas_kk.Location = new Point(1087, 134);
            panelstatistikringkas_kk.Name = "panelstatistikringkas_kk";
            panelstatistikringkas_kk.Size = new Size(389, 355);
            panelstatistikringkas_kk.TabIndex = 2;
            panelstatistikringkas_kk.Paint += panelstatistikringkas_kk_Paint;
            // 
            // pictureDataBaru
            // 
            pictureDataBaru.Image = (Image)resources.GetObject("pictureDataBaru.Image");
            pictureDataBaru.Location = new Point(235, 84);
            pictureDataBaru.Name = "pictureDataBaru";
            pictureDataBaru.Size = new Size(100, 100);
            pictureDataBaru.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDataBaru.TabIndex = 6;
            pictureDataBaru.TabStop = false;
            // 
            // pictureTotalKK
            // 
            pictureTotalKK.Image = (Image)resources.GetObject("pictureTotalKK.Image");
            pictureTotalKK.Location = new Point(65, 84);
            pictureTotalKK.Name = "pictureTotalKK";
            pictureTotalKK.Size = new Size(100, 100);
            pictureTotalKK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTotalKK.TabIndex = 5;
            pictureTotalKK.TabStop = false;
            // 
            // angkadata
            // 
            angkadata.AutoSize = true;
            angkadata.Font = new Font("Segoe UI", 20F);
            angkadata.Location = new Point(259, 252);
            angkadata.Name = "angkadata";
            angkadata.Size = new Size(45, 54);
            angkadata.TabIndex = 4;
            angkadata.Text = "0";
            angkadata.TextAlign = ContentAlignment.BottomCenter;
            angkadata.Click += angkadata_Click;
            // 
            // angkatotal
            // 
            angkatotal.AutoSize = true;
            angkatotal.Font = new Font("Segoe UI", 20F);
            angkatotal.Location = new Point(91, 252);
            angkatotal.Name = "angkatotal";
            angkatotal.Size = new Size(45, 54);
            angkatotal.TabIndex = 3;
            angkatotal.Text = "0";
            angkatotal.TextAlign = ContentAlignment.TopCenter;
            angkatotal.Click += angkatotal_Click;
            // 
            // lbldata_baru
            // 
            lbldata_baru.AutoSize = true;
            lbldata_baru.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lbldata_baru.Location = new Point(232, 204);
            lbldata_baru.Name = "lbldata_baru";
            lbldata_baru.Size = new Size(106, 25);
            lbldata_baru.TabIndex = 2;
            lbldata_baru.Text = "DATA BARU";
            // 
            // lblTotalKK
            // 
            lblTotalKK.AutoSize = true;
            lblTotalKK.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblTotalKK.Location = new Point(73, 204);
            lblTotalKK.Name = "lblTotalKK";
            lblTotalKK.Size = new Size(86, 25);
            lblTotalKK.TabIndex = 1;
            lblTotalKK.Text = "TOTAL KK";
            // 
            // statistik_ringkas
            // 
            statistik_ringkas.AutoSize = true;
            statistik_ringkas.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            statistik_ringkas.Location = new Point(113, 26);
            statistik_ringkas.Name = "statistik_ringkas";
            statistik_ringkas.Size = new Size(175, 32);
            statistik_ringkas.TabIndex = 0;
            statistik_ringkas.Text = "statistik ringkas";
            // 
            // FormKK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1565, 1050);
            Controls.Add(panelstatistikringkas_kk);
            Controls.Add(lblJuduul);
            Controls.Add(btnReset);
            Controls.Add(paneloutput_kk);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(panelinput_kk);
            Name = "FormKK";
            Text = "FormKK";
            Load += FormKK_Load;
            panelinput_kk.ResumeLayout(false);
            panelinput_kk.PerformLayout();
            paneloutput_kk.ResumeLayout(false);
            paneloutput_kk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).EndInit();
            panelstatistikringkas_kk.ResumeLayout(false);
            panelstatistikringkas_kk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDataBaru).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelinput_kk;
        private Panel paneloutput_kk;
        private Label lblJuduul;
        private Label lblNama_kepala_keluarga;
        private Label lblNik;
        private Label lblRT;
        private Label lblAlamat;
        private Label lblKabupaten_kota;
        private Label lblDesa_kelurahan;
        private Label lblKecamatan;
        private Label lblRW;
        private Label lblProvinsi;
        private TextBox txtKecamatan;
        private TextBox txtRW;
        private TextBox txtRT;
        private TextBox txtAlamat;
        private TextBox txtNama_kepala_keluarga;
        private TextBox txtNoKK;
        private TextBox txtProvinsi;
        private TextBox txtKabupaten_kota;
        private TextBox txtDesa_kelurahan;
        private Button btnTambah;
        private Button btnReset;
        private Button btnHapus;
        private Button btnUbah;
        private DataGridView dgvDataKK;
        private Panel panelstatistikringkas_kk;
        private Label statistik_ringkas;
        private Label lblTotalKK;
        private Label angkatotal;
        private PictureBox pictureTotalKK;
        private PictureBox pictureDataBaru;
        private Label angkadata;
        private Label lbldata_baru;
        //private DataGridViewTextBoxColumn colId_kk;
        //private DataGridViewTextBoxColumn colNo_kk;
        //private DataGridViewTextBoxColumn colNama_kepala_keluarga;
        //private DataGridViewTextBoxColumn colAlamat;
        //private DataGridViewTextBoxColumn colRT;
        //private DataGridViewTextBoxColumn colRW;
        //private DataGridViewTextBoxColumn colKecamatan;
        //private DataGridViewTextBoxColumn colDesa_kelurahan;
        //private DataGridViewTextBoxColumn colKabupaten;
        //private DataGridViewTextBoxColumn colProvinsi;
        private TextBox txtCari;
        private Label lblCari;
    }
}