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
namespace QuanLiNhanSu
{
    public partial class frmChiDan : Form
    {
        public frmChiDan()
        {
            InitializeComponent();
        }
       
        private void trViewGioiThieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str;
            if (trViewGioiThieu.SelectedNode.Name == "gtChung")
            {
                str = Application.StartupPath + "\\Gioithieu.mht";
                webBrowser1.Navigate(str);
            }
            if (trViewGioiThieu.SelectedNode.Name == "gtChiTiet")
            {
                str = Application.StartupPath + "\\Chitiet.mht";
                webBrowser1.Navigate(str);
            } 
        }

        private void ChiDan_Load(object sender, EventArgs e)
        {
           
        }

        private void trViewGioiThieu_Click(object sender, EventArgs e)
        {
           
        }
    }
}
