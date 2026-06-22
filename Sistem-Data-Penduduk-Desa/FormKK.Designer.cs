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
            txtNo_kk = new TextBox();
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
            dateTimePicker1 = new DateTimePicker();
            dgvDataKK = new DataGridView();
            btnReset = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            lblJudul = new Label();
            panelstatistikringkas_kk = new Panel();
            pictureDataBaru = new PictureBox();
            pictureTotalKK = new PictureBox();
            angkadata = new Label();
            angkatotal = new Label();
            data_baru = new Label();
            TotalKK = new Label();
            statistik_ringkas = new Label();
            colProvinsi = new DataGridViewTextBoxColumn();
            colKabupaten = new DataGridViewTextBoxColumn();
            colDesa_kelurahan = new DataGridViewTextBoxColumn();
            colKecamatan = new DataGridViewTextBoxColumn();
            colRW = new DataGridViewTextBoxColumn();
            colRT = new DataGridViewTextBoxColumn();
            colAlamat = new DataGridViewTextBoxColumn();
            colNama_kepala_keluarga = new DataGridViewTextBoxColumn();
            colNo_kk = new DataGridViewTextBoxColumn();
            colId_kk = new DataGridViewTextBoxColumn();
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
            panelinput_kk.Controls.Add(txtNo_kk);
            panelinput_kk.Controls.Add(lblProvinsi);
            panelinput_kk.Controls.Add(lblKabupaten_kota);
            panelinput_kk.Controls.Add(lblDesa_kelurahan);
            panelinput_kk.Controls.Add(lblKecamatan);
            panelinput_kk.Controls.Add(lblRW);
            panelinput_kk.Controls.Add(lblRT);
            panelinput_kk.Controls.Add(lblAlamat);
            panelinput_kk.Controls.Add(lblNama_kepala_keluarga);
            panelinput_kk.Controls.Add(lblNik);
            panelinput_kk.Location = new Point(13, 91);
            panelinput_kk.Name = "panelinput_kk";
            panelinput_kk.Size = new Size(1110, 355);
            panelinput_kk.TabIndex = 0;
            panelinput_kk.Paint += panel1_Paint;
            // 
            // txtProvinsi
            // 
            txtProvinsi.Location = new Point(825, 189);
            txtProvinsi.Name = "txtProvinsi";
            txtProvinsi.Size = new Size(239, 31);
            txtProvinsi.TabIndex = 17;
            // 
            // txtKabupaten_kota
            // 
            txtKabupaten_kota.Location = new Point(825, 134);
            txtKabupaten_kota.Name = "txtKabupaten_kota";
            txtKabupaten_kota.Size = new Size(239, 31);
            txtKabupaten_kota.TabIndex = 16;
            // 
            // txtDesa_kelurahan
            // 
            txtDesa_kelurahan.Location = new Point(825, 84);
            txtDesa_kelurahan.Name = "txtDesa_kelurahan";
            txtDesa_kelurahan.Size = new Size(239, 31);
            txtDesa_kelurahan.TabIndex = 15;
            // 
            // txtKecamatan
            // 
            txtKecamatan.Location = new Point(825, 28);
            txtKecamatan.Name = "txtKecamatan";
            txtKecamatan.Size = new Size(239, 31);
            txtKecamatan.TabIndex = 14;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(952, 292);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += button1_Click;
            // 
            // txtRW
            // 
            txtRW.Location = new Point(287, 240);
            txtRW.Name = "txtRW";
            txtRW.Size = new Size(94, 31);
            txtRW.TabIndex = 13;
            // 
            // txtRT
            // 
            txtRT.Location = new Point(287, 181);
            txtRT.Name = "txtRT";
            txtRT.Size = new Size(94, 31);
            txtRT.TabIndex = 12;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(287, 131);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(239, 31);
            txtAlamat.TabIndex = 11;
            // 
            // txtNama_kepala_keluarga
            // 
            txtNama_kepala_keluarga.Location = new Point(287, 78);
            txtNama_kepala_keluarga.Name = "txtNama_kepala_keluarga";
            txtNama_kepala_keluarga.Size = new Size(239, 31);
            txtNama_kepala_keluarga.TabIndex = 10;
            // 
            // txtNo_kk
            // 
            txtNo_kk.Location = new Point(287, 28);
            txtNo_kk.Name = "txtNo_kk";
            txtNo_kk.Size = new Size(239, 31);
            txtNo_kk.TabIndex = 9;
            // 
            // lblProvinsi
            // 
            lblProvinsi.AutoSize = true;
            lblProvinsi.Location = new Point(573, 189);
            lblProvinsi.Name = "lblProvinsi";
            lblProvinsi.Size = new Size(74, 25);
            lblProvinsi.TabIndex = 8;
            lblProvinsi.Text = "Provinsi";
            // 
            // lblKabupaten_kota
            // 
            lblKabupaten_kota.AutoSize = true;
            lblKabupaten_kota.Location = new Point(573, 134);
            lblKabupaten_kota.Name = "lblKabupaten_kota";
            lblKabupaten_kota.Size = new Size(140, 25);
            lblKabupaten_kota.TabIndex = 7;
            lblKabupaten_kota.Text = "Kabupaten/Kota";
            // 
            // lblDesa_kelurahan
            // 
            lblDesa_kelurahan.AutoSize = true;
            lblDesa_kelurahan.Location = new Point(573, 84);
            lblDesa_kelurahan.Name = "lblDesa_kelurahan";
            lblDesa_kelurahan.Size = new Size(135, 25);
            lblDesa_kelurahan.TabIndex = 6;
            lblDesa_kelurahan.Text = "Desa/Kelurahan";
            // 
            // lblKecamatan
            // 
            lblKecamatan.AutoSize = true;
            lblKecamatan.Location = new Point(573, 28);
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
            lblRT.Click += label2_Click_1;
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
            lblNik.Size = new Size(155, 25);
            lblNik.TabIndex = 0;
            lblNik.Text = "No Kartu Keluarga";
            // 
            // paneloutput_kk
            // 
            paneloutput_kk.BorderStyle = BorderStyle.FixedSingle;
            paneloutput_kk.Controls.Add(dateTimePicker1);
            paneloutput_kk.Controls.Add(dgvDataKK);
            paneloutput_kk.Controls.Add(btnReset);
            paneloutput_kk.Controls.Add(btnHapus);
            paneloutput_kk.Controls.Add(btnUbah);
            paneloutput_kk.Location = new Point(12, 484);
            paneloutput_kk.Name = "paneloutput_kk";
            paneloutput_kk.Size = new Size(1900, 544);
            paneloutput_kk.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1557, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // dgvDataKK
            // 
            dgvDataKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataKK.Columns.AddRange(new DataGridViewColumn[] { colId_kk, colNo_kk, colNama_kepala_keluarga, colAlamat, colRT, colRW, colKecamatan, colDesa_kelurahan, colKabupaten, colProvinsi });
            dgvDataKK.Location = new Point(36, 97);
            dgvDataKK.Name = "dgvDataKK";
            dgvDataKK.RowHeadersWidth = 62;
            dgvDataKK.Size = new Size(1821, 363);
            dgvDataKK.TabIndex = 21;
            dgvDataKK.CellContentClick += dgvDataKK_CellContentClick;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(954, 482);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 20;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(826, 482);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 19;
            btnHapus.Text = "hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(699, 482);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(112, 34);
            btnUbah.TabIndex = 18;
            btnUbah.Text = "ubah";
            btnUbah.UseVisualStyleBackColor = true;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.Location = new Point(839, 21);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(487, 48);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Pendaftaran Kartu Keluarga";
            lblJudul.Click += label1_Click;
            // 
            // panelstatistikringkas_kk
            // 
            panelstatistikringkas_kk.Controls.Add(pictureDataBaru);
            panelstatistikringkas_kk.Controls.Add(pictureTotalKK);
            panelstatistikringkas_kk.Controls.Add(angkadata);
            panelstatistikringkas_kk.Controls.Add(angkatotal);
            panelstatistikringkas_kk.Controls.Add(data_baru);
            panelstatistikringkas_kk.Controls.Add(TotalKK);
            panelstatistikringkas_kk.Controls.Add(statistik_ringkas);
            panelstatistikringkas_kk.Location = new Point(1236, 91);
            panelstatistikringkas_kk.Name = "panelstatistikringkas_kk";
            panelstatistikringkas_kk.Size = new Size(676, 355);
            panelstatistikringkas_kk.TabIndex = 2;
            panelstatistikringkas_kk.Paint += panel1_Paint_1;
            // 
            // pictureDataBaru
            // 
            pictureDataBaru.Image = (Image)resources.GetObject("pictureDataBaru.Image");
            pictureDataBaru.Location = new Point(410, 121);
            pictureDataBaru.Name = "pictureDataBaru";
            pictureDataBaru.Size = new Size(100, 100);
            pictureDataBaru.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDataBaru.TabIndex = 6;
            pictureDataBaru.TabStop = false;
            // 
            // pictureTotalKK
            // 
            pictureTotalKK.Image = (Image)resources.GetObject("pictureTotalKK.Image");
            pictureTotalKK.Location = new Point(71, 121);
            pictureTotalKK.Name = "pictureTotalKK";
            pictureTotalKK.Size = new Size(100, 100);
            pictureTotalKK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTotalKK.TabIndex = 5;
            pictureTotalKK.TabStop = false;
            pictureTotalKK.Click += pictureBox1_Click;
            // 
            // angkadata
            // 
            angkadata.AutoSize = true;
            angkadata.Font = new Font("Segoe UI", 20F);
            angkadata.Location = new Point(555, 156);
            angkadata.Name = "angkadata";
            angkadata.Size = new Size(45, 54);
            angkadata.TabIndex = 4;
            angkadata.Text = "0";
            angkadata.TextAlign = ContentAlignment.BottomCenter;
            angkadata.Click += label3_Click_1;
            // 
            // angkatotal
            // 
            angkatotal.AutoSize = true;
            angkatotal.Font = new Font("Segoe UI", 20F);
            angkatotal.Location = new Point(223, 156);
            angkatotal.Name = "angkatotal";
            angkatotal.Size = new Size(45, 54);
            angkatotal.TabIndex = 3;
            angkatotal.Text = "0";
            angkatotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // data_baru
            // 
            data_baru.AutoSize = true;
            data_baru.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            data_baru.Location = new Point(528, 108);
            data_baru.Name = "data_baru";
            data_baru.Size = new Size(106, 25);
            data_baru.TabIndex = 2;
            data_baru.Text = "DATA BARU";
            // 
            // TotalKK
            // 
            TotalKK.AutoSize = true;
            TotalKK.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            TotalKK.Location = new Point(205, 108);
            TotalKK.Name = "TotalKK";
            TotalKK.Size = new Size(86, 25);
            TotalKK.TabIndex = 1;
            TotalKK.Text = "TOTAL KK";
            // 
            // statistik_ringkas
            // 
            statistik_ringkas.AutoSize = true;
            statistik_ringkas.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            statistik_ringkas.Location = new Point(30, 29);
            statistik_ringkas.Name = "statistik_ringkas";
            statistik_ringkas.Size = new Size(175, 32);
            statistik_ringkas.TabIndex = 0;
            statistik_ringkas.Text = "statistik ringkas";
            // 
            // colProvinsi
            // 
            colProvinsi.HeaderText = "Provinsi";
            colProvinsi.MinimumWidth = 8;
            colProvinsi.Name = "colProvinsi";
            colProvinsi.Width = 200;
            // 
            // colKabupaten
            // 
            colKabupaten.HeaderText = "Kabupaten/kota";
            colKabupaten.MinimumWidth = 8;
            colKabupaten.Name = "colKabupaten";
            colKabupaten.Width = 200;
            // 
            // colDesa_kelurahan
            // 
            colDesa_kelurahan.HeaderText = "Desa/Kelurahan";
            colDesa_kelurahan.MinimumWidth = 8;
            colDesa_kelurahan.Name = "colDesa_kelurahan";
            colDesa_kelurahan.Width = 200;
            // 
            // colKecamatan
            // 
            colKecamatan.HeaderText = "Kecamatan";
            colKecamatan.MinimumWidth = 8;
            colKecamatan.Name = "colKecamatan";
            colKecamatan.Width = 200;
            // 
            // colRW
            // 
            colRW.HeaderText = "RW";
            colRW.MinimumWidth = 8;
            colRW.Name = "colRW";
            colRW.Width = 80;
            // 
            // colRT
            // 
            colRT.HeaderText = "RT";
            colRT.MinimumWidth = 8;
            colRT.Name = "colRT";
            colRT.Width = 80;
            // 
            // colAlamat
            // 
            colAlamat.HeaderText = "Alamat";
            colAlamat.MinimumWidth = 8;
            colAlamat.Name = "colAlamat";
            colAlamat.Width = 200;
            // 
            // colNama_kepala_keluarga
            // 
            colNama_kepala_keluarga.HeaderText = "Nama Kepala Keluarga";
            colNama_kepala_keluarga.MinimumWidth = 8;
            colNama_kepala_keluarga.Name = "colNama_kepala_keluarga";
            colNama_kepala_keluarga.Width = 250;
            // 
            // colNo_kk
            // 
            colNo_kk.HeaderText = "No. Kartu Keluarga";
            colNo_kk.MinimumWidth = 8;
            colNo_kk.Name = "colNo_kk";
            colNo_kk.Width = 250;
            // 
            // colId_kk
            // 
            colId_kk.HeaderText = "ID KK";
            colId_kk.MinimumWidth = 12;
            colId_kk.Name = "colId_kk";
            colId_kk.Width = 150;
            // 
            // FormKK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panelstatistikringkas_kk);
            Controls.Add(lblJudul);
            Controls.Add(paneloutput_kk);
            Controls.Add(panelinput_kk);
            Name = "FormKK";
            Text = "FormKK";
            Load += FormKK_Load;
            panelinput_kk.ResumeLayout(false);
            panelinput_kk.PerformLayout();
            paneloutput_kk.ResumeLayout(false);
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
        private Label lblJudul;
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
        private TextBox txtNo_kk;
        private TextBox txtProvinsi;
        private TextBox txtKabupaten_kota;
        private TextBox txtDesa_kelurahan;
        private Button btnTambah;
        private Button btnReset;
        private Button btnHapus;
        private Button btnUbah;
        private DataGridView dgvDataKK;
        private DateTimePicker dateTimePicker1;
        private Panel panelstatistikringkas_kk;
        private Label statistik_ringkas;
        private Label TotalKK;
        private Label angkatotal;
        private Label data_baru;
        private Label angkadata;
        private PictureBox pictureTotalKK;
        private PictureBox pictureDataBaru;
        private DataGridViewTextBoxColumn colId_kk;
        private DataGridViewTextBoxColumn colNo_kk;
        private DataGridViewTextBoxColumn colNama_kepala_keluarga;
        private DataGridViewTextBoxColumn colAlamat;
        private DataGridViewTextBoxColumn colRT;
        private DataGridViewTextBoxColumn colRW;
        private DataGridViewTextBoxColumn colKecamatan;
        private DataGridViewTextBoxColumn colDesa_kelurahan;
        private DataGridViewTextBoxColumn colKabupaten;
        private DataGridViewTextBoxColumn colProvinsi;
    }
}