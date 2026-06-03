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
            panelinput = new Panel();
            txtProvinsi = new TextBox();
            txtKabupaten_kota = new TextBox();
            txtDesa_kelurahan = new TextBox();
            txtKecamatan = new TextBox();
            tambah = new Button();
            txtRW = new TextBox();
            txtRT = new TextBox();
            txtAlamat = new TextBox();
            txtNama_kepala_keluarga = new TextBox();
            txtNo_kk = new TextBox();
            Provinsi = new Label();
            Kabupaten_kota = new Label();
            Desa_kelurahan = new Label();
            Kecamatan = new Label();
            RW = new Label();
            RT = new Label();
            Alamat = new Label();
            Nama_kepala_keluarga = new Label();
            No_kk = new Label();
            paneloutput = new Panel();
            dateTimePicker1 = new DateTimePicker();
            dgvDataKK = new DataGridView();
            colId_kk = new DataGridViewTextBoxColumn();
            colNo_kk = new DataGridViewTextBoxColumn();
            colNama_kepala_keluarga = new DataGridViewTextBoxColumn();
            colAlamat = new DataGridViewTextBoxColumn();
            colRT = new DataGridViewTextBoxColumn();
            colRW = new DataGridViewTextBoxColumn();
            colKecamatan = new DataGridViewTextBoxColumn();
            colDesa_kelurahan = new DataGridViewTextBoxColumn();
            colKabupaten = new DataGridViewTextBoxColumn();
            colProvinsi = new DataGridViewTextBoxColumn();
            reset = new Button();
            hapus = new Button();
            ubah = new Button();
            label1 = new Label();
            panelstatistikringkaskk = new Panel();
            pictureDataBaru = new PictureBox();
            pictureTotalKK = new PictureBox();
            angkadata = new Label();
            angkatotal = new Label();
            data_baru = new Label();
            TotalKK = new Label();
            statistik_ringkas = new Label();
            panelinput.SuspendLayout();
            paneloutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).BeginInit();
            panelstatistikringkaskk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDataBaru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).BeginInit();
            SuspendLayout();
            // 
            // panelinput
            // 
            panelinput.BorderStyle = BorderStyle.FixedSingle;
            panelinput.Controls.Add(txtProvinsi);
            panelinput.Controls.Add(txtKabupaten_kota);
            panelinput.Controls.Add(txtDesa_kelurahan);
            panelinput.Controls.Add(txtKecamatan);
            panelinput.Controls.Add(tambah);
            panelinput.Controls.Add(txtRW);
            panelinput.Controls.Add(txtRT);
            panelinput.Controls.Add(txtAlamat);
            panelinput.Controls.Add(txtNama_kepala_keluarga);
            panelinput.Controls.Add(txtNo_kk);
            panelinput.Controls.Add(Provinsi);
            panelinput.Controls.Add(Kabupaten_kota);
            panelinput.Controls.Add(Desa_kelurahan);
            panelinput.Controls.Add(Kecamatan);
            panelinput.Controls.Add(RW);
            panelinput.Controls.Add(RT);
            panelinput.Controls.Add(Alamat);
            panelinput.Controls.Add(Nama_kepala_keluarga);
            panelinput.Controls.Add(No_kk);
            panelinput.Location = new Point(13, 91);
            panelinput.Name = "panelinput";
            panelinput.Size = new Size(1110, 355);
            panelinput.TabIndex = 0;
            panelinput.Paint += panel1_Paint;
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
            // tambah
            // 
            tambah.Location = new Point(952, 292);
            tambah.Name = "tambah";
            tambah.Size = new Size(112, 34);
            tambah.TabIndex = 2;
            tambah.Text = "tambah";
            tambah.UseVisualStyleBackColor = true;
            tambah.Click += button1_Click;
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
            // Provinsi
            // 
            Provinsi.AutoSize = true;
            Provinsi.Location = new Point(573, 189);
            Provinsi.Name = "Provinsi";
            Provinsi.Size = new Size(74, 25);
            Provinsi.TabIndex = 8;
            Provinsi.Text = "Provinsi";
            // 
            // Kabupaten_kota
            // 
            Kabupaten_kota.AutoSize = true;
            Kabupaten_kota.Location = new Point(573, 134);
            Kabupaten_kota.Name = "Kabupaten_kota";
            Kabupaten_kota.Size = new Size(140, 25);
            Kabupaten_kota.TabIndex = 7;
            Kabupaten_kota.Text = "Kabupaten/Kota";
            // 
            // Desa_kelurahan
            // 
            Desa_kelurahan.AutoSize = true;
            Desa_kelurahan.Location = new Point(573, 84);
            Desa_kelurahan.Name = "Desa_kelurahan";
            Desa_kelurahan.Size = new Size(135, 25);
            Desa_kelurahan.TabIndex = 6;
            Desa_kelurahan.Text = "Desa/Kelurahan";
            // 
            // Kecamatan
            // 
            Kecamatan.AutoSize = true;
            Kecamatan.Location = new Point(573, 28);
            Kecamatan.Name = "Kecamatan";
            Kecamatan.Size = new Size(98, 25);
            Kecamatan.TabIndex = 5;
            Kecamatan.Text = "Kecamatan";
            // 
            // RW
            // 
            RW.AutoSize = true;
            RW.Location = new Point(35, 240);
            RW.Name = "RW";
            RW.Size = new Size(40, 25);
            RW.TabIndex = 4;
            RW.Text = "RW";
            // 
            // RT
            // 
            RT.AutoSize = true;
            RT.Location = new Point(35, 181);
            RT.Name = "RT";
            RT.Size = new Size(31, 25);
            RT.TabIndex = 3;
            RT.Text = "RT";
            RT.Click += label2_Click_1;
            // 
            // Alamat
            // 
            Alamat.AutoSize = true;
            Alamat.Location = new Point(35, 131);
            Alamat.Name = "Alamat";
            Alamat.Size = new Size(68, 25);
            Alamat.TabIndex = 2;
            Alamat.Text = "Alamat";
            // 
            // Nama_kepala_keluarga
            // 
            Nama_kepala_keluarga.AutoSize = true;
            Nama_kepala_keluarga.Location = new Point(35, 78);
            Nama_kepala_keluarga.Name = "Nama_kepala_keluarga";
            Nama_kepala_keluarga.Size = new Size(189, 25);
            Nama_kepala_keluarga.TabIndex = 1;
            Nama_kepala_keluarga.Text = "Nama Kepala Keluarga";
            // 
            // No_kk
            // 
            No_kk.AutoSize = true;
            No_kk.Location = new Point(35, 28);
            No_kk.Name = "No_kk";
            No_kk.Size = new Size(159, 25);
            No_kk.TabIndex = 0;
            No_kk.Text = "No. Kartu Keluarga";
            // 
            // paneloutput
            // 
            paneloutput.BorderStyle = BorderStyle.FixedSingle;
            paneloutput.Controls.Add(dateTimePicker1);
            paneloutput.Controls.Add(dgvDataKK);
            paneloutput.Controls.Add(reset);
            paneloutput.Controls.Add(hapus);
            paneloutput.Controls.Add(ubah);
            paneloutput.Location = new Point(12, 484);
            paneloutput.Name = "paneloutput";
            paneloutput.Size = new Size(1900, 544);
            paneloutput.TabIndex = 1;
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
            // colId_kk
            // 
            colId_kk.HeaderText = "ID KK";
            colId_kk.MinimumWidth = 12;
            colId_kk.Name = "colId_kk";
            colId_kk.Width = 150;
            // 
            // colNo_kk
            // 
            colNo_kk.HeaderText = "No. Kartu Keluarga";
            colNo_kk.MinimumWidth = 8;
            colNo_kk.Name = "colNo_kk";
            colNo_kk.Width = 250;
            // 
            // colNama_kepala_keluarga
            // 
            colNama_kepala_keluarga.HeaderText = "Nama Kepala Keluarga";
            colNama_kepala_keluarga.MinimumWidth = 8;
            colNama_kepala_keluarga.Name = "colNama_kepala_keluarga";
            colNama_kepala_keluarga.Width = 250;
            // 
            // colAlamat
            // 
            colAlamat.HeaderText = "Alamat";
            colAlamat.MinimumWidth = 8;
            colAlamat.Name = "colAlamat";
            colAlamat.Width = 200;
            // 
            // colRT
            // 
            colRT.HeaderText = "RT";
            colRT.MinimumWidth = 8;
            colRT.Name = "colRT";
            colRT.Width = 80;
            // 
            // colRW
            // 
            colRW.HeaderText = "RW";
            colRW.MinimumWidth = 8;
            colRW.Name = "colRW";
            colRW.Width = 80;
            // 
            // colKecamatan
            // 
            colKecamatan.HeaderText = "Kecamatan";
            colKecamatan.MinimumWidth = 8;
            colKecamatan.Name = "colKecamatan";
            colKecamatan.Width = 200;
            // 
            // colDesa_kelurahan
            // 
            colDesa_kelurahan.HeaderText = "Desa/Kelurahan";
            colDesa_kelurahan.MinimumWidth = 8;
            colDesa_kelurahan.Name = "colDesa_kelurahan";
            colDesa_kelurahan.Width = 200;
            // 
            // colKabupaten
            // 
            colKabupaten.HeaderText = "Kabupaten/kota";
            colKabupaten.MinimumWidth = 8;
            colKabupaten.Name = "colKabupaten";
            colKabupaten.Width = 200;
            // 
            // colProvinsi
            // 
            colProvinsi.HeaderText = "Provinsi";
            colProvinsi.MinimumWidth = 8;
            colProvinsi.Name = "colProvinsi";
            colProvinsi.Width = 200;
            // 
            // reset
            // 
            reset.Location = new Point(954, 482);
            reset.Name = "reset";
            reset.Size = new Size(112, 34);
            reset.TabIndex = 20;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
            // 
            // hapus
            // 
            hapus.Location = new Point(826, 482);
            hapus.Name = "hapus";
            hapus.Size = new Size(112, 34);
            hapus.TabIndex = 19;
            hapus.Text = "hapus";
            hapus.UseVisualStyleBackColor = true;
            // 
            // ubah
            // 
            ubah.Location = new Point(699, 482);
            ubah.Name = "ubah";
            ubah.Size = new Size(112, 34);
            ubah.TabIndex = 18;
            ubah.Text = "ubah";
            ubah.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(839, 21);
            label1.Name = "label1";
            label1.Size = new Size(487, 48);
            label1.TabIndex = 0;
            label1.Text = "Pendaftaran Kartu Keluarga";
            label1.Click += label1_Click;
            // 
            // panelstatistikringkaskk
            // 
            panelstatistikringkaskk.Controls.Add(pictureDataBaru);
            panelstatistikringkaskk.Controls.Add(pictureTotalKK);
            panelstatistikringkaskk.Controls.Add(angkadata);
            panelstatistikringkaskk.Controls.Add(angkatotal);
            panelstatistikringkaskk.Controls.Add(data_baru);
            panelstatistikringkaskk.Controls.Add(TotalKK);
            panelstatistikringkaskk.Controls.Add(statistik_ringkas);
            panelstatistikringkaskk.Location = new Point(1236, 91);
            panelstatistikringkaskk.Name = "panelstatistikringkaskk";
            panelstatistikringkaskk.Size = new Size(676, 355);
            panelstatistikringkaskk.TabIndex = 2;
            panelstatistikringkaskk.Paint += panel1_Paint_1;
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
            angkadata.Location = new Point(553, 170);
            angkadata.Name = "angkadata";
            angkadata.Size = new Size(45, 54);
            angkadata.TabIndex = 4;
            angkadata.Text = "1";
            angkadata.TextAlign = ContentAlignment.BottomCenter;
            angkadata.Click += label3_Click_1;
            // 
            // angkatotal
            // 
            angkatotal.AutoSize = true;
            angkatotal.Font = new Font("Segoe UI", 20F);
            angkatotal.Location = new Point(223, 170);
            angkatotal.Name = "angkatotal";
            angkatotal.Size = new Size(45, 54);
            angkatotal.TabIndex = 3;
            angkatotal.Text = "1";
            angkatotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // data_baru
            // 
            data_baru.AutoSize = true;
            data_baru.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            data_baru.Location = new Point(527, 110);
            data_baru.Name = "data_baru";
            data_baru.Size = new Size(106, 25);
            data_baru.TabIndex = 2;
            data_baru.Text = "DATA BARU";
            // 
            // TotalKK
            // 
            TotalKK.AutoSize = true;
            TotalKK.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            TotalKK.Location = new Point(205, 122);
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
            // FormKK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panelstatistikringkaskk);
            Controls.Add(label1);
            Controls.Add(paneloutput);
            Controls.Add(panelinput);
            Name = "FormKK";
            Text = "FormKK";
            Load += FormKK_Load;
            panelinput.ResumeLayout(false);
            panelinput.PerformLayout();
            paneloutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).EndInit();
            panelstatistikringkaskk.ResumeLayout(false);
            panelstatistikringkaskk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDataBaru).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelinput;
        private Panel paneloutput;
        private Label label1;
        private Label Nama_kepala_keluarga;
        private Label No_kk;
        private Label RT;
        private Label Alamat;
        private Label Kabupaten_kota;
        private Label Desa_kelurahan;
        private Label Kecamatan;
        private Label RW;
        private Label Provinsi;
        private TextBox txtKecamatan;
        private TextBox txtRW;
        private TextBox txtRT;
        private TextBox txtAlamat;
        private TextBox txtNama_kepala_keluarga;
        private TextBox txtNo_kk;
        private TextBox txtProvinsi;
        private TextBox txtKabupaten_kota;
        private TextBox txtDesa_kelurahan;
        private Button tambah;
        private Button reset;
        private Button hapus;
        private Button ubah;
        private DataGridView dgvDataKK;
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
        private DateTimePicker dateTimePicker1;
        private Panel panelstatistikringkaskk;
        private Label statistik_ringkas;
        private Label TotalKK;
        private Label angkatotal;
        private Label data_baru;
        private Label angkadata;
        private PictureBox pictureTotalKK;
        private PictureBox pictureDataBaru;
    }
}