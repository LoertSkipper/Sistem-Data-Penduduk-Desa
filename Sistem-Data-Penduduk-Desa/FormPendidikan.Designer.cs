namespace Sistem_Data_Penduduk_Desa
{
    partial class FormPendidikan
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
            panel1 = new Panel();
            id_pendidikan_txt = new TextBox();
            jenjang_txt = new TextBox();
            tambah_btn = new Button();
            hapus_btn = new Button();
            edit_btn = new Button();
            reset_btn = new Button();
            dataGridView1 = new DataGridView();
            id_pendidikan = new DataGridViewTextBoxColumn();
            jenjang = new DataGridViewTextBoxColumn();
            cari_txt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "FORM PENDIDIKAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 134);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "ID Pendidikan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 201);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Jenjang:";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(45, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 89);
            panel1.TabIndex = 3;
            // 
            // id_pendidikan_txt
            // 
            id_pendidikan_txt.BackColor = SystemColors.ControlLight;
            id_pendidikan_txt.Location = new Point(238, 131);
            id_pendidikan_txt.Name = "id_pendidikan_txt";
            id_pendidikan_txt.Size = new Size(583, 31);
            id_pendidikan_txt.TabIndex = 4;
            // 
            // jenjang_txt
            // 
            jenjang_txt.BackColor = SystemColors.ControlLight;
            jenjang_txt.Location = new Point(238, 195);
            jenjang_txt.Name = "jenjang_txt";
            jenjang_txt.Size = new Size(583, 31);
            jenjang_txt.TabIndex = 5;
            jenjang_txt.TextChanged += jenjang_txt_TextChanged;
            // 
            // tambah_btn
            // 
            tambah_btn.BackColor = SystemColors.ActiveCaption;
            tambah_btn.Location = new Point(45, 277);
            tambah_btn.Name = "tambah_btn";
            tambah_btn.Size = new Size(125, 46);
            tambah_btn.TabIndex = 6;
            tambah_btn.Text = "+ Tambah";
            tambah_btn.UseVisualStyleBackColor = false;
            // 
            // hapus_btn
            // 
            hapus_btn.BackColor = SystemColors.ActiveCaption;
            hapus_btn.Location = new Point(252, 279);
            hapus_btn.Name = "hapus_btn";
            hapus_btn.Size = new Size(127, 44);
            hapus_btn.TabIndex = 7;
            hapus_btn.Text = "Hapus";
            hapus_btn.UseVisualStyleBackColor = false;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = SystemColors.ActiveCaption;
            edit_btn.Location = new Point(480, 279);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(121, 44);
            edit_btn.TabIndex = 8;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = SystemColors.ActiveCaption;
            reset_btn.Location = new Point(697, 276);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(124, 47);
            reset_btn.TabIndex = 9;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_pendidikan, jenjang });
            dataGridView1.Location = new Point(63, 413);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(758, 177);
            dataGridView1.TabIndex = 10;
            // 
            // id_pendidikan
            // 
            id_pendidikan.HeaderText = "ID Pendidikan";
            id_pendidikan.MinimumWidth = 8;
            id_pendidikan.Name = "id_pendidikan";
            id_pendidikan.Width = 150;
            // 
            // jenjang
            // 
            jenjang.HeaderText = "Jenjang";
            jenjang.MinimumWidth = 8;
            jenjang.Name = "jenjang";
            jenjang.Width = 150;
            // 
            // cari_txt
            // 
            cari_txt.BackColor = SystemColors.ControlLight;
            cari_txt.Location = new Point(61, 374);
            cari_txt.Name = "cari_txt";
            cari_txt.Size = new Size(150, 31);
            cari_txt.TabIndex = 11;
            cari_txt.Text = "Cari";
            // 
            // FormPendidikan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 627);
            Controls.Add(cari_txt);
            Controls.Add(dataGridView1);
            Controls.Add(reset_btn);
            Controls.Add(edit_btn);
            Controls.Add(hapus_btn);
            Controls.Add(tambah_btn);
            Controls.Add(jenjang_txt);
            Controls.Add(id_pendidikan_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormPendidikan";
            Text = "FormPendidikan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox id_pendidikan_txt;
        private TextBox jenjang_txt;
        private Button tambah_btn;
        private Button hapus_btn;
        private Button edit_btn;
        private Button reset_btn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_pendidikan;
        private DataGridViewTextBoxColumn jenjang;
        private TextBox cari_txt;
    }
}