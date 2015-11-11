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
    public partial class frmXuatHang : Form
    {
        public frmXuatHang()
        {
            InitializeComponent();
        }

        ConnectData conn = new ConnectData();
        public string constr = @"select * from tblHangHoa";

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            conn.KhoiTao(dataGridView1, constr);
        }

        private void butXuat_Click(object sender, EventArgs e)
        {
            conn.MoKetNoi();
            SqlCommand sqlcm = new SqlCommand("DelDS", conn.conn);
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.Add("@MaHH", txtMaHH.Text);
            sqlcm.Parameters.Add("@TenHH", txtTenHH.Text);
            sqlcm.Parameters.Add("@MaNCC", txtMaNCC.Text);
            sqlcm.Parameters.Add("@SoLuong", txtSoLuong.Text);
            int check = sqlcm.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Xuất thành công");
                conn.KhoiTao(dataGridView1, @"select * from tblHangHoa");
                txtMaHH.Text = txtTenHH.Text = txtMaNCC.Text = txtSoLuong.Text = string.Empty;
            }
            else MessageBox.Show("Có lỗi, không còn hàng");
            conn.DongKetNoi();
        }

    }
}
