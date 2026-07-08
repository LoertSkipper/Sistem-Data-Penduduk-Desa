using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormPekerjaan : Form
    {
        // Variabel koneksi database
        string connString = "server=localhost;user=root;password=;database=sdpd";
        MySqlConnection conn;

        public FormPekerjaan()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
            LoadData();
        }

        // 1. FUNGSI UNTUK MENAMPILKAN DATA DARI DATABASE KE TABEL (DATA GRID VIEW)
        private void LoadData()
        {
            try
            {
                if (conn.State != ConnectionState.Closed) conn.Close();
                conn.Open();

                string query = "SELECT * FROM pekerjaan";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDataPekerjaan.DataSource = dt;
                lblAngkatotal.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // 2. FUNGSI UTAMA KONEKSI CRUD (CREATE, UPDATE, DELETE)
        private void ExecuteQuery(string query, string pesan, bool pakaiId, bool pakaiInput)
        {
            try
            {
                if (conn.State != ConnectionState.Closed) conn.Close();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Jika query butuh ID (Ubah & Hapus)
                if (pakaiId)
                {
                    if (dgvDataPekerjaan.CurrentRow != null)
                    {
                        cmd.Parameters.AddWithValue("@id", dgvDataPekerjaan.CurrentRow.Cells["id_pekerjaan"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Pilih data pada tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Jika query butuh input dari TextBox (Tambah & Ubah)
                if (pakaiInput)
                {
                    cmd.Parameters.AddWithValue("@nama", txtNama_pekerjaan.Text);
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat eksekusi data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                LoadData(); // Refresh tabel otomatis setelah query selesai
                btnReset_Click(null, EventArgs.Empty); // Form otomatis kosong setelah input/ubah/hapus
            }
        }

        // 3. BUTTON TAMBAH DATA
        private void btnTambahh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama_pekerjaan.Text.Trim()))
            {
                MessageBox.Show("Nama pekerjaan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO pekerjaan (nama_pekerjaan) VALUES (@nama)";
            ExecuteQuery(query, "Data berhasil ditambah.", false, true);
        }

        // 4. BUTTON UBAH DATA
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvDataPekerjaan.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diubah pada tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNama_pekerjaan.Text.Trim()))
            {
                MessageBox.Show("Nama pekerjaan baru tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "UPDATE pekerjaan SET nama_pekerjaan=@nama WHERE id_pekerjaan=@id";
            ExecuteQuery(query, "Data berhasil diubah.", true, true);
        }

        // 5. BUTTON HAPUS DATA
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvDataPekerjaan.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus pada tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM pekerjaan WHERE id_pekerjaan=@id";
                ExecuteQuery(query, "Data berhasil dihapus.", true, false);
            }
        }

        // 6. BUTTON RESET (Mengosongkan form inputan)
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama_pekerjaan.Clear();
            txtCari.Clear(); // Menghapus kolom pencarian juga jika ada
        }

        // 7. EVENT KLIK TABEL
        private void dgvDataPekerjaan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDataPekerjaan.Rows[e.RowIndex];
                if (row.Cells["nama_pekerjaan"].Value != null)
                {
                    txtNama_pekerjaan.Text = row.Cells["nama_pekerjaan"].Value.ToString();
                }
            }
        }
    }
}