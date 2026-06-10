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
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblTotalPenduduk = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            tbxcari = new TextBox();
            btncari = new Button();
            statistika.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // statistika
            // 
            statistika.BackColor = SystemColors.ActiveCaption;
            statistika.Controls.Add(btncari);
            statistika.Controls.Add(tbxcari);
            statistika.Controls.Add(label8);
            statistika.Dock = DockStyle.Top;
            statistika.Location = new Point(0, 0);
            statistika.Name = "statistika";
            statistika.Size = new Size(1174, 130);
            statistika.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(736, 34);
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(477, 34);
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalPenduduk);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(222, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 80);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Total penduduk";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(1174, 653);
            panel4.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 41);
            label8.Name = "label8";
            label8.Size = new Size(420, 38);
            label8.TabIndex = 4;
            label8.Text = "Statistika Data Penduduk Desa";
            // 
            // tbxcari
            // 
            tbxcari.Location = new Point(766, 49);
            tbxcari.Name = "tbxcari";
            tbxcari.Size = new Size(253, 31);
            tbxcari.TabIndex = 5;
            // 
            // btncari
            // 
            btncari.Location = new Point(1050, 47);
            btncari.Name = "btncari";
            btncari.Size = new Size(82, 34);
            btncari.TabIndex = 6;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = true;
            // 
            // FormStatistik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 783);
            Controls.Add(panel4);
            Controls.Add(statistika);
            Name = "FormStatistik";
            Text = "FormStatistik";
            statistika.ResumeLayout(false);
            statistika.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
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
        private Label label8;
        private Button btncari;
        private TextBox tbxcari;
    }
}