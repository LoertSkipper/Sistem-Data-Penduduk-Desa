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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            statistika = new Panel();
            btnTampilkan = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            lblTotalPenduduk = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            statistika.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            SuspendLayout();
            // 
            // statistika
            // 
            statistika.BackColor = Color.FromArgb(31, 73, 125);
            statistika.Controls.Add(btnTampilkan);
            statistika.Controls.Add(comboBox1);
            statistika.Controls.Add(label6);
            statistika.Controls.Add(label8);
            statistika.Controls.Add(panel1);
            statistika.Controls.Add(panel2);
            statistika.Controls.Add(panel3);
            statistika.Dock = DockStyle.Top;
            statistika.Location = new Point(0, 0);
            statistika.Name = "statistika";
            statistika.Size = new Size(1235, 110);
            statistika.TabIndex = 1;
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.FromArgb(41, 182, 246);
            btnTampilkan.FlatAppearance.BorderSize = 0;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.Location = new Point(1165, 70);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(55, 28);
            btnTampilkan.TabIndex = 8;
            btnTampilkan.Text = "Filter";
            btnTampilkan.UseVisualStyleBackColor = false;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1015, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 33);
            comboBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1015, 40);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 6;
            label6.Text = "Pilih RW :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 35);
            label8.Name = "label8";
            label8.Size = new Size(420, 38);
            label8.TabIndex = 4;
            label8.Text = "Statistika Data Penduduk Desa";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalPenduduk);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(480, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 80);
            panel1.TabIndex = 0;
            // 
            // lblTotalPenduduk
            // 
            lblTotalPenduduk.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalPenduduk.ForeColor = Color.FromArgb(31, 73, 125);
            lblTotalPenduduk.Location = new Point(0, 32);
            lblTotalPenduduk.Name = "lblTotalPenduduk";
            lblTotalPenduduk.Size = new Size(160, 44);
            lblTotalPenduduk.TabIndex = 2;
            lblTotalPenduduk.Text = "0";
            lblTotalPenduduk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 5);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 1;
            label1.Text = "Total Penduduk";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(655, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 80);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(0, 32);
            label2.Name = "label2";
            label2.Size = new Size(160, 44);
            label2.TabIndex = 2;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 5);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 1;
            label3.Text = "Laki - Laki";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(830, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 80);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(192, 57, 43);
            label4.Location = new Point(0, 32);
            label4.Name = "label4";
            label4.Size = new Size(160, 44);
            label4.TabIndex = 2;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(0, 5);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 1;
            label5.Text = "Perempuan";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 247, 250);
            panel4.Controls.Add(chart1);
            panel4.Controls.Add(chart3);
            panel4.Controls.Add(chart2);
            panel4.Controls.Add(chart4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 110);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15);
            panel4.Size = new Size(1235, 820);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(15, 15);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kepadatan Per Wilayah";
            chart1.Series.Add(series1);
            chart1.Size = new Size(590, 385);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart3.Legends.Add(legend2);
            chart3.Location = new Point(620, 15);
            chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Pendidikan";
            chart3.Series.Add(series2);
            chart3.Size = new Size(590, 385);
            chart3.TabIndex = 6;
            chart3.Text = "chart3";
            chart3.Click += chart3_Click;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart2.Legends.Add(legend3);
            chart2.Location = new Point(15, 415);
            chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Umur Penduduk";
            chart2.Series.Add(series3);
            chart2.Size = new Size(590, 385);
            chart2.TabIndex = 5;
            chart2.Text = "chart2";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart4.Legends.Add(legend4);
            chart4.Location = new Point(620, 415);
            chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Pekerjaan";
            chart4.Series.Add(series4);
            chart4.Size = new Size(590, 385);
            chart4.TabIndex = 7;
            chart4.Text = "chart4";
            // 
            // FormStatistik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 930);
            Controls.Add(panel4);
            Controls.Add(statistika);
            Name = "FormStatistik";
            Text = "FormStatistik";
            Load += FormStatistik_Load;
            statistika.ResumeLayout(false);
            statistika.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label6;
        private ComboBox comboBox1;
        private Button btnTampilkan;
    }
}