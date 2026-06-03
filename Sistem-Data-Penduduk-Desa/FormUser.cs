using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistem_Data_Penduduk_Desa.konfigurasi;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormUser : Form
    {
        Koneksi Koneksi = new Koneksi();
        public FormUser()
        {
            InitializeComponent();
            role_cmb.Items.Add("admin");
            role_cmb.Items.Add("petugas");
            role_cmb.Items.Add("kepala_desa");
        }

        void tampilUser()
        {
            string query = "SELECT * FROM users";
            DataTable dt = Koneksi.eksekusiQuery(query);
            user_dgv.DataSource = dt;
            user_dgv.Columns["id_user"].Visible = false;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            tampilUser();
        }

        private void user_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (user_dgv.Columns[e.ColumnIndex].Name == "password")
            {
                if (e.Value != null)
                {
                    e.Value = "********";
                }
            }
        }
    }
}
