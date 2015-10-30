using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLPhongKS
{
    public class TrangBiTB
    {
        KetNoi kn = new KetNoi();
        public DataTable ShowTrangbi()
        {
            string str = @"select MaLPhong as [Mã Loại Phòng],ID_TB as [Mã Thiết Bị],SOLUONG as [Số Lượng] from Trangbi_TB";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public string ThemTrangBi(string id_lphong, string idtb, string sl)
        {
            string str = "ThemTBTB";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_lphong", id_lphong);
            cmd.Parameters.AddWithValue("@id_tb", idtb);
            cmd.Parameters.AddWithValue("@soluong", sl);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public string SuaTrangBi(string idlphong, string idtb, string sl)
        {
            string str = "SuaTBTB";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idlphong", idlphong);
            cmd.Parameters.AddWithValue("@idtb", idtb);
            cmd.Parameters.AddWithValue("@soluong", sl);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        
        public string XoaTrangBi(string idlphong, string idtb)
        {
            string str = "XoaTBTB";
            SqlConnection con = new SqlConnection(kn.GetConnect()   );
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idlphong", idlphong);
            cmd.Parameters.AddWithValue("@idtb", idtb);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public DataTable TimKiemTBTB(string idlphong, string idtb, int chose)
        {
            string str = "TimKiemTBTB";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idphong", idlphong);
            cmd.Parameters.AddWithValue("@idtb", idtb);
            cmd.Parameters.AddWithValue("@chose", chose);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            cmd.Dispose();
            con.Close();
            return dt;
        }
    }
}
