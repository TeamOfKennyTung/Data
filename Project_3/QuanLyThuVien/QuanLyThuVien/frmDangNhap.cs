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

namespace QuanLyThuVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string str = @"select * from tblUser";

        private void butfrmMuonTra_Click(object sender, EventArgs e)
        {
            frmMuonTra frmmt = new frmMuonTra();
            frmmt.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHuongDan frmhd = new frmHuongDan();
            frmhd.ShowDialog();
        }

        private void butfrmDG_Click(object sender, EventArgs e)
        {
            frmDocGia frmdg = new frmDocGia();
            frmdg.ShowDialog();
        }

        private void butfrmSach_Click(object sender, EventArgs e)
        {
            frmSach frms = new frmSach();
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
