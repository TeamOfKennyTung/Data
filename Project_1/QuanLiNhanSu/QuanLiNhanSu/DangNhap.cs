using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiNhanSu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private SqlConnection con;
        DataTable dt;
        private SqlDataAdapter da = new SqlDataAdapter();
        private void connect()
        {
            try
            {
                con = new SqlConnection(ConnectDATA.getconnect());
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * From tblDangNhap Where (Taikhoan=@user) And (matkhau=@password)";
            command.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = txtTaiKhoan.Text;
            command.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txtMatKhau.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Dang nhap thanh cong");
                Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
       
    }
}
