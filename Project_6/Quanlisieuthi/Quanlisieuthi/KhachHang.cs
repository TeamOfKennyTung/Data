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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.KhachHang";

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_Ins_Click(object sender, EventArgs e)
        {
            but_OK.Visible = true;
            but_Ins.Visible = false;
            txtTen.Text = txtSDT.Text = txtGT.Text = String.Empty;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand(@"select count(MaDG) from tblDocGia", conn.conn);
            sqlcm.CommandType = CommandType.Text;
            int count = (int)sqlcm.ExecuteScalar();
            conn.DongKetNoi();
            count = count + 1;
            if (count < 10) txtID.Text = "KH000" + count.ToString();
            else if (count < 100 && count >= 10) txtID.Text = "KH00" + count.ToString();
            else if (count < 1000 && count >= 100) txtID.Text = "KH0" + count.ToString();
            else txtID.Text = "KH" + count.ToString();
        }

        private void but_Up_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("UpdDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@tenkhachhang", txtTen.Text);
            sqlcm.Parameters.Add("@SDT", txtSDT.Text);
            sqlcm.Parameters.Add("@gioitinh", txtGT.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtID.Text = txtTen.Text = txtSDT.Text = txtGT.Text = String.Empty;
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
                    txtID.Text = txtTen.Text = txtSDT.Text = txtGT.Text = txtFind.Text = string.Empty;
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
            SqlCommand sqlcm = new SqlCommand("FindKH", conn.conn);
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
            sqlcm.Parameters.Add("@tenkhachhang", txtTen.Text);
            sqlcm.Parameters.Add("@SDT", txtSDT.Text);
            sqlcm.Parameters.Add("@gioitinh", txtGT.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtID.Text = txtTen.Text = txtSDT.Text = txtGT.Text = txtFind.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtTen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtSDT.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtGT.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            }
            else
            {
                return;
            }
        }
    }
}
