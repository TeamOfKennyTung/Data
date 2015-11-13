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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        ConnectData con = new ConnectData();        
        public string constr = @"Data Source=UBUNTU;Initial Catalog=Project_4;Integrated Security=True";        

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(constr);
            SqlCommand com = new SqlCommand();
            com.CommandText = "ThongKeNhap";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = cn;
            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgv_thongke.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data is empty!");               
            }
            con.DongKetNoi();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(constr);
            SqlCommand com = new SqlCommand();
            com.CommandText = "ThongKeXuat";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = cn;
            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dgv_thongke.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data is empty!");
            }
            con.DongKetNoi();
        }

    }
}
