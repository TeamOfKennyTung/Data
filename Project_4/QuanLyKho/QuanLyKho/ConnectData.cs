using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyKho
{
    public class ConnectData
    {
        public SqlConnection conn = new SqlConnection();
        public string constr = @"Data Source=UBUNTU;Initial Catalog=Project_4;Integrated Security=True";

        public void MoKetNoi()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.ConnectionString = constr;
                conn.Open();
            }
        }

        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void KhoiTao(DataGridView dtgv, string sqlcm)
        {
            MoKetNoi();
            SqlDataAdapter ap = new SqlDataAdapter(sqlcm, conn);
            DataTable dt = new DataTable();
            ap.Fill(dt);
            DataView dv = new DataView(dt);
            dtgv.DataSource = dv;
            DongKetNoi();
        }
    }
}
