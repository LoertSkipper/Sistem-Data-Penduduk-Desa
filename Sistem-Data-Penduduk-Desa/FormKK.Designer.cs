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
            paneloutput = new Panel();
            label1 = new Label();
            No_kk = new Label();
            Nama_kepala_keluarga = new Label();
            RT = new Label();
            Alamat = new Label();
            Kecamatan = new Label();
            RW = new Label();
            Kabupaten_kota = new Label();
            Desa_kelurahan = new Label();
            Provinsi = new Label();
            txtNo_kk = new TextBox();
            txtNama_kepala_keluarga = new TextBox();
            txtAlamat = new TextBox();
            txtRT = new TextBox();
            txtRW = new TextBox();
            txtKecamatan = new TextBox();
            txtDesa_kelurahan = new TextBox();
            txtKabupaten_kota = new TextBox();
            txtProvinsi = new TextBox();
            tambah = new Button();
            ubah = new Button();
            hapus = new Button();
            reset = new Button();
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
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            statistik_ringkas = new Label();
            TotalKK = new Label();
            data_baru = new Label();
            angkatotal = new Label();
            angkadata = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelinput.SuspendLayout();
            paneloutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(377, 24);
            label1.Name = "label1";
            label1.Size = new Size(487, 48);
            label1.TabIndex = 0;
            label1.Text = "Pendaftaran Kartu Keluarga";
            label1.Click += label1_Click;
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
            // Nama_kepala_keluarga
            // 
            Nama_kepala_keluarga.AutoSize = true;
            Nama_kepala_keluarga.Location = new Point(35, 78);
            Nama_kepala_keluarga.Name = "Nama_kepala_keluarga";
            Nama_kepala_keluarga.Size = new Size(189, 25);
            Nama_kepala_keluarga.TabIndex = 1;
            Nama_kepala_keluarga.Text = "Nama Kepala Keluarga";
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
            // Provinsi
            // 
            Provinsi.AutoSize = true;
            Provinsi.Location = new Point(573, 189);
            Provinsi.Name = "Provinsi";
            Provinsi.Size = new Size(74, 25);
            Provinsi.TabIndex = 8;
            Provinsi.Text = "Provinsi";
            // 
            // txtNo_kk
            // 
            txtNo_kk.Location = new Point(287, 28);
            txtNo_kk.Name = "txtNo_kk";
            txtNo_kk.Size = new Size(239, 31);
            txtNo_kk.TabIndex = 9;
            // 
            // txtNama_kepala_keluarga
            // 
            txtNama_kepala_keluarga.Location = new Point(287, 78);
            txtNama_kepala_keluarga.Name = "txtNama_kepala_keluarga";
            txtNama_kepala_keluarga.Size = new Size(239, 31);
            txtNama_kepala_keluarga.TabIndex = 10;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(287, 131);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(239, 31);
            txtAlamat.TabIndex = 11;
            // 
            // txtRT
            // 
            txtRT.Location = new Point(287, 181);
            txtRT.Name = "txtRT";
            txtRT.Size = new Size(94, 31);
            txtRT.TabIndex = 12;
            // 
            // txtRW
            // 
            txtRW.Location = new Point(287, 240);
            txtRW.Name = "txtRW";
            txtRW.Size = new Size(94, 31);
            txtRW.TabIndex = 13;
            // 
            // txtKecamatan
            // 
            txtKecamatan.Location = new Point(825, 28);
            txtKecamatan.Name = "txtKecamatan";
            txtKecamatan.Size = new Size(239, 31);
            txtKecamatan.TabIndex = 14;
            // 
            // txtDesa_kelurahan
            // 
            txtDesa_kelurahan.Location = new Point(825, 84);
            txtDesa_kelurahan.Name = "txtDesa_kelurahan";
            txtDesa_kelurahan.Size = new Size(239, 31);
            txtDesa_kelurahan.TabIndex = 15;
            // 
            // txtKabupaten_kota
            // 
            txtKabupaten_kota.Location = new Point(825, 134);
            txtKabupaten_kota.Name = "txtKabupaten_kota";
            txtKabupaten_kota.Size = new Size(239, 31);
            txtKabupaten_kota.TabIndex = 16;
            // 
            // txtProvinsi
            // 
            txtProvinsi.Location = new Point(825, 189);
            txtProvinsi.Name = "txtProvinsi";
            txtProvinsi.Size = new Size(239, 31);
            txtProvinsi.TabIndex = 17;
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
            // ubah
            // 
            ubah.Location = new Point(699, 482);
            ubah.Name = "ubah";
            ubah.Size = new Size(112, 34);
            ubah.TabIndex = 18;
            ubah.Text = "ubah";
            ubah.UseVisualStyleBackColor = true;
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
            // reset
            // 
            reset.Location = new Point(954, 482);
            reset.Name = "reset";
            reset.Size = new Size(112, 34);
            reset.TabIndex = 20;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1557, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(angkadata);
            panel1.Controls.Add(angkatotal);
            panel1.Controls.Add(data_baru);
            panel1.Controls.Add(TotalKK);
            panel1.Controls.Add(statistik_ringkas);
            panel1.Location = new Point(1236, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 355);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(410, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // FormKK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel1;
        private Label statistik_ringkas;
        private Label TotalKK;
        private Label angkatotal;
        private Label data_baru;
        private Label angkadata;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}