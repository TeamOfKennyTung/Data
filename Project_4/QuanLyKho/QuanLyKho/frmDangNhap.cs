using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string str = @"select * from tblUser";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHuongDan frmhd = new frmHuongDan();
            frmhd.ShowDialog();
        }

        private void butfrmNhap_Click(object sender, EventArgs e)
        {
            frmNhapHang frmmt = new frmNhapHang();
            frmmt.ShowDialog();
        }

        private void butfrmXuat_Click(object sender, EventArgs e)
        {
            frmXuatHang frmdg = new frmXuatHang();
            frmdg.ShowDialog();
        }

        private void butfrmTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frms = new frmTimKiem();
            frms.ShowDialog();
        }

        private void butfrmThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frms = new frmThongKe();
            frms.ShowDialog();
        }

        private void butJoin_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == txtUser.Text && row[1].ToString() == txtPass.Text)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    break;
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ");
                    break;
                }

            }
            txtPass.Text = txtUser.Text = string.Empty;
            conn.DongKetNoi();
        }

        
        

    }
}
