namespace QuanLyThuVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.butJoin = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butfrmMuonTra = new System.Windows.Forms.Button();
            this.butfrmSach = new System.Windows.Forms.Button();
            this.butfrmDG = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(145, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(179, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(145, 54);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(179, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // butJoin
            // 
            this.butJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butJoin.Location = new System.Drawing.Point(15, 80);
            this.butJoin.Name = "butJoin";
            this.butJoin.Size = new System.Drawing.Size(100, 30);
            this.butJoin.TabIndex = 4;
            this.butJoin.Text = "Đăng nhập";
            this.butJoin.UseVisualStyleBackColor = true;
            this.butJoin.Click += new System.EventHandler(this.butJoin_Click);
            // 
            // butQuit
            // 
            this.butQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQuit.Location = new System.Drawing.Point(224, 80);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(100, 30);
            this.butQuit.TabIndex = 5;
            this.butQuit.Text = "Thoát";
            this.butQuit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.butfrmMuonTra);
            this.panel1.Controls.Add(this.butfrmSach);
            this.panel1.Controls.Add(this.butfrmDG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 169);
            this.panel1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(241, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hướng dẫn";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mượn Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Độc Giả";
            // 
            // butfrmMuonTra
            // 
            this.butfrmMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butfrmMuonTra.Location = new System.Drawing.Point(224, 3);
            this.butfrmMuonTra.Name = "butfrmMuonTra";
            this.butfrmMuonTra.Size = new System.Drawing.Size(100, 100);
            this.butfrmMuonTra.TabIndex = 2;
            this.butfrmMuonTra.UseVisualStyleBackColor = true;
            this.butfrmMuonTra.Click += new System.EventHandler(this.butfrmMuonTra_Click);
            // 
            // butfrmSach
            // 
            this.butfrmSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butfrmSach.Location = new System.Drawing.Point(118, 3);
            this.butfrmSach.Name = "butfrmSach";
            this.butfrmSach.Size = new System.Drawing.Size(100, 100);
            this.butfrmSach.TabIndex = 1;
            this.butfrmSach.UseVisualStyleBackColor = true;
            this.butfrmSach.Click += new System.EventHandler(this.butfrmSach_Click);
            // 
            // butfrmDG
            // 
            this.butfrmDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butfrmDG.Location = new System.Drawing.Point(15, 3);
            this.butfrmDG.Name = "butfrmDG";
            this.butfrmDG.Size = new System.Drawing.Size(100, 100);
            this.butfrmDG.TabIndex = 0;
            this.butfrmDG.UseVisualStyleBackColor = true;
            this.butfrmDG.Click += new System.EventHandler(this.butfrmDG_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butJoin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.ShowIcon = false;
            this.Text = "QuanLyThuVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button butJoin;
        private System.Windows.Forms.Button butQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butfrmMuonTra;
        private System.Windows.Forms.Button butfrmSach;
        private System.Windows.Forms.Button butfrmDG;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}