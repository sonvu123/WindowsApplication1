Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Form3
    Dim tb As New DataTable
    Dim chuoiketnoi As String = "workstation id=ps02260.mssql.somee.com;packet size=4096;user id=sonvu775_SQLLogin_1;pwd=l5u1rgdd9s;data source=ps02260.mssql.somee.com;persist security info=False;initial catalog=ps02260"
    Public Sub LoadData()
        Dim KetNoi As New SqlConnection(chuoiketnoi)
        Dim SqlAdapter As New SqlDataAdapter("SELECT * FROM San_pham", KetNoi)
        Try
            SqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from San_pham", ketnoi)
        Try
            ketnoi.Open()
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        ketnoi.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        textbox1.Text = DataGridView1.Item(0, index).Value
        TextBox2.Text = DataGridView1.Item(1, index).Value
        TextBox3.Text = DataGridView1.Item(2, index).Value
        TextBox4.Text = DataGridView1.Item(3, index).Value
        TextBox5.Text = DataGridView1.Item(4, index).Value
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim KetNoi As New SqlConnection(ChuoiKetNoi)
        KetNoi.Open()
        Dim stadd As String = "UPDATE San_pham SET Ten_sp = @TenSanPham, Gia_sp = @Gia, So_luong = @Soluong WHERE Ma_sp = @MaSanPham"
        Dim com As New SqlCommand(stadd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaSanPham", textbox1.Text)
            com.Parameters.AddWithValue("@TenSanPham", TextBox2.Text)
            com.Parameters.AddWithValue("@Gia", TextBox3.Text)
            com.Parameters.AddWithValue("@SoLuong", TextBox4.Text)
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim KetNoi As New SqlConnection(chuoiketnoi)
        KetNoi.Open()
        Dim stadd As String = "DELETE FROM San_Pham WHERE Ma_sp = @Ma_sp"
        Dim com As New SqlCommand(stadd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Ma_sp", textbox1.Text)
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim KetNoi As New SqlConnection(chuoiketnoi)
        KetNoi.Open()
        Dim stadd As String = "INSERT INTO San_pham VALUES (@Ma_sp, @Ten_sp, @Gia_sp, @So_luong, Loai_sp@)"
        Dim com As New SqlCommand(stadd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Ma_sp", textbox1.Text)
            com.Parameters.AddWithValue("@Ten_sp", TextBox2.Text)
            com.Parameters.AddWithValue("@Gia_sp", TextBox3.Text)
            com.Parameters.AddWithValue("@So_luong", TextBox4.Text)
            com.Parameters.AddWithValue("@Loai_sp", TextBox5.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Không thêm được")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class