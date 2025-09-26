Imports System.Configuration
Imports System.Data.SqlClient

Module DbHelper
    Private ReadOnly cs As String = ConfigurationManager.ConnectionStrings("cs").ConnectionString

    Public Function GetTable(sql As String, Optional params As List(Of SqlParameter) = Nothing) As DataTable
        Using cn As New SqlConnection(cs), cmd As New SqlCommand(sql, cn)
            If params IsNot Nothing Then
                For Each p In params
                    cmd.Parameters.AddWithValue(p.ParameterName, If(p.Value, DBNull.Value))
                Next
            End If
            Using da As New SqlDataAdapter(cmd)
                Dim tb As New DataTable()
                da.Fill(tb)
                Return tb
            End Using
        End Using
    End Function

    Public Function Exec(sql As String, Optional params As List(Of SqlParameter) = Nothing) As Integer
        Using cn As New SqlConnection(cs), cmd As New SqlCommand(sql, cn)
            If params IsNot Nothing Then
                For Each p In params
                    cmd.Parameters.AddWithValue(p.ParameterName, If(p.Value, DBNull.Value))
                Next
            End If
            cn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function
End Module
