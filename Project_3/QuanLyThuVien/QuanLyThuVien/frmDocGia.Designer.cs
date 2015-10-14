namespace QuanLyThuVien
{
    partial class frmDocGia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butOK = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.butFind = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butUpd = new System.Windows.Forms.Button();
            this.butIns = new System.Windows.Forms.Button();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.butDel);
            this.panel1.Controls.Add(this.butUpd);
            this.panel1.Controls.Add(this.butIns);
            this.panel1.Controls.Add(this.txtGT);
            this.panel1.Controls.Add(this.txtNS);
            this.panel1.Controls.Add(this.txtTenDG);
            this.panel1.Controls.Add(this.txtMDG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 462);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butOK);
            this.panel3.Controls.Add(this.txtFind);
            this.panel3.Controls.Add(this.butFind);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 319);
            this.panel3.TabIndex = 12;
            // 
            // butOK
            // 
            this.butOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOK.Location = new System.Drawing.Point(188, 46);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(100, 30);
            this.butOK.TabIndex = 13;
            this.butOK.Text = "Xong";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Visible = false;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(197, 13);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(211, 20);
            this.txtFind.TabIndex = 13;
            // 
            // butFind
            // 
            this.butFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFind.Location = new System.Drawing.Point(70, 3);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(100, 30);
            this.butFind.TabIndex = 11;
            this.butFind.Tag = "";
            this.butFind.Text = "Tìm kiếm";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // butDel
            // 
            this.butDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDel.Location = new System.Drawing.Point(308, 107);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(100, 30);
            this.butDel.TabIndex = 10;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butUpd
            // 
            this.butUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUpd.Location = new System.Drawing.Point(188, 107);
            this.butUpd.Name = "butUpd";
            this.butUpd.Size = new System.Drawing.Size(100, 30);
            this.butUpd.TabIndex = 9;
            this.butUpd.Text = "Chỉnh sửa";
            this.butUpd.UseVisualStyleBackColor = true;
            this.butUpd.Click += new System.EventHandler(this.butUpd_Click);
            // 
            // butIns
            // 
            this.butIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIns.Location = new System.Drawing.Point(70, 107);
            this.butIns.Name = "butIns";
            this.butIns.Size = new System.Drawing.Size(100, 30);
            this.butIns.TabIndex = 8;
            this.butIns.Text = "Thêm mới";
            this.butIns.UseVisualStyleBackColor = true;
            this.butIns.Click += new System.EventHandler(this.butIns_Click);
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(197, 81);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(211, 20);
            this.txtGT.TabIndex = 7;
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(197, 55);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(211, 20);
            this.txtNS.TabIndex = 6;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(197, 31);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(211, 20);
            this.txtTenDG.TabIndex = 5;
            // 
            // txtMDG
            // 
            this.txtMDG.Location = new System.Drawing.Point(197, 5);
            this.txtMDG.Name = "txtMDG";
            this.txtMDG.Size = new System.Drawing.Size(211, 20);
            this.txtMDG.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 237);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(484, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaDG";
            this.Column1.HeaderText = "Mã Độc Giả";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenDG";
            this.Column2.HeaderText = "Tên Độc Giả";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDocGia";
            this.ShowIcon = false;
            this.Text = "Độc Giả";
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butUpd;
        private System.Windows.Forms.Button butIns;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butOK;
    }
}

