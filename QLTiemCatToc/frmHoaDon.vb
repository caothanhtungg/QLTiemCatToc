Imports System.Data.SqlClient
Public Class frmHoaDon
    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHello.Text = "Xin chào, " & CurrentUser & If(CurrentRole = "Admin", " (Admin)", " (NV)")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        dgvHD.AllowUserToAddRows = False : dgvCT.AllowUserToAddRows = False
        LoadCombosHD()
        LoadHD()
        If CurrentRole <> "Admin" Then
            PictureBox8.Enabled = False
            PictureBox6.Enabled = False
        End If
    End Sub

    Private Sub LoadCombosHD()
        cboKhachHang.DataSource = GetTable("SELECT MaKH, TenKH FROM KhachHang ORDER BY TenKH")
        cboKhachHang.DisplayMember = "TenKH" : cboKhachHang.ValueMember = "MaKH"

        cboDichVu.DataSource = GetTable("SELECT MaDV, TenDV, DonGia FROM DichVu WHERE IsActive=1 ORDER BY TenDV")
        cboDichVu.DisplayMember = "TenDV" : cboDichVu.ValueMember = "MaDV"
    End Sub

    Private Sub LoadHD()
        dgvHD.DataSource = GetTable("SELECT MaHD, MaKH, NgayLap, GiamGia, Thue FROM HoaDon ORDER BY MaHD DESC")
    End Sub

    Private Sub dgvHD_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHD.CellClick
        If e.RowIndex < 0 Then Return
        Dim r = dgvHD.Rows(e.RowIndex)
        txtMaHD.Text = r.Cells("MaHD").Value.ToString()
        cboKhachHang.SelectedValue = CInt(r.Cells("MaKH").Value)
        dtpNgayLap.Value = CDate(r.Cells("NgayLap").Value)
        numGiamGia.Value = If(IsDBNull(r.Cells("GiamGia").Value), 0D, CDec(r.Cells("GiamGia").Value))
        numThue.Value = If(IsDBNull(r.Cells("Thue").Value), 0D, CDec(r.Cells("Thue").Value))


        dgvCT.DataSource = GetTable(
        "SELECT ct.MaDV, dv.TenDV, ct.SoLuong, ct.DonGia, (ct.SoLuong*ct.DonGia) AS ThanhTien
         FROM ChiTietHoaDon ct JOIN DichVu dv ON dv.MaDV=ct.MaDV
         WHERE ct.MaHD=@ma",
        New List(Of SqlParameter) From {New SqlParameter("@ma", CInt(txtMaHD.Text))})

        Dim t = GetTable("SELECT TongThanhToan FROM vw_HoaDonTong WHERE MaHD=@ma",
                         New List(Of SqlClient.SqlParameter) From {New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text))})

        Dim total As Decimal = 0D
        If t.Rows.Count > 0 AndAlso Not IsDBNull(t.Rows(0)("TongThanhToan")) Then
            total = Convert.ToDecimal(t.Rows(0)("TongThanhToan"))
        End If
        lblTongTien.Text = String.Format("{0:N0} đ", total)

    End Sub

    Private Sub cboDichVu_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDichVu.SelectionChangeCommitted
        Dim dv = DirectCast(cboDichVu.SelectedItem, DataRowView)
        txtDonGia.Text = If(IsDBNull(dv("DonGia")), "0", CDec(dv("DonGia")).ToString())
    End Sub

    Private Sub RefreshCT()
        dgvCT.DataSource = GetTable(
            "SELECT ct.MaDV, dv.TenDV, ct.SoLuong, ct.DonGia, (ct.SoLuong*ct.DonGia) AS ThanhTien
         FROM ChiTietHoaDon ct JOIN DichVu dv ON dv.MaDV=ct.MaDV
         WHERE ct.MaHD=@ma",
            New List(Of SqlClient.SqlParameter) From {New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text))})

        Dim t = GetTable("SELECT TongThanhToan FROM vw_HoaDonTong WHERE MaHD=@ma",
                         New List(Of SqlClient.SqlParameter) From {New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text))})
        Dim total As Decimal = 0D
        If t.Rows.Count > 0 AndAlso Not IsDBNull(t.Rows(0)(0)) Then total = CDec(t.Rows(0)(0))
        lblTongTien.Text = String.Format("{0:N0} đ", total)
    End Sub


    Private Sub btnquaylai_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        txtMaHD.Clear()
        If cboKhachHang.Items.Count > 0 Then cboKhachHang.SelectedIndex = 0
        dtpNgayLap.Value = Date.Now
        numGiamGia.Value = 0
        numThue.Value = 0
        dgvCT.DataSource = Nothing
        lblTongTien.Text = "0 đ"
        cboKhachHang.Focus()
    End Sub

    Private Sub btnThemHD_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If cboKhachHang.SelectedValue Is Nothing Then
            MessageBox.Show("Chọn khách hàng!") : Return
        End If

        Dim ps As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@kh", CInt(cboKhachHang.SelectedValue)),
            New SqlClient.SqlParameter("@ngay", dtpNgayLap.Value),
            New SqlClient.SqlParameter("@giam", numGiamGia.Value),
            New SqlClient.SqlParameter("@thue", numThue.Value)
        }
        If numGiamGia.Value < 0 OrElse numGiamGia.Value > 100 Then
            MessageBox.Show("Giảm giá phải trong khoảng 0–100%.") : Return
        End If
        If numThue.Value < 0 OrElse numThue.Value > 100 Then
            MessageBox.Show("Thuế phải trong khoảng 0–100%.") : Return
        End If

        If String.IsNullOrEmpty(txtMaHD.Text) Then
            Dim sqlI = "INSERT INTO HoaDon(MaKH, NgayLap, GiamGia, Thue)
                    VALUES(@kh,@ngay,@giam,@thue);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);"
            Dim tb = GetTable(sqlI, ps)
            txtMaHD.Text = tb.Rows(0)(0).ToString()
            MessageBox.Show("Đã tạo hóa đơn #" & txtMaHD.Text)
        Else
            ps.Add(New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text)))
            Dim sqlU = "UPDATE HoaDon SET MaKH=@kh, NgayLap=@ngay, GiamGia=@giam, Thue=@thue WHERE MaHD=@ma"
            Exec(sqlU, ps)
            MessageBox.Show("Đã cập nhật hóa đơn.")
        End If

        LoadHD()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If String.IsNullOrEmpty(txtMaHD.Text) Then
            MessageBox.Show("Hãy lưu hóa đơn trước khi thêm chi tiết.") : Return
        End If

        Dim sl As Integer = CInt(numSoLuong.Value)
        Dim gia As Decimal
        If sl <= 0 Then
            MessageBox.Show("Số lượng phải > 0.") : numSoLuong.Focus() : Return
        End If
        If Not Decimal.TryParse(txtDonGia.Text, gia) OrElse gia < 0D Then
            MessageBox.Show("Đơn giá phải là số ≥ 0.") : txtDonGia.Focus() : Return
        End If

        If cboDichVu.SelectedValue Is Nothing Then
            MessageBox.Show("Chọn dịch vụ.") : cboDichVu.Focus() : Return
        End If


        Dim ps As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text)),
            New SqlClient.SqlParameter("@dv", CInt(cboDichVu.SelectedValue)),
            New SqlClient.SqlParameter("@sl", sl),
            New SqlClient.SqlParameter("@gia", gia)
        }

        Dim sql =
            "IF EXISTS(SELECT 1 FROM ChiTietHoaDon WHERE MaHD=@ma AND MaDV=@dv)
           UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @sl, DonGia=@gia
           WHERE MaHD=@ma AND MaDV=@dv
         ELSE
           INSERT INTO ChiTietHoaDon(MaHD,MaDV,SoLuong,DonGia) VALUES(@ma,@dv,@sl,@gia);"
        Exec(sql, ps)
        RefreshCT()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If CurrentRole <> "Admin" Then
            MessageBox.Show("Chỉ Admin được xoá chi tiết.") : Return
        End If
        If String.IsNullOrEmpty(txtMaHD.Text) OrElse dgvCT.CurrentRow Is Nothing Then
            MessageBox.Show("Chọn dòng chi tiết để xóa.") : Return
        End If
        Dim maDV As Integer = CInt(dgvCT.CurrentRow.Cells("MaDV").Value)
        If MessageBox.Show("Xóa dịch vụ này khỏi hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Dim ps = New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text)),
        New SqlClient.SqlParameter("@dv", maDV)
    }
        Try
            Exec("DELETE FROM ChiTietHoaDon WHERE MaHD=@ma AND MaDV=@dv", ps)
            MessageBox.Show("Đã xóa chi tiết.")
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        RefreshCT()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If String.IsNullOrEmpty(txtMaHD.Text) Then
            MessageBox.Show("Chưa chọn hóa đơn.") : Return
        End If
        If MessageBox.Show("Xóa hóa đơn này? (Sẽ xóa cả chi tiết)", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Dim ps = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text))
        }

        Try
            Exec("DELETE FROM ChiTietHoaDon WHERE MaHD=@ma", ps)
            Exec("DELETE FROM HoaDon WHERE MaHD=@ma", ps)
            MessageBox.Show("Đã xóa hóa đơn.")
            txtMaHD.Clear()
            dgvCT.DataSource = Nothing
            lblTongTien.Text = "0 đ"
            LoadHD()
        Catch ex As SqlClient.SqlException
            If ex.Number = 547 Then
                MessageBox.Show("Không thể xóa do ràng buộc dữ liệu.")
            Else
                MessageBox.Show("Lỗi: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If String.IsNullOrEmpty(txtMaHD.Text) Then
            MessageBox.Show("Chưa chọn hóa đơn để in.") : Return
        End If

        Dim cnt = CInt(GetTable(
           "SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaHD=@ma",
           New List(Of SqlClient.SqlParameter) From {
           New SqlClient.SqlParameter("@ma", CInt(txtMaHD.Text))
           }).Rows(0)(0))

        If cnt = 0 Then
            MessageBox.Show("Hóa đơn chưa có chi tiết. Không thể in.")
            Return
        End If

        ppdHD.Document = pdHD
        ppdHD.ShowDialog()
    End Sub
    Private Sub pdHD_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdHD.PrintPage
        Dim g = e.Graphics, y As Integer = 40
        Dim fH = New Font("Segoe UI", 12, FontStyle.Bold)
        Dim f = New Font("Segoe UI", 10)

        g.DrawString("HÓA ĐƠN DỊCH VỤ", fH, Brushes.Black, 300, y) : y += 40
        g.DrawString("Mã HĐ: " & txtMaHD.Text, f, Brushes.Black, 60, y) : y += 20
        g.DrawString("Khách hàng: " & cboKhachHang.Text, f, Brushes.Black, 60, y) : y += 20
        g.DrawString("Ngày lập: " & dtpNgayLap.Value.ToString("dd/MM/yyyy HH:mm"), f, Brushes.Black, 60, y) : y += 30

        g.DrawString("Dịch vụ", fH, Brushes.Black, 60, y)
        g.DrawString("SL", fH, Brushes.Black, 360, y)
        g.DrawString("Đơn giá", fH, Brushes.Black, 420, y)
        g.DrawString("Thành tiền", fH, Brushes.Black, 540, y) : y += 25

        For Each r As DataGridViewRow In dgvCT.Rows
            If r.IsNewRow Then Continue For
            g.DrawString(r.Cells("TenDV").Value.ToString(), f, Brushes.Black, 60, y)
            g.DrawString(r.Cells("SoLuong").Value.ToString(), f, Brushes.Black, 360, y)
            g.DrawString(CDec(r.Cells("DonGia").Value).ToString("N0"), f, Brushes.Black, 420, y)
            g.DrawString(CDec(r.Cells("ThanhTien").Value).ToString("N0"), f, Brushes.Black, 540, y)
            y += 20
        Next

        y += 10
        g.DrawString("Giảm giá (%): " & numGiamGia.Value, f, Brushes.Black, 420, y) : y += 20
        g.DrawString("Thuế (%): " & numThue.Value, f, Brushes.Black, 420, y) : y += 20
        g.DrawString("TỔNG THANH TOÁN: " & lblTongTien.Text, fH, Brushes.Black, 420, y)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
    End Sub

    Private Sub lblTongTien_Click(sender As Object, e As EventArgs) Handles lblTongTien.Click

    End Sub
End Class