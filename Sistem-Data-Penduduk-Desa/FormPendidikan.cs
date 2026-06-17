using System;
using System.Data;
using System.Windows.Forms;
using Sistem_Data_Penduduk_Desa.konfigurasi;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormPendidikan : Form
    {
        Koneksi Koneksi = new Koneksi();

        public FormPendidikan()
        {
            InitializeComponent();
        }

        // ==========================
        // TAMPIL DATA
        // ==========================
        private void TampilData()
        {
            string query = "SELECT * FROM pendidikan";

            DataTable dt = Koneksi.eksekusiQuery(query);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["id_pendidikan"],
                    row["jenjang"]
                );
            }
        }

        // ==========================
        // RESET FORM
        // ==========================
        private void ResetForm()
        {
            id_pendidikan_txt.Clear();
            jenjang_txt.Clear();
            jenjang_txt.Focus();
        }

        // ==========================
        // FORM LOAD
        // ==========================
        private void FormPendidikan_Load(object sender, EventArgs e)
        {
            id_pendidikan_txt.ReadOnly = true;

            TampilData();
        }

        // ==========================
        // TAMBAH DATA
        // ==========================
        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (jenjang_txt.Text == "")
            {
                MessageBox.Show("Jenjang pendidikan harus diisi!");
                return;
            }

            string query =
                "INSERT INTO pendidikan (jenjang) VALUES ('" +
                jenjang_txt.Text + "')";

            int hasil = Koneksi.eksekusiNonQuery(query);

            if (hasil > 0)
            {
                MessageBox.Show("Data berhasil ditambahkan");

                TampilData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan");
            }
        }

        // ==========================
        // EDIT DATA
        // ==========================
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (id_pendidikan_txt.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diedit terlebih dahulu!");
                return;
            }

            if (jenjang_txt.Text.Trim() == "")
            {
                MessageBox.Show("Jenjang pendidikan tidak boleh kosong!");
                jenjang_txt.Focus();
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin mengubah data ini?",
                "Konfirmasi Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                string query =
                    "UPDATE pendidikan SET " +
                    "jenjang='" + jenjang_txt.Text + "' " +
                    "WHERE id_pendidikan='" +
                    id_pendidikan_txt.Text + "'";

                int hasil = Koneksi.eksekusiNonQuery(query);

                if (hasil > 0)
                {
                    MessageBox.Show("Data berhasil diubah");

                    TampilData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Data gagal diubah");
                }
            }
            else
            {
                MessageBox.Show("Perubahan data dibatalkan");
            }
        }

        // ==========================
        // HAPUS DATA
        // ==========================
        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (id_pendidikan_txt.Text == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus!");
                return;
            }

            DialogResult jawab =
                MessageBox.Show(
                    "Yakin ingin menghapus data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                string query =
                    "DELETE FROM pendidikan WHERE id_pendidikan='" +
                    id_pendidikan_txt.Text + "'";

                int hasil = Koneksi.eksekusiNonQuery(query);

                if (hasil > 0)
                {
                    MessageBox.Show("Data berhasil dihapus");

                    TampilData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }
        }

        // ==========================
        // RESET BUTTON
        // ==========================
        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // ==========================
        // CARI DATA
        // ==========================
        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            string query =
                "SELECT * FROM pendidikan WHERE jenjang LIKE '%" +
                cari_txt.Text + "%'";

            DataTable dt = Koneksi.eksekusiQuery(query);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["id_pendidikan"],
                    row["jenjang"]
                );
            }
        }

        // ==========================
        // KLIK DATAGRIDVIEW
        // ==========================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                id_pendidikan_txt.Text =
                    row.Cells[0].Value.ToString();

                jenjang_txt.Text =
                    row.Cells[1].Value.ToString();
            }
        }

        // ==========================
        // EVENT KOSONG
        // ==========================
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void jenjang_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_pendidikan_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}