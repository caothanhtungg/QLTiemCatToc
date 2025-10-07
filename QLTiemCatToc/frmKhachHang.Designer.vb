<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.cboGioiTinh = New System.Windows.Forms.ComboBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.txtTim = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thông Tin Khách Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã KH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(227, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Khách Hàng *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số Điện Thoại *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(227, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Giới Tính"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ngày Sinh"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ghi Chú"
        '
        'txtTen
        '
        Me.txtTen.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.ForeColor = System.Drawing.Color.White
        Me.txtTen.Location = New System.Drawing.Point(226, 79)
        Me.txtTen.Multiline = True
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(187, 35)
        Me.txtTen.TabIndex = 7
        '
        'txtSDT
        '
        Me.txtSDT.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSDT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDT.ForeColor = System.Drawing.Color.White
        Me.txtSDT.Location = New System.Drawing.Point(13, 171)
        Me.txtSDT.Multiline = True
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(185, 35)
        Me.txtSDT.TabIndex = 8
        '
        'txtGhiChu
        '
        Me.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGhiChu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhiChu.ForeColor = System.Drawing.Color.White
        Me.txtGhiChu.Location = New System.Drawing.Point(11, 338)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(402, 90)
        Me.txtGhiChu.TabIndex = 10
        '
        'txtMaKH
        '
        Me.txtMaKH.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKH.ForeColor = System.Drawing.Color.White
        Me.txtMaKH.Location = New System.Drawing.Point(13, 79)
        Me.txtMaKH.Multiline = True
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.ReadOnly = True
        Me.txtMaKH.Size = New System.Drawing.Size(185, 35)
        Me.txtMaKH.TabIndex = 12
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgaySinh.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgaySinh.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgaySinh.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgaySinh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgaySinh.Location = New System.Drawing.Point(13, 262)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.ShowCheckBox = True
        Me.dtpNgaySinh.Size = New System.Drawing.Size(250, 22)
        Me.dtpNgaySinh.TabIndex = 14
        '
        'cboGioiTinh
        '
        Me.cboGioiTinh.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboGioiTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGioiTinh.ForeColor = System.Drawing.Color.White
        Me.cboGioiTinh.FormattingEnabled = True
        Me.cboGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ ", "Khác"})
        Me.cboGioiTinh.Location = New System.Drawing.Point(226, 181)
        Me.cboGioiTinh.Name = "cboGioiTinh"
        Me.cboGioiTinh.Size = New System.Drawing.Size(154, 26)
        Me.cboGioiTinh.TabIndex = 13
        '
        'dgvKH
        '
        Me.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKH.BackgroundColor = System.Drawing.Color.White
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.GridColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.dgvKH.Location = New System.Drawing.Point(459, 167)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.ReadOnly = True
        Me.dgvKH.Size = New System.Drawing.Size(637, 504)
        Me.dgvKH.TabIndex = 1
        '
        'txtTim
        '
        Me.txtTim.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTim.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTim.ForeColor = System.Drawing.Color.White
        Me.txtTim.Location = New System.Drawing.Point(699, 126)
        Me.txtTim.Name = "txtTim"
        Me.txtTim.Size = New System.Drawing.Size(252, 20)
        Me.txtTim.TabIndex = 20
        Me.txtTim.Text = "🔍 Tìm kiếm theo tên hoặc SĐT..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(79, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(310, 40)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Quản Lý Khách Hàng"
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHello.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.White
        Me.lblHello.Location = New System.Drawing.Point(664, 23)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(93, 25)
        Me.lblHello.TabIndex = 58
        Me.lblHello.Text = "Xin chào "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(83, 42)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(90, 17)
        Me.lblDate.TabIndex = 59
        Me.lblDate.Text = "dd/MM/yyyy"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(951, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 25)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "← Quay lại"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtMaKH)
        Me.Panel1.Controls.Add(Me.txtTen)
        Me.Panel1.Controls.Add(Me.txtSDT)
        Me.Panel1.Controls.Add(Me.cboGioiTinh)
        Me.Panel1.Controls.Add(Me.dtpNgaySinh)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtGhiChu)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 553)
        Me.Panel1.TabIndex = 67
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.QLTiemCatToc.My.Resources.Resources.xoa
        Me.PictureBox6.Location = New System.Drawing.Point(168, 500)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 69
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.QLTiemCatToc.My.Resources.Resources.sua
        Me.PictureBox4.Location = New System.Drawing.Point(168, 445)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 69
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.QLTiemCatToc.My.Resources.Resources.luu
        Me.PictureBox5.Location = New System.Drawing.Point(11, 500)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 68
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.QLTiemCatToc.My.Resources.Resources.them
        Me.PictureBox3.Location = New System.Drawing.Point(11, 445)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 68
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(441, 553)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(659, 12)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(261, 49)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 63
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(935, 12)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(136, 49)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 64
        Me.PictureBox10.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(969, 118)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(127, 43)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 70
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(690, 118)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(261, 36)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 63
        Me.PictureBox8.TabStop = False
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 704)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTim)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.PictureBox8)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Name = "frmKhachHang"
        Me.Text = "frmKhachHang"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTen As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents txtTim As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblHello As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
