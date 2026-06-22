namespace Sistem_Data_Penduduk_Desa
{
    partial class FormUser
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
            user_dgv = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            username_txt = new TextBox();
            password_txt = new TextBox();
            role_cmb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tambah_btn = new Button();
            edit_btn = new Button();
            hapus_btn = new Button();
            reset_btn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            id_user_lbl = new Label();
            panel3 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)user_dgv).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // user_dgv
            // 
            user_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            user_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            user_dgv.Columns.AddRange(new DataGridViewColumn[] { username, password, role });
            user_dgv.Location = new Point(3, 113);
            user_dgv.Name = "user_dgv";
            user_dgv.RowHeadersWidth = 62;
            user_dgv.Size = new Size(1255, 437);
            user_dgv.TabIndex = 0;
            user_dgv.CellClick += user_dgv_CellClick;
            user_dgv.CellFormatting += user_dgv_CellFormatting;
            // 
            // username
            // 
            username.DataPropertyName = "username";
            username.HeaderText = "Username";
            username.MinimumWidth = 8;
            username.Name = "username";
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.MinimumWidth = 8;
            password.Name = "password";
            // 
            // role
            // 
            role.DataPropertyName = "role";
            role.HeaderText = "Role";
            role.MinimumWidth = 8;
            role.Name = "role";
            // 
            // username_txt
            // 
            username_txt.Location = new Point(145, 49);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(200, 31);
            username_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(445, 49);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(200, 31);
            password_txt.TabIndex = 2;
            // 
            // role_cmb
            // 
            role_cmb.FormattingEnabled = true;
            role_cmb.Location = new Point(745, 49);
            role_cmb.Name = "role_cmb";
            role_cmb.Size = new Size(200, 33);
            role_cmb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 21);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(745, 21);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // tambah_btn
            // 
            tambah_btn.Location = new Point(206, 603);
            tambah_btn.Name = "tambah_btn";
            tambah_btn.Size = new Size(112, 34);
            tambah_btn.TabIndex = 7;
            tambah_btn.Text = "Tambah";
            tambah_btn.UseVisualStyleBackColor = true;
            tambah_btn.Click += tambah_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(396, 603);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(112, 34);
            edit_btn.TabIndex = 8;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // hapus_btn
            // 
            hapus_btn.Location = new Point(586, 603);
            hapus_btn.Name = "hapus_btn";
            hapus_btn.Size = new Size(112, 34);
            hapus_btn.TabIndex = 9;
            hapus_btn.Text = "Hapus";
            hapus_btn.UseVisualStyleBackColor = true;
            hapus_btn.Click += hapus_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(776, 603);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(112, 34);
            reset_btn.TabIndex = 10;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(user_dgv);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1258, 446);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(role_cmb);
            panel1.Controls.Add(username_txt);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 100);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(id_user_lbl);
            panel2.Controls.Add(hapus_btn);
            panel2.Controls.Add(tambah_btn);
            panel2.Controls.Add(reset_btn);
            panel2.Controls.Add(edit_btn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1258, 664);
            panel2.TabIndex = 13;
            // 
            // id_user_lbl
            // 
            id_user_lbl.AutoSize = true;
            id_user_lbl.Location = new Point(72, 592);
            id_user_lbl.Name = "id_user_lbl";
            id_user_lbl.Size = new Size(0, 25);
            id_user_lbl.TabIndex = 11;
            id_user_lbl.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1255, 104);
            panel3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(501, 20);
            label4.Name = "label4";
            label4.Size = new Size(229, 57);
            label4.TabIndex = 0;
            label4.Text = "Kelola User";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "FormUser";
            Text = "FormUser";
            Load += FormUser_Load;
            ((System.ComponentModel.ISupportInitialize)user_dgv).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView user_dgv;
        private TextBox username_txt;
        private TextBox password_txt;
        private ComboBox role_cmb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button tambah_btn;
        private Button edit_btn;
        private Button hapus_btn;
        private Button reset_btn;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label id_user_lbl;
        private Panel panel3;
        private Label label4;
    }
}