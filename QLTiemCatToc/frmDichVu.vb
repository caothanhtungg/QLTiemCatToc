Imports System.Data.SqlClient
Public Class frmDichVu
    Private Sub frmDichVu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hiển thị chào user
        lblHello.Text = "Xin chào, " & CurrentUser & If(CurrentRole = "Admin", " (Admin)", " (NV)")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        LoadGrid()
        dgvDV.AllowUserToAddRows = False
        If CurrentRole <> "Admin" Then pbxoa.Enabled = False
    End Sub
    Private Sub LoadGrid()
        Dim sql = "SELECT MaDV, TenDV, DonGia, IsActive FROM DichVu"
        dgvDV.DataSource = GetTable(sql)
    End Sub

    Private Sub dgvDV_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDV.SelectionChanged
        If dgvDV.CurrentRow Is Nothing OrElse dgvDV.CurrentRow.IsNewRow Then Return

        With dgvDV.CurrentRow
            txtMaDV.Text = If(IsDBNull(.Cells("MaDV").Value), "", .Cells("MaDV").Value.ToString())
            txtTenDV.Text = If(IsDBNull(.Cells("TenDV").Value), "", .Cells("TenDV").Value.ToString())
            txtDonGia.Text = If(IsDBNull(.Cells("DonGia").Value), "", .Cells("DonGia").Value.ToString())

            Dim v = .Cells("IsActive").Value
            chkActive.Checked = If(v Is Nothing OrElse v Is DBNull.Value, False, Convert.ToBoolean(v))
        End With
    End Sub


    Private Sub pbThem_Click(sender As Object, e As EventArgs) Handles pbThem.Click
        txtMaDV.Clear() : txtTenDV.Clear() : txtDonGia.Clear()
        chkActive.Checked = True : txtTenDV.Focus()
    End Sub

    Private Sub pbluu_Click(sender As Object, e As EventArgs) Handles pbluu.Click
        If String.IsNullOrWhiteSpace(txtTenDV.Text) Then
            MessageBox.Show("Tên dịch vụ bắt buộc.") : txtTenDV.Focus() : Return
        End If

        Dim gia As Decimal
        If Not Decimal.TryParse(txtDonGia.Text, gia) OrElse gia < 0D Then
            MessageBox.Show("Đơn giá phải là số ≥ 0.") : txtDonGia.Focus() : Return
        End If

        If txtTenDV.Text.Trim = "" OrElse txtDonGia.Text.Trim = "" Then
            MessageBox.Show("Tên DV và Đơn giá bắt buộc.") : Return
        End If

        Dim ps As New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@Ten", txtTenDV.Text.Trim),
        New SqlClient.SqlParameter("@Gia", Decimal.Parse(txtDonGia.Text)),
        New SqlClient.SqlParameter("@Act", chkActive.Checked)
    }

        If txtMaDV.Text = "" Then
            Dim sqlI = "INSERT INTO DichVu(TenDV,DonGia,IsActive) VALUES(@Ten,@Gia,@Act)"
            Exec(sqlI, ps) : MessageBox.Show("Đã thêm DV.")
        Else
            ps.Add(New SqlClient.SqlParameter("@Ma", Integer.Parse(txtMaDV.Text)))
            Dim sqlU = "UPDATE DichVu SET TenDV=@Ten, DonGia=@Gia, IsActive=@Act WHERE MaDV=@Ma"
            Exec(sqlU, ps) : MessageBox.Show("Đã cập nhật DV.")
        End If

        LoadGrid()
    End Sub

    Private Sub pbxoa_Click(sender As Object, e As EventArgs) Handles pbxoa.Click
        If CurrentRole <> "Admin" Then
            MessageBox.Show("Chỉ Admin được xoá dịch vụ.") : Return
        End If
        If String.IsNullOrWhiteSpace(txtMaDV.Text) Then
            MessageBox.Show("Chưa chọn dịch vụ.") : Return
        End If
        If MessageBox.Show("Xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Dim ps = New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@Ma", CInt(txtMaDV.Text))
    }

        Try
            Exec("DELETE FROM DichVu WHERE MaDV=@Ma", ps)
            MessageBox.Show("Đã xóa.")
        Catch ex As SqlClient.SqlException
            If ex.Number = 547 Then
                ' Đang bị tham chiếu ở Hóa đơn/Chi tiết → chuyển sang Ẩn
                Exec("UPDATE DichVu SET IsActive=0 WHERE MaDV=@Ma", ps)
                MessageBox.Show("Dịch vụ đã phát sinh dữ liệu. Đã chuyển sang trạng thái Ẩn.")
            Else
                MessageBox.Show("Lỗi: " & ex.Message)
            End If
        End Try

        LoadGrid()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Close()
    End Sub

    Private Sub pbSua_Click(sender As Object, e As EventArgs) Handles pbSua.Click
        ' 1) Kiểm tra tối thiểu
        If String.IsNullOrWhiteSpace(txtMaDV.Text) Then
            MessageBox.Show("Hãy chọn 1 dịch vụ trong bảng trước khi sửa.") : Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtTenDV.Text) Then
            MessageBox.Show("Tên dịch vụ không được trống.") : txtTenDV.Focus() : Exit Sub
        End If

        Dim gia As Decimal
        If Not Decimal.TryParse(txtDonGia.Text.Trim(), gia) OrElse gia < 0D Then
            MessageBox.Show("Đơn giá phải là số ≥ 0.") : txtDonGia.Focus() : Exit Sub
        End If

        ' 2) Cập nhật
        Dim sql As String =
    "UPDATE DichVu
 SET TenDV=@TenDV,
     DonGia=@DonGia,
     IsActive=@IsActive
 WHERE MaDV=@MaDV"

        Dim prms As New List(Of SqlParameter) From {
            New SqlParameter("@MaDV", txtMaDV.Text.Trim()),
            New SqlParameter("@TenDV", txtTenDV.Text.Trim()),
            New SqlParameter("@DonGia", gia),
            New SqlParameter("@IsActive", If(chkActive.Checked, 1, 0))
        }

        Try
            Dim n = DbHelper.Exec(sql, prms) ' dùng đúng hàm Exec bạn đưa
            If n > 0 Then
                MessageBox.Show("Đã cập nhật dịch vụ.")
                LoadGrid() ' hoặc LoadGrid(txtTimDV.Text) nếu có ô tìm
            Else
                MessageBox.Show("Không có bản ghi nào được cập nhật.")
            End If
        Catch ex As SqlException
            If ex.Number = 2627 OrElse ex.Number = 2601 Then
                MessageBox.Show("Trùng dữ liệu (UNIQUE).")
            Else
                MessageBox.Show("Lỗi SQL: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub
End Class