Imports System.Data.SqlClient

Public Class FormBan
    ' Tải danh sách bàn, có lọc theo từ khóa
    Private Sub LoadTables(Optional keyword As String = "")
        Try
            Using conn As New SqlConnection(connStr)
                Dim sql As String =
                "SELECT MaBan_ID as [id], TenBan as [Tên], TrangThai as [Trạng Thái] 
                 FROM BAN"

                If Not String.IsNullOrEmpty(keyword) Then
                    sql &= " WHERE TenBan LIKE @kw OR TrangThai LIKE @kw OR CAST(MaBan_ID AS nvarchar) LIKE @kw"
                End If

                Using adapter As New SqlDataAdapter(sql, conn)
                    If Not String.IsNullOrEmpty(keyword) Then
                        adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    End If
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    ' Tìm kiếm khi gõ vào TextBox1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        LoadTables(TextBox1.Text.Trim())
    End Sub

    ' Tải dữ liệu khi mở form
    Private Sub FormBan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTables()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim f As New AddBan()
        f.ShowDialog()
        LoadTables(TextBox1.Text.Trim()) ' Nạp lại danh sách sau khi thêm
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Return

        ' Xử lý chọn icon SỬA
        If e.ColumnIndex = DataGridView1.Columns("colEdit").Index Then
            Dim maBan As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            Dim tenBan As String = DataGridView1.Rows(e.RowIndex).Cells("Tên").Value.ToString
            Dim trangThai As String = DataGridView1.Rows(e.RowIndex).Cells("Trạng Thái").Value.ToString

            ' Mở form sửa AddBan với dữ liệu truyền qua constructor/các thuộc tính
            Dim f As New AddBan(maBan, tenBan, trangThai)
            f.ShowDialog()
            LoadTables(TextBox1.Text.Trim()) ' Nạp lại danh sách sau khi sửa
        End If

        ' Xử lý chọn icon XÓA
        If e.ColumnIndex = DataGridView1.Columns("colDelete").Index Then
            Dim maBan As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            If MessageBox.Show("Bạn có chắc muốn xoá bàn này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Using conn As New SqlConnection(connStr)
                        conn.Open()
                        Dim cmd As New SqlCommand("DELETE FROM BAN WHERE MaBan_ID=@id", conn)
                        cmd.Parameters.AddWithValue("@id", maBan)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Đã xoá bàn thành công!")
                    End Using
                    LoadTables(TextBox1.Text.Trim())
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi xoá: " & ex.Message)
                End Try
            End If
        End If
    End Sub
End Class