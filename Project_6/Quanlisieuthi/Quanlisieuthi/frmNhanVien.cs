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

namespace Quanlisieuthi
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.NhanVien";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_Ins_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("InsNhanVien", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@hoten", txtHoTen.Text);
            sqlcm.Parameters.Add("@quequan", txtQueQuan.Text);
            sqlcm.Parameters.Add("@gioitinh", txtGioiTinh.Text);
            sqlcm.Parameters.Add("@CMND", txtCMND.Text);
            sqlcm.Parameters.Add("@ngaysinh", txtNgaySinh.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtGioiTinh.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("DelID", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.Add("@ID", txtID.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đã bán thành công");
                    conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                    txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtGioiTinh.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa dữ liệu");
                }
                conn.DongKetNoi();
            }
        }

        private void but_Find_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("FindNV", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@str", txtFind.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            if (dataGridView1.RowCount <= 0) MessageBox.Show("Nội dung cần tìm không có");
            txtFind.Text = string.Empty;
            conn.DongKetNoi();
        }

        private void but_Up_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("UpdDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@hoten", txtHoTen.Text);
            sqlcm.Parameters.Add("@quequan", txtQueQuan.Text);
            sqlcm.Parameters.Add("@ngioitinh", txtGioiTinh.Text);
            sqlcm.Parameters.Add("@CMND", txtCMND.Text);
            sqlcm.Parameters.Add("@ngaysinh", txtNgaySinh.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from dbo.NhanVien");
                txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtGioiTinh.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            but_OK.Visible = false;
            but_Ins.Visible = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("AddDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@hoten", txtHoTen.Text);
            sqlcm.Parameters.Add("@quequan", txtQueQuan.Text);
            sqlcm.Parameters.Add("@ngioitinh", txtGioiTinh.Text);
            sqlcm.Parameters.Add("@CMND", txtCMND.Text);
            sqlcm.Parameters.Add("@ngaysinh", txtNgaySinh.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtID.Text = txtHoTen.Text = txtQueQuan.Text = txtGioiTinh.Text = txtCMND.Text = txtGioiTinh.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }
    }

}