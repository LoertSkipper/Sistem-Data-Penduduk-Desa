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

        void clearForm()
        {
            username_txt.Clear();
            password_txt.Clear();
            role_cmb.SelectedIndex = -1;

            username_txt.Focus();
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

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == "" ||
                password_txt.Text == "" ||
                role_cmb.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!");
                return;
            }

            string query = $"INSERT INTO users(username,password,role) " +
                           $"VALUES('{username_txt.Text}', '{password_txt.Text}', '{role_cmb.Text}')";

            Koneksi.eksekusiQuery(query);

            MessageBox.Show("Data user berhasil ditambahkan");

            tampilUser();
            clearForm();
        }

        private void user_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = user_dgv.Rows[e.RowIndex];

                id_user_lbl.Text = row.Cells["id_user"].Value.ToString();
                username_txt.Text = row.Cells["username"].Value.ToString();
                password_txt.Text = row.Cells["password"].Value.ToString();
                role_cmb.Text = row.Cells["role"].Value.ToString();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (id_user_lbl.Text == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            string query = $"UPDATE users SET " +
                           $"username='{username_txt.Text}', " +
                           $"password='{password_txt.Text}', " +
                           $"role='{role_cmb.Text}' " +
                           $"WHERE id_user='{id_user_lbl.Text}'";

            Koneksi.eksekusiQuery(query);

            MessageBox.Show("Data user berhasil diubah");

            tampilUser();
            clearForm();

            id_user_lbl.Text = "";
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (id_user_lbl.Text == "")
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                string query = $"DELETE FROM users WHERE id_user='{id_user_lbl.Text}'";

                Koneksi.eksekusiQuery(query);

                MessageBox.Show("Data user berhasil dihapus");

                tampilUser();
                clearForm();

                id_user_lbl.Text = "";
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            clearForm();
            id_user_lbl.Text = "";
        }
    }
}