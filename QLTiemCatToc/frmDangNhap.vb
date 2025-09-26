Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography
Imports System.Text
Public Class frmDangNhap
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles  PictureBox2.Click
        If String.IsNullOrWhiteSpace(txtUser.Text) OrElse String.IsNullOrWhiteSpace(txtPass.Text) Then
            MessageBox.Show("Nhập tài khoản và mật khẩu.") : Return
        End If

        Dim sql = "
        SELECT UserName, Password, Role
        FROM TaiKhoan
        WHERE UserName=@u AND TrangThai=1"
        Dim ps As New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@u", txtUser.Text.Trim())
    }
        Dim tb = GetTable(sql, ps)
        If tb.Rows.Count = 0 Then
            MessageBox.Show("Sai tài khoản hoặc bị khóa.") : Return
        End If

        Dim row = tb.Rows(0)
        If Not String.Equals(txtPass.Text.Trim(), row("Password").ToString().Trim(), StringComparison.Ordinal) Then
            MessageBox.Show("Sai mật khẩu.") : Return
        End If

        ' Đăng nhập thành công
        CurrentUser = row("UserName").ToString()
        CurrentRole = row("Role").ToString()

        Me.Hide()
        Using f As New frmMain()
            f.StartPosition = FormStartPosition.CenterScreen
            f.ShowDialog(Me)
        End Using
        txtPass.Clear()
        txtPass.Focus()
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles  PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlRight_Paint(sender As Object, e As PaintEventArgs) Handles pnlRight.Paint
        ' ControlPaint.DrawBorder(e.Graphics, pnlRight.ClientRectangle,
        '     ColorTranslator.FromHtml("#F59E0B"), 1, ButtonBorderStyle.Solid,
        '     ColorTranslator.FromHtml("#F59E0B"), 1, ButtonBorderStyle.Solid,
        '     ColorTranslator.FromHtml("#F59E0B"), 1, ButtonBorderStyle.Solid,
        '     ColorTranslator.FromHtml("#F59E0B"), 1, ButtonBorderStyle.Solid)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        txtPass.PasswordChar = If(chkShowPass.Checked, ControlChars.NullChar, "*"c)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        ' Ví dụ muốn nhìn xuyên tới PictureBox nền (bgPic) hoặc Form
        PictureBox2.Parent = Me   ' hoặc: PictureBox1.Parent = Me  ' (Me = Form)
        PictureBox2.BackColor = Color.Transparent

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
