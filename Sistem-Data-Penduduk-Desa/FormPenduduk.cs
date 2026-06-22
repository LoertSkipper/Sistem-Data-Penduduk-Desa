using System;
using System.Data;
using System.Windows.Forms;
using Sistem_Data_Penduduk_Desa.konfigurasi;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormPenduduk : Form
    {
        Koneksi Koneksi = new Koneksi();

        public FormPenduduk()
        {
            InitializeComponent();
        }

        // =========================
        // METHOD TAMPIL DATA
        // =========================
        private void TampilData()
        {
            string query =
                "SELECT " +
                "p.id_penduduk, " +
                "p.nik, " +
                "p.nama, " +
                "p.jk, " +
                "p.tgl_lahir, " +
                "kk.no_kk, " +
                "pk.nama_pekerjaan, " +
                "pd.jenjang " +
                "FROM penduduk p " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                "INNER JOIN pekerjaan pk ON p.id_pekerjaan = pk.id_pekerjaan " +
                "INNER JOIN pendidikan pd ON p.id_pendidikan = pd.id_pendidikan";

            DataTable dt = Koneksi.eksekusiQuery(query);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["id_penduduk"],
                    row["nik"],
                    row["nama"],
                    row["jk"],
                    Convert.ToDateTime(row["tgl_lahir"]).ToString("yyyy-MM-dd"),
                    row["no_kk"],
                    row["nama_pekerjaan"],
                    row["jenjang"]
                );
            }
        }

        // =========================
        // LOAD PEKERJAAN
        // =========================
        private void LoadPekerjaan()
        {
            string query = "SELECT * FROM pekerjaan";

            DataTable dt = Koneksi.eksekusiQuery(query);

            id_pekerjaan_cbx.DataSource = dt;
            id_pekerjaan_cbx.DisplayMember = "nama_pekerjaan";
            id_pekerjaan_cbx.ValueMember = "id_pekerjaan";
        }

        // =========================
        // LOAD PENDIDIKAN
        // =========================
        private void LoadPendidikan()
        {
            string query = "SELECT * FROM pendidikan";

            DataTable dt = Koneksi.eksekusiQuery(query);

            id_pendidikan_cb.DataSource = dt;
            id_pendidikan_cb.DisplayMember = "jenjang";
            id_pendidikan_cb.ValueMember = "id_pendidikan";
        }

        // =========================
        // RESET FORM
        // =========================
        private void ResetForm()
        {
            id_penduduk_txt.Clear();
            nik_txt.Clear();
            nama_txt.Clear();

            lk_ck.Checked = false;
            pr_ck.Checked = false;

            id_keluarga_txt.Clear();

            tgl_lahir.Value = DateTime.Now;

            if (id_pekerjaan_cbx.Items.Count > 0)
                id_pekerjaan_cbx.SelectedIndex = 0;

            if (id_pendidikan_cb.Items.Count > 0)
                id_pendidikan_cb.SelectedIndex = 0;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void FormPenduduk_Load_1(object sender, EventArgs e)
        {
            id_penduduk_txt.ReadOnly = true;

            LoadPekerjaan();
            LoadPendidikan();
            TampilData();
        }

        // =========================
        // TAMBAH DATA
        // =========================
        private void tambah_btn_Click(object sender, EventArgs e)
        {
            string jk = "";

            if (lk_ck.Checked)
                jk = "L";

            if (pr_ck.Checked)
                jk = "P";

            string query =
                "INSERT INTO penduduk " +
                "(nik, nama, jk, tgl_lahir, id_kk, id_pekerjaan, id_pendidikan) VALUES (" +
                "'" + nik_txt.Text + "'," +
                "'" + nama_txt.Text + "'," +
                "'" + jk + "'," +
                "'" + tgl_lahir.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + id_keluarga_txt.Text + "'," +
                "'" + id_pekerjaan_cbx.SelectedValue + "'," +
                "'" + id_pendidikan_cb.SelectedValue + "')";

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

        // =========================
        // EDIT DATA
        // =========================
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (id_penduduk_txt.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diedit terlebih dahulu!");
                return;
            }

            string jk = "";

            if (lk_ck.Checked)
                jk = "L";

            if (pr_ck.Checked)
                jk = "P";

            DialogResult hasilKonfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin mengubah data ini?",
                "Konfirmasi Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasilKonfirmasi == DialogResult.Yes)
            {
                string query =
                    "UPDATE penduduk SET " +
                    "nik='" + nik_txt.Text + "'," +
                    "nama='" + nama_txt.Text + "'," +
                    "jk='" + jk + "'," +
                    "tgl_lahir='" + tgl_lahir.Value.ToString("yyyy-MM-dd") + "'," +
                    "id_kk='" + id_keluarga_txt.Text + "'," +
                    "id_pekerjaan='" + id_pekerjaan_cbx.SelectedValue + "'," +
                    "id_pendidikan='" + id_pendidikan_cb.SelectedValue + "' " +
                    "WHERE id_penduduk='" + id_penduduk_txt.Text + "'";

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

        // =========================
        // HAPUS DATA
        // =========================
        private void Hapus_btn_Click(object sender, EventArgs e)
        {
            if (id_penduduk_txt.Text == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!");
                return;
            }

            DialogResult hasilKonfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasilKonfirmasi == DialogResult.Yes)
            {
                string query =
                    "DELETE FROM penduduk WHERE id_penduduk='" +
                    id_penduduk_txt.Text + "'";

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
            else
            {
                MessageBox.Show("Penghapusan data dibatalkan");
            }
        }

        // =========================
        // RESET BUTTON
        // =========================
        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // =========================
        // CARI DATA
        // =========================
        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            string query =
                "SELECT " +
                "p.id_penduduk, " +
                "p.nik, " +
                "p.nama, " +
                "p.jk, " +
                "p.tgl_lahir, " +
                "kk.no_kk, " +
                "pk.nama_pekerjaan, " +
                "pd.jenjang " +
                "FROM penduduk p " +
                "INNER JOIN kartu_keluarga kk ON p.id_kk = kk.id_kk " +
                "INNER JOIN pekerjaan pk ON p.id_pekerjaan = pk.id_pekerjaan " +
                "INNER JOIN pendidikan pd ON p.id_pendidikan = pd.id_pendidikan " +
                "WHERE p.nama LIKE '%" + cari_txt.Text + "%'";

            DataTable dt = Koneksi.eksekusiQuery(query);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["id_penduduk"],
                    row["nik"],
                    row["nama"],
                    row["jk"],
                    Convert.ToDateTime(row["tgl_lahir"]).ToString("yyyy-MM-dd"),
                    row["no_kk"],
                    row["nama_pekerjaan"],
                    row["jenjang"]
                );
            }
        }

        // =========================
        // KLIK DATAGRIDVIEW
        // =========================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idPenduduk = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                string query =
                    "SELECT * FROM penduduk " +
                    "WHERE id_penduduk = '" + idPenduduk + "'";

                DataTable dt = Koneksi.eksekusiQuery(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    id_penduduk_txt.Text = row["id_penduduk"].ToString();
                    nik_txt.Text = row["nik"].ToString();
                    nama_txt.Text = row["nama"].ToString();

                    string jk = row["jk"].ToString();

                    if (jk == "L")
                    {
                        lk_ck.Checked = true;
                        pr_ck.Checked = false;
                    }
                    else
                    {
                        lk_ck.Checked = false;
                        pr_ck.Checked = true;
                    }

                    tgl_lahir.Value =
                        Convert.ToDateTime(row["tgl_lahir"]);

                    id_keluarga_txt.Text =
                        row["id_kk"].ToString();

                    id_pekerjaan_cbx.SelectedValue =
                        row["id_pekerjaan"];

                    id_pendidikan_cb.SelectedValue =
                        row["id_pendidikan"];
                }
            }
        }

        // =========================
        // EVENT KOSONG
        // =========================
        private void id_penduduk_txt_TextChanged(object sender, EventArgs e) { }
        private void nik_txt_TextChanged(object sender, EventArgs e) { }
        private void nama_txt_TextChanged(object sender, EventArgs e) { }
        private void id_keluarga_txt_TextChanged(object sender, EventArgs e) { }
        private void id_pekerjaan_cbx_SelectedIndexChanged(object sender, EventArgs e) { }
        private void id_pendidikan_cb_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tgl_lahir_ValueChanged(object sender, EventArgs e) { }

        private void lk_ck_CheckedChanged(object sender, EventArgs e)
        {
            if (lk_ck.Checked)
                pr_ck.Checked = false;
        }

        private void pr_ck_CheckedChanged(object sender, EventArgs e)
        {
            if (pr_ck.Checked)
                lk_ck.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}