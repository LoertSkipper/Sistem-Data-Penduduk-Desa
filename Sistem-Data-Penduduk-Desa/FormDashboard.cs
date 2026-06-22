using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if (Session.role == "admin")
            {
                user_btn.Visible = true;
                laporan_btn.Visible = true;
            }
            else if (Session.role == "petugas")
            {
                user_btn.Visible = false;
                laporan_btn.Visible = false;
            }
            else if (Session.role == "kepala_desa")
            {
                penduduk_btn.Visible = false;
                kk_btn.Visible = false;
                pekerjaan_btn.Visible = false;
                pendidikan_btn.Visible = false;

                laporan_btn.Visible = true;
                statistik_btn.Visible = true;
            }
        }
        private Form activeForm = null;

        private void openForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            openForm(new FormUser());
        }

        private void penduduk_btn_Click(object sender, EventArgs e)
        {
            openForm(new FormPenduduk());
        }

        private void kk_btn_Click(object sender, EventArgs e)
        {
            openForm(new FormKK());
        }

        private void pekerjaan_btn_Click(object sender, EventArgs e)
        {
            openForm(new FormPekerjaan());
        }

        private void pendidikan_btn_Click(object sender, EventArgs e)
        {
            openForm(new FormPendidikan());
        }

        private void statistik_btn_Click(object sender, EventArgs e)
        {
            openForm(new FormStatistik());
        }

        private void laporan_btn_Click(object sender, EventArgs e)
        {
            openForm(new FormLaporan());
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
