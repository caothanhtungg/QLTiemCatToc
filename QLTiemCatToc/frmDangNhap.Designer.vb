<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDangNhap
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRight.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlRight.Controls.Add(Me.PictureBox3)
        Me.pnlRight.Controls.Add(Me.PictureBox2)
        Me.pnlRight.Controls.Add(Me.txtUser)
        Me.pnlRight.Controls.Add(Me.chkShowPass)
        Me.pnlRight.Controls.Add(Me.txtPass)
        Me.pnlRight.Controls.Add(Me.Label3)
        Me.pnlRight.Controls.Add(Me.Label8)
        Me.pnlRight.Controls.Add(Me.Label2)
        Me.pnlRight.Controls.Add(Me.Label1)
        Me.pnlRight.Controls.Add(Me.PictureBox4)
        Me.pnlRight.Location = New System.Drawing.Point(361, 150)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(446, 400)
        Me.pnlRight.TabIndex = 14
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(252, 299)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 73)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 299)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(26, 124)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(386, 46)
        Me.txtUser.TabIndex = 22
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkShowPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.chkShowPass.Location = New System.Drawing.Point(26, 259)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(130, 25)
        Me.chkShowPass.TabIndex = 29
        Me.chkShowPass.Text = "Hiện mật khẩu"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(26, 212)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(386, 46)
        Me.txtPass.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 47)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Salon Tóc Đẹp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(18, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Đăng Nhập Hệ Thống"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Mật Khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tài khoản:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(443, 397)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(125, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Dành cho Nhân viên & Chủ tiệm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(122, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(326, 40)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Quản Lý Quán Cắt Tóc"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QLTiemCatToc.My.Resources.Resources.Elegant_Hair_Salon_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(57, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 730)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.Label9)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmDangNhap"
        Me.Text = "frmDangNhap"
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlRight As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
