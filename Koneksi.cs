using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POSS
{
    class Koneksi
    {
        public static SqlConnection Connect = new SqlConnection("Data Source = 127.0.0.1; Database = dbPOS; UID = sa; password = Auruman1.");
    }
}
