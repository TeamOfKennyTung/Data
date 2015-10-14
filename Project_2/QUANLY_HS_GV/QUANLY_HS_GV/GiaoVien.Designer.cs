namespace QUANLY_HS_GV
{
    partial class GiaoVien
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cbo_Monhoc = new System.Windows.Forms.ComboBox();
            this.lblMonhoc = new System.Windows.Forms.Label();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtIDGv = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblTenGiaovien = new System.Windows.Forms.Label();
            this.lblGiaovien = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvGiaovien = new System.Windows.Forms.DataGridView();
            this.qUANLY_HS_GVDataSet1 = new QUANLY_HS_GV.QUANLY_HS_GVDataSet1();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoVienTableAdapter = new QUANLY_HS_GV.QUANLY_HS_GVDataSet1TableAdapters.GiaoVienTableAdapter();
            this.iDLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaovien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_HS_GVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(316, 241);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 38);
            this.btnEdit.TabIndex = 124;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Blue;
            this.btnShow.Location = new System.Drawing.Point(28, 241);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(101, 38);
            this.btnShow.TabIndex = 117;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(465, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 38);
            this.btnDelete.TabIndex = 118;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // bntThoat
            // 
            this.bntThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.ForeColor = System.Drawing.Color.Red;
            this.bntThoat.Location = new System.Drawing.Point(667, 241);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(90, 46);
            this.bntThoat.TabIndex = 115;
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
            this.cboSearch.Location = new System.Drawing.Point(167, 296);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(121, 21);
            this.cboSearch.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(86, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(316, 296);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 20);
            this.txtSearch.TabIndex = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_Lop);
            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Controls.Add(this.cbo_Monhoc);
            this.groupBox1.Controls.Add(this.lblMonhoc);
            this.groupBox1.Controls.Add(this.dtNgaysinh);
            this.groupBox1.Controls.Add(this.lblNgaysinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.cboGioitinh);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.txtIDGv);
            this.groupBox1.Controls.Add(this.lblCMND);
            this.groupBox1.Controls.Add(this.lblChucvu);
            this.groupBox1.Controls.Add(this.lblGT);
            this.groupBox1.Controls.Add(this.lblQueQuan);
            this.groupBox1.Controls.Add(this.lblTenGiaovien);
            this.groupBox1.Controls.Add(this.lblGiaovien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 211);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
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
            this.cbo_Lop.Location = new System.Drawing.Point(488, 129);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(121, 24);
            this.cbo_Lop.TabIndex = 100;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.ForeColor = System.Drawing.Color.Blue;
            this.lblLop.Location = new System.Drawing.Point(388, 136);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(51, 16);
            this.lblLop.TabIndex = 99;
            this.lblLop.Text = "ID_Lớp";
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
            this.cbo_Monhoc.Location = new System.Drawing.Point(488, 96);
            this.cbo_Monhoc.Name = "cbo_Monhoc";
            this.cbo_Monhoc.Size = new System.Drawing.Size(121, 24);
            this.cbo_Monhoc.TabIndex = 98;
            // 
            // lblMonhoc
            // 
            this.lblMonhoc.AutoSize = true;
            this.lblMonhoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonhoc.ForeColor = System.Drawing.Color.Blue;
            this.lblMonhoc.Location = new System.Drawing.Point(386, 102);
            this.lblMonhoc.Name = "lblMonhoc";
            this.lblMonhoc.Size = new System.Drawing.Size(78, 16);
            this.lblMonhoc.TabIndex = 97;
            this.lblMonhoc.Text = "ID_Môn học";
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
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(488, 61);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(175, 22);
            this.txtSDT.TabIndex = 93;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(119, 168);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(161, 22);
            this.txtCMND.TabIndex = 92;
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
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.Blue;
            this.lblCMND.Location = new System.Drawing.Point(3, 168);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(47, 16);
            this.lblCMND.TabIndex = 87;
            this.lblCMND.Text = "CMND";
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.ForeColor = System.Drawing.Color.Blue;
            this.lblChucvu.Location = new System.Drawing.Point(386, 62);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(54, 16);
            this.lblChucvu.TabIndex = 81;
            this.lblChucvu.Text = "Chức vụ";
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
            // lblTenGiaovien
            // 
            this.lblTenGiaovien.AutoSize = true;
            this.lblTenGiaovien.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGiaovien.ForeColor = System.Drawing.Color.Blue;
            this.lblTenGiaovien.Location = new System.Drawing.Point(3, 62);
            this.lblTenGiaovien.Name = "lblTenGiaovien";
            this.lblTenGiaovien.Size = new System.Drawing.Size(85, 16);
            this.lblTenGiaovien.TabIndex = 75;
            this.lblTenGiaovien.Text = "Tên Giáo viên";
            // 
            // lblGiaovien
            // 
            this.lblGiaovien.AutoSize = true;
            this.lblGiaovien.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaovien.ForeColor = System.Drawing.Color.Blue;
            this.lblGiaovien.Location = new System.Drawing.Point(3, 24);
            this.lblGiaovien.Name = "lblGiaovien";
            this.lblGiaovien.Size = new System.Drawing.Size(84, 16);
            this.lblGiaovien.TabIndex = 74;
            this.lblGiaovien.Text = "ID_Giáo Viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(167, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 38);
            this.btnAdd.TabIndex = 123;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvGiaovien
            // 
            this.dgvGiaovien.AutoGenerateColumns = false;
            this.dgvGiaovien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaovien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGiaovien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvGiaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaovien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGvDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.gTDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.iDMonHocDataGridViewTextBoxColumn,
            this.iDLopDataGridViewTextBoxColumn});
            this.dgvGiaovien.DataSource = this.giaoVienBindingSource;
            this.dgvGiaovien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiaovien.Location = new System.Drawing.Point(0, 330);
            this.dgvGiaovien.Name = "dgvGiaovien";
            this.dgvGiaovien.ShowRowErrors = false;
            this.dgvGiaovien.Size = new System.Drawing.Size(784, 231);
            this.dgvGiaovien.TabIndex = 122;
            // 
            // qUANLY_HS_GVDataSet1
            // 
            this.qUANLY_HS_GVDataSet1.DataSetName = "QUANLY_HS_GVDataSet1";
            this.qUANLY_HS_GVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.qUANLY_HS_GVDataSet1;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
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
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.HeaderText = "GT";
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "Quequan";
            this.quequanDataGridViewTextBoxColumn.HeaderText = "Quequan";
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // iDGvDataGridViewTextBoxColumn
            // 
            this.iDGvDataGridViewTextBoxColumn.DataPropertyName = "ID_Gv";
            this.iDGvDataGridViewTextBoxColumn.HeaderText = "ID_Gv";
            this.iDGvDataGridViewTextBoxColumn.Name = "iDGvDataGridViewTextBoxColumn";
            // 
            // GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvGiaovien);
            this.Name = "GiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin giáo viên";
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaovien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_HS_GVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtIDGv;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblTenGiaovien;
        private System.Windows.Forms.Label lblGiaovien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvGiaovien;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cbo_Monhoc;
        private System.Windows.Forms.Label lblMonhoc;
        private QUANLY_HS_GVDataSet1 qUANLY_HS_GVDataSet1;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QUANLY_HS_GVDataSet1TableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopDataGridViewTextBoxColumn;
    }
}