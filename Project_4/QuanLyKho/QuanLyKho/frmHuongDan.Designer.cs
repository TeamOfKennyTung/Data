namespace QuanLyKho
{
    partial class frmHuongDan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Giới thiệu chung về phần mềm");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nhập hàng");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Xuất hàng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tìm kiếm");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Thống kê");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hướng dẫn sử dụng", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Thông tin liên hệ");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 22);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "rGioiThieu";
            treeNode1.Text = "Giới thiệu chung về phần mềm";
            treeNode2.Name = "nDangNhap";
            treeNode2.Text = "Đăng nhập";
            treeNode3.Name = "nNhapHang";
            treeNode3.Text = "Nhập hàng";
            treeNode4.Name = "nXuatHang";
            treeNode4.Text = "Xuất hàng";
            treeNode5.Name = "nTimKiem";
            treeNode5.Text = "Tìm kiếm";
            treeNode6.Name = "nThongKe";
            treeNode6.Text = "Thống kê";
            treeNode7.Name = "rHDSD";
            treeNode7.Text = "Hướng dẫn sử dụng";
            treeNode8.Name = "rLienHe";
            treeNode8.Text = "Thông tin liên hệ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(255, 405);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(273, 22);
            this.txtHD.Multiline = true;
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(537, 405);
            this.txtHD.TabIndex = 3;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "Hướng dẫn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtHD;
    }
}