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
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void connect()
        {
            string cn = @"Data Source=(local);Initial Catalog=QuanLiNhanSu;Integrated Security=True";
            try
            {
                con = new SqlConnection(cn);
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
            command.CommandText = "Select * From tblDangNhap Where (name=@user) And (pass=@password)";
            command.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = txtTaiKhoan.Text;
            command.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txtMatKhau.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form frm = new frmMenu();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
       
    }
}
