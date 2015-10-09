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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblDauSach";
        private void frmSach_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (butIns.Visible == false) butDel.Enabled = butUpd.Enabled = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtMDS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtTenDS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtGB.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            }
            else
            {
                return;
            }
        }

        private void butUpd_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("UpdDS", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@mads", txtMDS.Text);
            sqlcm.Parameters.Add("@tends", txtTenDS.Text);
            sqlcm.Parameters.Add("@giaban", txtGB.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDauSach");
                txtGB.Text = txtMDS.Text = txtTenDS.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi, không thể sửa dữ liệu");
            conn.DongKetNoi();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("DelDS", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.Add("@mads", txtMDS.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    conn.KhoiTao(dataGridView1, @"select * from tblDauSach");
                    txtGB.Text = txtMDS.Text = txtTenDS.Text = string.Empty;
                }
                else MessageBox.Show("Có lỗi, không thể sửa dữ liệu");
                conn.DongKetNoi();
            }
        }

        private void butIns_Click(object sender, EventArgs e)
        {
            butIns.Visible = false;
            butOK.Visible = true;
            txtGB.Text = txtTenDS.Text = string.Empty; 
            txtMDS.ReadOnly = true;
            SqlCommand sqlcm = new SqlCommand(@"select count(MaDS) from tblDauSach", conn.conn);
            sqlcm.CommandType = CommandType.Text;
            conn.MoKetNoi();
            int count = (int)sqlcm.ExecuteScalar();
            count = count + 1;
            conn.DongKetNoi();
            if (count < 10) txtMDS.Text = "DS000" + count.ToString();
            else if (count < 100 && count >=10) txtMDS.Text = "DS00" + count.ToString();
            else if (count < 1000 && count >=100) txtMDS.Text = "DS0" + count.ToString();
            else txtMDS.Text = "DS" + count.ToString();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            butIns.Visible = true;
            butOK.Visible = false;
            txtGB.Text = txtMDS.Text = txtTenDS.Text = string.Empty;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("AddDS", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@tends", txtTenDS.Text);
            sqlcm.Parameters.Add("@giaban", txtGB.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblDauSach");
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("FindDS", conn.conn);
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
