using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem_Data_Penduduk_Desa.konfigurasi
{
    internal class Setting
    {
        public static string[] ambilSetting(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
