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
            lblJudulPekerjaan = new Label();
            panelinputPekerjaan = new Panel();
            btnTambah = new Button();
            lblPendapatan = new Label();
            lblPekerjaan = new Label();
            lblPendidikan_terakhir = new Label();
            lblStatus = new Label();
            lblTTL = new Label();
            lblGender = new Label();
            lblNama = new Label();
            lblNo_nik = new Label();
            panelinputPekerjaan.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudulPekerjaan
            // 
            lblJudulPekerjaan.AutoSize = true;
            lblJudulPekerjaan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudulPekerjaan.Location = new Point(64, 58);
            lblJudulPekerjaan.Name = "lblJudulPekerjaan";
            lblJudulPekerjaan.Size = new Size(369, 48);
            lblJudulPekerjaan.TabIndex = 1;
            lblJudulPekerjaan.Text = "Pendataan Pekerjaan";
            // 
            // panelinputPekerjaan
            // 
            panelinputPekerjaan.BorderStyle = BorderStyle.FixedSingle;
            panelinputPekerjaan.Controls.Add(btnTambah);
            panelinputPekerjaan.Controls.Add(lblPendapatan);
            panelinputPekerjaan.Controls.Add(lblPekerjaan);
            panelinputPekerjaan.Controls.Add(lblPendidikan_terakhir);
            panelinputPekerjaan.Controls.Add(lblStatus);
            panelinputPekerjaan.Controls.Add(lblTTL);
            panelinputPekerjaan.Controls.Add(lblGender);
            panelinputPekerjaan.Controls.Add(lblNama);
            panelinputPekerjaan.Controls.Add(lblNo_nik);
            panelinputPekerjaan.Location = new Point(64, 161);
            panelinputPekerjaan.Name = "panelinputPekerjaan";
            panelinputPekerjaan.Size = new Size(1110, 355);
            panelinputPekerjaan.TabIndex = 2;
            panelinputPekerjaan.Paint += panelinputPekerjaan_Paint;
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
            lblPendidikan_terakhir.Size = new Size(162, 25);
            lblPendidikan_terakhir.TabIndex = 5;
            lblPendidikan_terakhir.Text = "Pendidikan terakhir";
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
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(35, 78);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(131, 25);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Lengkap";
            // 
            // lblNo_nik
            // 
            lblNo_nik.AutoSize = true;
            lblNo_nik.Location = new Point(35, 28);
            lblNo_nik.Name = "lblNo_nik";
            lblNo_nik.Size = new Size(38, 25);
            lblNo_nik.TabIndex = 0;
            lblNo_nik.Text = "Nik";
            // 
            // FormPekerjaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 1050);
            Controls.Add(lblJudulPekerjaan);
            Controls.Add(panelinputPekerjaan);
            Name = "FormPekerjaan";
            Text = "FormPekerjaan";
            Load += FormPekerjaan_Load;
            panelinputPekerjaan.ResumeLayout(false);
            panelinputPekerjaan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudulPekerjaan;
        private Panel panelinputPekerjaan;
        private Button btnTambah;
        private Label lblPendapatan;
        private Label lblPekerjaan;
        private Label lblPendidikan_terakhir;
        private Label lblStatus;
        private Label lblTTL;
        private Label lblGender;
        private Label lblNama;
        private Label lblNo_nik;
    }
}