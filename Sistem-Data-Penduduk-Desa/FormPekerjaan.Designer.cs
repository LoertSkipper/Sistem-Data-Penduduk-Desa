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
            btnReset = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            panelinput_pekerjaan = new Panel();
            txtJumlah_tanggungan = new TextBox();
            txtKabupaten_kota = new TextBox();
            txtDesa_kelurahan = new TextBox();
            txtKecamatan = new TextBox();
            btnTambah = new Button();
            txtRW = new TextBox();
            txtRT = new TextBox();
            txtAlamat = new TextBox();
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
            colId_pekerja = new DataGridViewTextBoxColumn();
            colNama_Lengkap = new DataGridViewTextBoxColumn();
            colTTL = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colPendidikan_terakhir = new DataGridViewTextBoxColumn();
            colPekerjaan = new DataGridViewTextBoxColumn();
            colPendapatan = new DataGridViewTextBoxColumn();
            colJumlah_tanggungan = new DataGridViewTextBoxColumn();
            panelstatistikringkas_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).BeginInit();
            paneloutput_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).BeginInit();
            panelinput_pekerjaan.SuspendLayout();
            SuspendLayout();
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
            // panelstatistikringkas_pekerjaan
            // 
            panelstatistikringkas_pekerjaan.Controls.Add(pictureBox1);
            panelstatistikringkas_pekerjaan.Controls.Add(angkaRata2);
            panelstatistikringkas_pekerjaan.Controls.Add(lblRata2_pendapatan);
            panelstatistikringkas_pekerjaan.Controls.Add(pictureTotalKK);
            panelstatistikringkas_pekerjaan.Controls.Add(lblAngkatotal);
            panelstatistikringkas_pekerjaan.Controls.Add(lblTotal_pekerja);
            panelstatistikringkas_pekerjaan.Controls.Add(lblStatistik_ringkas);
            panelstatistikringkas_pekerjaan.Location = new Point(1236, 92);
            panelstatistikringkas_pekerjaan.Name = "panelstatistikringkas_pekerjaan";
            panelstatistikringkas_pekerjaan.Size = new Size(676, 355);
            panelstatistikringkas_pekerjaan.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 121);
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
            angkaRata2.Location = new Point(522, 156);
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
            lblRata2_pendapatan.Location = new Point(456, 108);
            lblRata2_pendapatan.Name = "lblRata2_pendapatan";
            lblRata2_pendapatan.Size = new Size(176, 25);
            lblRata2_pendapatan.TabIndex = 6;
            lblRata2_pendapatan.Text = "RATA\" PENDAPATAN";
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
            // 
            // lblAngkatotal
            // 
            lblAngkatotal.AutoSize = true;
            lblAngkatotal.Font = new Font("Segoe UI", 20F);
            lblAngkatotal.Location = new Point(220, 156);
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
            lblTotal_pekerja.Location = new Point(176, 108);
            lblTotal_pekerja.Name = "lblTotal_pekerja";
            lblTotal_pekerja.Size = new Size(134, 25);
            lblTotal_pekerja.TabIndex = 1;
            lblTotal_pekerja.Text = "TOTAL PEKERJA";
            // 
            // lblStatistik_ringkas
            // 
            lblStatistik_ringkas.AutoSize = true;
            lblStatistik_ringkas.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblStatistik_ringkas.Location = new Point(30, 29);
            lblStatistik_ringkas.Name = "lblStatistik_ringkas";
            lblStatistik_ringkas.Size = new Size(175, 32);
            lblStatistik_ringkas.TabIndex = 0;
            lblStatistik_ringkas.Text = "statistik ringkas";
            // 
            // lblJudulPendataanPekerjaan
            // 
            lblJudulPendataanPekerjaan.AutoSize = true;
            lblJudulPendataanPekerjaan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudulPendataanPekerjaan.Location = new Point(381, 23);
            lblJudulPendataanPekerjaan.Name = "lblJudulPendataanPekerjaan";
            lblJudulPendataanPekerjaan.Size = new Size(369, 48);
            lblJudulPendataanPekerjaan.TabIndex = 3;
            lblJudulPendataanPekerjaan.Text = "Pendataan Pekerjaan";
            lblJudulPendataanPekerjaan.Click += lblJudul_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(810, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // paneloutput_pekerjaan
            // 
            paneloutput_pekerjaan.BorderStyle = BorderStyle.FixedSingle;
            paneloutput_pekerjaan.Controls.Add(dateTimePicker1);
            paneloutput_pekerjaan.Controls.Add(dgvDataKK);
            paneloutput_pekerjaan.Controls.Add(btnReset);
            paneloutput_pekerjaan.Controls.Add(btnHapus);
            paneloutput_pekerjaan.Controls.Add(btnUbah);
            paneloutput_pekerjaan.Location = new Point(12, 485);
            paneloutput_pekerjaan.Name = "paneloutput_pekerjaan";
            paneloutput_pekerjaan.Size = new Size(1900, 544);
            paneloutput_pekerjaan.TabIndex = 5;
            // 
            // dgvDataKK
            // 
            dgvDataKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataKK.Columns.AddRange(new DataGridViewColumn[] { colId_pekerja, colNama_Lengkap, colTTL, colStatus, colPendidikan_terakhir, colPekerjaan, colPendapatan, colJumlah_tanggungan });
            dgvDataKK.Location = new Point(36, 141);
            dgvDataKK.Name = "dgvDataKK";
            dgvDataKK.RowHeadersWidth = 62;
            dgvDataKK.Size = new Size(1429, 319);
            dgvDataKK.TabIndex = 21;
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
            // panelinput_pekerjaan
            // 
            panelinput_pekerjaan.BorderStyle = BorderStyle.FixedSingle;
            panelinput_pekerjaan.Controls.Add(txtJumlah_tanggungan);
            panelinput_pekerjaan.Controls.Add(txtKabupaten_kota);
            panelinput_pekerjaan.Controls.Add(txtDesa_kelurahan);
            panelinput_pekerjaan.Controls.Add(txtKecamatan);
            panelinput_pekerjaan.Controls.Add(btnTambah);
            panelinput_pekerjaan.Controls.Add(txtRW);
            panelinput_pekerjaan.Controls.Add(txtRT);
            panelinput_pekerjaan.Controls.Add(txtAlamat);
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
            panelinput_pekerjaan.Location = new Point(13, 92);
            panelinput_pekerjaan.Name = "panelinput_pekerjaan";
            panelinput_pekerjaan.Size = new Size(1110, 355);
            panelinput_pekerjaan.TabIndex = 4;
            // 
            // txtJumlah_tanggungan
            // 
            txtJumlah_tanggungan.Location = new Point(825, 189);
            txtJumlah_tanggungan.Name = "txtJumlah_tanggungan";
            txtJumlah_tanggungan.Size = new Size(239, 31);
            txtJumlah_tanggungan.TabIndex = 17;
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
            // 
            // txtRW
            // 
            txtRW.Location = new Point(287, 240);
            txtRW.Name = "txtRW";
            txtRW.Size = new Size(239, 31);
            txtRW.TabIndex = 13;
            // 
            // txtRT
            // 
            txtRT.Location = new Point(287, 181);
            txtRT.Name = "txtRT";
            txtRT.Size = new Size(239, 31);
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
            // txtNik
            // 
            txtNik.Location = new Point(287, 28);
            txtNik.Name = "txtNik";
            txtNik.Size = new Size(239, 31);
            txtNik.TabIndex = 9;
            // 
            // lblJumlah_tanggungan
            // 
            lblJumlah_tanggungan.AutoSize = true;
            lblJumlah_tanggungan.Location = new Point(573, 189);
            lblJumlah_tanggungan.Name = "lblJumlah_tanggungan";
            lblJumlah_tanggungan.Size = new Size(169, 25);
            lblJumlah_tanggungan.TabIndex = 8;
            lblJumlah_tanggungan.Text = "Jumlah tanggungan";
            // 
            // lblPendapatan
            // 
            lblPendapatan.AutoSize = true;
            lblPendapatan.Location = new Point(573, 134);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(105, 25);
            lblPendapatan.TabIndex = 7;
            lblPendapatan.Text = "Pendapatan";
            // 
            // lblPekerjaan
            // 
            lblPekerjaan.AutoSize = true;
            lblPekerjaan.Location = new Point(573, 84);
            lblPekerjaan.Name = "lblPekerjaan";
            lblPekerjaan.Size = new Size(86, 25);
            lblPekerjaan.TabIndex = 6;
            lblPekerjaan.Text = "Pekerjaan";
            // 
            // lblPendidikan_terakhir
            // 
            lblPendidikan_terakhir.AutoSize = true;
            lblPendidikan_terakhir.Location = new Point(573, 28);
            lblPendidikan_terakhir.Name = "lblPendidikan_terakhir";
            lblPendidikan_terakhir.Size = new Size(163, 25);
            lblPendidikan_terakhir.TabIndex = 5;
            lblPendidikan_terakhir.Text = "Pendidikan Terakhir";
            lblPendidikan_terakhir.Click += lblPendidikan_terakhir_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(35, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblTTL
            // 
            lblTTL.AutoSize = true;
            lblTTL.Location = new Point(35, 181);
            lblTTL.Name = "lblTTL";
            lblTTL.Size = new Size(38, 25);
            lblTTL.TabIndex = 3;
            lblTTL.Text = "TTL";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(35, 131);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender";
            // 
            // lblNama_lengkap
            // 
            lblNama_lengkap.AutoSize = true;
            lblNama_lengkap.Location = new Point(35, 78);
            lblNama_lengkap.Name = "lblNama_lengkap";
            lblNama_lengkap.Size = new Size(131, 25);
            lblNama_lengkap.TabIndex = 1;
            lblNama_lengkap.Text = "Nama Lengkap";
            // 
            // colId_pekerja
            // 
            colId_pekerja.HeaderText = "ID Pekerja";
            colId_pekerja.MinimumWidth = 8;
            colId_pekerja.Name = "colId_pekerja";
            // 
            // colNama_Lengkap
            // 
            colNama_Lengkap.HeaderText = "Gender";
            colNama_Lengkap.MinimumWidth = 8;
            colNama_Lengkap.Name = "colNama_Lengkap";
            // 
            // colTTL
            // 
            colTTL.HeaderText = "TTL";
            colTTL.MinimumWidth = 8;
            colTTL.Name = "colTTL";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            // 
            // colPendidikan_terakhir
            // 
            colPendidikan_terakhir.HeaderText = "Pendidikan Terakhir";
            colPendidikan_terakhir.MinimumWidth = 8;
            colPendidikan_terakhir.Name = "colPendidikan_terakhir";
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
            colJumlah_tanggungan.Width = 130;
            // 
            // FormPekerjaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
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
        private TextBox txtRW;
        private TextBox txtRT;
        private TextBox txtAlamat;
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
    }
}