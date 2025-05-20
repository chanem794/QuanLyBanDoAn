Imports System.Data.SqlClient

Public Class AddDanhMuc
    Private isEdit As Boolean = False
    Private _id As Integer

    ' Constructor mới cho chế độ sửa
    Public Sub New(Optional id As Integer = 0, Optional ten As String = "")
        InitializeComponent()
        If id > 0 Then
            isEdit = True
            _id = id
            TextBox1.Text = id.ToString()      ' Mã danh mục
            TextBox2.Text = ten                ' Tên danh mục
            TextBox1.Enabled = False           ' Không cho sửa mã
            Button1.Text = "Lưu thay đổi"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim maduoi As Integer
        If Not Integer.TryParse(TextBox1.Text.Trim(), maduoi) Then
            MessageBox.Show("Mã Danh Mục phải là số nguyên!")
            Return
        End If
        Dim ten As String = TextBox2.Text.Trim()
        If ten = "" Then
            MessageBox.Show("Vui lòng nhập Tên Danh Mục!")
            Return
        End If

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim sql As String
                If isEdit Then
                    sql = "UPDATE DANHMUC SET TenDanhMuc=@ten WHERE Madanhmuc_ID=@id"
                Else
                    sql = "INSERT INTO DANHMUC (Madanhmuc_ID, TenDanhMuc) VALUES (@id, @ten)"
                End If

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", maduoi)
                    cmd.Parameters.AddWithValue("@ten", ten)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(If(isEdit, "Cập nhật thành công!", "Thêm thành công!"))
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub
End Class