namespace QLPhongKS
{
    partial class FormKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxGT = new System.Windows.Forms.ComboBox();
            this.cbxMaKH = new System.Windows.Forms.ComboBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblIDKHang = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thaoTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.lblLoaiTK = new System.Windows.Forms.Label();
            this.cbxChon = new System.Windows.Forms.ComboBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grbTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGT
            // 
            this.cbxGT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxGT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxGT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGT.FormattingEnabled = true;
            this.cbxGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGT.Location = new System.Drawing.Point(411, 31);
            this.cbxGT.Name = "cbxGT";
            this.cbxGT.Size = new System.Drawing.Size(121, 23);
            this.cbxGT.TabIndex = 53;
            // 
            // cbxMaKH
            // 
            this.cbxMaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxMaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaKH.FormattingEnabled = true;
            this.cbxMaKH.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "401",
            "402",
            "403",
            "404",
            "405",
            "501",
            "502",
            "503",
            "504",
            "601",
            "602",
            "603",
            "604",
            "605"});
            this.cbxMaKH.Location = new System.Drawing.Point(133, 32);
            this.cbxMaKH.Name = "cbxMaKH";
            this.cbxMaKH.Size = new System.Drawing.Size(121, 23);
            this.cbxMaKH.TabIndex = 52;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocTich.Location = new System.Drawing.Point(133, 135);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(175, 22);
            this.txtQuocTich.TabIndex = 51;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(411, 100);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(175, 22);
            this.txtSDT.TabIndex = 50;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(411, 66);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(175, 22);
            this.txtCMND.TabIndex = 49;
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.AutoSize = true;
            this.lblQuocTich.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuocTich.Location = new System.Drawing.Point(19, 138);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(64, 15);
            this.lblQuocTich.TabIndex = 48;
            this.lblQuocTich.Text = "Quốc Tịch";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(331, 103);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(77, 15);
            this.lblSDT.TabIndex = 47;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(331, 69);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(45, 15);
            this.lblCMND.TabIndex = 46;
            this.lblCMND.Text = "CMND";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(133, 98);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(175, 22);
            this.txtQueQuan.TabIndex = 45;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(133, 64);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(175, 22);
            this.txtTenKH.TabIndex = 44;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(331, 35);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(60, 15);
            this.lblGT.TabIndex = 43;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueQuan.Location = new System.Drawing.Point(19, 100);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(63, 15);
            this.lblQueQuan.TabIndex = 42;
            this.lblQueQuan.Text = "Quê Quán";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(19, 66);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(98, 15);
            this.lblTenKH.TabIndex = 41;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblIDKHang
            // 
            this.lblIDKHang.AutoSize = true;
            this.lblIDKHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDKHang.Location = new System.Drawing.Point(19, 33);
            this.lblIDKHang.Name = "lblIDKHang";
            this.lblIDKHang.Size = new System.Drawing.Size(94, 15);
            this.lblIDKHang.TabIndex = 40;
            this.lblIDKHang.Text = "Mã Khách Hàng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaoTácToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thaoTácToolStripMenuItem
            // 
            this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.thaoTácToolStripMenuItem.Name = "thaoTácToolStripMenuItem";
            this.thaoTácToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.thaoTácToolStripMenuItem.Text = "Thao tác";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // grbTK
            // 
            this.grbTK.Controls.Add(this.lblLoaiTK);
            this.grbTK.Controls.Add(this.cbxChon);
            this.grbTK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTK.Location = new System.Drawing.Point(608, 35);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(200, 64);
            this.grbTK.TabIndex = 55;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Tìm Kiếm";
            // 
            // lblLoaiTK
            // 
            this.lblLoaiTK.AutoSize = true;
            this.lblLoaiTK.Location = new System.Drawing.Point(15, 24);
            this.lblLoaiTK.Name = "lblLoaiTK";
            this.lblLoaiTK.Size = new System.Drawing.Size(51, 15);
            this.lblLoaiTK.TabIndex = 1;
            this.lblLoaiTK.Text = "Loại TK";
            // 
            // cbxChon
            // 
            this.cbxChon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxChon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxChon.FormattingEnabled = true;
            this.cbxChon.Items.AddRange(new object[] {
            "Tên Khách Hàng",
            "CMND",
            "Mã Khách Hàng"});
            this.cbxChon.Location = new System.Drawing.Point(73, 21);
            this.cbxChon.Name = "cbxChon";
            this.cbxChon.Size = new System.Drawing.Size(121, 23);
            this.cbxChon.TabIndex = 0;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 185);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(832, 224);
            this.dgvKhachHang.TabIndex = 56;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 409);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.grbTK);
            this.Controls.Add(this.cbxGT);
            this.Controls.Add(this.cbxMaKH);
            this.Controls.Add(this.txtQuocTich);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblQuocTich);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblIDKHang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxGT;
        private System.Windows.Forms.ComboBox cbxMaKH;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblIDKHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thaoTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbTK;
        private System.Windows.Forms.Label lblLoaiTK;
        private System.Windows.Forms.ComboBox cbxChon;
        private System.Windows.Forms.DataGridView dgvKhachHang;
    }
}