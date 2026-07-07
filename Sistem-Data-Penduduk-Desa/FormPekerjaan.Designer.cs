using Microsoft.VisualBasic.FileIO;

namespace Sistem_Data_Penduduk_Desa
{
    partial class FormPekerjaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPekerjaan));
            lblNik = new Label();
            panelstatistikringkas_pekerjaan = new Panel();
            pictureBox1 = new PictureBox();
            angkaRata2 = new Label();
            lblRata2_pendapatan = new Label();
            pictureTotalKK = new PictureBox();
            lblAngkatotal = new Label();
            lblTotal_pekerja = new Label();
            lblStatistik_ringkas = new Label();
            lblJudulPendataanPekerjaan = new Label();
            dateTimePicker1 = new DateTimePicker();
            paneloutput_pekerjaan = new Panel();
            dgvDataKK = new DataGridView();
            colId_pekerja = new DataGridViewTextBoxColumn();
            colNama_Lengkap = new DataGridViewTextBoxColumn();
            colTTL = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colPendidikan_terakhir = new DataGridViewTextBoxColumn();
            colPekerjaan = new DataGridViewTextBoxColumn();
            colPendapatan = new DataGridViewTextBoxColumn();
            colJumlah_tanggungan = new DataGridViewTextBoxColumn();
            colnik = new DataGridViewTextBoxColumn();
            btnReset = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            panelinput_pekerjaan = new Panel();
            panel1 = new Panel();
            cmbGender = new ComboBox();
            cmbStatus = new ComboBox();
            cmbJumlah_Tanggungann = new TextBox();
            txtPendapatann = new TextBox();
            cmbPekerjaann = new TextBox();
            txtPendidikan_Terakhirr = new TextBox();
            btnTambahh = new Button();
            txtTtll = new TextBox();
            txtNama_Lengkap = new TextBox();
            txtNo_nik = new TextBox();
            lblJumlah_Tanggungann = new Label();
            lblPendapatann = new Label();
            lblPekerjaann = new Label();
            lblPendidikan_Terakhirr = new Label();
            lblStatuss = new Label();
            lblTtll = new Label();
            label7 = new Label();
            label8 = new Label();
            lblNo_nik = new Label();
            comboBox1 = new ComboBox();
            txtJumlah_tanggungan = new TextBox();
            txtKabupaten_kota = new TextBox();
            txtDesa_kelurahan = new TextBox();
            txtKecamatan = new TextBox();
            btnTambah = new Button();
            txtRT = new TextBox();
            txtNama_kepala_keluarga = new TextBox();
            txtNik = new TextBox();
            lblJumlah_tanggungan = new Label();
            lblPendapatan = new Label();
            lblPekerjaan = new Label();
            lblPendidikan_terakhir = new Label();
            lblStatus = new Label();
            lblTTL = new Label();
            lblGender = new Label();
            lblNama_lengkap = new Label();
            panelstatistikringkas_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).BeginInit();
            paneloutput_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).BeginInit();
            panelinput_pekerjaan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNik
            // 
            lblNik.AutoSize = true;
            lblNik.Location = new Point(25, 28);
            lblNik.Name = "lblNik";
            lblNik.Size = new Size(40, 25);
            lblNik.TabIndex = 0;
            lblNik.Text = "NIK";
            // 
            // panelstatistikringkas_pekerjaan
            // 
            panelstatistikringkas_pekerjaan.Controls.Add(pictureBox1);
            panelstatistikringkas_pekerjaan.Controls.Add(angkaRata2);
            panelstatistikringkas_pekerjaan.Controls.Add(lblRata2_pendapatan);
            panelstatistikringkas_pekerjaan.Controls.Add(pictureTotalKK);
            panelstatistikringkas_pekerjaan.Controls.Add(lblAngkatotal);
            panelstatistikringkas_pekerjaan.Controls.Add(lblTotal_pekerja);
            panelstatistikringkas_pekerjaan.Controls.Add(lblStatistik_ringkas);
            panelstatistikringkas_pekerjaan.Location = new Point(953, 92);
            panelstatistikringkas_pekerjaan.Name = "panelstatistikringkas_pekerjaan";
            panelstatistikringkas_pekerjaan.Size = new Size(422, 355);
            panelstatistikringkas_pekerjaan.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(256, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // angkaRata2
            // 
            angkaRata2.AutoSize = true;
            angkaRata2.Font = new Font("Segoe UI", 20F);
            angkaRata2.Location = new Point(286, 275);
            angkaRata2.Name = "angkaRata2";
            angkaRata2.Size = new Size(45, 54);
            angkaRata2.TabIndex = 7;
            angkaRata2.Text = "0";
            angkaRata2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRata2_pendapatan
            // 
            lblRata2_pendapatan.AutoSize = true;
            lblRata2_pendapatan.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblRata2_pendapatan.Location = new Point(220, 227);
            lblRata2_pendapatan.Name = "lblRata2_pendapatan";
            lblRata2_pendapatan.Size = new Size(176, 25);
            lblRata2_pendapatan.TabIndex = 6;
            lblRata2_pendapatan.Text = "RATA\" PENDAPATAN";
            // 
            // pictureTotalKK
            // 
            pictureTotalKK.Image = (Image)resources.GetObject("pictureTotalKK.Image");
            pictureTotalKK.Location = new Point(50, 107);
            pictureTotalKK.Name = "pictureTotalKK";
            pictureTotalKK.Size = new Size(100, 100);
            pictureTotalKK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTotalKK.TabIndex = 5;
            pictureTotalKK.TabStop = false;
            // 
            // lblAngkatotal
            // 
            lblAngkatotal.AutoSize = true;
            lblAngkatotal.Font = new Font("Segoe UI", 20F);
            lblAngkatotal.Location = new Point(80, 275);
            lblAngkatotal.Name = "lblAngkatotal";
            lblAngkatotal.Size = new Size(45, 54);
            lblAngkatotal.TabIndex = 3;
            lblAngkatotal.Text = "0";
            lblAngkatotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotal_pekerja
            // 
            lblTotal_pekerja.AutoSize = true;
            lblTotal_pekerja.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblTotal_pekerja.Location = new Point(36, 227);
            lblTotal_pekerja.Name = "lblTotal_pekerja";
            lblTotal_pekerja.Size = new Size(134, 25);
            lblTotal_pekerja.TabIndex = 1;
            lblTotal_pekerja.Text = "TOTAL PEKERJA";
            // 
            // lblStatistik_ringkas
            // 
            lblStatistik_ringkas.AutoSize = true;
            lblStatistik_ringkas.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblStatistik_ringkas.Location = new Point(116, 29);
            lblStatistik_ringkas.Name = "lblStatistik_ringkas";
            lblStatistik_ringkas.Size = new Size(175, 32);
            lblStatistik_ringkas.TabIndex = 0;
            lblStatistik_ringkas.Text = "statistik ringkas";
            // 
            // lblJudulPendataanPekerjaan
            // 
            lblJudulPendataanPekerjaan.AutoSize = true;
            lblJudulPendataanPekerjaan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudulPendataanPekerjaan.Location = new Point(523, 23);
            lblJudulPendataanPekerjaan.Name = "lblJudulPendataanPekerjaan";
            lblJudulPendataanPekerjaan.Size = new Size(369, 48);
            lblJudulPendataanPekerjaan.TabIndex = 3;
            lblJudulPendataanPekerjaan.Text = "Pendataan Pekerjaan";
            lblJudulPendataanPekerjaan.Click += lblJudul_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1028, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // paneloutput_pekerjaan
            // 
            paneloutput_pekerjaan.BorderStyle = BorderStyle.FixedSingle;
            paneloutput_pekerjaan.Controls.Add(dateTimePicker1);
            paneloutput_pekerjaan.Controls.Add(dgvDataKK);
            paneloutput_pekerjaan.Controls.Add(btnReset);
            paneloutput_pekerjaan.Controls.Add(btnHapus);
            paneloutput_pekerjaan.Controls.Add(btnUbah);
            paneloutput_pekerjaan.Location = new Point(20, 485);
            paneloutput_pekerjaan.Name = "paneloutput_pekerjaan";
            paneloutput_pekerjaan.Size = new Size(1355, 506);
            paneloutput_pekerjaan.TabIndex = 5;
            // 
            // dgvDataKK
            // 
            dgvDataKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataKK.Columns.AddRange(new DataGridViewColumn[] { colId_pekerja, colNama_Lengkap, colTTL, colStatus, colPendidikan_terakhir, colPekerjaan, colPendapatan, colJumlah_tanggungan, colnik });
            dgvDataKK.Location = new Point(25, 92);
            dgvDataKK.Name = "dgvDataKK";
            dgvDataKK.RowHeadersWidth = 62;
            dgvDataKK.Size = new Size(1303, 319);
            dgvDataKK.TabIndex = 21;
            // 
            // colId_pekerja
            // 
            colId_pekerja.HeaderText = "ID Pekerja";
            colId_pekerja.MinimumWidth = 8;
            colId_pekerja.Name = "colId_pekerja";
            colId_pekerja.Width = 150;
            // 
            // colNama_Lengkap
            // 
            colNama_Lengkap.HeaderText = "NIK";
            colNama_Lengkap.MinimumWidth = 8;
            colNama_Lengkap.Name = "colNama_Lengkap";
            colNama_Lengkap.Width = 150;
            // 
            // colTTL
            // 
            colTTL.HeaderText = "TTL";
            colTTL.MinimumWidth = 8;
            colTTL.Name = "colTTL";
            colTTL.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.Width = 150;
            // 
            // colPendidikan_terakhir
            // 
            colPendidikan_terakhir.HeaderText = "Pendidikan Terakhir";
            colPendidikan_terakhir.MinimumWidth = 8;
            colPendidikan_terakhir.Name = "colPendidikan_terakhir";
            colPendidikan_terakhir.Width = 150;
            // 
            // colPekerjaan
            // 
            colPekerjaan.HeaderText = "Pekerjaan";
            colPekerjaan.MinimumWidth = 8;
            colPekerjaan.Name = "colPekerjaan";
            colPekerjaan.Width = 150;
            // 
            // colPendapatan
            // 
            colPendapatan.HeaderText = "Pendapatan";
            colPendapatan.MinimumWidth = 8;
            colPendapatan.Name = "colPendapatan";
            colPendapatan.Width = 177;
            // 
            // colJumlah_tanggungan
            // 
            colJumlah_tanggungan.HeaderText = "Jumlah Tanggungan";
            colJumlah_tanggungan.MinimumWidth = 8;
            colJumlah_tanggungan.Name = "colJumlah_tanggungan";
            colJumlah_tanggungan.Width = 200;
            // 
            // colnik
            // 
            colnik.HeaderText = "Gender";
            colnik.MinimumWidth = 8;
            colnik.Name = "colnik";
            colnik.Width = 150;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1216, 440);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(1088, 440);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 19;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(961, 440);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(112, 34);
            btnUbah.TabIndex = 18;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click;
            // 
            // panelinput_pekerjaan
            // 
            panelinput_pekerjaan.BorderStyle = BorderStyle.FixedSingle;
            panelinput_pekerjaan.Controls.Add(panel1);
            panelinput_pekerjaan.Controls.Add(comboBox1);
            panelinput_pekerjaan.Controls.Add(txtJumlah_tanggungan);
            panelinput_pekerjaan.Controls.Add(txtKabupaten_kota);
            panelinput_pekerjaan.Controls.Add(txtDesa_kelurahan);
            panelinput_pekerjaan.Controls.Add(txtKecamatan);
            panelinput_pekerjaan.Controls.Add(btnTambah);
            panelinput_pekerjaan.Controls.Add(txtRT);
            panelinput_pekerjaan.Controls.Add(txtNama_kepala_keluarga);
            panelinput_pekerjaan.Controls.Add(txtNik);
            panelinput_pekerjaan.Controls.Add(lblJumlah_tanggungan);
            panelinput_pekerjaan.Controls.Add(lblPendapatan);
            panelinput_pekerjaan.Controls.Add(lblPekerjaan);
            panelinput_pekerjaan.Controls.Add(lblPendidikan_terakhir);
            panelinput_pekerjaan.Controls.Add(lblStatus);
            panelinput_pekerjaan.Controls.Add(lblTTL);
            panelinput_pekerjaan.Controls.Add(lblGender);
            panelinput_pekerjaan.Controls.Add(lblNama_lengkap);
            panelinput_pekerjaan.Controls.Add(lblNik);
            panelinput_pekerjaan.Location = new Point(21, 92);
            panelinput_pekerjaan.Name = "panelinput_pekerjaan";
            panelinput_pekerjaan.Size = new Size(908, 355);
            panelinput_pekerjaan.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(cmbJumlah_Tanggungann);
            panel1.Controls.Add(txtPendapatann);
            panel1.Controls.Add(cmbPekerjaann);
            panel1.Controls.Add(txtPendidikan_Terakhirr);
            panel1.Controls.Add(btnTambahh);
            panel1.Controls.Add(txtTtll);
            panel1.Controls.Add(txtNama_Lengkap);
            panel1.Controls.Add(txtNo_nik);
            panel1.Controls.Add(lblJumlah_Tanggungann);
            panel1.Controls.Add(lblPendapatann);
            panel1.Controls.Add(lblPekerjaann);
            panel1.Controls.Add(lblPendidikan_Terakhirr);
            panel1.Controls.Add(lblStatuss);
            panel1.Controls.Add(lblTtll);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblNo_nik);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 355);
            panel1.TabIndex = 19;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(189, 131);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(239, 33);
            cmbGender.TabIndex = 19;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(189, 240);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(239, 33);
            cmbStatus.TabIndex = 18;
            // 
            // cmbJumlah_Tanggungann
            // 
            cmbJumlah_Tanggungann.Location = new Point(634, 189);
            cmbJumlah_Tanggungann.Name = "cmbJumlah_Tanggungann";
            cmbJumlah_Tanggungann.Size = new Size(239, 31);
            cmbJumlah_Tanggungann.TabIndex = 17;
            // 
            // txtPendapatann
            // 
            txtPendapatann.Location = new Point(634, 134);
            txtPendapatann.Name = "txtPendapatann";
            txtPendapatann.Size = new Size(239, 31);
            txtPendapatann.TabIndex = 16;
            // 
            // cmbPekerjaann
            // 
            cmbPekerjaann.Location = new Point(634, 84);
            cmbPekerjaann.Name = "cmbPekerjaann";
            cmbPekerjaann.Size = new Size(239, 31);
            cmbPekerjaann.TabIndex = 15;
            // 
            // txtPendidikan_Terakhirr
            // 
            txtPendidikan_Terakhirr.Location = new Point(634, 28);
            txtPendidikan_Terakhirr.Name = "txtPendidikan_Terakhirr";
            txtPendidikan_Terakhirr.Size = new Size(239, 31);
            txtPendidikan_Terakhirr.TabIndex = 14;
            // 
            // btnTambahh
            // 
            btnTambahh.Location = new Point(761, 292);
            btnTambahh.Name = "btnTambahh";
            btnTambahh.Size = new Size(112, 34);
            btnTambahh.TabIndex = 2;
            btnTambahh.Text = "Tambah";
            btnTambahh.UseVisualStyleBackColor = true;
            // 
            // txtTtll
            // 
            txtTtll.Location = new Point(189, 181);
            txtTtll.Name = "txtTtll";
            txtTtll.Size = new Size(239, 31);
            txtTtll.TabIndex = 12;
            // 
            // txtNama_Lengkap
            // 
            txtNama_Lengkap.Location = new Point(189, 78);
            txtNama_Lengkap.Name = "txtNama_Lengkap";
            txtNama_Lengkap.Size = new Size(239, 31);
            txtNama_Lengkap.TabIndex = 10;
            // 
            // txtNo_nik
            // 
            txtNo_nik.Location = new Point(189, 28);
            txtNo_nik.Name = "txtNo_nik";
            txtNo_nik.Size = new Size(239, 31);
            txtNo_nik.TabIndex = 9;
            // 
            // lblJumlah_Tanggungann
            // 
            lblJumlah_Tanggungann.AutoSize = true;
            lblJumlah_Tanggungann.Location = new Point(456, 189);
            lblJumlah_Tanggungann.Name = "lblJumlah_Tanggungann";
            lblJumlah_Tanggungann.Size = new Size(169, 25);
            lblJumlah_Tanggungann.TabIndex = 8;
            lblJumlah_Tanggungann.Text = "Jumlah tanggungan";
            // 
            // lblPendapatann
            // 
            lblPendapatann.AutoSize = true;
            lblPendapatann.Location = new Point(456, 134);
            lblPendapatann.Name = "lblPendapatann";
            lblPendapatann.Size = new Size(105, 25);
            lblPendapatann.TabIndex = 7;
            lblPendapatann.Text = "Pendapatan";
            // 
            // lblPekerjaann
            // 
            lblPekerjaann.AutoSize = true;
            lblPekerjaann.Location = new Point(456, 84);
            lblPekerjaann.Name = "lblPekerjaann";
            lblPekerjaann.Size = new Size(86, 25);
            lblPekerjaann.TabIndex = 6;
            lblPekerjaann.Text = "Pekerjaan";
            // 
            // lblPendidikan_Terakhirr
            // 
            lblPendidikan_Terakhirr.AutoSize = true;
            lblPendidikan_Terakhirr.Location = new Point(456, 28);
            lblPendidikan_Terakhirr.Name = "lblPendidikan_Terakhirr";
            lblPendidikan_Terakhirr.Size = new Size(163, 25);
            lblPendidikan_Terakhirr.TabIndex = 5;
            lblPendidikan_Terakhirr.Text = "Pendidikan Terakhir";
            // 
            // lblStatuss
            // 
            lblStatuss.AutoSize = true;
            lblStatuss.Location = new Point(25, 240);
            lblStatuss.Name = "lblStatuss";
            lblStatuss.Size = new Size(60, 25);
            lblStatuss.TabIndex = 4;
            lblStatuss.Text = "Status";
            // 
            // lblTtll
            // 
            lblTtll.AutoSize = true;
            lblTtll.Location = new Point(25, 181);
            lblTtll.Name = "lblTtll";
            lblTtll.Size = new Size(38, 25);
            lblTtll.TabIndex = 3;
            lblTtll.Text = "TTL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 131);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 2;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 78);
            label8.Name = "label8";
            label8.Size = new Size(131, 25);
            label8.TabIndex = 1;
            label8.Text = "Nama Lengkap";
            // 
            // lblNo_nik
            // 
            lblNo_nik.AutoSize = true;
            lblNo_nik.Location = new Point(25, 28);
            lblNo_nik.Name = "lblNo_nik";
            lblNo_nik.Size = new Size(40, 25);
            lblNo_nik.TabIndex = 0;
            lblNo_nik.Text = "NIK";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 240);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 33);
            comboBox1.TabIndex = 18;
            // 
            // txtJumlah_tanggungan
            // 
            txtJumlah_tanggungan.Location = new Point(634, 189);
            txtJumlah_tanggungan.Name = "txtJumlah_tanggungan";
            txtJumlah_tanggungan.Size = new Size(239, 31);
            txtJumlah_tanggungan.TabIndex = 17;
            // 
            // txtKabupaten_kota
            // 
            txtKabupaten_kota.Location = new Point(634, 134);
            txtKabupaten_kota.Name = "txtKabupaten_kota";
            txtKabupaten_kota.Size = new Size(239, 31);
            txtKabupaten_kota.TabIndex = 16;
            // 
            // txtDesa_kelurahan
            // 
            txtDesa_kelurahan.Location = new Point(634, 84);
            txtDesa_kelurahan.Name = "txtDesa_kelurahan";
            txtDesa_kelurahan.Size = new Size(239, 31);
            txtDesa_kelurahan.TabIndex = 15;
            // 
            // txtKecamatan
            // 
            txtKecamatan.Location = new Point(634, 28);
            txtKecamatan.Name = "txtKecamatan";
            txtKecamatan.Size = new Size(239, 31);
            txtKecamatan.TabIndex = 14;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(761, 292);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // txtRT
            // 
            txtRT.Location = new Point(189, 181);
            txtRT.Name = "txtRT";
            txtRT.Size = new Size(239, 31);
            txtRT.TabIndex = 12;
            // 
            // txtNama_kepala_keluarga
            // 
            txtNama_kepala_keluarga.Location = new Point(189, 78);
            txtNama_kepala_keluarga.Name = "txtNama_kepala_keluarga";
            txtNama_kepala_keluarga.Size = new Size(239, 31);
            txtNama_kepala_keluarga.TabIndex = 10;
            // 
            // txtNik
            // 
            txtNik.Location = new Point(189, 28);
            txtNik.Name = "txtNik";
            txtNik.Size = new Size(239, 31);
            txtNik.TabIndex = 9;
            // 
            // lblJumlah_tanggungan
            // 
            lblJumlah_tanggungan.AutoSize = true;
            lblJumlah_tanggungan.Location = new Point(456, 189);
            lblJumlah_tanggungan.Name = "lblJumlah_tanggungan";
            lblJumlah_tanggungan.Size = new Size(169, 25);
            lblJumlah_tanggungan.TabIndex = 8;
            lblJumlah_tanggungan.Text = "Jumlah tanggungan";
            // 
            // lblPendapatan
            // 
            lblPendapatan.AutoSize = true;
            lblPendapatan.Location = new Point(456, 134);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(105, 25);
            lblPendapatan.TabIndex = 7;
            lblPendapatan.Text = "Pendapatan";
            // 
            // lblPekerjaan
            // 
            lblPekerjaan.AutoSize = true;
            lblPekerjaan.Location = new Point(456, 84);
            lblPekerjaan.Name = "lblPekerjaan";
            lblPekerjaan.Size = new Size(86, 25);
            lblPekerjaan.TabIndex = 6;
            lblPekerjaan.Text = "Pekerjaan";
            // 
            // lblPendidikan_terakhir
            // 
            lblPendidikan_terakhir.AutoSize = true;
            lblPendidikan_terakhir.Location = new Point(456, 28);
            lblPendidikan_terakhir.Name = "lblPendidikan_terakhir";
            lblPendidikan_terakhir.Size = new Size(163, 25);
            lblPendidikan_terakhir.TabIndex = 5;
            lblPendidikan_terakhir.Text = "Pendidikan Terakhir";
            lblPendidikan_terakhir.Click += lblPendidikan_terakhir_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(25, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblTTL
            // 
            lblTTL.AutoSize = true;
            lblTTL.Location = new Point(25, 181);
            lblTTL.Name = "lblTTL";
            lblTTL.Size = new Size(38, 25);
            lblTTL.TabIndex = 3;
            lblTTL.Text = "TTL";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(25, 131);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender";
            // 
            // lblNama_lengkap
            // 
            lblNama_lengkap.AutoSize = true;
            lblNama_lengkap.Location = new Point(25, 78);
            lblNama_lengkap.Name = "lblNama_lengkap";
            lblNama_lengkap.Size = new Size(131, 25);
            lblNama_lengkap.TabIndex = 1;
            lblNama_lengkap.Text = "Nama Lengkap";
            // 
            // FormPekerjaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 1050);
            Controls.Add(panelstatistikringkas_pekerjaan);
            Controls.Add(lblJudulPendataanPekerjaan);
            Controls.Add(paneloutput_pekerjaan);
            Controls.Add(panelinput_pekerjaan);
            Name = "FormPekerjaan";
            Text = "FormPekerjaan";
            Load += FormPekerjaan_Load;
            panelstatistikringkas_pekerjaan.ResumeLayout(false);
            panelstatistikringkas_pekerjaan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).EndInit();
            paneloutput_pekerjaan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).EndInit();
            panelinput_pekerjaan.ResumeLayout(false);
            panelinput_pekerjaan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNik;
        private Panel panelstatistikringkas_pekerjaan;
        private PictureBox pictureDataBaru;
        private PictureBox pictureTotalKK;
        private Label angkadata;
        private Label lblAngkatotal;
        private Label data_baru;
        private Label lblTotal_pekerja;
        private Label lblStatistik_ringkas;
        private Label lblJudulPendataanPekerjaan;
        private DateTimePicker dateTimePicker1;
        private Panel paneloutput_pekerjaan;
        private DataGridView dgvDataKK;
        private Button btnReset;
        private Button btnHapus;
        private Button btnUbah;
        private Panel panelinput_pekerjaan;
        private TextBox txtKabupaten_kota;
        private TextBox txtDesa_kelurahan;
        private TextBox txtKecamatan;
        private Button btnTambah;
        private TextBox txtRT;
        private TextBox txtNama_kepala_keluarga;
        private TextBox txtNik;
        private Label lblPendapatan;
        private Label lblPekerjaan;
        private Label lblPendidikan_terakhir;
        private Label lblStatus;
        private Label lblTTL;
        private Label lblGender;
        private Label lblNama_lengkap;
        private TextBox txtJumlah_tanggungan;
        private Label lblJumlah_tanggungan;
        private PictureBox pictureBox1;
        private Label angkaRata2;
        private Label lblRata2_pendapatan;
        private DataGridViewTextBoxColumn colId_pekerja;
        private DataGridViewTextBoxColumn colNama_Lengkap;
        private DataGridViewTextBoxColumn colTTL;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colPendidikan_terakhir;
        private DataGridViewTextBoxColumn colPekerjaan;
        private DataGridViewTextBoxColumn colPendapatan;
        private DataGridViewTextBoxColumn colJumlah_tanggungan;
        private DataGridViewTextBoxColumn colnik;
        private Panel panel1;
        private ComboBox cmbStatus;
        private TextBox cmbJumlah_Tanggungann;
        private TextBox txtPendapatann;
        private TextBox cmbPekerjaann;
        private TextBox txtPendidikan_Terakhirr;
        private Button btnTambahh;
        private TextBox txtTtll;
        private TextBox txtNama_Lengkap;
        private TextBox txtNo_nik;
        private Label lblJumlah_Tanggungann;
        private Label lblPendapatann;
        private Label lblPekerjaann;
        private Label lblPendidikan_Terakhirr;
        private Label lblStatuss;
        private Label lblTtll;
        private Label label7;
        private Label label8;
        private Label lblNo_nik;
        private ComboBox comboBox1;
        private ComboBox cmbGender;
    }
}