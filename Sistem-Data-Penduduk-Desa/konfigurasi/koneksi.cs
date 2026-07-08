using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistem_Data_Penduduk_Desa.konfigurasi
{
    internal class Koneksi : Konfigurasi
    {
        MySqlConnection _conn;
        MySqlCommand _com;
        MySqlDataAdapter _adapter;
        //static string[] data = Setting.ambilSetting("setting.txt");
        string _link = "server=localhost;database=sdpd;port=3306;username=root;password=";
        public Koneksi()
        {
            _conn = new MySqlConnection(_link);
            _com = new MySqlCommand();
            _adapter = new MySqlDataAdapter();
        }
        void bukaKoneksi()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error membuka koneksi: " + ex.Message);

            }
        }
        void tutupKoneksi()
        {
            _conn.Close();
        }
        public override int eksekusiNonQuery(string query)
        {
            int nilai = -1;
            try
            {
                bukaKoneksi();
                _com.Connection = _conn;
                _com.CommandText = query;
                nilai = _com.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                tutupKoneksi();
            }
            return nilai;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable nilai = new DataTable();
            try
            {
                bukaKoneksi();
                _com.Connection = _conn;
                _com.CommandText = query;
                _adapter.SelectCommand = _com;
                _adapter.Fill(nilai);
            }
            catch (Exception)
            {
            }
            finally
            {
                tutupKoneksi();
            }
            return nilai;
        }
    }
}
