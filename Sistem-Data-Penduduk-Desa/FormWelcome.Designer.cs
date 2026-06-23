namespace Sistem_Data_Penduduk_Desa
{
    partial class FormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            lbl_welcome = new Label();
            img_logo = new PictureBox();
            lbl_desc = new Label();
            ((System.ComponentModel.ISupportInitialize)img_logo).BeginInit();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(138, 52);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(982, 38);
            lbl_welcome.TabIndex = 1;
            lbl_welcome.Text = "SELAMAT DATANG DI SISTEM DATA PENDUDUK DESA";
            // 
            // img_logo
            // 
            img_logo.Image = (Image)resources.GetObject("img_logo.Image");
            img_logo.Location = new Point(438, 186);
            img_logo.Name = "img_logo";
            img_logo.Size = new Size(356, 325);
            img_logo.SizeMode = PictureBoxSizeMode.Zoom;
            img_logo.TabIndex = 2;
            img_logo.TabStop = false;
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_desc.Location = new Point(149, 594);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(971, 29);
            lbl_desc.TabIndex = 3;
            lbl_desc.Text = "Sistem yang berguna untuk mengelola data penduduk yang ada di sebuah desa.";
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(lbl_desc);
            Controls.Add(img_logo);
            Controls.Add(lbl_welcome);
            Name = "FormWelcome";
            Text = "FormWelcome";
            ((System.ComponentModel.ISupportInitialize)img_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private PictureBox img_logo;
        private Label lbl_desc;
    }
}