<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKe
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThongKe))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.pnlDoanhThu = New System.Windows.Forms.Panel()
        Me.lblDoanhThu = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTitleDT = New System.Windows.Forms.Label()
        Me.pnlSoHD = New System.Windows.Forms.Panel()
        Me.lblSoHD = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTitleHD = New System.Windows.Forms.Label()
        Me.pnlSoKH = New System.Windows.Forms.Panel()
        Me.lblSoKH = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTitleKH = New System.Windows.Forms.Label()
        Me.pnlTBHD = New System.Windows.Forms.Panel()
        Me.lblTBHD = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTitleTB = New System.Windows.Forms.Label()
        Me.dgvTK = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnxem = New System.Windows.Forms.Button()
        Me.pnlDoanhThu.SuspendLayout()
        Me.pnlSoHD.SuspendLayout()
        Me.pnlSoKH.SuspendLayout()
        Me.pnlTBHD.SuspendLayout()
        CType(Me.dgvTK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bộ lọc thống kê"
        '
        'dtpFrom
        '
        Me.dtpFrom.CalendarFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(33, 81)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(457, 35)
        Me.dtpFrom.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "📅 Từ Ngày"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(561, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "📅 Đến Ngày"
        '
        'dtpTo
        '
        Me.dtpTo.CalendarFont = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(561, 81)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(456, 35)
        Me.dtpTo.TabIndex = 16
        Me.dtpTo.Value = New Date(2025, 8, 23, 6, 41, 9, 0)
        '
        'pnlDoanhThu
        '
        Me.pnlDoanhThu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlDoanhThu.Controls.Add(Me.lblDoanhThu)
        Me.pnlDoanhThu.Controls.Add(Me.Label8)
        Me.pnlDoanhThu.Controls.Add(Me.lblTitleDT)
        Me.pnlDoanhThu.Location = New System.Drawing.Point(11, 25)
        Me.pnlDoanhThu.Name = "pnlDoanhThu"
        Me.pnlDoanhThu.Size = New System.Drawing.Size(244, 124)
        Me.pnlDoanhThu.TabIndex = 0
        '
        'lblDoanhThu
        '
        Me.lblDoanhThu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoanhThu.ForeColor = System.Drawing.Color.White
        Me.lblDoanhThu.Location = New System.Drawing.Point(100, 42)
        Me.lblDoanhThu.Name = "lblDoanhThu"
        Me.lblDoanhThu.Size = New System.Drawing.Size(38, 33)
        Me.lblDoanhThu.TabIndex = 0
        Me.lblDoanhThu.Text = "0 đ"
        Me.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label8.Location = New System.Drawing.Point(100, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "VNĐ"
        '
        'lblTitleDT
        '
        Me.lblTitleDT.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitleDT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDT.ForeColor = System.Drawing.Color.White
        Me.lblTitleDT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTitleDT.Location = New System.Drawing.Point(0, 0)
        Me.lblTitleDT.Name = "lblTitleDT"
        Me.lblTitleDT.Size = New System.Drawing.Size(244, 21)
        Me.lblTitleDT.TabIndex = 0
        Me.lblTitleDT.Text = "💰 Tổng Doanh Thu"
        Me.lblTitleDT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlSoHD
        '
        Me.pnlSoHD.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlSoHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlSoHD.Controls.Add(Me.lblSoHD)
        Me.pnlSoHD.Controls.Add(Me.Label11)
        Me.pnlSoHD.Controls.Add(Me.lblTitleHD)
        Me.pnlSoHD.Location = New System.Drawing.Point(287, 25)
        Me.pnlSoHD.Name = "pnlSoHD"
        Me.pnlSoHD.Size = New System.Drawing.Size(244, 124)
        Me.pnlSoHD.TabIndex = 1
        '
        'lblSoHD
        '
        Me.lblSoHD.AutoSize = True
        Me.lblSoHD.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoHD.ForeColor = System.Drawing.Color.White
        Me.lblSoHD.Location = New System.Drawing.Point(110, 42)
        Me.lblSoHD.Name = "lblSoHD"
        Me.lblSoHD.Size = New System.Drawing.Size(28, 32)
        Me.lblSoHD.TabIndex = 0
        Me.lblSoHD.Text = "0"
        Me.lblSoHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label11.Location = New System.Drawing.Point(94, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Hóa Đơn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTitleHD
        '
        Me.lblTitleHD.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitleHD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleHD.ForeColor = System.Drawing.Color.White
        Me.lblTitleHD.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTitleHD.Location = New System.Drawing.Point(0, 0)
        Me.lblTitleHD.Name = "lblTitleHD"
        Me.lblTitleHD.Size = New System.Drawing.Size(244, 21)
        Me.lblTitleHD.TabIndex = 0
        Me.lblTitleHD.Text = "📄 Số Hóa Đơn"
        Me.lblTitleHD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlSoKH
        '
        Me.pnlSoKH.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlSoKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlSoKH.Controls.Add(Me.lblSoKH)
        Me.pnlSoKH.Controls.Add(Me.Label14)
        Me.pnlSoKH.Controls.Add(Me.lblTitleKH)
        Me.pnlSoKH.Location = New System.Drawing.Point(560, 25)
        Me.pnlSoKH.Name = "pnlSoKH"
        Me.pnlSoKH.Size = New System.Drawing.Size(244, 124)
        Me.pnlSoKH.TabIndex = 1
        '
        'lblSoKH
        '
        Me.lblSoKH.AutoSize = True
        Me.lblSoKH.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoKH.ForeColor = System.Drawing.Color.White
        Me.lblSoKH.Location = New System.Drawing.Point(104, 42)
        Me.lblSoKH.Name = "lblSoKH"
        Me.lblSoKH.Size = New System.Drawing.Size(28, 32)
        Me.lblSoKH.TabIndex = 0
        Me.lblSoKH.Text = "0"
        Me.lblSoKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(78, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Khách Hàng"
        '
        'lblTitleKH
        '
        Me.lblTitleKH.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitleKH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleKH.ForeColor = System.Drawing.Color.White
        Me.lblTitleKH.Location = New System.Drawing.Point(0, 0)
        Me.lblTitleKH.Name = "lblTitleKH"
        Me.lblTitleKH.Size = New System.Drawing.Size(244, 21)
        Me.lblTitleKH.TabIndex = 0
        Me.lblTitleKH.Text = "👥 Khách Hàng"
        Me.lblTitleKH.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlTBHD
        '
        Me.pnlTBHD.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlTBHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTBHD.Controls.Add(Me.lblTBHD)
        Me.pnlTBHD.Controls.Add(Me.Label17)
        Me.pnlTBHD.Controls.Add(Me.lblTitleTB)
        Me.pnlTBHD.Location = New System.Drawing.Point(836, 25)
        Me.pnlTBHD.Name = "pnlTBHD"
        Me.pnlTBHD.Size = New System.Drawing.Size(244, 124)
        Me.pnlTBHD.TabIndex = 1
        '
        'lblTBHD
        '
        Me.lblTBHD.AutoSize = True
        Me.lblTBHD.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTBHD.ForeColor = System.Drawing.Color.White
        Me.lblTBHD.Location = New System.Drawing.Point(56, 42)
        Me.lblTBHD.Name = "lblTBHD"
        Me.lblTBHD.Size = New System.Drawing.Size(50, 32)
        Me.lblTBHD.TabIndex = 0
        Me.lblTBHD.Text = "0 đ"
        Me.lblTBHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label17.Location = New System.Drawing.Point(104, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "VNĐ"
        '
        'lblTitleTB
        '
        Me.lblTitleTB.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitleTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTB.ForeColor = System.Drawing.Color.White
        Me.lblTitleTB.Location = New System.Drawing.Point(0, 0)
        Me.lblTitleTB.Name = "lblTitleTB"
        Me.lblTitleTB.Size = New System.Drawing.Size(244, 21)
        Me.lblTitleTB.TabIndex = 0
        Me.lblTitleTB.Text = "📊 Trung Bình/HĐ"
        Me.lblTitleTB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvTK
        '
        Me.dgvTK.AllowUserToAddRows = False
        Me.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTK.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTK.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTK.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgvTK.Location = New System.Drawing.Point(8, 467)
        Me.dgvTK.Name = "dgvTK"
        Me.dgvTK.ReadOnly = True
        Me.dgvTK.Size = New System.Drawing.Size(1090, 242)
        Me.dgvTK.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(945, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "← Quay lại"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblHello.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.White
        Me.lblHello.Location = New System.Drawing.Point(660, 27)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(93, 25)
        Me.lblHello.TabIndex = 66
        Me.lblHello.Text = "Xin chào "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(72, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(363, 40)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "📊 Thống Kê Doanh Thu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(76, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(90, 17)
        Me.lblDate.TabIndex = 67
        Me.lblDate.Text = "dd/MM/yyyy"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(655, 16)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(261, 49)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 70
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(931, 16)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(136, 49)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 71
        Me.PictureBox10.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.dtpTo)
        Me.Panel1.Controls.Add(Me.dtpFrom)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(10, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1088, 204)
        Me.Panel1.TabIndex = 73
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(921, 138)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(149, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 76
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(560, 138)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(149, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 77
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(742, 138)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(149, 42)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 74
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(373, 138)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(149, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 75
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1083, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlTBHD)
        Me.Panel2.Controls.Add(Me.pnlSoKH)
        Me.Panel2.Controls.Add(Me.pnlSoHD)
        Me.Panel2.Controls.Add(Me.pnlDoanhThu)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Location = New System.Drawing.Point(10, 287)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1088, 174)
        Me.Panel2.TabIndex = 74
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(1088, 174)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 75
        Me.PictureBox7.TabStop = False
        '
        'btnxem
        '
        Me.btnxem.Location = New System.Drawing.Point(542, 567)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(75, 23)
        Me.btnxem.TabIndex = 78
        Me.btnxem.Text = "Button1"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'frmThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.dgvTK)
        Me.Controls.Add(Me.btnxem)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmThongKe"
        Me.Text = "cardThongKe"
        Me.pnlDoanhThu.ResumeLayout(False)
        Me.pnlSoHD.ResumeLayout(False)
        Me.pnlSoHD.PerformLayout()
        Me.pnlSoKH.ResumeLayout(False)
        Me.pnlSoKH.PerformLayout()
        Me.pnlTBHD.ResumeLayout(False)
        Me.pnlTBHD.PerformLayout()
        CType(Me.dgvTK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents pnlDoanhThu As Panel
    Friend WithEvents pnlSoHD As Panel
    Friend WithEvents pnlSoKH As Panel
    Friend WithEvents pnlTBHD As Panel
    Friend WithEvents lblTitleDT As Label
    Friend WithEvents lblDoanhThu As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSoHD As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTitleHD As Label
    Friend WithEvents lblSoKH As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTitleKH As Label
    Friend WithEvents lblTBHD As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTitleTB As Label
    Friend WithEvents dgvTK As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents lblHello As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnxem As Button
End Class
