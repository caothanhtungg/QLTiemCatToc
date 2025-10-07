Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmKhachHang
    Private Sub LoadGrid(Optional kw As String = "")
        Dim sql = "SELECT MaKH, TenKH, SDT, GioiTinh, NgaySinh, GhiChu FROM KhachHang"
        Dim ps As New List(Of SqlClient.SqlParameter)
        If kw <> "" Then
            sql &= " WHERE TenKH LIKE @kw OR SDT LIKE @kw"
            ps.Add(New SqlClient.SqlParameter("@kw", "%" & kw & "%"))
        End If
        dgvKH.DataSource = GetTable(sql, ps)
    End Sub
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hiển thị chào user
        lblHello.Text = "Xin chào, " & CurrentUser & If(CurrentRole = "Admin", " (Admin)", " (NV)")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        LoadGrid()
    End Sub
    Private Sub dgvKH_SelectionChanged(sender As Object, e As EventArgs) Handles dgvKH.SelectionChanged
        If dgvKH.CurrentRow Is Nothing OrElse dgvKH.CurrentRow.IsNewRow Then Return
        With dgvKH.CurrentRow
            txtMaKH.Text = .Cells("MaKH").Value.ToString()
            txtTen.Text = .Cells("TenKH").Value.ToString()
            txtSDT.Text = .Cells("SDT").Value.ToString()
            cboGioiTinh.Text = If(IsDBNull(.Cells("GioiTinh").Value), "", .Cells("GioiTinh").Value.ToString())
            If IsDBNull(.Cells("NgaySinh").Value) Then
                dtpNgaySinh.Checked = False
            Else
                dtpNgaySinh.Checked = True
                dtpNgaySinh.Value = CDate(.Cells("NgaySinh").Value)
            End If
            txtGhiChu.Text = If(IsDBNull(.Cells("GhiChu").Value), "", .Cells("GhiChu").Value.ToString())
        End With
    End Sub
    Private Sub txtTim_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTim.KeyDown
        If e.KeyCode = Keys.Enter Then LoadGrid(txtTim.Text.Trim())
    End Sub
    Private Sub txtTim_TextChanged(sender As Object, e As EventArgs) Handles txtTim.TextChanged
        If txtTim.Text.Length = 0 Then LoadGrid()
    End Sub
    Private Function IsValidPhone(s As String) As Boolean
        Return Regex.IsMatch(s, "^(0[0-9]{9,10})$") ' 10–11 số, bắt đầu bằng 0
    End Function
    ''chặn gõ chữ vào SĐT
    Private Sub txtSDT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSDT.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub
    Private Sub BaseGrid(dgv As DataGridView)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersHeight = 34
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToResizeRows = False

        ' Định dạng cột nếu trùng tên trong ảnh
        If dgv.Columns.Contains("NgaySinh") Then
            dgv.Columns("NgaySinh").DefaultCellStyle.Format = "dd/MM/yyyy"
        End If
        If dgv.Columns.Contains("SDT") Then
            dgv.Columns("SDT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        ' Chống nhấp nháy khi cuộn (double-buffer)
        Dim t = dgv.GetType()
        Dim pi = t.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If pi IsNot Nothing Then pi.SetValue(dgv, True, Nothing)
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        BaseGrid(dgvKH)

        dgvKH.BackgroundColor = ColorTranslator.FromHtml("#0B1220")

        Dim header = dgvKH.ColumnHeadersDefaultCellStyle
        header.BackColor = ColorTranslator.FromHtml("#0F172A")
        header.ForeColor = Color.White
        header.Font = New Font("Inter", 10.0!, FontStyle.Bold)
        header.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvKH.GridColor = ColorTranslator.FromHtml("#111827") ' đường kẻ mảnh

        dgvKH.DefaultCellStyle.Font = New Font("Inter", 10.0!)
        dgvKH.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0B1324")
        dgvKH.DefaultCellStyle.ForeColor = Color.Gainsboro
        dgvKH.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#F59E0B") ' gold
        dgvKH.DefaultCellStyle.SelectionForeColor = Color.Black

        dgvKH.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#111827")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Close()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtMaKH.Clear() : txtTen.Clear() : txtSDT.Clear() : txtGhiChu.Clear()
        cboGioiTinh.SelectedIndex = -1 : dtpNgaySinh.Checked = False
        txtTen.Focus()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ' 1) Validate
        If txtTen.Text.Trim = "" Then
            MessageBox.Show("Tên bắt buộc.") : txtTen.Focus() : Return
        End If
        If txtSDT.Text.Trim = "" OrElse Not IsValidPhone(txtSDT.Text.Trim) Then
            MessageBox.Show("SĐT không hợp lệ (bắt đầu bằng 0, 10-11 số).")
            txtSDT.Focus() : Return
        End If
        If dtpNgaySinh.Checked AndAlso dtpNgaySinh.Value.Date > Date.Today Then
            MessageBox.Show("Ngày sinh không được lớn hơn hôm nay.")
            dtpNgaySinh.Focus() : Return
        End If
        ' 2) Tham số chung
        Dim ps As New List(Of SqlParameter) From {
        New SqlParameter("@Ten", txtTen.Text.Trim),
        New SqlParameter("@SDT", txtSDT.Text.Trim),
        New SqlParameter("@GT", If(String.IsNullOrEmpty(cboGioiTinh.Text), CType(DBNull.Value, Object), cboGioiTinh.Text)),
        New SqlParameter("@NS", If(dtpNgaySinh.Checked, CType(dtpNgaySinh.Value.Date, Object), DBNull.Value)),
        New SqlParameter("@GC", If(String.IsNullOrWhiteSpace(txtGhiChu.Text), CType(DBNull.Value, Object), txtGhiChu.Text.Trim))
    }

        ' 3) Thêm / Sửa
        Try
            If String.IsNullOrEmpty(txtMaKH.Text) Then
                Exec("INSERT INTO KhachHang(TenKH,SDT,GioiTinh,NgaySinh,GhiChu)
                  VALUES(@Ten,@SDT,@GT,@NS,@GC)", ps)
                MessageBox.Show("Đã thêm khách hàng.")
            Else
                ps.Add(New SqlParameter("@Ma", CInt(txtMaKH.Text)))
                Exec("UPDATE KhachHang
                  SET TenKH=@Ten, SDT=@SDT, GioiTinh=@GT, NgaySinh=@NS, GhiChu=@GC
                  WHERE MaKH=@Ma", ps)
                MessageBox.Show("Đã cập nhật khách hàng.")
            End If
        Catch ex As SqlException
            ' Nếu có UNIQUE SDT
            If ex.Number = 2627 OrElse ex.Message.Contains("UNIQUE") Then
                MessageBox.Show("SĐT đã tồn tại.") : txtSDT.Focus()
            Else
                MessageBox.Show("Lỗi: " & ex.Message)
            End If
        End Try

        ' 4) Refresh lưới
        LoadGrid()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Chưa chọn khách hàng để xóa.") : Return
        End If
        If MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Dim ps As New List(Of SqlClient.SqlParameter) From {New SqlClient.SqlParameter("@Ma", CInt(txtMaKH.Text))}
        Try
            Exec("DELETE FROM KhachHang WHERE MaKH=@Ma", ps)
            MessageBox.Show("Đã xóa khách hàng.")
        Catch ex As SqlClient.SqlException
            If ex.Number = 547 Then
                MessageBox.Show("Khách hàng đã phát sinh dữ liệu (lịch hẹn/hóa đơn). Không thể xóa.")
            Else
                MessageBox.Show("Lỗi: " & ex.Message)
            End If
        End Try
        LoadGrid()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        LoadGrid(txtTim.Text.Trim())
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ' Kiểm tra chọn dòng + dữ liệu tối thiểu
        If String.IsNullOrWhiteSpace(txtMaKH.Text) Then
            MessageBox.Show("Hãy chọn 1 khách hàng trong bảng trước khi sửa.")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtTen.Text) Then
            MessageBox.Show("Tên khách hàng không được để trống.")
            txtTen.Focus() : Exit Sub
        End If
        ' Kiểm tra SĐT đơn giản (9–11 số) – tùy bạn
        Dim sdt = txtSDT.Text.Trim()
        If sdt <> "" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(sdt, "^\d{9,11}$") Then
            MessageBox.Show("Số điện thoại không hợp lệ (9–11 số).")
            txtSDT.Focus() : Exit Sub
        End If

        ' UPDATE
        Dim sql As String =
    "UPDATE KhachHang
SET TenKH=@TenKH, SDT=@SDT, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, GhiChu=@GhiChu
WHERE MaKH=@MaKH"

        Dim ps As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@MaKH", txtMaKH.Text.Trim()),
            New SqlClient.SqlParameter("@TenKH", txtTen.Text.Trim()),
            New SqlClient.SqlParameter("@SDT", If(sdt = "", CType(DBNull.Value, Object), sdt)),
            New SqlClient.SqlParameter("@GioiTinh", If(String.IsNullOrWhiteSpace(cboGioiTinh.Text), CType(DBNull.Value, Object), cboGioiTinh.Text)),
            New SqlClient.SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
            New SqlClient.SqlParameter("@GhiChu", If(String.IsNullOrWhiteSpace(txtGhiChu.Text), CType(DBNull.Value, Object), txtGhiChu.Text.Trim()))
        }

        Try
            Exec(sql, ps)                 ' dùng hàm NonQuery sẵn có của bạn
            LoadGrid(txtTim.Text.Trim())     ' reload bảng (giữ keyword nếu có)
            MessageBox.Show("Đã cập nhật khách hàng.")
        Catch ex As SqlClient.SqlException
            If ex.Number = 2627 OrElse ex.Number = 2601 Then
                MessageBox.Show("SĐT đã tồn tại (trùng unique).")
            Else
                MessageBox.Show("Lỗi SQL: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub
End Class