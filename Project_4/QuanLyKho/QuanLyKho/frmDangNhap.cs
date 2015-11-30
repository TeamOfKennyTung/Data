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

        public void butJoin_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(str, conn.conn);
            DataTable dt = new DataTable();            
            da.Fill(dt);
            bool check = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == txtUser.Text && row[1].ToString() == txtPass.Text)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            if (check == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                txtPass.ReadOnly = txtUser.ReadOnly = true;
                panel1.Enabled = true;
                txtPass.Text = "";
                txtUser.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ");
                txtUser.Text = txtPass.Text = string.Empty;
            }
            conn.DongKetNoi();

        }

        private void butQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }            
    }
}
