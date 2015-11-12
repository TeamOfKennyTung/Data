using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblHangHoa";

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void butIns_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("NhapMoi", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@MaHH", txtMaHH.Text);
            sqlcm.Parameters.Add("@TenHH", txtTenHH.Text);
            sqlcm.Parameters.Add("@MaNCC", txtMaNCC.Text);
            sqlcm.Parameters.Add("@Soluong", txtSoLuong.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblHangHoa");
                txtMaHH.Text = txtTenHH.Text = txtMaNCC.Text = txtSoLuong.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void butUpd_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("NhapThem", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@MaHH", txtMaHH.Text);
            sqlcm.Parameters.Add("@TenHH", txtTenHH.Text);
            sqlcm.Parameters.Add("@MaNCC", txtMaNCC.Text);
            sqlcm.Parameters.Add("@SoLuong", txtSoLuong.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Nhập thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblHangHoa");
                txtMaHH.Text = txtTenHH.Text = txtMaNCC.Text = txtSoLuong.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.DongKetNoi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                string temp = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                DateTime dt = Convert.ToDateTime(temp);
                txtMaHH.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtTenHH.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtMaNCC.Text = dt.ToShortDateString();
                txtSoLuong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            }
            else
            {
                return;
            }
        }

    }
}
