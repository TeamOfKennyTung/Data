namespace QUANLY_HS_GV
{
    partial class HocSinh
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Monhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvHocsinh = new System.Windows.Forms.DataGridView();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtIDGv = new System.Windows.Forms.TextBox();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lblHocsinh = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qUANLY_HS_GVDataSet = new QUANLY_HS_GV.QUANLY_HS_GVDataSet();
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocSinhTableAdapter = new QUANLY_HS_GV.QUANLY_HS_GVDataSetTableAdapters.HocSinhTableAdapter();
            this.iDHsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_HS_GVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(388, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "ID_Lớp";
            // 
            // cbo_Monhoc
            // 
            this.cbo_Monhoc.FormattingEnabled = true;
            this.cbo_Monhoc.Items.AddRange(new object[] {
            "MH01",
            "MH02",
            "MH03",
            "MH04",
            "MH05"});
            this.cbo_Monhoc.Location = new System.Drawing.Point(488, 56);
            this.cbo_Monhoc.Name = "cbo_Monhoc";
            this.cbo_Monhoc.Size = new System.Drawing.Size(121, 24);
            this.cbo_Monhoc.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(386, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "ID_Môn học";
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(488, 24);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaysinh.TabIndex = 96;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.ForeColor = System.Drawing.Color.Blue;
            this.lblNgaysinh.Location = new System.Drawing.Point(386, 24);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(63, 16);
            this.lblNgaysinh.TabIndex = 95;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(171, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 38);
            this.btnAdd.TabIndex = 133;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvHocsinh
            // 
            this.dgvHocsinh.AutoGenerateColumns = false;
            this.dgvHocsinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocsinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHocsinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvHocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHsDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.gTDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn,
            this.iDMonHocDataGridViewTextBoxColumn});
            this.dgvHocsinh.DataSource = this.hocSinhBindingSource;
            this.dgvHocsinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocsinh.Location = new System.Drawing.Point(0, 308);
            this.dgvHocsinh.Name = "dgvHocsinh";
            this.dgvHocsinh.ShowRowErrors = false;
            this.dgvHocsinh.Size = new System.Drawing.Size(784, 253);
            this.dgvHocsinh.TabIndex = 132;
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Items.AddRange(new object[] {
            "LOP01",
            "LOP02",
            "LOP03",
            "LOP04",
            "LOP05"});
            this.cbo_Lop.Location = new System.Drawing.Point(488, 89);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(121, 24);
            this.cbo_Lop.TabIndex = 100;
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh.Location = new System.Drawing.Point(119, 129);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(121, 24);
            this.cboGioitinh.TabIndex = 91;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(119, 96);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(175, 22);
            this.txtQueQuan.TabIndex = 90;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(119, 59);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(175, 22);
            this.txtTenGV.TabIndex = 89;
            // 
            // txtIDGv
            // 
            this.txtIDGv.Location = new System.Drawing.Point(119, 21);
            this.txtIDGv.Name = "txtIDGv";
            this.txtIDGv.Size = new System.Drawing.Size(175, 22);
            this.txtIDGv.TabIndex = 88;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.ForeColor = System.Drawing.Color.Blue;
            this.lblGT.Location = new System.Drawing.Point(3, 136);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(61, 16);
            this.lblGT.TabIndex = 77;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueQuan.ForeColor = System.Drawing.Color.Blue;
            this.lblQueQuan.Location = new System.Drawing.Point(3, 102);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(63, 16);
            this.lblQueQuan.TabIndex = 76;
            this.lblQueQuan.Text = "Quê Quán";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.ForeColor = System.Drawing.Color.Blue;
            this.lblTenHS.Location = new System.Drawing.Point(3, 62);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(81, 16);
            this.lblTenHS.TabIndex = 75;
            this.lblTenHS.Text = "Tên Học sinh";
            // 
            // lblHocsinh
            // 
            this.lblHocsinh.AutoSize = true;
            this.lblHocsinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocsinh.ForeColor = System.Drawing.Color.Blue;
            this.lblHocsinh.Location = new System.Drawing.Point(3, 24);
            this.lblHocsinh.Name = "lblHocsinh";
            this.lblHocsinh.Size = new System.Drawing.Size(78, 16);
            this.lblHocsinh.TabIndex = 74;
            this.lblHocsinh.Text = "ID_Học sinh";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(320, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 38);
            this.btnEdit.TabIndex = 134;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Blue;
            this.btnShow.Location = new System.Drawing.Point(32, 208);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(101, 38);
            this.btnShow.TabIndex = 127;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(469, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 38);
            this.btnDelete.TabIndex = 128;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // bntThoat
            // 
            this.bntThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.ForeColor = System.Drawing.Color.Red;
            this.bntThoat.Location = new System.Drawing.Point(671, 208);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(90, 46);
            this.bntThoat.TabIndex = 125;
            this.bntThoat.Text = "Exit";
            this.bntThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntThoat.UseVisualStyleBackColor = true;
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "ID_Khach",
            "CMND"});
            this.cboSearch.Location = new System.Drawing.Point(171, 263);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(90, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 131;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(320, 263);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 20);
            this.txtSearch.TabIndex = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_Lop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbo_Monhoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtNgaysinh);
            this.groupBox1.Controls.Add(this.lblNgaysinh);
            this.groupBox1.Controls.Add(this.cboGioitinh);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.txtIDGv);
            this.groupBox1.Controls.Add(this.lblGT);
            this.groupBox1.Controls.Add(this.lblQueQuan);
            this.groupBox1.Controls.Add(this.lblTenHS);
            this.groupBox1.Controls.Add(this.lblHocsinh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 178);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // qUANLY_HS_GVDataSet
            // 
            this.qUANLY_HS_GVDataSet.DataSetName = "QUANLY_HS_GVDataSet";
            this.qUANLY_HS_GVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "HocSinh";
            this.hocSinhBindingSource.DataSource = this.qUANLY_HS_GVDataSet;
            // 
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // iDHsDataGridViewTextBoxColumn
            // 
            this.iDHsDataGridViewTextBoxColumn.DataPropertyName = "ID_Hs";
            this.iDHsDataGridViewTextBoxColumn.HeaderText = "ID_Hs";
            this.iDHsDataGridViewTextBoxColumn.Name = "iDHsDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "Quequan";
            this.quequanDataGridViewTextBoxColumn.HeaderText = "Quequan";
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.HeaderText = "GT";
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // iDLopDataGridViewTextBoxColumn
            // 
            this.iDLopDataGridViewTextBoxColumn.DataPropertyName = "ID_Lop";
            this.iDLopDataGridViewTextBoxColumn.HeaderText = "ID_Lop";
            this.iDLopDataGridViewTextBoxColumn.Name = "iDLopDataGridViewTextBoxColumn";
            // 
            // iDMonHocDataGridViewTextBoxColumn
            // 
            this.iDMonHocDataGridViewTextBoxColumn.DataPropertyName = "ID_MonHoc";
            this.iDMonHocDataGridViewTextBoxColumn.HeaderText = "ID_MonHoc";
            this.iDMonHocDataGridViewTextBoxColumn.Name = "iDMonHocDataGridViewTextBoxColumn";
            // 
            // HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvHocsinh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "HocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin học sinh";
            this.Load += new System.EventHandler(this.HocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocsinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_HS_GVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Monhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvHocsinh;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtIDGv;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblHocsinh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private QUANLY_HS_GVDataSet qUANLY_HS_GVDataSet;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private QUANLY_HS_GVDataSetTableAdapters.HocSinhTableAdapter hocSinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonHocDataGridViewTextBoxColumn;
    }
}