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
            No_kk = new Label();
            Nama_kepala_keluarga = new Label();
            RT = new Label();
            Alamat = new Label();
            Kecamatan = new Label();
            RW = new Label();
            Kabupaten = new Label();
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            panelinput.SuspendLayout();
            paneloutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).BeginInit();
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
            panelinput.Controls.Add(Kabupaten);
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
            paneloutput.Controls.Add(dgvDataKK);
            paneloutput.Controls.Add(button4);
            paneloutput.Controls.Add(button3);
            paneloutput.Controls.Add(button2);
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
            // Kabupaten
            // 
            Kabupaten.AutoSize = true;
            Kabupaten.Location = new Point(573, 134);
            Kabupaten.Name = "Kabupaten";
            Kabupaten.Size = new Size(97, 25);
            Kabupaten.TabIndex = 7;
            Kabupaten.Text = "Kabupaten";
            // 
            // Desa_kelurahan
            // 
            Desa_kelurahan.AutoSize = true;
            Desa_kelurahan.Location = new Point(573, 84);
            Desa_kelurahan.Name = "Desa_kelurahan";
            Desa_kelurahan.Size = new Size(51, 25);
            Desa_kelurahan.TabIndex = 6;
            Desa_kelurahan.Text = "Desa";
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
            // button2
            // 
            button2.Location = new Point(699, 482);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 18;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(826, 482);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 19;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(954, 482);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 20;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvDataKK
            // 
            dgvDataKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataKK.Columns.AddRange(new DataGridViewColumn[] { colId_kk, colNo_kk, colNama_kepala_keluarga, colAlamat, colRT, colRW, colKecamatan, colDesa_kelurahan, colKabupaten, colProvinsi });
            dgvDataKK.Location = new Point(36, 42);
            dgvDataKK.Name = "dgvDataKK";
            dgvDataKK.RowHeadersWidth = 62;
            dgvDataKK.Size = new Size(1512, 225);
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
            colNo_kk.Width = 150;
            // 
            // colNama_kepala_keluarga
            // 
            colNama_kepala_keluarga.HeaderText = "Nama Kepala Keluarga";
            colNama_kepala_keluarga.MinimumWidth = 8;
            colNama_kepala_keluarga.Name = "colNama_kepala_keluarga";
            colNama_kepala_keluarga.Width = 150;
            // 
            // colAlamat
            // 
            colAlamat.HeaderText = "Alamat";
            colAlamat.MinimumWidth = 8;
            colAlamat.Name = "colAlamat";
            colAlamat.Width = 150;
            // 
            // colRT
            // 
            colRT.HeaderText = "RT";
            colRT.MinimumWidth = 8;
            colRT.Name = "colRT";
            colRT.Width = 150;
            // 
            // colRW
            // 
            colRW.HeaderText = "RW";
            colRW.MinimumWidth = 8;
            colRW.Name = "colRW";
            colRW.Width = 150;
            // 
            // colKecamatan
            // 
            colKecamatan.HeaderText = "Kecamatan";
            colKecamatan.MinimumWidth = 8;
            colKecamatan.Name = "colKecamatan";
            colKecamatan.Width = 150;
            // 
            // colDesa_kelurahan
            // 
            colDesa_kelurahan.HeaderText = "Desa atau Kelurahan";
            colDesa_kelurahan.MinimumWidth = 8;
            colDesa_kelurahan.Name = "colDesa_kelurahan";
            colDesa_kelurahan.Width = 150;
            // 
            // colKabupaten
            // 
            colKabupaten.HeaderText = "Kabupaten/kota";
            colKabupaten.MinimumWidth = 8;
            colKabupaten.Name = "colKabupaten";
            colKabupaten.Width = 150;
            // 
            // colProvinsi
            // 
            colProvinsi.HeaderText = "Provinsi";
            colProvinsi.MinimumWidth = 8;
            colProvinsi.Name = "colProvinsi";
            colProvinsi.Width = 150;
            // 
            // FormKK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(label1);
            Controls.Add(paneloutput);
            Controls.Add(panelinput);
            Name = "FormKK";
            Text = "FormKK";
            panelinput.ResumeLayout(false);
            panelinput.PerformLayout();
            paneloutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataKK).EndInit();
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
        private Label Kabupaten;
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
        private Button button4;
        private Button button3;
        private Button button2;
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
    }
}