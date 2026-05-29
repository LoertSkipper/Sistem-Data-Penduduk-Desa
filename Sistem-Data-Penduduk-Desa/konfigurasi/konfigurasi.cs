using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Data_Penduduk_Desa.konfigurasi
{
    abstract class Konfigurasi
    {
        public abstract int eksekusiNonQuery(string query);

        public abstract DataTable eksekusiQuery(string query);
    }
    
}
