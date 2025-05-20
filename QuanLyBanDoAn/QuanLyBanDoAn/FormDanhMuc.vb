Imports System.Data.SqlClient
Public Class FormDanhMuc

    Private Sub LoadDanhMuc()
        Try
            Using conn As New SqlConnection(connStr)
                Dim adapter As New SqlDataAdapter("SELECT * FROM DANHMUC", conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi nạp dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub FormDanhMuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDanhMuc()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim f As New AddDanhMuc()
        f.ShowDialog()
        LoadDanhMuc()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Kiểm tra click vào cột Edit (sửa)
        If e.ColumnIndex = DataGridView1.Columns("colEdit").Index AndAlso e.RowIndex >= 0 Then
            Dim id As Integer = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            Dim ten As String = DataGridView1.Rows(e.RowIndex).Cells("Tên").Value.ToString

            ' Hiện form sửa, truyền thông tin cũ vào  
            Dim f As New AddDanhMuc(id, ten) ' Tạo constructor mới cho AddDanhMuc
            f.ShowDialog()
            LoadDanhMuc()
        End If

        ' Kiểm tra click vào cột Delete (xoá)
        If e.ColumnIndex = DataGridView1.Columns("colDelete").Index AndAlso e.RowIndex >= 0 Then
            Dim id As Integer = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            If MessageBox.Show("Bạn có chắc chắn xoá không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Using conn As New SqlConnection(connStr)
                        conn.Open()
                        Dim cmd As New SqlCommand("DELETE FROM DANHMUC WHERE Madanhmuc_ID=@id", conn)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Đã xoá thành công!", "Thông Báo")
                    End Using
                    LoadDanhMuc()
                Catch ex As Exception
                    MessageBox.Show("Lỗi xoá: " & ex.Message)
                End Try
            End If
        End If
    End Sub
End Class