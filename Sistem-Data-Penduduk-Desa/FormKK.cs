using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormKK : Form
    {
        string connString = "server=localhost;user=root;password=;database=sdpd";
        MySqlConnection conn;

        public FormKK()
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

                string query = "SELECT * FROM kartu_keluarga";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDataKK.DataSource = dt;

                // Memperbarui nilai pada Label yang Anda inginkan
                angkatotal.Text = dt.Rows.Count.ToString();

                string queryBaru = "SELECT COUNT(*) FROM kartu_keluarga";
                MySqlCommand cmdBaru = new MySqlCommand(queryBaru, conn);
                object result = cmdBaru.ExecuteScalar();
                angkadata.Text = (result != null) ? result.ToString() : "0";
            }
            catch (Exception ex) { MessageBox.Show("Error Load: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void ExecuteQuery(string query, string message, bool useId)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (useId && dgvDataKK.CurrentRow != null)
                    cmd.Parameters.AddWithValue("@id", dgvDataKK.CurrentRow.Cells["id_kk"].Value);

                cmd.Parameters.AddWithValue("@nokk", txtNoKK.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama_kepala_keluarga.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("@rt", txtRT.Text);
                cmd.Parameters.AddWithValue("@rw", txtRW.Text);
                cmd.Parameters.AddWithValue("@kec", txtKecamatan.Text);
                cmd.Parameters.AddWithValue("@desa", txtDesa_kelurahan.Text);
                cmd.Parameters.AddWithValue("@kab", txtKabupaten_kota.Text);
                cmd.Parameters.AddWithValue("@prov", txtProvinsi.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show(message);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { conn.Close(); LoadData(); btnReset_Click(null, null); }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO kartu_keluarga (no_kk, nama_kepala_keluarga, alamat, rt, rw, kecamatan, desa_kelurahan, kabupaten_kota, provinsi) VALUES (@nokk, @nama, @alamat, @rt, @rw, @kec, @desa, @kab, @prov)";
            ExecuteQuery(query, "Data berhasil ditambah!", false);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvDataKK.CurrentRow == null) return;
            string query = "UPDATE kartu_keluarga SET no_kk=@nokk, nama_kepala_keluarga=@nama, alamat=@alamat, rt=@rt, rw=@rw, kecamatan=@kec, desa_kelurahan=@desa, kabupaten_kota=@kab, provinsi=@prov WHERE id_kk=@id";
            ExecuteQuery(query, "Data berhasil diubah!", true);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDataKK.CurrentRow == null) return;
            string query = "DELETE FROM kartu_keluarga WHERE id_kk=@id";
            ExecuteQuery(query, "Data berhasil dihapus!", true);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text)) { LoadData(); return; }
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string query = "SELECT * FROM kartu_keluarga WHERE no_kk LIKE @key OR nama_kepala_keluarga LIKE @key";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@key", "%" + txtCari.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDataKK.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error Cari: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNoKK.Clear(); txtNama_kepala_keluarga.Clear(); txtAlamat.Clear();
            txtRT.Clear(); txtRW.Clear(); txtKecamatan.Clear();
            txtDesa_kelurahan.Clear(); txtKabupaten_kota.Clear(); txtProvinsi.Clear();
            txtCari.Clear();
        }

        private void dgvDataKK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDataKK.Rows.Count)
            {
                DataGridViewRow row = dgvDataKK.Rows[e.RowIndex];
                txtNoKK.Text = row.Cells["no_kk"]?.Value?.ToString() ?? "";
                txtNama_kepala_keluarga.Text = row.Cells["nama_kepala_keluarga"]?.Value?.ToString() ?? "";
                txtAlamat.Text = row.Cells["alamat"]?.Value?.ToString() ?? "";
                txtRT.Text = row.Cells["rt"]?.Value?.ToString() ?? "";
                txtRW.Text = row.Cells["rw"]?.Value?.ToString() ?? "";
                txtKecamatan.Text = row.Cells["kecamatan"]?.Value?.ToString() ?? "";
                txtDesa_kelurahan.Text = row.Cells["desa_kelurahan"]?.Value?.ToString() ?? "";
                txtKabupaten_kota.Text = row.Cells["kabupaten_kota"]?.Value?.ToString() ?? "";
                txtProvinsi.Text = row.Cells["provinsi"]?.Value?.ToString() ?? "";
            }
        }

        // Event yang Anda minta
        private void angkatotal_Click(object sender, EventArgs e) { }
        private void angkadata_Click(object sender, EventArgs e) { }

        private void panelstatistikringkas_kk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormKK_Load(object sender, EventArgs e)
        {

        }

        private void lblJuduul_Click(object sender, EventArgs e)
        {

        }

        private void panelinput_kk_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}