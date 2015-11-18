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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuHocsinh_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.Show();
        }

        private void mnuGiaovien_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            //Login tg = new Login();
            //tg.Show();
        }

        private void mnuhelp_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog mo = new OpenFileDialog();
            mo.ShowDialog();
            mo.Filter = "mht file|*.mht";
        }
    }
}
