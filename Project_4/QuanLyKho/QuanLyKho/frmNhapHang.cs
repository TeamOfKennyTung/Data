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
        public string consql = @"Data Source=UBUNTU;Initial Catalog=Project_4;Integrated Security=True";        

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dgv_Hanghoa, constr);
        }

        private void butIns_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("NhapMoi", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@TenHH", txtTenHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
            sqlcm.Parameters.AddWithValue("@Soluong", txtSoLuong.Text.Trim());
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công");
                conn.KhoiTao(dgv_Hanghoa, @"select * from tblHangHoa");
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
            sqlcm.Parameters.AddWithValue("@MaHH", txtMaHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@TenHH", txtTenHH.Text.Trim());
            sqlcm.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
            sqlcm.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text.Trim());
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Nhập thành công");
                conn.KhoiTao(dgv_Hanghoa, @"select * from tblHangHoa");
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
                string temp = Convert.ToString(dgv_Hanghoa.CurrentRow.Cells[2].Value);
                //DateTime dt = Convert.ToDateTime(temp);
                txtMaHH.Text = Convert.ToString(dgv_Hanghoa.CurrentRow.Cells[0].Value);
                txtTenHH.Text = Convert.ToString(dgv_Hanghoa.CurrentRow.Cells[1].Value);
                txtMaNCC.Text = Convert.ToString(dgv_Hanghoa.CurrentRow.Cells[2].Value);
                txtSoLuong.Text = Convert.ToString(dgv_Hanghoa.CurrentRow.Cells[3].Value);
            }
            else
            {
                return;
            }
        }
        /*ham nay dung de xoa cac thong tin tren muc*/
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtMaNCC.Text = "";
            txtSoLuong.Text = "";
        }
        /*Hien thi du lieu cua bang Hang hoa len Form*/
        private void btn_Load_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(consql);
            //SqlCommand com = new SqlCommand();
            //com.CommandText = "LoadHangHoa";
            //com.CommandType = CommandType.StoredProcedure;
            //com.Connection = cn;
            //SqlDataAdapter adap = new SqlDataAdapter(com);
            //DataTable dt = new DataTable();
            //adap.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    dgv_Hanghoa.DataSource = dt;
            //}
            //else
            //{
            //    MessageBox.Show("Data is empty!");
            //}
            //conn.DongKetNoi();
        }

    }
}
