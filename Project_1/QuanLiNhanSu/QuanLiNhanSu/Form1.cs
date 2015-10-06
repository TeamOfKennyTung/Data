using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        NhanVien NV = new NhanVien();

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable dt = NV.ShowNhanVien();
            dtgNhanVien.DataSource = dt;
            cbxMaNV.DataSource = dt;
            cbxMaNV.DisplayMember = "Mã Nhân Viên";
            cbxMaPB.DataSource = dt;
            cbxMaPB.DisplayMember = "Mã Phòng Ban";
        }

        private void dtgNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            cbxMaCV.Text = dtgNhanVien.Rows[dong].Cells[0].Value.ToString();
            txtTenNV.Text = dtgNhanVien.Rows[dong].Cells[1].Value.ToString();
            dTPNgaySinh.Text = dtgNhanVien.Rows[dong].Cells[2].Value.ToString();
            cbxGT.Text = dtgNhanVien.Rows[dong].Cells[5].Value.ToString();
            txtQueQuan.Text = dtgNhanVien.Rows[dong].Cells[4].Value.ToString();
            txtLuong.Text = dtgNhanVien.Rows[dong].Cells[5].Value.ToString();
            cbxMaCV.Text = dtgNhanVien.Rows[dong].Cells[6].Value.ToString();
            cbxMaPB.Text = dtgNhanVien.Rows[dong].Cells[7].Value.ToString();
        }
<<<<<<< HEAD
        private void Init()
        {
            
        }
        private void bntThemNV_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> KennyTung94-patch-1
        
    }
}
