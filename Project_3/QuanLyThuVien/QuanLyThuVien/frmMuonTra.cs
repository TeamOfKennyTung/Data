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
    public partial class frmMuonTra : Form
    {
        public frmMuonTra()
        {
            InitializeComponent();
        }
        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblMuonTra";

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (butIns.Visible == false) butDel.Enabled = butUpd.Enabled = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string temp1 = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                DateTime dt1 = Convert.ToDateTime(temp1);
                string temp2 = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                DateTime dt2 = Convert.ToDateTime(temp2);
                txtMPM.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtMDG.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtMDS.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtNM.Text = dt1.ToShortDateString();
                txtNT.Text = dt2.ToShortDateString();
            }
            else
            {
                return;
            }
        }

        private void butUpd_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("UpdMT", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@mapm", txtMPM.Text);
            sqlcm.Parameters.Add("@madg", txtMDG.Text);
            sqlcm.Parameters.Add("@mads", txtMDS.Text);
            sqlcm.Parameters.Add("@ngaymuon", txtNM.Text);
            sqlcm.Parameters.Add("@ngaytra", txtNT.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblMuonTra");
                txtNT.Text = txtNM.Text = txtMPM.Text = txtMDS.Text = txtMDG.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.MoKetNoi();
                SqlCommand sqlcm = new SqlCommand("DelMT", conn.conn);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.Add("@mapm", txtMPM.Text);
                sqlcm.Parameters.Add("@madg", txtMDG.Text);
                sqlcm.Parameters.Add("@mads", txtMDS.Text);
                sqlcm.Parameters.Add("@ngaymuon", txtNM.Text);
                sqlcm.Parameters.Add("@ngaytra", txtNT.Text);
                int check = sqlcm.ExecuteNonQuery();
                if (check > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    conn.KhoiTao(dataGridView1, @"select * from tblMuonTra");
                    txtNT.Text = txtNM.Text = txtMPM.Text = txtMDS.Text = txtMDG.Text = string.Empty;
                }
                else MessageBox.Show("Có lỗi");
                conn.DongKetNoi();
            }
        }

        private void butIns_Click(object sender, EventArgs e)
        {
            butIns.Visible = false;
            butOK.Visible = true;
            txtMDG.Text = txtMDS.Text = txtNM.Text = txtNT.Text = string.Empty;
            txtMPM.ReadOnly = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand(@"select count(mapm) from tblMuonTra", conn.conn);
            sqlcm.CommandType = CommandType.Text;
            int count = (int)sqlcm.ExecuteScalar();
            count = count + 1;
            conn.DongKetNoi();
            if (count < 10) txtMPM.Text= "PM000" + count.ToString();
            else if (count < 100 && count >= 10) txtMPM.Text = "PM00" + count.ToString();
            else if (count < 1000 && count >= 100) txtMPM.Text = "PM0" + count.ToString();
            else txtMPM.Text = "PM" + count.ToString();
            txtNM.ReadOnly = true;
            txtNM.Text = DateTime.Now.ToShortDateString();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            butOK.Visible = false; butIns.Visible = true;
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("AddMT", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@mapm", txtMPM.Text);
            sqlcm.Parameters.Add("@madg", txtMDG.Text);
            sqlcm.Parameters.Add("@mads", txtMDS.Text);
            sqlcm.Parameters.Add("@ngaymuon", txtNM.Text);
            sqlcm.Parameters.Add("@ngaytra", txtNT.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblMuonTra");
                txtMPM.Text = txtNM.Text = txtNT.Text = txtMDG.Text = txtMDS.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi");
            conn.DongKetNoi();
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("FindMT", conn.conn);
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
