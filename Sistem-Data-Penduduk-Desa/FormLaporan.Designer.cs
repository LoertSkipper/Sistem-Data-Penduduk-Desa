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
            label2 = new Label();
            label1 = new Label();
            laporan = new Panel();
            cbxRw = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbxPekerjaan = new ComboBox();
            tbxnama = new TextBox();
            btnFilter = new Button();
            btnReset = new Button();
            dataGridView1 = new DataGridView();
            NIK = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            jns_kelamin = new DataGridViewTextBoxColumn();
            pekerjaan = new DataGridViewTextBoxColumn();
            pendidikan = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            laporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
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
            panel3.Size = new Size(972, 508);
            panel3.TabIndex = 2;
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
            laporan.Size = new Size(972, 79);
            laporan.TabIndex = 1;
            // 
            // cbxRw
            // 
            cbxRw.FormattingEnabled = true;
            cbxRw.Location = new Point(130, 24);
            cbxRw.Name = "cbxRw";
            cbxRw.Size = new Size(149, 33);
            cbxRw.TabIndex = 2;
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
            // cbxPekerjaan
            // 
            cbxPekerjaan.FormattingEnabled = true;
            cbxPekerjaan.Location = new Point(456, 24);
            cbxPekerjaan.Name = "cbxPekerjaan";
            cbxPekerjaan.Size = new Size(149, 33);
            cbxPekerjaan.TabIndex = 5;
            // 
            // tbxnama
            // 
            tbxnama.Location = new Point(753, 24);
            tbxnama.Name = "tbxnama";
            tbxnama.Size = new Size(145, 31);
            tbxnama.TabIndex = 6;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NIK, Nama, jns_kelamin, pekerjaan, pendidikan });
            dataGridView1.Location = new Point(61, 201);
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
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 587);
            Controls.Add(panel3);
            Controls.Add(laporan);
            Name = "FormLaporan";
            Text = "FormLaporan";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            laporan.ResumeLayout(false);
            laporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}