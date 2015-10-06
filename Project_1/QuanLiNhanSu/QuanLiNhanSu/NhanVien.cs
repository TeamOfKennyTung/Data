using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLiNhanSu
{
    public class NhanVien
    {
        public DataTable ShowNhanVien()
        {
            string str = @"select MaNV as [Mã Nhân Viên], TenNV as [Tên Nhân Viên],NgaySinh as [Ngày Sinh],
            GioiTinh as [Giới tính],QueQuan as [Quê Quán],Luong as [Lương],MaCV as [Mã Chức Vụ],
            MaPB as [Mã Phòng Ban] from tblNhanVien";
            SqlConnection con = new SqlConnection(ConnectDATA.getconnect());
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
<<<<<<< HEAD
        public string ThemNV(string tennv,string ngaysinh,string gioitinh,string quequan,string luong,string macv,string mapb)
        {
            string str = "ThemNhanVien";
            SqlConnection con = new SqlConnection(ConnectDATA.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", tennv);
            cmd.Parameters["@ten"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ns", ngaysinh);
            cmd.Parameters["@ns"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@gt", gioitinh);
            cmd.Parameters["@gt"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@qq", quequan);
            cmd.Parameters["@qq"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@l", luong);
            cmd.Parameters["@l"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@macv", macv);
            cmd.Parameters["@macv"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@mapb", mapb);
            cmd.Parameters["@mapb"].Direction = ParameterDirection.Input;
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            con.Close();
            cmd.Dispose();
            return kq;
        }
        public string SuaNV(string manv,string tennv, string ngaysinh, string gioitinh, string quequan, string luong, string macv, string mapb)
        {
            string str = "SuaNhanVien";
            SqlConnection con = new SqlConnection(ConnectDATA.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@ten", tennv);
            cmd.Parameters.AddWithValue("@ns", ngaysinh);
            cmd.Parameters.AddWithValue("@gt", gioitinh);
            cmd.Parameters.AddWithValue("@qq", quequan);
            cmd.Parameters.AddWithValue("@l", luong);
            cmd.Parameters.AddWithValue("@macv", macv);
            cmd.Parameters.AddWithValue("@mapb", mapb);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
        public DataTable Timkiem(string tennv, string mapb, string quequan,int chose)
        {
            string str = "TimKiemNhanVien";
            SqlConnection con = new SqlConnection(ConnectDATA.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten",tennv );
            cmd.Parameters.AddWithValue("@mapb", mapb);
            cmd.Parameters.AddWithValue("@quequan", quequan);
            cmd.Parameters.AddWithValue("@chose", chose);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public string XoaNV(string manv)
        {
            string str = "XoaNhanVien";
            SqlConnection con = new SqlConnection(ConnectDATA.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            SqlParameter para = new SqlParameter("@kq", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            string kq = para.Value.ToString();
            cmd.Dispose();
            con.Close();
            return kq;
        }
=======
>>>>>>> KennyTung94-patch-1
    }
}
