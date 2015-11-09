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

namespace Quanlisieuthi
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.HoaDon";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_Ins_Click(object sender, EventArgs e)
        {
            but_OK.Visible = true;
            but_Ins.Visible = false;
            txtHoaDon.Text = txtKhachHang.Text = txtHangHoa.Text = txtNhanVien.Text = String.Empty;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand(@"select count(MaDG) from tblDocGia", conn.conn);
            sqlcm.CommandType = CommandType.Text;
            int count = (int)sqlcm.ExecuteScalar();
            conn.DongKetNoi();
            count = count + 1;
            if (count < 10) txtID.Text = "HD000" + count.ToString();
            else if (count < 100 && count >= 10) txtID.Text = "HD00" + count.ToString();
            else if (count < 1000 && count >= 100) txtID.Text = "HD0" + count.ToString();
            else txtID.Text = "HD" + count.ToString();
        }

        private void but_Up_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("UpdDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@hoadon", txtHoaDon.Text);
            sqlcm.Parameters.Add("@khachhang", txtKhachHang.Text);
            sqlcm.Parameters.Add("@hanghoa", txtHangHoa.Text);
            sqlcm.Parameters.Add("@nhanvien", txtNhanVien.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtID.Text = txtHoaDon.Text = txtKhachHang.Text = txtHangHoa.Text = txtNhanVien.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("DelID", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.Add("@ID", txtID.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đã bán thành công");
                    conn.KhoiTao(dataGridView1, @"select * from dbo.HoaDon");
                    txtID.Text = txtHoaDon.Text = txtKhachHang.Text = txtHangHoa.Text = txtNhanVien.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa hóa đơn");
                }
                conn.DongKetNoi();
            }
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("FindHD", conn.conn);
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

        private void but_OK_Click(object sender, EventArgs e)
        {
            but_OK.Visible = false;
            but_Ins.Visible = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("AddDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@hoadon", txtHoaDon.Text);
            sqlcm.Parameters.Add("@khachhang", txtKhachHang.Text);
            sqlcm.Parameters.Add("@hanghoa", txtHangHoa.Text);
            sqlcm.Parameters.Add("@nhanvien", txtNhanVien.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtID.Text = txtHoaDon.Text = txtKhachHang.Text = txtHangHoa.Text = txtNhanVien.Text = txtFind.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtHoaDon.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtKhachHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtHangHoa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtNhanVien.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }
            else { return; }
        }
    }
}
