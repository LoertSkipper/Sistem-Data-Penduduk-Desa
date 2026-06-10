namespace Sistem_Data_Penduduk_Desa
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            username_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            password_txt = new TextBox();
            login_btn = new Button();
            keluar_btn = new Button();
            login_panel = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new Point(675, 224);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(345, 31);
            username_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(675, 187);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(675, 277);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // password_txt
            // 
            password_txt.Location = new Point(675, 314);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(345, 31);
            password_txt.TabIndex = 2;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.ActiveCaption;
            login_btn.ForeColor = SystemColors.Control;
            login_btn.Location = new Point(908, 413);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(112, 34);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // keluar_btn
            // 
            keluar_btn.BackColor = SystemColors.ActiveCaption;
            keluar_btn.ForeColor = SystemColors.Control;
            keluar_btn.Location = new Point(767, 413);
            keluar_btn.Name = "keluar_btn";
            keluar_btn.Size = new Size(112, 34);
            keluar_btn.TabIndex = 5;
            keluar_btn.Text = "Keluar";
            keluar_btn.UseVisualStyleBackColor = false;
            keluar_btn.Click += keluar_btn_Click;
            // 
            // login_panel
            // 
            login_panel.Controls.Add(pictureBox1);
            login_panel.Controls.Add(keluar_btn);
            login_panel.Controls.Add(password_txt);
            login_panel.Controls.Add(login_btn);
            login_panel.Controls.Add(username_txt);
            login_panel.Controls.Add(label2);
            login_panel.Controls.Add(label1);
            login_panel.Dock = DockStyle.Top;
            login_panel.Location = new Point(0, 64);
            login_panel.Name = "login_panel";
            login_panel.Size = new Size(1258, 493);
            login_panel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 64);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 600);
            panel2.Name = "panel2";
            panel2.Size = new Size(1258, 64);
            panel2.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(login_panel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Form Login";
            Load += FormLogin_Load;
            Resize += FormLogin_Resize;
            login_panel.ResumeLayout(false);
            login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox username_txt;
        private Label label1;
        private Label label2;
        private TextBox password_txt;
        private Button login_btn;
        private Button keluar_btn;
        private Panel login_panel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}
