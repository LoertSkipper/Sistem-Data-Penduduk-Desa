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
            password_txt.PasswordChar = '*';
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
