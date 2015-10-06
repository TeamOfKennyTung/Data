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
            return (@"Data Source=(local);Initial Catalog=QuanLiNhanSu;Integrated Security=True");
        }
    }
}
