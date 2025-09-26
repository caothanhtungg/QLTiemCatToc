
Public Class frmThongKe

    Private Sub LoadKPI(d1 As Date, d2 As Date)
        Dim soHD = CInt(GetTable(
        "SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS DATE) BETWEEN @d1 AND @d2",
        New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@d1", d1),
            New SqlClient.SqlParameter("@d2", d2)
        }).Rows(0)(0))

        Dim soKH = CInt(GetTable(
        "SELECT COUNT(DISTINCT MaKH) FROM HoaDon WHERE CAST(NgayLap AS DATE) BETWEEN @d1 AND @d2",
        New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@d1", d1),
            New SqlClient.SqlParameter("@d2", d2)
        }).Rows(0)(0))

        Dim t = GetTable(
        "SELECT SUM(v.TongThanhToan)
         FROM HoaDon hd JOIN vw_HoaDonTong v ON v.MaHD=hd.MaHD
         WHERE CAST(hd.NgayLap AS DATE) BETWEEN @d1 AND @d2",
        New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@d1", d1),
            New SqlClient.SqlParameter("@d2", d2)
        })
        Dim total As Decimal = If(t.Rows.Count = 0 OrElse IsDBNull(t.Rows(0)(0)), 0D, CDec(t.Rows(0)(0)))

        lblSoHD.Text = soHD.ToString()
        lblSoKH.Text = soKH.ToString()
        lblDoanhThu.Text = String.Format("{0:N0} đ", total)
        lblTBHD.Text = String.Format("{0:N0} đ", If(soHD > 0, total / soHD, 0D))
    End Sub

    Private Sub frmThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hiển thị chào user
        lblHello.Text = "Xin chào, " & CurrentUser & If(CurrentRole = "Admin", " (Admin)", " (NV)")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        With dgvTK
            .AutoGenerateColumns = True
            .AllowUserToAddRows = False
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .RowsDefaultCellStyle.ForeColor = Color.Black
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
            .DefaultCellStyle.SelectionForeColor = Color.White
        End With
    End Sub

    ' đặt nhanh khoảng ngày rồi gọi lại Xem
    Private Sub SetRangeAndView(d1 As Date, d2 As Date)
        dtpFrom.Value = d1
        dtpTo.Value = d2
        btnxem.PerformClick()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnquaylai_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        btnxem.PerformClick()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim d = Date.Today
        SetRangeAndView(d, d)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim d1 As New Date(Date.Today.Year, Date.Today.Month, 1)
        Dim d2 As Date = Date.Today
        SetRangeAndView(d1, d2)
    End Sub

    Private Sub dgvTK_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTK.CellContentClick

    End Sub

    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        Dim d1 = dtpFrom.Value.Date, d2 = dtpTo.Value.Date
        LoadKPI(d1, d2)
        Dim ps = New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@d1", d1),
        New SqlClient.SqlParameter("@d2", d2)
    }
        dgvTK.DataSource = GetTable("
        SELECT hd.MaHD, kh.TenKH, hd.NgayLap, v.TongThanhToan
        FROM HoaDon hd
        JOIN vw_HoaDonTong v ON v.MaHD = hd.MaHD
        JOIN KhachHang kh ON kh.MaKH = hd.MaKH
        WHERE CAST(hd.NgayLap AS DATE) BETWEEN @d1 AND @d2
        ORDER BY hd.NgayLap", ps)
    End Sub
End Class