Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Form4
    Dim tb As New DataTable
    Dim chuoiketnoi As String = "workstation id=ps02260.mssql.somee.com;packet size=4096;user id=sonvu775_SQLLogin_1;pwd=l5u1rgdd9s;data source=ps02260.mssql.somee.com;persist security info=False;initial catalog=ps02260"
    Public Sub LoadData()
        Dim KetNoi As New SqlConnection(chuoiketnoi)
        Dim SqlAdapter As New SqlDataAdapter("SELECT * FROM Khach_hang", KetNoi)
        Try
            SqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
        TextBox3.Text = DataGridView1.Item(2, index).Value
        TextBox4.Text = DataGridView1.Item(3, index).Value
        TextBox5.Text = DataGridView1.Item(4, index).Value
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Khach_hang", ketnoi)
        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim KetNoi As New SqlConnection(chuoiketnoi)
        KetNoi.Open()
        Dim stadd As String = "DELETE FROM Khach_hang WHERE Ma_kh = @Makhachhang"
        Dim com As New SqlCommand(stadd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Makhachhang", TextBox1.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim KetNoi As New SqlConnection(chuoiketnoi)
        KetNoi.Open()
        Dim stadd As String = "UPDATE Khach_hang SET Ten_kh = @Tenkhachhang, Dia_chi = @Diachi, Sdt = @Sodienthoai WHERE Ma_kh = @Makhachhang"
        Dim com As New SqlCommand(stadd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Makhachhang", TextBox1.Text)
            com.Parameters.AddWithValue("@Tenkhachhang", TextBox2.Text)
            com.Parameters.AddWithValue("@Diachi", TextBox3.Text)
            com.Parameters.AddWithValue("@Sodienthoai", TextBox4.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Không sửa được")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub
End Class