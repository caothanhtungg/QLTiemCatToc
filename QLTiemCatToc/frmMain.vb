Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDashboard()
        lblHello.Text = "Xin chào, " & CurrentUser & If(CurrentRole = "Admin", " (Admin)", " (NV)")

        If CurrentRole <> "Admin" Then
            cardThongKe.Enabled = False
            cardThongKe.Visible = False

        End If
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub RefreshDashboard()
        lblKH.Text = GetTable("SELECT COUNT(*) FROM KhachHang").Rows(0)(0).ToString()

        Dim psLH = New List(Of SqlParameter) From {New SqlParameter("@d", Date.Today)}
        lblLH.Text = GetTable("SELECT COUNT(*) FROM LichHen WHERE Ngay=@d", psLH).Rows(0)(0).ToString()

        Dim psDone = New List(Of SqlParameter) From {New SqlParameter("@d", Date.Today)}
        lblDone.Text = GetTable("SELECT COUNT(*) FROM LichHen WHERE Ngay=@d AND TrangThai=N'Hoàn tất'", psDone).Rows(0)(0).ToString()

        Dim psDT = New List(Of SqlParameter) From {New SqlParameter("@d", Date.Today)}
        Dim t = GetTable("
            SELECT SUM(v.TongThanhToan)
            FROM HoaDon hd JOIN vw_HoaDonTong v ON v.MaHD=hd.MaHD
            WHERE CAST(hd.NgayLap AS DATE)=@d", psDT)
        Dim total As Decimal = If(t.Rows.Count = 0 OrElse IsDBNull(t.Rows(0)(0)), 0D, CDec(t.Rows(0)(0)))
        lblDoanhThu.Text = String.Format("{0:N0}", total)
    End Sub

    Private Sub cardKhachHang_DoubleClick(sender As Object, e As EventArgs) Handles cardKhachHang.DoubleClick
        Using f As New frmKhachHang()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub Label11_doubleClick(sender As Object, e As EventArgs) Handles Label11.DoubleClick
        Using f As New frmKhachHang()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub

    Private Sub cardDichVu_DoubleClick(sender As Object, e As EventArgs) Handles cardDichVu.DoubleClick
        Using f As New frmDichVu()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub Label14_doubleClick(sender As Object, e As EventArgs) Handles Label14.DoubleClick
        Using f As New frmDichVu()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub

    Private Sub cardNhanVien_DoubleClick(sender As Object, e As EventArgs) Handles cardNhanVien.DoubleClick
        Using f As New frmNhanVien()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub Label16_doubleClick(sender As Object, e As EventArgs) Handles Label16.DoubleClick
        Using f As New frmNhanVien()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub

    Private Sub cardLichHen_DoubleClick(sender As Object, e As EventArgs) Handles cardLichhen.DoubleClick
        Using f As New frmLichHen()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub Label18_doubleClick(sender As Object, e As EventArgs) Handles Label18.DoubleClick
        Using f As New frmLichHen()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub

    Private Sub cardHoaDon_DoubleClick(sender As Object, e As EventArgs) Handles cardHoaDon.DoubleClick
        Using f As New frmHoaDon()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub Label22_doubleClick(sender As Object, e As EventArgs) Handles Label22.DoubleClick
        Using f As New frmHoaDon()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub cardThongKe_DoubleClick(sender As Object, e As EventArgs) Handles cardThongKe.DoubleClick
        Using f As New frmThongKe()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub Label20_doubleClick(sender As Object, e As EventArgs) Handles Label20.DoubleClick
        Using f As New frmThongKe()
            Me.Hide()
            f.StartPosition = FormStartPosition.CenterParent
            f.ShowInTaskbar = False
            f.ShowDialog(Me)
            Me.Show() : Me.Activate()
        End Using
    End Sub
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        RefreshDashboard()
    End Sub

    Private Sub cardHoaDon_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click, Label2.Click
        If MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        CurrentUser = ""
        CurrentRole = ""

        Me.Hide()

        Using f As New frmDangNhap()
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog()
        End Using

        Me.Close()
    End Sub

    Private Sub flpMenu_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub lblHello_Click(sender As Object, e As EventArgs) Handles lblHello.Click

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub cardDichVu_Paint(sender As Object, e As PaintEventArgs) Handles cardDichVu.Paint

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class