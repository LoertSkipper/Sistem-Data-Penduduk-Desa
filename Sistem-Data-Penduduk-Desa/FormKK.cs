using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistem_Data_Penduduk_Desa
{
    public partial class FormKK : Form
    {
        // Ganti pwd sesuai dengan password database Anda jika ada
        MySqlConnection conn = new MySqlConnection("server=localhost;database=sdpd;uid=root;pwd=;");

        public FormKK()
        {
            InitializeComponent();
        }

        private void FormKK_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM kartu_keluarga";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error Load: " + ex.Message); }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }

        private void ClearInputs()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox4.Clear(); textBox5.Clear();
            comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1; comboBox4.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e) // Tambah
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO kartu_keluarga (no_kk, nama_kepala_keluarga, alamat, rt, rw, kecamatan, desa_kelurahan, kabupaten_kota, provinsi) VALUES (@no, @nama, @alamat, @rt, @rw, @kec, @desa, @kab, @prov)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@no", textBox1.Text);
                cmd.Parameters.AddWithValue("@nama", textBox2.Text);
                cmd.Parameters.AddWithValue("@alamat", textBox3.Text);
                cmd.Parameters.AddWithValue("@rt", textBox4.Text);
                cmd.Parameters.AddWithValue("@rw", textBox5.Text);
                cmd.Parameters.AddWithValue("@kec", comboBox1.Text);
                cmd.Parameters.AddWithValue("@desa", comboBox2.Text);
                cmd.Parameters.AddWithValue("@kab", comboBox3.Text);
                cmd.Parameters.AddWithValue("@prov", comboBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambah!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { conn.Close(); LoadData(); ClearInputs(); }
        }
    }
}