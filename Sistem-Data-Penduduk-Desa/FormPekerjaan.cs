using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormPekerjaan : Form
    {
        string connString = "server=localhost;user=root;password=;database=sdpd";
        MySqlConnection conn;

        public FormPekerjaan()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                string query = "SELECT * FROM pekerjaan";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDataPekerjaan.DataSource = dt;
                lblAngkatotal.Text = dt.Rows.Count.ToString();

                MySqlCommand cmd = new MySqlCommand("SELECT AVG(pendapatan) FROM pekerjaan", conn);
                object hasil = cmd.ExecuteScalar();
                if (hasil != DBNull.Value && hasil != null)
                    angkaRata2.Text = "Rp " + Convert.ToDecimal(hasil).ToString("N0");
                else
                    angkaRata2.Text = "Rp 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ExecuteQuery(string query, string pesan, bool pakaiId, bool pakaiInput)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (pakaiId)
                {
                    cmd.Parameters.AddWithValue("@id", dgvDataPekerjaan.CurrentRow.Cells["id_pekerjaan"].Value);
                }

                if (pakaiInput)
                {
                    cmd.Parameters.AddWithValue("@nama", txtNama_pekerjaan.Text);

                    decimal pendapatan = 0;
                    decimal.TryParse(txtPendapatan.Text.Replace(".", "").Replace(",", ""), out pendapatan);
                    cmd.Parameters.AddWithValue("@pendapatan", pendapatan);

                    int tanggungan = 0;
                    int.TryParse(txtJumlah_Tanggungann.Text, out tanggungan);
                    cmd.Parameters.AddWithValue("@tanggungan", tanggungan);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show(pesan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                LoadData();
                btnReset_Click(null, EventArgs.Empty);
            }
        }

        private void btnTambahh_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pekerjaan (nama_pekerjaan, pendapatan, jumlah_tanggungan) VALUES (@nama, @pendapatan, @tanggungan)";
            ExecuteQuery(query, "Data berhasil ditambah.", false, true);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvDataPekerjaan.CurrentRow == null) return;
            string query = "UPDATE pekerjaan SET nama_pekerjaan=@nama, pendapatan=@pendapatan, jumlah_tanggungan=@tanggungan WHERE id_pekerjaan=@id";
            ExecuteQuery(query, "Data berhasil diubah.", true, true);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDataPekerjaan.CurrentRow == null) return;
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM pekerjaan WHERE id_pekerjaan=@id";
                ExecuteQuery(query, "Data berhasil dihapus.", true, false);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama_pekerjaan.Clear();
            txtPendapatan.Clear();
            txtJumlah_Tanggungann.Clear();
        }

        private void dgvDataPekerjaan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvDataPekerjaan.Rows[e.RowIndex];
            txtNama_pekerjaan.Text = row.Cells["nama_pekerjaan"].Value.ToString();
            txtPendapatan.Text = Convert.ToDecimal(row.Cells["pendapatan"].Value).ToString("N0");
            txtJumlah_Tanggungann.Text = row.Cells["jumlah_tanggungan"].Value.ToString();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string query = "SELECT * FROM pekerjaan WHERE nama_pekerjaan LIKE @cari";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@cari", "%" + txtCari.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDataPekerjaan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtJumlah_Tanggungann_TextChanged(object sender, EventArgs e)
        {

        }
    }
}