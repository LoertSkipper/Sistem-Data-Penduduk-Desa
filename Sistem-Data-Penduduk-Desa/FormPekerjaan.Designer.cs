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
            panelstatistikringkas_pekerjaan = new Panel();
            pictureBox1 = new PictureBox();
            angkaRata2 = new Label();
            lblRata2_pendapatan = new Label();
            pictureTotalKK = new PictureBox();
            lblAngkatotal = new Label();
            lblTotal_pekerja = new Label();
            lblStatistik_ringkas = new Label();
            paneloutput_pekerjaan = new Panel();
            txtCari = new TextBox();
            lblCari = new Label();
            dgvDataPekerjaan = new DataGridView();
            btnReset = new Button();
            btnHapus = new Button();
            btnUbah = new Button();
            lblJudulPendataanPekerjaan = new Label();
            panelinput = new Panel();
            txtJumlah_Tanggungann = new TextBox();
            txtPendapatan = new TextBox();
            btnTambahh = new Button();
            txtNama_pekerjaan = new TextBox();
            lblJumlah_Tanggungann = new Label();
            lblPendapatan = new Label();
            lblNama_pekerjaan = new Label();
            panelstatistikringkas_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).BeginInit();
            paneloutput_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataPekerjaan).BeginInit();
            panelinput.SuspendLayout();
            SuspendLayout();
            // 
            // panelstatistikringkas_pekerjaan
            // 
            panelstatistikringkas_pekerjaan.BackColor = Color.White;
            panelstatistikringkas_pekerjaan.Controls.Add(pictureBox1);
            panelstatistikringkas_pekerjaan.Controls.Add(angkaRata2);
            panelstatistikringkas_pekerjaan.Controls.Add(lblRata2_pendapatan);
            panelstatistikringkas_pekerjaan.Controls.Add(pictureTotalKK);
            panelstatistikringkas_pekerjaan.Controls.Add(lblAngkatotal);
            panelstatistikringkas_pekerjaan.Controls.Add(lblTotal_pekerja);
            panelstatistikringkas_pekerjaan.Controls.Add(lblStatistik_ringkas);
            panelstatistikringkas_pekerjaan.Location = new Point(613, 91);
            panelstatistikringkas_pekerjaan.Name = "panelstatistikringkas_pekerjaan";
            panelstatistikringkas_pekerjaan.Size = new Size(606, 355);
            panelstatistikringkas_pekerjaan.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(401, 107);
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
            angkaRata2.Location = new Point(431, 275);
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
            lblRata2_pendapatan.Location = new Point(365, 227);
            lblRata2_pendapatan.Name = "lblRata2_pendapatan";
            lblRata2_pendapatan.Size = new Size(176, 25);
            lblRata2_pendapatan.TabIndex = 6;
            lblRata2_pendapatan.Text = "RATA\" PENDAPATAN";
            // 
            // pictureTotalKK
            // 
            pictureTotalKK.Image = (Image)resources.GetObject("pictureTotalKK.Image");
            pictureTotalKK.Location = new Point(83, 107);
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
            lblAngkatotal.Location = new Point(113, 275);
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
            lblTotal_pekerja.Location = new Point(69, 227);
            lblTotal_pekerja.Name = "lblTotal_pekerja";
            lblTotal_pekerja.Size = new Size(134, 25);
            lblTotal_pekerja.TabIndex = 1;
            lblTotal_pekerja.Text = "TOTAL PEKERJA";
            // 
            // lblStatistik_ringkas
            // 
            lblStatistik_ringkas.AutoSize = true;
            lblStatistik_ringkas.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblStatistik_ringkas.Location = new Point(219, 29);
            lblStatistik_ringkas.Name = "lblStatistik_ringkas";
            lblStatistik_ringkas.Size = new Size(175, 32);
            lblStatistik_ringkas.TabIndex = 0;
            lblStatistik_ringkas.Text = "statistik ringkas";
            // 
            // paneloutput_pekerjaan
            // 
            paneloutput_pekerjaan.BorderStyle = BorderStyle.FixedSingle;
            paneloutput_pekerjaan.Controls.Add(txtCari);
            paneloutput_pekerjaan.Controls.Add(lblCari);
            paneloutput_pekerjaan.Controls.Add(dgvDataPekerjaan);
            paneloutput_pekerjaan.Location = new Point(20, 492);
            paneloutput_pekerjaan.Name = "paneloutput_pekerjaan";
            paneloutput_pekerjaan.Size = new Size(1283, 341);
            paneloutput_pekerjaan.TabIndex = 5;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(94, 22);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(239, 31);
            txtCari.TabIndex = 23;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // lblCari
            // 
            lblCari.AutoSize = true;
            lblCari.Location = new Point(29, 25);
            lblCari.Name = "lblCari";
            lblCari.Size = new Size(51, 25);
            lblCari.TabIndex = 22;
            lblCari.Text = "CARI";
            // 
            // dgvDataPekerjaan
            // 
            dgvDataPekerjaan.BackgroundColor = Color.White;
            dgvDataPekerjaan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPekerjaan.Location = new Point(94, 76);
            dgvDataPekerjaan.Name = "dgvDataPekerjaan";
            dgvDataPekerjaan.RowHeadersWidth = 62;
            dgvDataPekerjaan.Size = new Size(1081, 212);
            dgvDataPekerjaan.TabIndex = 21;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1188, 866);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(1060, 866);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 19;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(933, 866);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(112, 34);
            btnUbah.TabIndex = 18;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click;
            // 
            // lblJudulPendataanPekerjaan
            // 
            lblJudulPendataanPekerjaan.AutoSize = true;
            lblJudulPendataanPekerjaan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudulPendataanPekerjaan.Location = new Point(476, 22);
            lblJudulPendataanPekerjaan.Name = "lblJudulPendataanPekerjaan";
            lblJudulPendataanPekerjaan.Size = new Size(369, 48);
            lblJudulPendataanPekerjaan.TabIndex = 3;
            lblJudulPendataanPekerjaan.Text = "Pendataan Pekerjaan";
            // 
            // panelinput
            // 
            panelinput.BorderStyle = BorderStyle.FixedSingle;
            panelinput.Controls.Add(txtJumlah_Tanggungann);
            panelinput.Controls.Add(txtPendapatan);
            panelinput.Controls.Add(btnTambahh);
            panelinput.Controls.Add(txtNama_pekerjaan);
            panelinput.Controls.Add(lblJumlah_Tanggungann);
            panelinput.Controls.Add(lblPendapatan);
            panelinput.Controls.Add(lblNama_pekerjaan);
            panelinput.Location = new Point(93, 91);
            panelinput.Name = "panelinput";
            panelinput.Size = new Size(497, 355);
            panelinput.TabIndex = 21;
            // 
            // txtJumlah_Tanggungann
            // 
            txtJumlah_Tanggungann.Location = new Point(211, 151);
            txtJumlah_Tanggungann.Name = "txtJumlah_Tanggungann";
            txtJumlah_Tanggungann.Size = new Size(239, 31);
            txtJumlah_Tanggungann.TabIndex = 17;
            txtJumlah_Tanggungann.TextChanged += txtJumlah_Tanggungann_TextChanged;
            // 
            // txtPendapatan
            // 
            txtPendapatan.Location = new Point(211, 96);
            txtPendapatan.Name = "txtPendapatan";
            txtPendapatan.Size = new Size(239, 31);
            txtPendapatan.TabIndex = 16;
            txtPendapatan.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTambahh
            // 
            btnTambahh.Location = new Point(338, 274);
            btnTambahh.Name = "btnTambahh";
            btnTambahh.Size = new Size(112, 34);
            btnTambahh.TabIndex = 2;
            btnTambahh.Text = "Tambah";
            btnTambahh.UseVisualStyleBackColor = true;
            // 
            // txtNama_pekerjaan
            // 
            txtNama_pekerjaan.Location = new Point(211, 40);
            txtNama_pekerjaan.Name = "txtNama_pekerjaan";
            txtNama_pekerjaan.Size = new Size(239, 31);
            txtNama_pekerjaan.TabIndex = 9;
            // 
            // lblJumlah_Tanggungann
            // 
            lblJumlah_Tanggungann.AutoSize = true;
            lblJumlah_Tanggungann.Location = new Point(33, 151);
            lblJumlah_Tanggungann.Name = "lblJumlah_Tanggungann";
            lblJumlah_Tanggungann.Size = new Size(170, 25);
            lblJumlah_Tanggungann.TabIndex = 8;
            lblJumlah_Tanggungann.Text = "Jumlah Tanggungan";
            // 
            // lblPendapatan
            // 
            lblPendapatan.AutoSize = true;
            lblPendapatan.Location = new Point(33, 96);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(105, 25);
            lblPendapatan.TabIndex = 7;
            lblPendapatan.Text = "Pendapatan";
            // 
            // lblNama_pekerjaan
            // 
            lblNama_pekerjaan.AutoSize = true;
            lblNama_pekerjaan.Location = new Point(33, 40);
            lblNama_pekerjaan.Name = "lblNama_pekerjaan";
            lblNama_pekerjaan.Size = new Size(138, 25);
            lblNama_pekerjaan.TabIndex = 0;
            lblNama_pekerjaan.Text = "Nama Pekerjaan";
            // 
            // FormPekerjaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1377, 1050);
            Controls.Add(panelinput);
            Controls.Add(panelstatistikringkas_pekerjaan);
            Controls.Add(lblJudulPendataanPekerjaan);
            Controls.Add(paneloutput_pekerjaan);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Name = "FormPekerjaan";
            Text = "FormPekerjaan";
            panelstatistikringkas_pekerjaan.ResumeLayout(false);
            panelstatistikringkas_pekerjaan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).EndInit();
            paneloutput_pekerjaan.ResumeLayout(false);
            paneloutput_pekerjaan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataPekerjaan).EndInit();
            panelinput.ResumeLayout(false);
            panelinput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelstatistikringkas_pekerjaan;
        private PictureBox pictureDataBaru;
        private PictureBox pictureTotalKK;
        private Label angkadata;
        private Label lblAngkatotal;
        private Label data_baru;
        private Label lblTotal_pekerja;
        private Label lblStatistik_ringkas;
        private Panel paneloutput_pekerjaan;
        private DataGridView dgvDataPekerjaan;
        private Button btnReset;
        private Button btnHapus;
        private Button btnUbah;
        private PictureBox pictureBox1;
        private Label angkaRata2;
        private Label lblRata2_pendapatan;
        private TextBox txtCari;
        private Label lblCari;
        private Label lblJudulPendataanPekerjaan;
        private Panel panelinput;
        private TextBox txtJumlah_Tanggungann;
        private TextBox txtPendapatan;
        private Button btnTambahh;
        private TextBox txtNama_pekerjaan;
        private Label lblJumlah_Tanggungann;
        private Label lblPendapatan;
        private Label lblNama_pekerjaan;
    }
}