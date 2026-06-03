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
            login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username_txt
            // 
            username_txt.Location = new Point(287, 202);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(345, 31);
            username_txt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 165);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 255);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // password_txt
            // 
            password_txt.Location = new Point(287, 292);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(345, 31);
            password_txt.TabIndex = 2;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(520, 391);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(112, 34);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // keluar_btn
            // 
            keluar_btn.Location = new Point(382, 391);
            keluar_btn.Name = "keluar_btn";
            keluar_btn.Size = new Size(112, 34);
            keluar_btn.TabIndex = 5;
            keluar_btn.Text = "Keluar";
            keluar_btn.UseVisualStyleBackColor = true;
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
            login_panel.Location = new Point(209, 104);
            login_panel.Name = "login_panel";
            login_panel.Size = new Size(885, 493);
            login_panel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(378, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(login_panel);
            Name = "FormLogin";
            Text = "Form Login";
            FormClosing += FormLogin_FormClosing;
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
    }
}
