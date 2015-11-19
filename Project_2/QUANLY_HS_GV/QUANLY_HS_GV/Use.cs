using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QUANLY_HS_GV
{
    public partial class frmUse : Form
    {
        OpenFileDialog mo = new OpenFileDialog();
        
        public frmUse()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            //mo.InitialDirectory = @"F:\";
            //mo.Filter = "|*mht;*docx;*doc";
            //if (mo.ShowDialog() == DialogResult.OK)
            //{
            //    webBrowser1.Show();
            //}
            System.Diagnostics.Process.Start("Hocsinh_Giaovien.mht");
        }
    }
}
