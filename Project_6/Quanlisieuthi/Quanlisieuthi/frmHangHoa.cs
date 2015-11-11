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
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string constr = @"select * from dbo.HangHoa";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void but_Find_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("timkienhanghoa", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@tim", txtFind.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            if (dataGridView1.RowCount <= 0) MessageBox.Show("Nội dung cần tìm không có");
            txtFind.Text = string.Empty;
            conn.DongKetNoi();
        }

        private void but_Nhap_Click(object sender, EventArgs e)
        {
            but_OK.Visible = true;
            but_Nhap.Visible = false;
            txtTenHang.Text = txtGiaHang.Text = txtNgayNhap.Text = txtHanSuDung.Text = String.Empty;
            dataGridView1.Enabled = false;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand(@"select count(ID_HangHoa) from HangHoa", conn.conn);
            sqlcm.CommandType = CommandType.Text;
            int count = (int)sqlcm.ExecuteScalar();
            conn.DongKetNoi();
            count = count + 1;
            if (count < 10) txtID.Text = "HH000" + count.ToString();
            else if (count < 100 && count >= 10) txtID.Text = "HH00" + count.ToString();
            else if (count < 1000 && count >= 100) txtID.Text = "HH0" + count.ToString();
            else txtID.Text = "HH" + count.ToString();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            but_OK.Visible = false;
            but_Nhap.Visible = true;
            dataGridView1.Enabled = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("Add_HangHoa", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
            sqlcm.Parameters.AddWithValue("@GiaHang", txtGiaHang.Text);
            sqlcm.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Text);
            sqlcm.Parameters.AddWithValue("@HanSd", txtHanSuDung.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from dbo.HangHoa");
                txtID.Text = txtTenHang.Text = txtGiaHang.Text = txtNgayNhap.Text = txtHanSuDung.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void but_Ban_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("Delete_HangHoa", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@ID_HangHoa", txtID.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Đã bán thành công");
                    conn.KhoiTao(dataGridView1, @"select * from dbo.HangHoa");
                    txtID.Text = txtTenHang.Text = txtGiaHang.Text = txtNgayNhap.Text = txtHanSuDung.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa dữ liệu");
                }
                conn.DongKetNoi();
            }
        }

        private void but_ThemHang_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("Edit_HangHoa", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
<<<<<<< HEAD
            sqlcm.Parameters.AddWithValue("@id_hanghoa", txtID.Text);
            sqlcm.Parameters.AddWithValue("@TenHang", txtTenHang.Text);
            sqlcm.Parameters.AddWithValue("@GiaHang", txtGiaHang.Text);
            sqlcm.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Text);
            sqlcm.Parameters.AddWithValue("@HanSd", txtHanSuDung.Text);
=======
            sqlcm.Parameters.Add("@id_hanghoa", txtID.Text);
            sqlcm.Parameters.Add("@TenHang", txtTenHang.Text);
            sqlcm.Parameters.Add("@GiaHang", txtGiaHang.Text);
            sqlcm.Parameters.Add("@NgayNhap", txtNgayNhap.Text);
            sqlcm.Parameters.Add("@HanSd", txtHanSuDung.Text);
>>>>>>> origin/master
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from HangHoa");
                txtID.Text = txtTenHang.Text = txtGiaHang.Text = txtNgayNhap.Text = txtHanSuDung.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (but_Nhap.Visible == false) but_Ban.Enabled = but_ThemHang.Enabled = true;
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                string temp = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                DateTime dt = Convert.ToDateTime(temp);
                String temp1 = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                DateTime dt1 = Convert.ToDateTime(temp1);
                txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtTenHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtGiaHang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtNgayNhap.Text = dt.ToShortDateString();
                txtHanSuDung.Text = dt1.ToShortDateString();

            }
           
        }
    }
}



