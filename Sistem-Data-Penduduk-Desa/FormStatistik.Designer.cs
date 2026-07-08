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

            // ── Controls ──────────────────────────────────────────────────────────────
            statistika      = new Panel();
            btnTampilkan    = new Button();
            comboBox1       = new ComboBox();
            label6          = new Label();
            label8          = new Label();
            panel3          = new Panel();
            label4          = new Label();
            label5          = new Label();
            panel2          = new Panel();
            label2          = new Label();
            label3          = new Label();
            panel1          = new Panel();
            lblTotalPenduduk = new Label();
            label1          = new Label();
            panel4          = new Panel();
            chart4          = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3          = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2          = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1          = new System.Windows.Forms.DataVisualization.Charting.Chart();

            statistika.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();

            // ── statistika (top header panel) ────────────────────────────────────────
            statistika.BackColor = System.Drawing.Color.FromArgb(31, 73, 125);
            statistika.Controls.Add(btnTampilkan);
            statistika.Controls.Add(comboBox1);
            statistika.Controls.Add(label6);
            statistika.Controls.Add(label8);
            statistika.Controls.Add(panel1);
            statistika.Controls.Add(panel2);
            statistika.Controls.Add(panel3);
            statistika.Dock   = DockStyle.Top;
            statistika.Location = new System.Drawing.Point(0, 0);
            statistika.Name   = "statistika";
            statistika.Size   = new System.Drawing.Size(1235, 110);
            statistika.TabIndex = 1;

            // ── label8 (title) ────────────────────────────────────────────────────────
            label8.AutoSize  = true;
            label8.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location  = new System.Drawing.Point(20, 35);
            label8.Name      = "label8";
            label8.Size      = new System.Drawing.Size(420, 38);
            label8.TabIndex  = 4;
            label8.Text      = "Statistika Data Penduduk Desa";

            // ── panel1 (Total Penduduk) ───────────────────────────────────────────────
            panel1.BackColor  = System.Drawing.Color.White;
            panel1.Controls.Add(lblTotalPenduduk);
            panel1.Controls.Add(label1);
            panel1.Location   = new System.Drawing.Point(480, 15);
            panel1.Name       = "panel1";
            panel1.Size       = new System.Drawing.Size(160, 80);
            panel1.TabIndex   = 0;

            lblTotalPenduduk.AutoSize  = false;
            lblTotalPenduduk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTotalPenduduk.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTotalPenduduk.ForeColor = System.Drawing.Color.FromArgb(31, 73, 125);
            lblTotalPenduduk.Location  = new System.Drawing.Point(0, 32);
            lblTotalPenduduk.Name      = "lblTotalPenduduk";
            lblTotalPenduduk.Size      = new System.Drawing.Size(160, 44);
            lblTotalPenduduk.TabIndex  = 2;
            lblTotalPenduduk.Text      = "0";

            label1.AutoSize  = false;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location  = new System.Drawing.Point(0, 5);
            label1.Name      = "label1";
            label1.Size      = new System.Drawing.Size(160, 25);
            label1.TabIndex  = 1;
            label1.Text      = "Total Penduduk";

            // ── panel2 (Laki-Laki) ────────────────────────────────────────────────────
            panel2.BackColor  = System.Drawing.Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location   = new System.Drawing.Point(655, 15);
            panel2.Name       = "panel2";
            panel2.Size       = new System.Drawing.Size(160, 80);
            panel2.TabIndex   = 3;

            label2.AutoSize  = false;
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label2.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label2.Location  = new System.Drawing.Point(0, 32);
            label2.Name      = "label2";
            label2.Size      = new System.Drawing.Size(160, 44);
            label2.TabIndex  = 2;
            label2.Text      = "0";

            label3.AutoSize  = false;
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label3.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.Gray;
            label3.Location  = new System.Drawing.Point(0, 5);
            label3.Name      = "label3";
            label3.Size      = new System.Drawing.Size(160, 25);
            label3.TabIndex  = 1;
            label3.Text      = "Laki - Laki";

            // ── panel3 (Perempuan) ────────────────────────────────────────────────────
            panel3.BackColor  = System.Drawing.Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location   = new System.Drawing.Point(830, 15);
            panel3.Name       = "panel3";
            panel3.Size       = new System.Drawing.Size(160, 80);
            panel3.TabIndex   = 3;

            label4.AutoSize  = false;
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            label4.Location  = new System.Drawing.Point(0, 32);
            label4.Name      = "label4";
            label4.Size      = new System.Drawing.Size(160, 44);
            label4.TabIndex  = 2;
            label4.Text      = "0";

            label5.AutoSize  = false;
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label5.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Gray;
            label5.Location  = new System.Drawing.Point(0, 5);
            label5.Name      = "label5";
            label5.Size      = new System.Drawing.Size(160, 25);
            label5.TabIndex  = 1;
            label5.Text      = "Perempuan";

            // ── label6 (Pilih RW) ─────────────────────────────────────────────────────
            label6.AutoSize  = true;
            label6.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location  = new System.Drawing.Point(1015, 40);
            label6.Name      = "label6";
            label6.Size      = new System.Drawing.Size(75, 28);
            label6.TabIndex  = 6;
            label6.Text      = "Pilih RW :";

            // ── comboBox1 ─────────────────────────────────────────────────────────────
            comboBox1.FormattingEnabled = true;
            comboBox1.Font    = new System.Drawing.Font("Segoe UI", 9F);
            comboBox1.Location = new System.Drawing.Point(1015, 70);
            comboBox1.Name    = "comboBox1";
            comboBox1.Size    = new System.Drawing.Size(140, 28);
            comboBox1.TabIndex = 7;

            // ── btnTampilkan ──────────────────────────────────────────────────────────
            btnTampilkan.BackColor = System.Drawing.Color.FromArgb(41, 182, 246);
            btnTampilkan.ForeColor = System.Drawing.Color.White;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.FlatAppearance.BorderSize = 0;
            btnTampilkan.Font   = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnTampilkan.Location = new System.Drawing.Point(1165, 70);
            btnTampilkan.Name   = "btnTampilkan";
            btnTampilkan.Size   = new System.Drawing.Size(55, 28);
            btnTampilkan.TabIndex = 8;
            btnTampilkan.Text   = "Filter";
            btnTampilkan.UseVisualStyleBackColor = false;
            btnTampilkan.Click += btnTampilkan_Click;

            // ── panel4 (chart container) ──────────────────────────────────────────────
            panel4.BackColor  = System.Drawing.Color.FromArgb(245, 247, 250);
            panel4.Controls.Add(chart1);
            panel4.Controls.Add(chart3);
            panel4.Controls.Add(chart2);
            panel4.Controls.Add(chart4);
            panel4.Dock       = DockStyle.Fill;
            panel4.Location   = new System.Drawing.Point(0, 110);
            panel4.Name       = "panel4";
            panel4.Padding    = new Padding(15);
            panel4.Size       = new System.Drawing.Size(1235, 820);
            panel4.TabIndex   = 2;
            panel4.Paint      += panel4_Paint;

            // ── chart1 (Kepadatan per RW — Column, top-left) ──────────────────────────
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Legend    = "Legend1";
            series1.Name      = "Kepadatan Per Wilayah";
            chart1.Series.Add(series1);
            chart1.Location   = new System.Drawing.Point(15, 15);
            chart1.Name       = "chart1";
            chart1.Size       = new System.Drawing.Size(590, 385);
            chart1.TabIndex   = 4;
            chart1.Text       = "chart1";
            chart1.Anchor     = AnchorStyles.Top | AnchorStyles.Left;

            // ── chart3 (Pendidikan — Pie, top-right) ──────────────────────────────────
            chartArea2.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart3.Legends.Add(legend2);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend    = "Legend1";
            series2.Name      = "Pendidikan";
            chart3.Series.Add(series2);
            chart3.Location   = new System.Drawing.Point(620, 15);
            chart3.Name       = "chart3";
            chart3.Size       = new System.Drawing.Size(590, 385);
            chart3.TabIndex   = 6;
            chart3.Text       = "chart3";
            chart3.Anchor     = AnchorStyles.Top | AnchorStyles.Left;
            chart3.Click     += chart3_Click;

            // ── chart2 (Kelompok Umur — Column, bottom-left) ──────────────────────────
            chartArea3.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart2.Legends.Add(legend3);
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series3.Legend    = "Legend1";
            series3.Name      = "Umur Penduduk";
            chart2.Series.Add(series3);
            chart2.Location   = new System.Drawing.Point(15, 415);
            chart2.Name       = "chart2";
            chart2.Size       = new System.Drawing.Size(590, 385);
            chart2.TabIndex   = 5;
            chart2.Text       = "chart2";
            chart2.Anchor     = AnchorStyles.Top | AnchorStyles.Left;

            // ── chart4 (Pekerjaan — Bar, bottom-right) ────────────────────────────────
            chartArea4.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chart4.Legends.Add(legend4);
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend    = "Legend1";
            series4.Name      = "Pekerjaan";
            chart4.Series.Add(series4);
            chart4.Location   = new System.Drawing.Point(620, 415);
            chart4.Name       = "chart4";
            chart4.Size       = new System.Drawing.Size(590, 385);
            chart4.TabIndex   = 7;
            chart4.Text       = "chart4";
            chart4.Anchor     = AnchorStyles.Top | AnchorStyles.Left;

            // ── FormStatistik ─────────────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize    = new System.Drawing.Size(1235, 930);
            Controls.Add(panel4);
            Controls.Add(statistika);
            Name = "FormStatistik";
            Text = "FormStatistik";
            Load += FormStatistik_Load;

            statistika.ResumeLayout(false);
            statistika.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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