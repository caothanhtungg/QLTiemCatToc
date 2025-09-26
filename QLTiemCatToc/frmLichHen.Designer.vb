<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLichHen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLichHen))
        Me.cboDichVu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dsuhfgd = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.cboTrangThai = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboGio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboKhachHang = New System.Windows.Forms.ComboBox()
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.cboNhanVien = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaLich = New System.Windows.Forms.TextBox()
        Me.dgvLich = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvLich, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDichVu
        '
        Me.cboDichVu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDichVu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDichVu.ForeColor = System.Drawing.Color.White
        Me.cboDichVu.FormattingEnabled = True
        Me.cboDichVu.Items.AddRange(New Object() {"✂️ Cắt tóc", "🧴 Gội đầu", "💰 Thu ngân", "👔 Quản lý", "💡 Tư vấn", "🎯 Lễ tân"})
        Me.cboDichVu.Location = New System.Drawing.Point(257, 167)
        Me.cboDichVu.Name = "cboDichVu"
        Me.cboDichVu.Size = New System.Drawing.Size(201, 25)
        Me.cboDichVu.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(254, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "✂️ Dịch Vụ *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "👨‍💼 Nhân Viên *"
        '
        'dsuhfgd
        '
        Me.dsuhfgd.AutoSize = True
        Me.dsuhfgd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsuhfgd.ForeColor = System.Drawing.Color.White
        Me.dsuhfgd.Location = New System.Drawing.Point(250, 67)
        Me.dsuhfgd.Name = "dsuhfgd"
        Me.dsuhfgd.Size = New System.Drawing.Size(115, 17)
        Me.dsuhfgd.TabIndex = 2
        Me.dsuhfgd.Text = "👤 Khách Hàng *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "🆔 Mã Lịch Hẹn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "📝 Thông Tin Lịch Hẹn"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGhiChu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhiChu.ForeColor = System.Drawing.Color.White
        Me.txtGhiChu.Location = New System.Drawing.Point(752, 172)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(309, 106)
        Me.txtGhiChu.TabIndex = 22
        '
        'cboTrangThai
        '
        Me.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTrangThai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrangThai.ForeColor = System.Drawing.Color.White
        Me.cboTrangThai.FormattingEnabled = True
        Me.cboTrangThai.Items.AddRange(New Object() {"Đặt", "Hoàn tất", "Hủy"})
        Me.cboTrangThai.Location = New System.Drawing.Point(749, 92)
        Me.cboTrangThai.Name = "cboTrangThai"
        Me.cboTrangThai.Size = New System.Drawing.Size(201, 25)
        Me.cboTrangThai.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(746, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "📋 Trạng Thái *"
        '
        'cboGio
        '
        Me.cboGio.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboGio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGio.ForeColor = System.Drawing.Color.White
        Me.cboGio.FormattingEnabled = True
        Me.cboGio.Items.AddRange(New Object() {"08:00", "08:30", "09:00"})
        Me.cboGio.Location = New System.Drawing.Point(502, 169)
        Me.cboGio.Name = "cboGio"
        Me.cboGio.Size = New System.Drawing.Size(202, 25)
        Me.cboGio.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(499, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "🕐 Giờ Hẹn *"
        '
        'cboKhachHang
        '
        Me.cboKhachHang.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKhachHang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKhachHang.ForeColor = System.Drawing.Color.White
        Me.cboKhachHang.FormattingEnabled = True
        Me.cboKhachHang.Location = New System.Drawing.Point(257, 92)
        Me.cboKhachHang.Name = "cboKhachHang"
        Me.cboKhachHang.Size = New System.Drawing.Size(201, 25)
        Me.cboKhachHang.TabIndex = 24
        '
        'dtpNgay
        '
        Me.dtpNgay.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgay.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgay.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgay.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dtpNgay.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.dtpNgay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgay.Location = New System.Drawing.Point(503, 93)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(201, 23)
        Me.dtpNgay.TabIndex = 23
        '
        'cboNhanVien
        '
        Me.cboNhanVien.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNhanVien.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNhanVien.ForeColor = System.Drawing.Color.White
        Me.cboNhanVien.FormattingEnabled = True
        Me.cboNhanVien.Location = New System.Drawing.Point(11, 167)
        Me.cboNhanVien.Name = "cboNhanVien"
        Me.cboNhanVien.Size = New System.Drawing.Size(201, 25)
        Me.cboNhanVien.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(746, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Ghi Chú"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(497, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "📅 Ngày Hẹn *"
        '
        'txtMaLich
        '
        Me.txtMaLich.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMaLich.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaLich.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaLich.ForeColor = System.Drawing.Color.White
        Me.txtMaLich.Location = New System.Drawing.Point(11, 95)
        Me.txtMaLich.Name = "txtMaLich"
        Me.txtMaLich.ReadOnly = True
        Me.txtMaLich.Size = New System.Drawing.Size(197, 18)
        Me.txtMaLich.TabIndex = 12
        '
        'dgvLich
        '
        Me.dgvLich.AllowUserToAddRows = False
        Me.dgvLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLich.Location = New System.Drawing.Point(10, 398)
        Me.dgvLich.Name = "dgvLich"
        Me.dgvLich.ReadOnly = True
        Me.dgvLich.Size = New System.Drawing.Size(1086, 261)
        Me.dgvLich.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(948, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "← Quay lại"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHello.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.White
        Me.lblHello.Location = New System.Drawing.Point(663, 30)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(93, 25)
        Me.lblHello.TabIndex = 58
        Me.lblHello.Text = "Xin chào "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(75, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(311, 40)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "📅 Quản Lý Lịch Hẹn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(79, 51)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(90, 17)
        Me.lblDate.TabIndex = 59
        Me.lblDate.Text = "dd/MM/yyyy"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(658, 19)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(261, 49)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 63
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(934, 19)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(136, 49)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 64
        Me.PictureBox10.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1084, 302)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtGhiChu)
        Me.Panel1.Controls.Add(Me.cboGio)
        Me.Panel1.Controls.Add(Me.cboTrangThai)
        Me.Panel1.Controls.Add(Me.cboNhanVien)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.dtpNgay)
        Me.Panel1.Controls.Add(Me.cboKhachHang)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.cboDichVu)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dsuhfgd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtMaLich)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 302)
        Me.Panel1.TabIndex = 67
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.QLTiemCatToc.My.Resources.Resources.xoa
        Me.PictureBox6.Location = New System.Drawing.Point(516, 219)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 72
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.QLTiemCatToc.My.Resources.Resources.sua
        Me.PictureBox4.Location = New System.Drawing.Point(173, 219)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 73
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.QLTiemCatToc.My.Resources.Resources.luu
        Me.PictureBox5.Location = New System.Drawing.Point(345, 219)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 70
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.QLTiemCatToc.My.Resources.Resources.them
        Me.PictureBox3.Location = New System.Drawing.Point(8, 219)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(126, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 71
        Me.PictureBox3.TabStop = False
        '
        'frmLichHen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 675)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.dgvLich)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLichHen"
        Me.Text = "frmLichHen"
        CType(Me.dgvLich, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDichVu As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dsuhfgd As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboKhachHang As ComboBox
    Friend WithEvents txtMaLich As TextBox
    Friend WithEvents cboNhanVien As ComboBox
    Friend WithEvents cboTrangThai As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboGio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvLich As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents lblHello As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
