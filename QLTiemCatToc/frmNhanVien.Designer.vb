<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNhanVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhanVien))
        Me.chkTrangThai = New System.Windows.Forms.CheckBox()
        Me.cboVaiTro = New System.Windows.Forms.ComboBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dsuhfgd = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvNV = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbxoa = New System.Windows.Forms.PictureBox()
        Me.pbSua = New System.Windows.Forms.PictureBox()
        Me.pbluu = New System.Windows.Forms.PictureBox()
        Me.pbThem = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvNV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbluu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkTrangThai
        '
        Me.chkTrangThai.AutoSize = True
        Me.chkTrangThai.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrangThai.ForeColor = System.Drawing.Color.White
        Me.chkTrangThai.Location = New System.Drawing.Point(14, 258)
        Me.chkTrangThai.Name = "chkTrangThai"
        Me.chkTrangThai.Size = New System.Drawing.Size(95, 24)
        Me.chkTrangThai.TabIndex = 19
        Me.chkTrangThai.Text = "Đang làm"
        Me.chkTrangThai.UseVisualStyleBackColor = True
        '
        'cboVaiTro
        '
        Me.cboVaiTro.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVaiTro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVaiTro.ForeColor = System.Drawing.Color.White
        Me.cboVaiTro.FormattingEnabled = True
        Me.cboVaiTro.Items.AddRange(New Object() {"✂️ Cắt tóc", "🧴 Gội đầu", "💰 Thu ngân", "👔 Quản lý", "💡 Tư vấn", "🎯 Lễ tân"})
        Me.cboVaiTro.Location = New System.Drawing.Point(234, 220)
        Me.cboVaiTro.Name = "cboVaiTro"
        Me.cboVaiTro.Size = New System.Drawing.Size(144, 25)
        Me.cboVaiTro.TabIndex = 13
        '
        'txtMaNV
        '
        Me.txtMaNV.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaNV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.ForeColor = System.Drawing.Color.White
        Me.txtMaNV.Location = New System.Drawing.Point(11, 109)
        Me.txtMaNV.Multiline = True
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.ReadOnly = True
        Me.txtMaNV.Size = New System.Drawing.Size(195, 39)
        Me.txtMaNV.TabIndex = 12
        '
        'txtSDT
        '
        Me.txtSDT.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSDT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDT.ForeColor = System.Drawing.Color.White
        Me.txtSDT.Location = New System.Drawing.Point(11, 206)
        Me.txtSDT.Multiline = True
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(195, 39)
        Me.txtSDT.TabIndex = 8
        '
        'txtTenNV
        '
        Me.txtTenNV.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTenNV.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenNV.ForeColor = System.Drawing.Color.White
        Me.txtTenNV.Location = New System.Drawing.Point(234, 109)
        Me.txtTenNV.Multiline = True
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(196, 39)
        Me.txtTenNV.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(234, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "💼 Vai Trò *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "📱 Số Điện Thoại *"
        '
        'dsuhfgd
        '
        Me.dsuhfgd.AutoSize = True
        Me.dsuhfgd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsuhfgd.ForeColor = System.Drawing.Color.White
        Me.dsuhfgd.Location = New System.Drawing.Point(233, 88)
        Me.dsuhfgd.Name = "dsuhfgd"
        Me.dsuhfgd.Size = New System.Drawing.Size(132, 17)
        Me.dsuhfgd.TabIndex = 2
        Me.dsuhfgd.Text = "👤 Tên Nhân Viên *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "🆔 Mã Nhân Viên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thông Tin Khách Hàng"
        '
        'dgvNV
        '
        Me.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNV.Location = New System.Drawing.Point(486, 98)
        Me.dgvNV.Name = "dgvNV"
        Me.dgvNV.ReadOnly = True
        Me.dgvNV.Size = New System.Drawing.Size(598, 425)
        Me.dgvNV.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(965, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 25)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "← Quay lại"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHello.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.White
        Me.lblHello.Location = New System.Drawing.Point(683, 24)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(93, 25)
        Me.lblHello.TabIndex = 77
        Me.lblHello.Text = "Xin chào "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(96, 43)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(90, 17)
        Me.lblDate.TabIndex = 73
        Me.lblDate.Text = "dd/MM/yyyy"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(672, 13)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(261, 49)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 75
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(948, 13)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(136, 49)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 76
        Me.PictureBox10.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(92, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 40)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Quản Lý Nhân Viên"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbxoa)
        Me.Panel1.Controls.Add(Me.chkTrangThai)
        Me.Panel1.Controls.Add(Me.pbSua)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbluu)
        Me.Panel1.Controls.Add(Me.txtMaNV)
        Me.Panel1.Controls.Add(Me.dsuhfgd)
        Me.Panel1.Controls.Add(Me.txtSDT)
        Me.Panel1.Controls.Add(Me.pbThem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTenNV)
        Me.Panel1.Controls.Add(Me.cboVaiTro)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(24, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 405)
        Me.Panel1.TabIndex = 79
        '
        'pbxoa
        '
        Me.pbxoa.Image = Global.QLTiemCatToc.My.Resources.Resources.xoa
        Me.pbxoa.Location = New System.Drawing.Point(165, 343)
        Me.pbxoa.Name = "pbxoa"
        Me.pbxoa.Size = New System.Drawing.Size(126, 42)
        Me.pbxoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxoa.TabIndex = 82
        Me.pbxoa.TabStop = False
        '
        'pbSua
        '
        Me.pbSua.Image = Global.QLTiemCatToc.My.Resources.Resources.sua
        Me.pbSua.Location = New System.Drawing.Point(165, 288)
        Me.pbSua.Name = "pbSua"
        Me.pbSua.Size = New System.Drawing.Size(126, 42)
        Me.pbSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSua.TabIndex = 83
        Me.pbSua.TabStop = False
        '
        'pbluu
        '
        Me.pbluu.Image = Global.QLTiemCatToc.My.Resources.Resources.luu
        Me.pbluu.Location = New System.Drawing.Point(8, 343)
        Me.pbluu.Name = "pbluu"
        Me.pbluu.Size = New System.Drawing.Size(126, 42)
        Me.pbluu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbluu.TabIndex = 80
        Me.pbluu.TabStop = False
        '
        'pbThem
        '
        Me.pbThem.Image = Global.QLTiemCatToc.My.Resources.Resources.them
        Me.pbThem.Location = New System.Drawing.Point(8, 288)
        Me.pbThem.Name = "pbThem"
        Me.pbThem.Size = New System.Drawing.Size(126, 42)
        Me.pbThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThem.TabIndex = 81
        Me.pbThem.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 405)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 580)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dgvNV)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmNhanVien"
        Me.Text = "frmNhanVien"
        CType(Me.dgvNV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbluu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboVaiTro As ComboBox
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtTenNV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dsuhfgd As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkTrangThai As CheckBox
    Friend WithEvents dgvNV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents lblHello As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbxoa As PictureBox
    Friend WithEvents pbSua As PictureBox
    Friend WithEvents pbluu As PictureBox
    Friend WithEvents pbThem As PictureBox
End Class
