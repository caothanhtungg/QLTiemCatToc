Imports System.Data.SqlClient
Public Class frmLichHen



    Private Sub frmLichHen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hiển thị chào user
        lblHello.Text = "Xin chào, " & CurrentUser & If(CurrentRole = "Admin", " (Admin)", " (NV)")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        dgvLich.AllowUserToAddRows = False
        dgvLich.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLich.MultiSelect = False
        LoadCombos()
        LoadGrid()
    End Sub
    Private Sub dgvLich_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLich.CellClick
        If e.RowIndex < 0 Then Return
        Dim r = dgvLich.Rows(e.RowIndex)

        txtMaLich.Text = r.Cells("MaLich").Value.ToString()
        cboKhachHang.SelectedValue = CInt(r.Cells("MaKH").Value)
        cboNhanVien.SelectedValue = CInt(r.Cells("MaNV").Value)
        cboDichVu.SelectedValue = CInt(r.Cells("MaDV").Value)
        dtpNgay.Value = CDate(r.Cells("Ngay").Value)
        Dim t As TimeSpan = DirectCast(r.Cells("Gio").Value, TimeSpan)
        cboGio.Text = t.ToString("hh\:mm")
        cboTrangThai.Text = r.Cells("TrangThai").Value.ToString()
        txtGhiChu.Text = If(IsDBNull(r.Cells("GhiChu").Value), "", r.Cells("GhiChu").Value.ToString())
    End Sub
    Private Sub LoadCombos()
        ' Khách hàng
        Dim kh = GetTable("SELECT MaKH, TenKH FROM KhachHang ORDER BY TenKH")
        cboKhachHang.DataSource = kh : cboKhachHang.DisplayMember = "TenKH" : cboKhachHang.ValueMember = "MaKH"

        ' Nhân viên (đang làm)
        Dim nv = GetTable("SELECT MaNV, TenNV FROM NhanVien WHERE TrangThai=1 ORDER BY TenNV")
        cboNhanVien.DataSource = nv : cboNhanVien.DisplayMember = "TenNV" : cboNhanVien.ValueMember = "MaNV"

        ' Dịch vụ (còn hoạt động)
        Dim dv = GetTable("SELECT MaDV, TenDV FROM DichVu WHERE IsActive=1 ORDER BY TenDV")
        cboDichVu.DataSource = dv : cboDichVu.DisplayMember = "TenDV" : cboDichVu.ValueMember = "MaDV"

        ' Giờ hẹn (mỗi 30 phút 08:00–20:00)
        cboGio.Items.Clear()
        For h = 8 To 20
            cboGio.Items.Add(String.Format("{0:00}:00", h))
            cboGio.Items.Add(String.Format("{0:00}:30", h))
        Next
        cboGio.SelectedIndex = 0

        ' Trạng thái
        cboTrangThai.Items.Clear()
        cboTrangThai.Items.AddRange(New String() {"Đặt", "Hoàn tất", "Hủy"})
        cboTrangThai.SelectedIndex = 0
    End Sub
    Private Sub LoadGrid(Optional ngay As Date? = Nothing)
        Dim sql As String =
            "SELECT lh.MaLich, kh.TenKH, nv.TenNV, dv.TenDV, lh.Ngay, lh.Gio, lh.TrangThai, lh.GhiChu,
                lh.MaKH, lh.MaNV, lh.MaDV
         FROM LichHen lh
         JOIN KhachHang kh ON kh.MaKH = lh.MaKH
         JOIN NhanVien nv ON nv.MaNV = lh.MaNV
         JOIN DichVu dv ON dv.MaDV = lh.MaDV"

        Dim ps As New List(Of SqlClient.SqlParameter)
        If ngay.HasValue Then
            sql &= " WHERE lh.Ngay = @d"
            ps.Add(New SqlClient.SqlParameter("@d", ngay.Value.Date))
        End If
        sql &= " ORDER BY lh.Ngay DESC, lh.Gio DESC"

        dgvLich.DataSource = GetTable(sql, ps)
    End Sub
    Private Sub dgvLich_SelectionChanged(sender As Object, e As EventArgs)
        If dgvLich.CurrentRow Is Nothing OrElse dgvLich.CurrentRow.IsNewRow Then Return
        With dgvLich.CurrentRow
            txtMaLich.Text = .Cells("MaLich").Value.ToString()
            cboKhachHang.SelectedValue = CInt(.Cells("MaKH").Value)
            cboNhanVien.SelectedValue = CInt(.Cells("MaNV").Value)
            cboDichVu.SelectedValue = CInt(.Cells("MaDV").Value)
            dtpNgay.Value = CDate(.Cells("Ngay").Value)
            cboGio.Text = CDate(.Cells("Gio").Value).ToString("HH:mm")
            cboTrangThai.Text = .Cells("TrangThai").Value.ToString()
            txtGhiChu.Text = If(IsDBNull(.Cells("GhiChu").Value), "", .Cells("GhiChu").Value.ToString())
        End With
    End Sub



    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtMaLich.Clear()
        cboKhachHang.SelectedIndex = 0
        cboNhanVien.SelectedIndex = 0
        cboDichVu.SelectedIndex = 0
        dtpNgay.Value = Date.Today
        cboGio.SelectedIndex = 0
        cboTrangThai.Text = "Đặt"
        txtGhiChu.Clear()
        cboKhachHang.Focus()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If String.IsNullOrWhiteSpace(txtMaLich.Text) Then
            MessageBox.Show("Chưa chọn lịch hẹn.") : Return
        End If
        If MessageBox.Show("Xóa lịch hẹn này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Dim ps = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@ma", CInt(txtMaLich.Text))
        }

        Try
            Exec("DELETE FROM LichHen WHERE MaLich=@ma", ps)
            MessageBox.Show("Đã xóa lịch hẹn.")
        Catch ex As SqlClient.SqlException
            ' Nếu lịch đã được dùng nơi khác (ví dụ gắn vào hóa đơn…) → không xóa cứng
            If ex.Number = 547 Then
                Exec("UPDATE LichHen SET TrangThai=N'Hủy' WHERE MaLich=@ma", ps)
                MessageBox.Show("Lịch hẹn đã phát sinh dữ liệu. Đã chuyển trạng thái thành 'Hủy'.")
            Else
                MessageBox.Show("Lỗi: " & ex.Message)
            End If
        End Try

        LoadGrid() ' nạp lại danh sách
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        '=== VALIDATE ===
        If cboKhachHang.SelectedValue Is Nothing Then MessageBox.Show("Chọn Khách hàng.") : Return
        If cboNhanVien.SelectedValue Is Nothing Then MessageBox.Show("Chọn Nhân viên.") : Return
        If cboDichVu.SelectedValue Is Nothing Then MessageBox.Show("Chọn Dịch vụ.") : Return
        If String.IsNullOrWhiteSpace(cboGio.Text) Then MessageBox.Show("Chọn giờ hẹn.") : Return
        '=== /VALIDATE ===
        If cboKhachHang.SelectedValue Is Nothing OrElse cboNhanVien.SelectedValue Is Nothing OrElse cboDichVu.SelectedValue Is Nothing Then
            MessageBox.Show("Chọn đủ Khách hàng, Nhân viên, Dịch vụ.") : Return
        End If
        '=== CHECK TRÙNG SLOT ===
        Dim psCheck = New List(Of SqlClient.SqlParameter) From {
    New SqlClient.SqlParameter("@ma", If(String.IsNullOrEmpty(txtMaLich.Text), CType(DBNull.Value, Object), CInt(txtMaLich.Text))),
    New SqlClient.SqlParameter("@nv", CInt(cboNhanVien.SelectedValue)),
    New SqlClient.SqlParameter("@ngay", dtpNgay.Value.Date),
    New SqlClient.SqlParameter("@gio", TimeSpan.Parse(cboGio.Text))
}
        Dim sqlCheck = "
    SELECT COUNT(*) 
    FROM LichHen 
    WHERE MaNV=@nv AND Ngay=@ngay AND Gio=@gio 
      AND (@ma IS NULL OR MaLich<>@ma)"
        Dim tr = CInt(GetTable(sqlCheck, psCheck).Rows(0)(0))
        If tr > 0 Then
            MessageBox.Show("Nhân viên này đã có lịch ở khung giờ đó.") : Return
        End If
        '=== /CHECK TRÙNG SLOT ===

        Dim ps As New List(Of SqlParameter) From {
            New SqlParameter("@kh", CInt(cboKhachHang.SelectedValue)),
            New SqlParameter("@nv", CInt(cboNhanVien.SelectedValue)),
            New SqlParameter("@dv", CInt(cboDichVu.SelectedValue)),
            New SqlParameter("@ngay", dtpNgay.Value.Date),
            New SqlParameter("@gio", TimeSpan.Parse(cboGio.Text)),
            New SqlParameter("@tt", cboTrangThai.Text),
            New SqlParameter("@gc", If(String.IsNullOrWhiteSpace(txtGhiChu.Text), CType(DBNull.Value, Object), txtGhiChu.Text.Trim))
        }

        If String.IsNullOrEmpty(txtMaLich.Text) Then
            ' INSERT
            Dim sqlI = "INSERT INTO LichHen(MaKH,MaNV,MaDV,Ngay,Gio,TrangThai,GhiChu)
                    VALUES(@kh,@nv,@dv,@ngay,@gio,@tt,@gc)"
            Exec(sqlI, ps)
            MessageBox.Show("Đã thêm lịch hẹn.")
        Else
            ' UPDATE
            ps.Add(New SqlParameter("@ma", CInt(txtMaLich.Text)))
            Dim sqlU = "UPDATE LichHen SET MaKH=@kh,MaNV=@nv,MaDV=@dv,Ngay=@ngay,Gio=@gio,TrangThai=@tt,GhiChu=@gc
                    WHERE MaLich=@ma"
            Try
                Exec(sqlU, ps)
                MessageBox.Show("Đã cập nhật lịch hẹn.")
            Catch ex As SqlException
                If ex.Number = 2627 OrElse ex.Number = 2601 Then
                    MessageBox.Show("Nhân viên đã có lịch ở khung giờ này.")
                Else
                    MessageBox.Show("Lỗi: " & ex.Message)
                End If
            End Try
        End If

        LoadGrid()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
    End Sub
End Class