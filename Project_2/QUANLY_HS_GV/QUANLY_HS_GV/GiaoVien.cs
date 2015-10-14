using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_HS_GV
{
    public partial class GiaoVien : Form
    {
        public GiaoVien()
        {
            InitializeComponent();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLY_HS_GVDataSet1.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qUANLY_HS_GVDataSet1.GiaoVien);

        }
    }
}
