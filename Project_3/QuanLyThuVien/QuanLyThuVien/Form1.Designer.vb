<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLyThuVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pData = New System.Windows.Forms.Panel()
        Me.pUser = New System.Windows.Forms.Panel()
        Me.data = New System.Windows.Forms.DataGridView()
        Me.lblMaDS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMDS = New System.Windows.Forms.TextBox()
        Me.txtGB = New System.Windows.Forms.TextBox()
        Me.txtTenDS = New System.Windows.Forms.TextBox()
        Me.butIns = New System.Windows.Forms.Button()
        Me.butDel = New System.Windows.Forms.Button()
        Me.butUpd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.butFind = New System.Windows.Forms.Button()
        Me.rMDS = New System.Windows.Forms.RadioButton()
        Me.rTenDS = New System.Windows.Forms.RadioButton()
        Me.rGB = New System.Windows.Forms.RadioButton()
        Me.MaDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pData.SuspendLayout()
        Me.pUser.SuspendLayout()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pData
        '
        Me.pData.BackColor = System.Drawing.Color.Violet
        Me.pData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pData.Controls.Add(Me.data)
        Me.pData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pData.Location = New System.Drawing.Point(0, 187)
        Me.pData.Name = "pData"
        Me.pData.Size = New System.Drawing.Size(541, 323)
        Me.pData.TabIndex = 0
        '
        'pUser
        '
        Me.pUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pUser.Controls.Add(Me.Panel1)
        Me.pUser.Controls.Add(Me.butUpd)
        Me.pUser.Controls.Add(Me.butDel)
        Me.pUser.Controls.Add(Me.butIns)
        Me.pUser.Controls.Add(Me.txtTenDS)
        Me.pUser.Controls.Add(Me.txtGB)
        Me.pUser.Controls.Add(Me.txtMDS)
        Me.pUser.Controls.Add(Me.Label3)
        Me.pUser.Controls.Add(Me.Label2)
        Me.pUser.Controls.Add(Me.lblMaDS)
        Me.pUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.pUser.Location = New System.Drawing.Point(0, 0)
        Me.pUser.Name = "pUser"
        Me.pUser.Size = New System.Drawing.Size(541, 181)
        Me.pUser.TabIndex = 1
        '
        'data
        '
        Me.data.AllowUserToAddRows = False
        Me.data.AllowUserToDeleteRows = False
        Me.data.AllowUserToResizeColumns = False
        Me.data.AllowUserToResizeRows = False
        Me.data.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDS, Me.TenDS, Me.GiaBan})
        Me.data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data.GridColor = System.Drawing.Color.Maroon
        Me.data.Location = New System.Drawing.Point(0, 0)
        Me.data.MultiSelect = False
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.data.RowHeadersVisible = False
        Me.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data.Size = New System.Drawing.Size(539, 321)
        Me.data.TabIndex = 0
        '
        'lblMaDS
        '
        Me.lblMaDS.AutoSize = True
        Me.lblMaDS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaDS.Location = New System.Drawing.Point(12, 9)
        Me.lblMaDS.Name = "lblMaDS"
        Me.lblMaDS.Size = New System.Drawing.Size(101, 19)
        Me.lblMaDS.TabIndex = 0
        Me.lblMaDS.Text = "Mã Đầu Sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Đầu Sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Giá Bán"
        '
        'txtMDS
        '
        Me.txtMDS.Location = New System.Drawing.Point(162, 6)
        Me.txtMDS.Name = "txtMDS"
        Me.txtMDS.Size = New System.Drawing.Size(166, 22)
        Me.txtMDS.TabIndex = 3
        '
        'txtGB
        '
        Me.txtGB.Location = New System.Drawing.Point(162, 94)
        Me.txtGB.Name = "txtGB"
        Me.txtGB.Size = New System.Drawing.Size(166, 22)
        Me.txtGB.TabIndex = 4
        '
        'txtTenDS
        '
        Me.txtTenDS.Location = New System.Drawing.Point(162, 51)
        Me.txtTenDS.Name = "txtTenDS"
        Me.txtTenDS.Size = New System.Drawing.Size(166, 22)
        Me.txtTenDS.TabIndex = 5
        '
        'butIns
        '
        Me.butIns.BackColor = System.Drawing.Color.WhiteSmoke
        Me.butIns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butIns.Location = New System.Drawing.Point(12, 141)
        Me.butIns.Name = "butIns"
        Me.butIns.Size = New System.Drawing.Size(100, 30)
        Me.butIns.TabIndex = 6
        Me.butIns.Text = "Thêm mới"
        Me.butIns.UseVisualStyleBackColor = False
        '
        'butDel
        '
        Me.butDel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.butDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butDel.Location = New System.Drawing.Point(118, 141)
        Me.butDel.Name = "butDel"
        Me.butDel.Size = New System.Drawing.Size(100, 30)
        Me.butDel.TabIndex = 7
        Me.butDel.Text = "Chỉnh sửa"
        Me.butDel.UseVisualStyleBackColor = False
        '
        'butUpd
        '
        Me.butUpd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.butUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butUpd.Location = New System.Drawing.Point(224, 141)
        Me.butUpd.Name = "butUpd"
        Me.butUpd.Size = New System.Drawing.Size(100, 30)
        Me.butUpd.TabIndex = 8
        Me.butUpd.Text = "Xóa"
        Me.butUpd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.rGB)
        Me.Panel1.Controls.Add(Me.rTenDS)
        Me.Panel1.Controls.Add(Me.rMDS)
        Me.Panel1.Controls.Add(Me.butFind)
        Me.Panel1.Controls.Add(Me.txtFind)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(341, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 181)
        Me.Panel1.TabIndex = 9
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(16, 6)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(166, 22)
        Me.txtFind.TabIndex = 6
        '
        'butFind
        '
        Me.butFind.BackColor = System.Drawing.Color.WhiteSmoke
        Me.butFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butFind.Location = New System.Drawing.Point(16, 110)
        Me.butFind.Name = "butFind"
        Me.butFind.Size = New System.Drawing.Size(100, 30)
        Me.butFind.TabIndex = 9
        Me.butFind.Text = "Tìm Kiếm"
        Me.butFind.UseVisualStyleBackColor = False
        '
        'rMDS
        '
        Me.rMDS.AutoSize = True
        Me.rMDS.Location = New System.Drawing.Point(16, 35)
        Me.rMDS.Name = "rMDS"
        Me.rMDS.Size = New System.Drawing.Size(97, 19)
        Me.rMDS.TabIndex = 10
        Me.rMDS.TabStop = True
        Me.rMDS.Text = "Mã Đầu Sách"
        Me.rMDS.UseVisualStyleBackColor = True
        '
        'rTenDS
        '
        Me.rTenDS.AutoSize = True
        Me.rTenDS.Location = New System.Drawing.Point(16, 60)
        Me.rTenDS.Name = "rTenDS"
        Me.rTenDS.Size = New System.Drawing.Size(101, 19)
        Me.rTenDS.TabIndex = 11
        Me.rTenDS.TabStop = True
        Me.rTenDS.Text = "Tên Đầu Sách"
        Me.rTenDS.UseVisualStyleBackColor = True
        '
        'rGB
        '
        Me.rGB.AutoSize = True
        Me.rGB.Location = New System.Drawing.Point(16, 85)
        Me.rGB.Name = "rGB"
        Me.rGB.Size = New System.Drawing.Size(69, 19)
        Me.rGB.TabIndex = 12
        Me.rGB.TabStop = True
        Me.rGB.Text = "Giá Bán"
        Me.rGB.UseVisualStyleBackColor = True
        '
        'MaDS
        '
        Me.MaDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaDS.DataPropertyName = "MaDS"
        Me.MaDS.HeaderText = "Mã Đầu Sách"
        Me.MaDS.Name = "MaDS"
        Me.MaDS.ReadOnly = True
        '
        'TenDS
        '
        Me.TenDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenDS.DataPropertyName = "TenDS"
        Me.TenDS.HeaderText = "Tên Đầu Sách"
        Me.TenDS.Name = "TenDS"
        Me.TenDS.ReadOnly = True
        '
        'GiaBan
        '
        Me.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GiaBan.DataPropertyName = "GiaBan"
        Me.GiaBan.HeaderText = "Giá Bán"
        Me.GiaBan.Name = "GiaBan"
        Me.GiaBan.ReadOnly = True
        '
        'QuanLyThuVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 510)
        Me.Controls.Add(Me.pUser)
        Me.Controls.Add(Me.pData)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "QuanLyThuVien"
        Me.ShowIcon = False
        Me.Text = "QuanLyThuVien"
        Me.pData.ResumeLayout(False)
        Me.pUser.ResumeLayout(False)
        Me.pUser.PerformLayout()
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pData As System.Windows.Forms.Panel
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents pUser As System.Windows.Forms.Panel
    Friend WithEvents butUpd As System.Windows.Forms.Button
    Friend WithEvents butDel As System.Windows.Forms.Button
    Friend WithEvents butIns As System.Windows.Forms.Button
    Friend WithEvents txtTenDS As System.Windows.Forms.TextBox
    Friend WithEvents txtGB As System.Windows.Forms.TextBox
    Friend WithEvents txtMDS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMaDS As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rGB As System.Windows.Forms.RadioButton
    Friend WithEvents rTenDS As System.Windows.Forms.RadioButton
    Friend WithEvents rMDS As System.Windows.Forms.RadioButton
    Friend WithEvents butFind As System.Windows.Forms.Button
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents MaDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiaBan As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
