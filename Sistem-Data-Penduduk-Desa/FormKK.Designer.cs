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
            panelinput = new Panel();
            paneloutput = new Panel();
            label1 = new Label();
            txtNo_kk = new Label();
            txtNama = new Label();
            txtRT = new Label();
            txtAlamat = new Label();
            txtKecamatan = new Label();
            txtRW = new Label();
            ttxtKabuapaten = new Label();
            txtDesa_kelurahan = new Label();
            panelinput.SuspendLayout();
            SuspendLayout();
            // 
            // panelinput
            // 
            panelinput.BorderStyle = BorderStyle.FixedSingle;
            panelinput.Controls.Add(ttxtKabuapaten);
            panelinput.Controls.Add(txtDesa_kelurahan);
            panelinput.Controls.Add(txtKecamatan);
            panelinput.Controls.Add(txtRW);
            panelinput.Controls.Add(txtRT);
            panelinput.Controls.Add(txtAlamat);
            panelinput.Controls.Add(txtNama);
            panelinput.Controls.Add(txtNo_kk);
            panelinput.Location = new Point(13, 91);
            panelinput.Name = "panelinput";
            panelinput.Size = new Size(577, 508);
            panelinput.TabIndex = 0;
            panelinput.Paint += panel1_Paint;
            // 
            // paneloutput
            // 
            paneloutput.BorderStyle = BorderStyle.FixedSingle;
            paneloutput.Location = new Point(612, 91);
            paneloutput.Name = "paneloutput";
            paneloutput.Size = new Size(584, 508);
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
            // txtNo_kk
            // 
            txtNo_kk.AutoSize = true;
            txtNo_kk.Location = new Point(38, 41);
            txtNo_kk.Name = "txtNo_kk";
            txtNo_kk.Size = new Size(159, 25);
            txtNo_kk.TabIndex = 0;
            txtNo_kk.Text = "No. Kartu Keluarga";
            // 
            // txtNama
            // 
            txtNama.AutoSize = true;
            txtNama.Location = new Point(38, 91);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(189, 25);
            txtNama.TabIndex = 1;
            txtNama.Text = "Nama Kepala Keluarga";
            // 
            // txtRT
            // 
            txtRT.AutoSize = true;
            txtRT.Location = new Point(38, 194);
            txtRT.Name = "txtRT";
            txtRT.Size = new Size(31, 25);
            txtRT.TabIndex = 3;
            txtRT.Text = "RT";
            txtRT.Click += label2_Click_1;
            // 
            // txtAlamat
            // 
            txtAlamat.AutoSize = true;
            txtAlamat.Location = new Point(38, 144);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(68, 25);
            txtAlamat.TabIndex = 2;
            txtAlamat.Text = "Alamat";
            // 
            // txtKecamatan
            // 
            txtKecamatan.AutoSize = true;
            txtKecamatan.Location = new Point(38, 303);
            txtKecamatan.Name = "txtKecamatan";
            txtKecamatan.Size = new Size(98, 25);
            txtKecamatan.TabIndex = 5;
            txtKecamatan.Text = "Kecamatan";
            // 
            // txtRW
            // 
            txtRW.AutoSize = true;
            txtRW.Location = new Point(38, 253);
            txtRW.Name = "txtRW";
            txtRW.Size = new Size(40, 25);
            txtRW.TabIndex = 4;
            txtRW.Text = "RW";
            // 
            // ttxtKabuapaten
            // 
            ttxtKabuapaten.AutoSize = true;
            ttxtKabuapaten.Location = new Point(38, 409);
            ttxtKabuapaten.Name = "ttxtKabuapaten";
            ttxtKabuapaten.Size = new Size(97, 25);
            ttxtKabuapaten.TabIndex = 7;
            ttxtKabuapaten.Text = "Kabupaten";
            // 
            // txtDesa_kelurahan
            // 
            txtDesa_kelurahan.AutoSize = true;
            txtDesa_kelurahan.Location = new Point(38, 359);
            txtDesa_kelurahan.Name = "txtDesa_kelurahan";
            txtDesa_kelurahan.Size = new Size(51, 25);
            txtDesa_kelurahan.TabIndex = 6;
            txtDesa_kelurahan.Text = "Desa";
            // 
            // FormKK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 611);
            Controls.Add(label1);
            Controls.Add(paneloutput);
            Controls.Add(panelinput);
            Name = "FormKK";
            Text = "FormKK";
            panelinput.ResumeLayout(false);
            panelinput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelinput;
        private Panel paneloutput;
        private Label label1;
        private Label txtNama;
        private Label txtNo_kk;
        private Label txtRT;
        private Label txtAlamat;
        private Label ttxtKabuapaten;
        private Label txtDesa_kelurahan;
        private Label txtKecamatan;
        private Label txtRW;
    }
}