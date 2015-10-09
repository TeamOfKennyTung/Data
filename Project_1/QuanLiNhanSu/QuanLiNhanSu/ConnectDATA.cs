using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    class ConnectDATA
    {
        public static string getconnect()
        {
            return (@"Data Source=LUANJR11-PC\LUANJR_SQL;Initial Catalog=QuanLiNhanSu;Integrated Security=True");
        }
    }
}
