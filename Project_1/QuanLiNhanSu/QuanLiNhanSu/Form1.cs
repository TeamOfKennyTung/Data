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
        int chose;
        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable dt = NV.ShowNhanVien();
            DataTable dt1 = NV.ShowChucVu();
            DataTable dt2 = NV.ShowPhongBan();
            dtgNhanVien.DataSource = dt;
            dtgSuaNV.DataSource = dt;

            cbxTKMaCV.DataSource = dt1;
            cbxTKMaCV.DisplayMember = "Mã Chức Vụ";
            
            cbxThemMaCV.DataSource = dt1;
            cbxThemMaCV.DisplayMember = "Mã Chức Vụ";

            cbxThemMaPB.DataSource = dt2;
            cbxThemMaPB.DisplayMember = "Mã Phòng Ban";

            cbxTKMaNV.DataSource = dt;
            cbxTKMaNV.DisplayMember = "Mã nhân viên";

            cbxTKMaCV.DataSource = dt1;
            cbxTKMaCV.DisplayMember = "Mã Chức Vụ";
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

        private void Init()
        {
            txtThemTen.Clear(); txtQueQuan.Clear();
            txtLuong.Clear(); cbxThemMaPB.Text = "";
            cbxThemGT.Text = ""; cbxThemMaCV.Text = "";
            txtThemQQ.Clear(); txtThemLuong.Clear();
        }
        private void bntLamRong_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void bntThemNV_Click(object sender, EventArgs e)
        {
            ThemNV them = new ThemNV();
            string kq = them.ThemNhanVien(txtThemTen.Text, dTPThemNS.Text, cbxThemGT.Text, txtThemQQ.Text, txtThemLuong.Text, cbxThemMaCV.Text, cbxThemMaPB.Text);
            if (kq == "2")
                MessageBox.Show("Thêm thành công");
            else
                if (kq == "0")
                    MessageBox.Show("Không có mã công việc này");
                else
                    if (kq == "1")
                        MessageBox.Show("Không có mã phòng ban");

        }

        private void bntRefreshThem_Click(object sender, EventArgs e)
        {
            DataTable dt = NV.ShowNhanVien();
            dtgThemNV.DataSource = dt;
            Init();
        }

        private void dtgSuaNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            cbxMaCV.Text = dtgSuaNV.Rows[dong].Cells[0].Value.ToString();
            txtTenNV.Text = dtgSuaNV.Rows[dong].Cells[1].Value.ToString();
            dTPNgaySinh.Text = dtgSuaNV.Rows[dong].Cells[2].Value.ToString();
            cbxGT.Text = dtgSuaNV.Rows[dong].Cells[5].Value.ToString();
            txtQueQuan.Text = dtgSuaNV.Rows[dong].Cells[4].Value.ToString();
            txtLuong.Text = dtgSuaNV.Rows[dong].Cells[5].Value.ToString();
            cbxMaCV.Text = dtgSuaNV.Rows[dong].Cells[6].Value.ToString();
            cbxMaPB.Text = dtgSuaNV.Rows[dong].Cells[7].Value.ToString();
        }

        private void bntRefreshXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = NV.ShowNhanVien();
            dtgThemNV.DataSource = dt;
            Init();
        }

        private void rBMaNV_CheckedChanged(object sender, EventArgs e)
        {
            chose = 1;
            cbxTKMaNV.Enabled = true;
            cbxTKMaCV.Enabled = false;
            txtTKTenNV.Enabled = false;
        }

        private void rBTenNV_CheckedChanged(object sender, EventArgs e)
        {
            chose = 2;
            cbxTKMaNV.Enabled = false;
            cbxTKMaCV.Enabled = false;
            txtTKTenNV.Enabled = true;
        }

        private void rBMaCV_CheckedChanged(object sender, EventArgs e)
        {
            chose = 3;
            cbxTKMaNV.Enabled = false;
            cbxTKMaCV.Enabled = true;
            txtTKTenNV.Enabled = false;
        }

        private void txtTKTenNV_Enter(object sender, EventArgs e)
        {
            TimKiemNV tk = new TimKiemNV();
            DataTable dt = tk.TimKiem(cbxTKMaNV.Text, txtTKTenNV.Text, cbxTKMaCV.Text);
            dtgTimKiem.DataSource = dt;
        }
    }
}