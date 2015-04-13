Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Form2
    Dim tb As New DataTable
    Dim chuoiketnoi As String = "workstation id=ps02260.mssql.somee.com;packet size=4096;user id=sonvu775_SQLLogin_1;pwd=l5u1rgdd9s;data source=ps02260.mssql.somee.com;persist security info=False;initial catalog=ps02260"
    Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub DanhSáchKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchKháchHàngToolStripMenuItem.Click
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
    Private Sub DanhSáchSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchSảnPhẩmToolStripMenuItem.Click
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
    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class