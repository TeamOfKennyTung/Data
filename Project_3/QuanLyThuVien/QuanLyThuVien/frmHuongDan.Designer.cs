namespace QuanLyThuVien
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Thêm mới");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Chỉnh sửa");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Xóa");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tìm kiếm");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hướng dẫn sử dụng", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Thông tin liên hệ");
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 442);
            this.panel1.TabIndex = 0;
            // 
            // txtHD
            // 
            this.txtHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHD.Location = new System.Drawing.Point(0, 0);
            this.txtHD.Multiline = true;
            this.txtHD.Name = "txtHD";
            this.txtHD.ReadOnly = true;
            this.txtHD.Size = new System.Drawing.Size(377, 442);
            this.txtHD.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 442);
            this.panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "rGioiThieu";
            treeNode1.Text = "Giới thiệu chung về phần mềm";
            treeNode2.Name = "nDangNhap";
            treeNode2.Text = "Đăng nhập";
            treeNode3.Name = "nadd";
            treeNode3.Text = "Thêm mới";
            treeNode4.Name = "nfix";
            treeNode4.Text = "Chỉnh sửa";
            treeNode5.Name = "ndel";
            treeNode5.Text = "Xóa";
            treeNode6.Name = "nfind";
            treeNode6.Text = "Tìm kiếm";
            treeNode7.Name = "rHDSD";
            treeNode7.Text = "Hướng dẫn sử dụng";
            treeNode8.Name = "rLienHe";
            treeNode8.Text = "Thông tin liên hệ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7,
            treeNode8});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(241, 442);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHuongDan";
            this.ShowIcon = false;
            this.Text = "Hướng Dẫn";
            this.Load += new System.EventHandler(this.frmHuongDan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtHD;
    }
}