Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dangnhap.Click
        Dim chuoiketnoi As String = "workstation id=ps02260.mssql.somee.com;packet size=4096;user id=sonvu775_SQLLogin_1;pwd=l5u1rgdd9s;data source=ps02260.mssql.somee.com;persist security info=False;initial catalog=ps02260"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhan_vien where Ma_nv='" & TextBox1.Text & "' and password='" & TextBox2.Text & "' ", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu")
            End If
        Catch ex As Exception
        End Try
    End Sub
   
    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
