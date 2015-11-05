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
                pAcc.Enabled = true;
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
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }          
        }
    }
}
