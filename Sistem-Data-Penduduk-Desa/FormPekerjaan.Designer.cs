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
            pictureTotalKK = new PictureBox();
            lblAngkatotal = new Label();
            lblTotal_pekerja = new Label();
            lblStatistik_ringkas = new Label();
            paneloutput_pekerjaan = new Panel();
            btnReset = new Button();
            txtCari = new TextBox();
            lblCari = new Label();
            dgvDataPekerjaan = new DataGridView();
            btnHapus = new Button();
            btnUbah = new Button();
            lblJudulPendataanPekerjaan = new Label();
            panelinput = new Panel();
            btnTambah = new Button();
            txtNama_pekerjaan = new TextBox();
            lblNama_pekerjaan = new Label();
            panelstatistikringkas_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTotalKK).BeginInit();
            paneloutput_pekerjaan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataPekerjaan).BeginInit();
            panelinput.SuspendLayout();
            SuspendLayout();
            // 
            // panelstatistikringkas_pekerjaan
            // 
            panelstatistikringkas_pekerjaan.BackColor = Color.White;
            panelstatistikringkas_pekerjaan.Controls.Add(pictureTotalKK);
            panelstatistikringkas_pekerjaan.Controls.Add(lblAngkatotal);
            panelstatistikringkas_pekerjaan.Controls.Add(lblTotal_pekerja);
            panelstatistikringkas_pekerjaan.Controls.Add(lblStatistik_ringkas);
            panelstatistikringkas_pekerjaan.Location = new Point(613, 91);
            panelstatistikringkas_pekerjaan.Name = "panelstatistikringkas_pekerjaan";
            panelstatistikringkas_pekerjaan.Size = new Size(606, 355);
            panelstatistikringkas_pekerjaan.TabIndex = 6;
            // 
            // pictureTotalKK
            // 
            pictureTotalKK.Image = (Image)resources.GetObject("pictureTotalKK.Image");
            pictureTotalKK.Location = new Point(253, 100);
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
            lblAngkatotal.Location = new Point(283, 268);
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
            lblTotal_pekerja.Location = new Point(239, 220);
            lblTotal_pekerja.Name = "lblTotal_pekerja";
            lblTotal_pekerja.Size = new Size(159, 25);
            lblTotal_pekerja.TabIndex = 1;
            lblTotal_pekerja.Text = "TOTAL PEKERJAAN";
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
            paneloutput_pekerjaan.Controls.Add(btnReset);
            paneloutput_pekerjaan.Controls.Add(txtCari);
            paneloutput_pekerjaan.Controls.Add(lblCari);
            paneloutput_pekerjaan.Controls.Add(dgvDataPekerjaan);
            paneloutput_pekerjaan.Location = new Point(20, 492);
            paneloutput_pekerjaan.Name = "paneloutput_pekerjaan";
            paneloutput_pekerjaan.Size = new Size(1283, 341);
            paneloutput_pekerjaan.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1063, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(94, 22);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(239, 31);
            txtCari.TabIndex = 23;
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
            // btnHapus
            // 
            btnHapus.Location = new Point(216, 274);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 19;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(89, 274);
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
            panelinput.Controls.Add(btnTambah);
            panelinput.Controls.Add(txtNama_pekerjaan);
            panelinput.Controls.Add(lblNama_pekerjaan);
            panelinput.Controls.Add(btnUbah);
            panelinput.Controls.Add(btnHapus);
            panelinput.Location = new Point(93, 91);
            panelinput.Name = "panelinput";
            panelinput.Size = new Size(497, 355);
            panelinput.TabIndex = 21;
            // 
            // btnTambah
            // 
            btnTambah.BackgroundImageLayout = ImageLayout.Center;
            btnTambah.Location = new Point(338, 274);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambahh_Click;
            // 
            // txtNama_pekerjaan
            // 
            txtNama_pekerjaan.Location = new Point(211, 99);
            txtNama_pekerjaan.Name = "txtNama_pekerjaan";
            txtNama_pekerjaan.Size = new Size(239, 31);
            txtNama_pekerjaan.TabIndex = 9;
            // 
            // lblNama_pekerjaan
            // 
            lblNama_pekerjaan.AutoSize = true;
            lblNama_pekerjaan.Location = new Point(33, 99);
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
            Name = "FormPekerjaan";
            Text = "FormPekerjaan";
            panelstatistikringkas_pekerjaan.ResumeLayout(false);
            panelstatistikringkas_pekerjaan.PerformLayout();
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
        private Button btnHapus;
        private Button btnUbah;
        private TextBox txtCari;
        private Label lblCari;
        private Label lblJudulPendataanPekerjaan;
        private Panel panelinput;
        private TextBox txtJumlah_Tanggungann;
        private TextBox txtPendapatan;
        private Button btnTambah;
        private TextBox txtNama_pekerjaan;
        private Label lblJumlah_Tanggungan;
        private Label lblPendapatan;
        private Label lblNama_pekerjaan;
        private Button btnReset;
    }
}