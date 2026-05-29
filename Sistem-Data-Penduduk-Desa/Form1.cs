using Sistem_Data_Penduduk_Desa.konfigurasi;
using System.Data;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CenterPanel();
            password_txt.PasswordChar = '*';
        }

        private void CenterPanel()
        {
            login_panel.Left = (this.ClientSize.Width - login_panel.Width) / 2;
            login_panel.Top = (this.ClientSize.Height - login_panel.Height) / 2;
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();

            string username = username_txt.Text;
            string password = password_txt.Text;

            string query =
                "SELECT * FROM users " +
                "WHERE username='" + username + "' " +
                "AND password='" + password + "'";

            DataTable dt = kon.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                string role =
                    dt.Rows[0]["role"].ToString();

                MessageBox.Show(
                    "Login berhasil sebagai " + role
                );

                FormDashboard dashboard =
                    new FormDashboard();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Username atau password salah!"
                );
            }
        }

        private void keluar_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
