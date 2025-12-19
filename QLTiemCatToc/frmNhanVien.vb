Imports System.Data.SqlClient
Public Class frmNhanVien
    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHello.Text = "Xin chào, " & CurrentUser & If(CurrentRole = "Admin", " (Admin)", " (NV)")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        dgvNV.AllowUserToAddRows = False
        LoadGrid()
        If CurrentRole <> "Admin" Then pbxoa.Enabled = False
    End Sub

    Private Sub LoadGrid()
        Dim sql = "SELECT MaNV, TenNV, SDT, VaiTro, TrangThai FROM NhanVien"
        dgvNV.DataSource = GetTable(sql)
    End Sub

    Private Sub dgvNV_SelectionChanged(sender As Object, e As EventArgs) Handles dgvNV.SelectionChanged
        If dgvNV.CurrentRow Is Nothing OrElse dgvNV.CurrentRow.IsNewRow Then Return
        With dgvNV.CurrentRow
            txtMaNV.Text = If(IsDBNull(.Cells("MaNV").Value), "", .Cells("MaNV").Value.ToString())
            txtTenNV.Text = If(IsDBNull(.Cells("TenNV").Value), "", .Cells("TenNV").Value.ToString())
            txtSDT.Text = If(IsDBNull(.Cells("SDT").Value), "", .Cells("SDT").Value.ToString())
            cboVaiTro.Text = If(IsDBNull(.Cells("VaiTro").Value), "", .Cells("VaiTro").Value.ToString())
            Dim v = .Cells("TrangThai").Value
            chkTrangThai.Checked = If(v Is Nothing OrElse v Is DBNull.Value, True, Convert.ToBoolean(v))
        End With
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub pbThem_Click(sender As Object, e As EventArgs) Handles pbThem.Click
        txtMaNV.Clear() : txtTenNV.Clear() : txtSDT.Clear()
        cboVaiTro.Text = "" : chkTrangThai.Checked = True
        txtTenNV.Focus()
    End Sub

    Private Sub pbxoa_Click(sender As Object, e As EventArgs) Handles pbxoa.Click
        If CurrentRole <> "Admin" Then
            MessageBox.Show("Chỉ Admin được xoá nhân viên.") : Return
        End If
        If String.IsNullOrWhiteSpace(txtMaNV.Text) Then
            MessageBox.Show("Chưa chọn nhân viên.") : Return
        End If
        If MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Dim ps = New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@Ma", CInt(txtMaNV.Text))
    }

        Try
            Exec("DELETE FROM NhanVien WHERE MaNV=@Ma", ps)
            MessageBox.Show("Đã xóa.")
        Catch ex As SqlClient.SqlException
            If ex.Number = 547 Then
                Exec("UPDATE NhanVien SET TrangThai=0 WHERE MaNV=@Ma", ps)
                MessageBox.Show("NV đã phát sinh dữ liệu. Đã chuyển sang trạng thái NGHỈ.")
            Else
                MessageBox.Show("Lỗi: " & ex.Message)
            End If
        End Try

        LoadGrid()
    End Sub

    Private Sub pbluu_Click(sender As Object, e As EventArgs) Handles pbluu.Click
        If txtTenNV.Text.Trim = "" Then
            MessageBox.Show("Tên NV bắt buộc.") : Return
        End If

        Dim sdt = txtSDT.Text.Trim()
        If sdt <> "" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(sdt, "^(0|\+84)\d{9,10}$") Then
            MessageBox.Show("SĐT không hợp lệ.") : txtSDT.Focus() : Return
        End If
        Dim ps As New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@Ten", txtTenNV.Text.Trim),
        New SqlClient.SqlParameter("@SDT", If(String.IsNullOrWhiteSpace(txtSDT.Text), CType(DBNull.Value, Object), txtSDT.Text.Trim)),
        New SqlClient.SqlParameter("@VaiTro", If(String.IsNullOrWhiteSpace(cboVaiTro.Text), CType(DBNull.Value, Object), cboVaiTro.Text)),
        New SqlClient.SqlParameter("@TT", chkTrangThai.Checked)
    }

        If txtMaNV.Text = "" Then
            Dim sqlI = "INSERT INTO NhanVien(TenNV,SDT,VaiTro,TrangThai) VALUES(@Ten,@SDT,@VaiTro,@TT)"
            Exec(sqlI, ps)
            MessageBox.Show("Đã thêm nhân viên.")
        Else
            ps.Add(New SqlClient.SqlParameter("@Ma", Integer.Parse(txtMaNV.Text)))
            Dim sqlU = "UPDATE NhanVien SET TenNV=@Ten, SDT=@SDT, VaiTro=@VaiTro, TrangThai=@TT WHERE MaNV=@Ma"
            Exec(sqlU, ps)
            MessageBox.Show("Đã cập nhật nhân viên.")
        End If

        LoadGrid()
    End Sub

    Private Sub pbSua_Click(sender As Object, e As EventArgs) Handles pbSua.Click
        If String.IsNullOrWhiteSpace(txtMaNV.Text) Then
            MessageBox.Show("Hãy chọn 1 nhân viên trước khi sửa.") : Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtTenNV.Text) Then
            MessageBox.Show("Tên nhân viên không được trống.") : txtTenNV.Focus() : Exit Sub
        End If
        Dim sdt = txtSDT.Text.Trim()
        If sdt <> "" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(sdt, "^\d{9,11}$") Then
            MessageBox.Show("Số điện thoại không hợp lệ (9–11 số).") : txtSDT.Focus() : Exit Sub
        End If

        Dim sql As String =
    "UPDATE NhanVien
   SET TenNV=@Ten,
       SDT=@SDT,
       VaiTro=@VaiTro,
       TrangThai=@TT
 WHERE MaNV=@Ma"

        Dim ps As New List(Of SqlParameter) From {
            New SqlParameter("@Ma", Integer.Parse(txtMaNV.Text)),
            New SqlParameter("@Ten", txtTenNV.Text.Trim()),
            New SqlParameter("@SDT", If(sdt = "", CType(DBNull.Value, Object), sdt)),
            New SqlParameter("@VaiTro", If(String.IsNullOrWhiteSpace(cboVaiTro.Text), CType(DBNull.Value, Object), cboVaiTro.Text.Trim())),
            New SqlParameter("@TT", If(chkTrangThai.Checked, 1, 0))
        }

        Try
            Dim n = Exec(sql, ps)
            If n > 0 Then
                MessageBox.Show("Đã cập nhật nhân viên.")
                LoadGrid()
            Else
                MessageBox.Show("Không có bản ghi nào được cập nhật.")
            End If
        Catch ex As SqlException
            If ex.Number = 2627 OrElse ex.Number = 2601 Then
                MessageBox.Show("Dữ liệu trùng (ví dụ SDT/username UNIQUE).")
            Else
                MessageBox.Show("Lỗi SQL: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub
End Class