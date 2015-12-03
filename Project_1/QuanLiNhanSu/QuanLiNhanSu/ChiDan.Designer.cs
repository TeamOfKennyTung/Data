namespace QuanLiNhanSu
{
    partial class frmChiDan
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Giới thiệu chung");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Giới thiệu chi tiết");
            this.trViewGioiThieu = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // trViewGioiThieu
            // 
            this.trViewGioiThieu.Location = new System.Drawing.Point(12, 12);
            this.trViewGioiThieu.Name = "trViewGioiThieu";
            treeNode3.Name = "gtChung";
            treeNode3.Text = "Giới thiệu chung";
            treeNode4.Name = "gtChiTiet";
            treeNode4.Text = "Giới thiệu chi tiết";
            this.trViewGioiThieu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.trViewGioiThieu.Size = new System.Drawing.Size(142, 482);
            this.trViewGioiThieu.TabIndex = 0;
            this.trViewGioiThieu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trViewGioiThieu_AfterSelect);
            this.trViewGioiThieu.Click += new System.EventHandler(this.trViewGioiThieu_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(160, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(748, 482);
            this.webBrowser1.TabIndex = 1;
            // 
            // frmChiDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 506);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.trViewGioiThieu);
            this.Name = "frmChiDan";
            this.Text = "ChiDan";
            this.Load += new System.EventHandler(this.ChiDan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trViewGioiThieu;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}