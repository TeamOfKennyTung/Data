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

namespace QuanLyThuVien
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblDocGia";

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (butIns.Visible == false) butDel.Enabled = butUpd.Enabled = true;
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                string temp = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                DateTime dt = Convert.ToDateTime(temp);
                txtMDG.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtTenDG.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtNS.Text = dt.ToShortDateString();
                txtGT.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            }
            else
            {
                return;
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("DelDG", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.Add("@MaDG", txtMDG.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                    txtMDG.Text = txtGT.Text = txtNS.Text = txtTenDG.Text = txtFind.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Có lỗi, không thể xóa dữ liệu");
                }
                conn.DongKetNoi();
            }
        }

        private void butUpd_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("UpdDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@MaDG", txtMDG.Text);
            sqlcm.Parameters.Add("@TenDG", txtTenDG.Text);
            sqlcm.Parameters.Add("@NgaySinh", txtNS.Text);
            sqlcm.Parameters.Add("@GioiTinh", txtGT.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtMDG.Text = txtTenDG.Text = txtNS.Text = txtGT.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void butIns_Click(object sender, EventArgs e)
        {
            butOK.Visible = true;
            butIns.Visible = false;
            txtGT.Text = txtNS.Text = txtTenDG.Text = string.Empty;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand(@"select count(MaDG) from tblDocGia", conn.conn);
            sqlcm.CommandType = CommandType.Text;
            int count = (int)sqlcm.ExecuteScalar();
            conn.DongKetNoi();
            count = count + 1;
            if (count < 10) txtMDG.Text = "DG000" + count.ToString();
            else if (count < 100 && count >= 10) txtMDG.Text = "DG00" + count.ToString();
            else if (count < 1000 && count >= 100) txtMDG.Text = "DG0" + count.ToString();
            else txtMDG.Text = "DG" + count.ToString();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            butOK.Visible = false;
            butIns.Visible = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("AddDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@tendg", txtTenDG.Text);
            sqlcm.Parameters.Add("@ngaysinh", txtNS.Text);
            sqlcm.Parameters.Add("@gioitinh", txtGT.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDocGia");
                txtMDG.Text = txtNS.Text = txtTenDG.Text = txtGT.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("FindDG", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@str", txtFind.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
            txtFind.Text = string.Empty;
            conn.DongKetNoi();
        }
    }
}
