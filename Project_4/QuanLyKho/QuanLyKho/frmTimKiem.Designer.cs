namespace QuanLyKho
{
    partial class frmTimKiem
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.butTimSL = new System.Windows.Forms.Button();
            this.butTimNCC = new System.Windows.Forms.Button();
            this.butTimTen = new System.Windows.Forms.Button();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.butTimMa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.txtTenHH);
            this.panel1.Controls.Add(this.butTimSL);
            this.panel1.Controls.Add(this.butTimNCC);
            this.panel1.Controls.Add(this.butTimTen);
            this.panel1.Controls.Add(this.txtMaHH);
            this.panel1.Controls.Add(this.butTimMa);
            this.panel1.Location = new System.Drawing.Point(37, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 239);
            this.panel1.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(211, 185);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(177, 20);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(211, 133);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(177, 20);
            this.txtMaNCC.TabIndex = 6;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(211, 81);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(177, 20);
            this.txtTenHH.TabIndex = 5;
            // 
            // butTimSL
            // 
            this.butTimSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTimSL.Location = new System.Drawing.Point(36, 171);
            this.butTimSL.Name = "butTimSL";
            this.butTimSL.Size = new System.Drawing.Size(111, 46);
            this.butTimSL.TabIndex = 4;
            this.butTimSL.Text = "Tìm theo Số lượng";
            this.butTimSL.UseVisualStyleBackColor = true;
            this.butTimSL.Click += new System.EventHandler(this.butTimSL_Click);
            // 
            // butTimNCC
            // 
            this.butTimNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTimNCC.Location = new System.Drawing.Point(36, 119);
            this.butTimNCC.Name = "butTimNCC";
            this.butTimNCC.Size = new System.Drawing.Size(111, 46);
            this.butTimNCC.TabIndex = 3;
            this.butTimNCC.Text = "Tìm theo Nhà cung cấp";
            this.butTimNCC.UseVisualStyleBackColor = true;
            this.butTimNCC.Click += new System.EventHandler(this.butTimNCC_Click);
            // 
            // butTimTen
            // 
            this.butTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTimTen.Location = new System.Drawing.Point(36, 67);
            this.butTimTen.Name = "butTimTen";
            this.butTimTen.Size = new System.Drawing.Size(111, 46);
            this.butTimTen.TabIndex = 2;
            this.butTimTen.Text = "Tìm theo Tên hàng hóa";
            this.butTimTen.UseVisualStyleBackColor = true;
            this.butTimTen.Click += new System.EventHandler(this.butTimTen_Click);
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(211, 29);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(177, 20);
            this.txtMaHH.TabIndex = 1;
            // 
            // butTimMa
            // 
            this.butTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTimMa.Location = new System.Drawing.Point(36, 15);
            this.butTimMa.Name = "butTimMa";
            this.butTimMa.Size = new System.Drawing.Size(111, 46);
            this.butTimMa.TabIndex = 0;
            this.butTimMa.Text = "Tìm theo Mã hàng hóa";
            this.butTimMa.UseVisualStyleBackColor = true;
            this.butTimMa.Click += new System.EventHandler(this.butTimMa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 204);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Button butTimMa;
        private System.Windows.Forms.Button butTimSL;
        private System.Windows.Forms.Button butTimNCC;
        private System.Windows.Forms.Button butTimTen;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}