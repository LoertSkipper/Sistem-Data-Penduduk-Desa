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
                string queryRata = "SELECT AVG(pendapatan) FROM pekerjaan";
                MySqlCommand cmdRata = new MySqlCommand(queryRata, conn);
                object result = cmdRata.ExecuteScalar();
                angkaRata2.Text = (result != DBNull.Value) ? "Rp " + Convert.ToDouble(result).ToString("N0") : "Rp 0";
            }
            catch (Exception ex) { MessageBox.Show("Error Load: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void ExecuteQuery(string query, string message, bool useId)
        {
            try
            {
                conn.Open();

                // 1. CEK APAKAH NIK TERDAFTAR
                string checkNik = "SELECT COUNT(*) FROM penduduk WHERE nik = @nik";
                MySqlCommand cmdCheck = new MySqlCommand(checkNik, conn);
                cmdCheck.Parameters.AddWithValue("@nik", txtNo_nik.Text);
                long count = (long)cmdCheck.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("NIK " + txtNo_nik.Text + " tidak ditemukan di data penduduk!");
                    conn.Close(); return;
                }

                // 2. JALANKAN QUERY
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (useId && dgvDataPekerjaan.CurrentRow != null)
                    cmd.Parameters.AddWithValue("@id", dgvDataPekerjaan.CurrentRow.Cells["id_pekerjaan"].Value);

                cmd.Parameters.AddWithValue("@nik", txtNo_nik.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama_Lengkap.Text);
                cmd.Parameters.AddWithValue("@gender", (cmbGender.Text == "Laki-laki") ? "L" : "P");
                cmd.Parameters.AddWithValue("@ttl", dateTtll.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@pendidikan", txtPendidikan_Terakhirr.Text);
                cmd.Parameters.AddWithValue("@pekerjaan", cmbPekerjaann.Text);

                // 3. BERSIHKAN FORMAT RUPIAH
                string cleanPend = txtPendapatann.Text.Replace("Rp ", "").Replace(".", "").Replace(",", "");
                cmd.Parameters.AddWithValue("@pendapatan", cleanPend);

                cmd.Parameters.AddWithValue("@tanggungan", cmbJumlah_Tanggungann.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(message);
            }
            catch (Exception ex) { MessageBox.Show("Error Database: " + ex.Message); }
            finally { conn.Close(); LoadData(); btnReset_Click(null, null); }
        }

        private void btnTambahh_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pekerjaan (nik, nama_lengkap, gender, ttl, status, pendidikan_terakhir, nama_pekerjaan, pendapatan, jumlah_tanggungan) VALUES (@nik, @nama, @gender, @ttl, @status, @pendidikan, @pekerjaan, @pendapatan, @tanggungan)";
            ExecuteQuery(query, "Data berhasil ditambah!", false);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvDataPekerjaan.CurrentRow == null) return;
            string query = "UPDATE pekerjaan SET nik=@nik, nama_lengkap=@nama, gender=@gender, ttl=@ttl, status=@status, pendidikan_terakhir=@pendidikan, nama_pekerjaan=@pekerjaan, pendapatan=@pendapatan, jumlah_tanggungan=@tanggungan WHERE id_pekerjaan=@id";
            ExecuteQuery(query, "Data berhasil diubah!", true);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDataPekerjaan.CurrentRow == null) return;
            string query = "DELETE FROM pekerjaan WHERE id_pekerjaan=@id";
            ExecuteQuery(query, "Data berhasil dihapus!", true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNo_nik.Clear(); txtNama_Lengkap.Clear(); txtPendapatann.Clear();
            txtPendidikan_Terakhirr.Clear(); cmbStatus.Text = "";
            cmbPekerjaann.Text = ""; cmbJumlah_Tanggungann.Text = ""; cmbGender.Text = "";
            dateTtll.Value = DateTime.Now;
        }

        private void dgvDataPekerjaan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDataPekerjaan.Rows.Count)
            {
                DataGridViewRow row = dgvDataPekerjaan.Rows[e.RowIndex];
                txtNo_nik.Text = row.Cells["nik"]?.Value?.ToString();
                txtNama_Lengkap.Text = row.Cells["nama_lengkap"]?.Value?.ToString();
                cmbGender.Text = (row.Cells["gender"]?.Value?.ToString() == "L") ? "Laki-laki" : "Perempuan";
                if (row.Cells["ttl"].Value != DBNull.Value) dateTtll.Value = Convert.ToDateTime(row.Cells["ttl"].Value);
                cmbStatus.Text = row.Cells["status"]?.Value?.ToString();
                txtPendidikan_Terakhirr.Text = row.Cells["pendidikan_terakhir"]?.Value?.ToString();
                cmbPekerjaann.Text = row.Cells["nama_pekerjaan"]?.Value?.ToString();

                decimal p = Convert.ToDecimal(row.Cells["pendapatan"].Value);
                txtPendapatann.Text = "Rp " + p.ToString("N0");

                cmbJumlah_Tanggungann.Text = row.Cells["jumlah_tanggungan"]?.Value?.ToString();
            }
        }
    }
}