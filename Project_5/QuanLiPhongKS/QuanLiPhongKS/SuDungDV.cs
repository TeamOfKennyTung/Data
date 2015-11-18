using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLPhongKS
{
    class SuDungDV
    {
        KetNoi kn = new KetNoi();
        public DataTable ShowDichVu()
        {
            string str = @"select SoPhong as [Số phòng],MaDV as [Mã Dịch Vụ],Soluong as [Số Lượng],ngaysd as [Ngày sử dụng]
                from tblTrangbiTB";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ShowMaDV()
        {
            string str = @"select MaDV as [madv] from tblDichVuPhong";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ShowPhong()
        {
            string str = @"select SoPhong as [sophong] from tblPhong where HienTrang='Đã thuê'";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;

        }
        public string ThemSuDungDV(int idphong, string iddv, string sl,string ngaysd)
        {
            string str = "ThemSDDV";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_lphong", idphong);
            cmd.Parameters.AddWithValue("@id_tb", iddv);
            cmd.Parameters.AddWithValue("@soluong", sl);
            cmd.Parameters.AddWithValue("@ngaysd", Convert.ToDateTime(ngaysd));
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public string SuaSuDungDV(int idphong, string idtb, string sl,string ngaysd)
        {
            string str = "SuaSDDV";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idlphong", idphong);
            cmd.Parameters.AddWithValue("@idtb", idtb);
            cmd.Parameters.AddWithValue("@soluong", sl);
            cmd.Parameters.AddWithValue("@ngaysd",Convert.ToDateTime(ngaysd));
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }

        public string XoaTrangBi(int idphong, string idtb)
        {
            string str = "XoaSDDV";
            SqlConnection con = new SqlConnection(kn.GetConnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_phong", idphong);
            cmd.Parameters.AddWithValue("@id_dv", idtb);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
    }
}
