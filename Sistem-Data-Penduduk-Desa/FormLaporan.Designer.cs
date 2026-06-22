namespace Sistem_Data_Penduduk_Desa
{
    partial class FormLaporan
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
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            NIK = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            jns_kelamin = new DataGridViewTextBoxColumn();
            pekerjaan = new DataGridViewTextBoxColumn();
            pendidikan = new DataGridViewTextBoxColumn();
            btnReset = new Button();
            btnFilter = new Button();
            tbxnama = new TextBox();
            cbxPekerjaan = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cbxRw = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            laporan = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            btnexcel = new Button();
            btnpdf = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            laporan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(btnFilter);
            panel3.Controls.Add(tbxnama);
            panel3.Controls.Add(cbxPekerjaan);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cbxRw);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(973, 597);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NIK, Nama, jns_kelamin, pekerjaan, pendidikan });
            dataGridView1.Location = new Point(64, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(815, 295);
            dataGridView1.TabIndex = 9;
            // 
            // NIK
            // 
            NIK.HeaderText = "NIK";
            NIK.MinimumWidth = 8;
            NIK.Name = "NIK";
            NIK.Width = 150;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama Lengkap";
            Nama.MinimumWidth = 8;
            Nama.Name = "Nama";
            Nama.Width = 150;
            // 
            // jns_kelamin
            // 
            jns_kelamin.HeaderText = "Jenis Kelamin";
            jns_kelamin.MinimumWidth = 8;
            jns_kelamin.Name = "jns_kelamin";
            jns_kelamin.Width = 150;
            // 
            // pekerjaan
            // 
            pekerjaan.HeaderText = "Pekerjaan";
            pekerjaan.MinimumWidth = 8;
            pekerjaan.Name = "pekerjaan";
            pekerjaan.Width = 150;
            // 
            // pendidikan
            // 
            pendidikan.HeaderText = "Pendidikan";
            pendidikan.MinimumWidth = 8;
            pendidikan.Name = "pendidikan";
            pendidikan.Width = 150;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ActiveCaption;
            btnReset.Location = new Point(549, 87);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(116, 35);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = SystemColors.ActiveCaption;
            btnFilter.Location = new Point(251, 87);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(116, 35);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // tbxnama
            // 
            tbxnama.Location = new Point(753, 24);
            tbxnama.Name = "tbxnama";
            tbxnama.Size = new Size(145, 31);
            tbxnama.TabIndex = 6;
            // 
            // cbxPekerjaan
            // 
            cbxPekerjaan.FormattingEnabled = true;
            cbxPekerjaan.Location = new Point(456, 24);
            cbxPekerjaan.Name = "cbxPekerjaan";
            cbxPekerjaan.Size = new Size(149, 33);
            cbxPekerjaan.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(308, 27);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 4;
            label4.Text = "Pilih Pekerjaan :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(641, 27);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 3;
            label3.Text = "Cari Nama :";
            // 
            // cbxRw
            // 
            cbxRw.FormattingEnabled = true;
            cbxRw.Location = new Point(130, 24);
            cbxRw.Name = "cbxRw";
            cbxRw.Size = new Size(149, 33);
            cbxRw.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 27);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Pilih RW :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 21);
            label1.Name = "label1";
            label1.Size = new Size(489, 38);
            label1.TabIndex = 0;
            label1.Text = "LAPORAN DATA KEPENDUDUDKAN";
            label1.Click += label1_Click;
            // 
            // laporan
            // 
            laporan.BackColor = SystemColors.ActiveCaption;
            laporan.Controls.Add(label1);
            laporan.Dock = DockStyle.Top;
            laporan.Location = new Point(0, 0);
            laporan.Name = "laporan";
            laporan.Size = new Size(973, 79);
            laporan.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnpdf);
            panel1.Controls.Add(btnexcel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 125);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 36);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 0;
            label5.Text = "Total Data :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 36);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 1;
            label6.Text = "0";
            // 
            // btnexcel
            // 
            btnexcel.BackColor = SystemColors.ActiveCaption;
            btnexcel.Location = new Point(774, 36);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(141, 34);
            btnexcel.TabIndex = 2;
            btnexcel.Text = "Export Excel";
            btnexcel.UseVisualStyleBackColor = false;
            // 
            // btnpdf
            // 
            btnpdf.BackColor = SystemColors.ActiveCaption;
            btnpdf.Location = new Point(604, 36);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(112, 34);
            btnpdf.TabIndex = 3;
            btnpdf.Text = "Cetak PDF";
            btnpdf.UseVisualStyleBackColor = false;
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 676);
            Controls.Add(panel3);
            Controls.Add(laporan);
            Name = "FormLaporan";
            Text = "FormLaporan";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            laporan.ResumeLayout(false);
            laporan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel laporan;
        private ComboBox cbxRw;
        private Label label4;
        private Label label3;
        private TextBox tbxnama;
        private ComboBox cbxPekerjaan;
        private Button btnFilter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NIK;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn jns_kelamin;
        private DataGridViewTextBoxColumn pekerjaan;
        private DataGridViewTextBoxColumn pendidikan;
        private Button btnReset;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Button btnpdf;
        private Button btnexcel;
    }
}