namespace Sistem_Data_Penduduk_Desa
{
    partial class FormPenduduk
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            id_penduduk_txt = new TextBox();
            nama_txt = new TextBox();
            nik_txt = new TextBox();
            lk_ck = new CheckBox();
            pr_ck = new CheckBox();
            id_keluarga_txt = new TextBox();
            id_pekerjaan_txt = new TextBox();
            id_pendidikan_txt = new TextBox();
            tambah_btn = new Button();
            Hapus_btn = new Button();
            edit_btn = new Button();
            reset_btn = new Button();
            dataGridView1 = new DataGridView();
            id_penduduk = new DataGridViewTextBoxColumn();
            nik = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            jenis_kelamin = new DataGridViewTextBoxColumn();
            tanggal_lahir = new DataGridViewTextBoxColumn();
            id_kk = new DataGridViewTextBoxColumn();
            id_pekerjaan = new DataGridViewTextBoxColumn();
            id_pendidikan = new DataGridViewTextBoxColumn();
            cari_txt = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 39);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "FORM PENDUDUK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 118);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "ID Penduduk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 172);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "NIK:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 221);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Nama:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 274);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 4;
            label5.Text = "Jenis Kelamin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 326);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 5;
            label6.Text = "Tanggal Lahir:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 386);
            label7.Name = "label7";
            label7.Size = new Size(152, 25);
            label7.TabIndex = 6;
            label7.Text = "ID Kartu keluarga:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 439);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 7;
            label8.Text = "ID Pekerjaan:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 493);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 8;
            label9.Text = "ID Pendidikan:";
            // 
            // id_penduduk_txt
            // 
            id_penduduk_txt.BackColor = SystemColors.ControlLight;
            id_penduduk_txt.Location = new Point(317, 118);
            id_penduduk_txt.Name = "id_penduduk_txt";
            id_penduduk_txt.Size = new Size(1004, 31);
            id_penduduk_txt.TabIndex = 9;
            id_penduduk_txt.TextChanged += id_penduduk_txt_TextChanged;
            // 
            // nama_txt
            // 
            nama_txt.BackColor = SystemColors.ControlLight;
            nama_txt.Location = new Point(317, 215);
            nama_txt.Name = "nama_txt";
            nama_txt.Size = new Size(1004, 31);
            nama_txt.TabIndex = 10;
            // 
            // nik_txt
            // 
            nik_txt.BackColor = SystemColors.ControlLight;
            nik_txt.Location = new Point(317, 166);
            nik_txt.Name = "nik_txt";
            nik_txt.Size = new Size(1004, 31);
            nik_txt.TabIndex = 11;
            nik_txt.TextChanged += nik_txt_TextChanged;
            // 
            // lk_ck
            // 
            lk_ck.AutoSize = true;
            lk_ck.Location = new Point(317, 274);
            lk_ck.Name = "lk_ck";
            lk_ck.Size = new Size(101, 29);
            lk_ck.TabIndex = 12;
            lk_ck.Text = "Laki-laki";
            lk_ck.UseVisualStyleBackColor = true;
            // 
            // pr_ck
            // 
            pr_ck.AutoSize = true;
            pr_ck.Location = new Point(317, 309);
            pr_ck.Name = "pr_ck";
            pr_ck.Size = new Size(127, 29);
            pr_ck.TabIndex = 13;
            pr_ck.Text = "Perempuan";
            pr_ck.UseVisualStyleBackColor = true;
            // 
            // id_keluarga_txt
            // 
            id_keluarga_txt.BackColor = SystemColors.ControlLight;
            id_keluarga_txt.Location = new Point(317, 383);
            id_keluarga_txt.Name = "id_keluarga_txt";
            id_keluarga_txt.Size = new Size(1004, 31);
            id_keluarga_txt.TabIndex = 14;
            // 
            // id_pekerjaan_txt
            // 
            id_pekerjaan_txt.BackColor = SystemColors.ControlLight;
            id_pekerjaan_txt.Location = new Point(317, 433);
            id_pekerjaan_txt.Name = "id_pekerjaan_txt";
            id_pekerjaan_txt.Size = new Size(1004, 31);
            id_pekerjaan_txt.TabIndex = 15;
            id_pekerjaan_txt.TextChanged += id_pekerjaan_txt_TextChanged;
            // 
            // id_pendidikan_txt
            // 
            id_pendidikan_txt.BackColor = SystemColors.ControlLight;
            id_pendidikan_txt.Location = new Point(317, 487);
            id_pendidikan_txt.Name = "id_pendidikan_txt";
            id_pendidikan_txt.Size = new Size(1004, 31);
            id_pendidikan_txt.TabIndex = 16;
            // 
            // tambah_btn
            // 
            tambah_btn.BackColor = SystemColors.ActiveCaption;
            tambah_btn.Location = new Point(53, 569);
            tambah_btn.Name = "tambah_btn";
            tambah_btn.Size = new Size(121, 45);
            tambah_btn.TabIndex = 17;
            tambah_btn.Text = "+ Tambah";
            tambah_btn.UseVisualStyleBackColor = false;
            // 
            // Hapus_btn
            // 
            Hapus_btn.BackColor = SystemColors.ActiveCaption;
            Hapus_btn.Location = new Point(269, 569);
            Hapus_btn.Name = "Hapus_btn";
            Hapus_btn.Size = new Size(121, 45);
            Hapus_btn.TabIndex = 18;
            Hapus_btn.Text = "Hapus";
            Hapus_btn.UseVisualStyleBackColor = false;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = SystemColors.ActiveCaption;
            edit_btn.Location = new Point(488, 569);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(121, 45);
            edit_btn.TabIndex = 19;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = SystemColors.ActiveCaption;
            reset_btn.Location = new Point(713, 569);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(121, 45);
            reset_btn.TabIndex = 20;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_penduduk, nik, nama, jenis_kelamin, tanggal_lahir, id_kk, id_pekerjaan, id_pendidikan });
            dataGridView1.Location = new Point(53, 685);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1268, 225);
            dataGridView1.TabIndex = 21;
            // 
            // id_penduduk
            // 
            id_penduduk.HeaderText = "ID Penduduk";
            id_penduduk.MinimumWidth = 8;
            id_penduduk.Name = "id_penduduk";
            id_penduduk.Width = 150;
            // 
            // nik
            // 
            nik.HeaderText = "NIK";
            nik.MinimumWidth = 8;
            nik.Name = "nik";
            nik.Width = 150;
            // 
            // nama
            // 
            nama.HeaderText = "Nama";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            nama.Width = 150;
            // 
            // jenis_kelamin
            // 
            jenis_kelamin.HeaderText = "Jenis kelamin";
            jenis_kelamin.MinimumWidth = 8;
            jenis_kelamin.Name = "jenis_kelamin";
            jenis_kelamin.Width = 150;
            // 
            // tanggal_lahir
            // 
            tanggal_lahir.HeaderText = "Tanggal Lahir";
            tanggal_lahir.MinimumWidth = 8;
            tanggal_lahir.Name = "tanggal_lahir";
            tanggal_lahir.Width = 150;
            // 
            // id_kk
            // 
            id_kk.HeaderText = "ID KK";
            id_kk.MinimumWidth = 8;
            id_kk.Name = "id_kk";
            id_kk.Width = 150;
            // 
            // id_pekerjaan
            // 
            id_pekerjaan.HeaderText = "ID Pekerjaan";
            id_pekerjaan.MinimumWidth = 8;
            id_pekerjaan.Name = "id_pekerjaan";
            id_pekerjaan.Width = 150;
            // 
            // id_pendidikan
            // 
            id_pendidikan.HeaderText = "ID Pendidikan";
            id_pendidikan.MinimumWidth = 8;
            id_pendidikan.Name = "id_pendidikan";
            id_pendidikan.Width = 150;
            // 
            // cari_txt
            // 
            cari_txt.BackColor = SystemColors.ControlLight;
            cari_txt.Location = new Point(53, 648);
            cari_txt.Name = "cari_txt";
            cari_txt.Size = new Size(252, 31);
            cari_txt.TabIndex = 22;
            cari_txt.Text = "Cari";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(53, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 112);
            panel1.TabIndex = 23;
            // 
            // FormPenduduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 943);
            Controls.Add(cari_txt);
            Controls.Add(dataGridView1);
            Controls.Add(reset_btn);
            Controls.Add(edit_btn);
            Controls.Add(Hapus_btn);
            Controls.Add(tambah_btn);
            Controls.Add(id_pendidikan_txt);
            Controls.Add(id_pekerjaan_txt);
            Controls.Add(id_keluarga_txt);
            Controls.Add(pr_ck);
            Controls.Add(lk_ck);
            Controls.Add(nik_txt);
            Controls.Add(nama_txt);
            Controls.Add(id_penduduk_txt);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormPenduduk";
            Text = "FormPenduduk";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox id_penduduk_txt;
        private TextBox nama_txt;
        private TextBox nik_txt;
        private CheckBox lk_ck;
        private CheckBox pr_ck;
        private TextBox id_keluarga_txt;
        private TextBox id_pekerjaan_txt;
        private TextBox id_pendidikan_txt;
        private Button tambah_btn;
        private Button Hapus_btn;
        private Button edit_btn;
        private Button reset_btn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_penduduk;
        private DataGridViewTextBoxColumn nik;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn jenis_kelamin;
        private DataGridViewTextBoxColumn tanggal_lahir;
        private DataGridViewTextBoxColumn id_kk;
        private DataGridViewTextBoxColumn id_pekerjaan;
        private DataGridViewTextBoxColumn id_pendidikan;
        private TextBox cari_txt;
        private Panel panel1;
    }
}