﻿namespace QuanLyKho
{
    partial class frmDangNhap
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
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butfrmThongKe = new System.Windows.Forms.Button();
            this.butfrmTimKiem = new System.Windows.Forms.Button();
            this.butfrmXuat = new System.Windows.Forms.Button();
            this.butfrmNhap = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.butJoin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.butfrmThongKe);
            this.panel1.Controls.Add(this.butfrmTimKiem);
            this.panel1.Controls.Add(this.butfrmXuat);
            this.panel1.Controls.Add(this.butfrmNhap);
            this.panel1.Location = new System.Drawing.Point(42, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 166);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Thống kê";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(261, 133);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 16);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hướng dẫn";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Xuất hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhập hàng";
            // 
            // butfrmThongKe
            // 
            this.butfrmThongKe.Location = new System.Drawing.Point(264, 18);
            this.butfrmThongKe.Name = "butfrmThongKe";
            this.butfrmThongKe.Size = new System.Drawing.Size(75, 75);
            this.butfrmThongKe.TabIndex = 17;
            this.butfrmThongKe.UseVisualStyleBackColor = true;
            this.butfrmThongKe.Click += new System.EventHandler(this.butfrmThongKe_Click);
            // 
            // butfrmTimKiem
            // 
            this.butfrmTimKiem.Location = new System.Drawing.Point(183, 18);
            this.butfrmTimKiem.Name = "butfrmTimKiem";
            this.butfrmTimKiem.Size = new System.Drawing.Size(75, 75);
            this.butfrmTimKiem.TabIndex = 16;
            this.butfrmTimKiem.UseVisualStyleBackColor = true;
            this.butfrmTimKiem.Click += new System.EventHandler(this.butfrmTimKiem_Click);
            // 
            // butfrmXuat
            // 
            this.butfrmXuat.Location = new System.Drawing.Point(102, 18);
            this.butfrmXuat.Name = "butfrmXuat";
            this.butfrmXuat.Size = new System.Drawing.Size(75, 75);
            this.butfrmXuat.TabIndex = 15;
            this.butfrmXuat.UseVisualStyleBackColor = true;
            this.butfrmXuat.Click += new System.EventHandler(this.butfrmXuat_Click);
            // 
            // butfrmNhap
            // 
            this.butfrmNhap.Location = new System.Drawing.Point(21, 18);
            this.butfrmNhap.Name = "butfrmNhap";
            this.butfrmNhap.Size = new System.Drawing.Size(75, 75);
            this.butfrmNhap.TabIndex = 6;
            this.butfrmNhap.UseVisualStyleBackColor = true;
            this.butfrmNhap.Click += new System.EventHandler(this.butfrmNhap_Click);
            // 
            // butQuit
            // 
            this.butQuit.Location = new System.Drawing.Point(306, 130);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(75, 44);
            this.butQuit.TabIndex = 21;
            this.butQuit.Text = "Thoát";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // butJoin
            // 
            this.butJoin.Location = new System.Drawing.Point(63, 130);
            this.butJoin.Name = "butJoin";
            this.butJoin.Size = new System.Drawing.Size(75, 44);
            this.butJoin.TabIndex = 20;
            this.butJoin.Text = "Đăng nhập";
            this.butJoin.UseVisualStyleBackColor = true;
            this.butJoin.Click += new System.EventHandler(this.butJoin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(200, 73);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(181, 20);
            this.txtPass.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(200, 33);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(181, 20);
            this.txtUser.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butJoin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyKho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butfrmThongKe;
        private System.Windows.Forms.Button butfrmTimKiem;
        private System.Windows.Forms.Button butfrmXuat;
        private System.Windows.Forms.Button butfrmNhap;
        private System.Windows.Forms.Button butQuit;
        private System.Windows.Forms.Button butJoin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
    }
}

