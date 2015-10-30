using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiNhanSu
{
    class XoaNV
    {
        public string XoaNhanVien(string manv)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            string str = "XoaNhanVien";
=======
            string str = "ThemNhanVien";
>>>>>>> master
=======
            string str = "XoaNhanVien";
>>>>>>> origin/master
            SqlConnection con = new SqlConnection(ConnectDATA.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
<<<<<<< HEAD
<<<<<<< HEAD
            cmd.Parameters["@manv"].Direction = ParameterDirection.Input;
=======
            cmd.Parameters["@ten"].Direction = ParameterDirection.Input;
>>>>>>> master
=======
            cmd.Parameters["@manv"].Direction = ParameterDirection.Input;
>>>>>>> origin/master
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            con.Close();
            cmd.Dispose();
            return kq;
        }
    }
}
