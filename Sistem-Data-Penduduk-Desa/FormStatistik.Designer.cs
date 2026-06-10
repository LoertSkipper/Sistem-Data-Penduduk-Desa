namespace Sistem_Data_Penduduk_Desa
{
    partial class FormStatistik
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
            statistika = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            lblTotalPenduduk = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            dgvWilayah = new DataGridView();
            panel5 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            dgvUmur = new DataGridView();
            label7 = new Label();
            statistika.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWilayah).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUmur).BeginInit();
            SuspendLayout();
            // 
            // statistika
            // 
            statistika.BackColor = SystemColors.ControlLight;
            statistika.Controls.Add(panel3);
            statistika.Controls.Add(panel2);
            statistika.Controls.Add(panel1);
            statistika.Dock = DockStyle.Top;
            statistika.Location = new Point(0, 0);
            statistika.Name = "statistika";
            statistika.Size = new Size(977, 120);
            statistika.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalPenduduk);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(146, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Total penduduk";
            // 
            // lblTotalPenduduk
            // 
            lblTotalPenduduk.AutoSize = true;
            lblTotalPenduduk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPenduduk.Location = new Point(54, 35);
            lblTotalPenduduk.Name = "lblTotalPenduduk";
            lblTotalPenduduk.Size = new Size(33, 38);
            lblTotalPenduduk.TabIndex = 2;
            lblTotalPenduduk.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(410, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(143, 80);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 35);
            label2.Name = "label2";
            label2.Size = new Size(33, 38);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 6);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 1;
            label3.Text = "Laki - Laki";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(668, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(143, 80);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 35);
            label4.Name = "label4";
            label4.Size = new Size(33, 38);
            label4.TabIndex = 2;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 5);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 1;
            label5.Text = "Perempuan";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(977, 460);
            panel4.TabIndex = 2;
            // 
            // dgvWilayah
            // 
            dgvWilayah.BackgroundColor = Color.LightGray;
            dgvWilayah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWilayah.Location = new Point(30, 114);
            dgvWilayah.Name = "dgvWilayah";
            dgvWilayah.RowHeadersWidth = 62;
            dgvWilayah.Size = new Size(424, 314);
            dgvWilayah.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(dgvWilayah);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(487, 460);
            panel5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.Location = new Point(131, 43);
            label6.Name = "label6";
            label6.Size = new Size(255, 36);
            label6.TabIndex = 1;
            label6.Text = "Statistik Per Wilayah";
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Controls.Add(dgvUmur);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(487, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(490, 460);
            panel6.TabIndex = 1;
            // 
            // dgvUmur
            // 
            dgvUmur.BackgroundColor = Color.LightGray;
            dgvUmur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUmur.Location = new Point(36, 114);
            dgvUmur.Name = "dgvUmur";
            dgvUmur.RowHeadersWidth = 62;
            dgvUmur.Size = new Size(424, 314);
            dgvUmur.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label7.Location = new Point(130, 43);
            label7.Name = "label7";
            label7.Size = new Size(310, 36);
            label7.TabIndex = 2;
            label7.Text = "Statistik Kelompok Umur";
            label7.Click += label7_Click;
            // 
            // FormStatistik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 580);
            Controls.Add(panel4);
            Controls.Add(statistika);
            Name = "FormStatistik";
            Text = "FormStatistik";
            statistika.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWilayah).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUmur).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel statistika;
        private Panel panel1;
        private Label lblTotalPenduduk;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private DataGridView dgvWilayah;
        private Panel panel5;
        private Panel panel6;
        private Label label7;
        private DataGridView dgvUmur;
        private Label label6;
    }
}