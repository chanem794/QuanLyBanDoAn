Imports System.Data.SqlClient

Public Class FormMon
    ' Tải danh sách món, có lọc theo từ khóa
    Private Sub LoadMenu(Optional keyword As String = "")
        Try
            Using conn As New SqlConnection(connStr)
                ' Lấy cả tên danh mục (JOIN DANHMUC)
                Dim sql As String =
                "SELECT m.MaMon_ID as [id], m.TenMon as [Tên], m.DonGia as [Đơn Giá], d.TenDanhMuc as [Danh Mục]
                 FROM MENU m
                 INNER JOIN DANHMUC d ON m.MaDanhMuc_ID = d.Madanhmuc_ID"

                ' Thêm điều kiện tìm kiếm nếu có từ khóa
                If Not String.IsNullOrEmpty(keyword) Then
                    sql &= " WHERE m.TenMon LIKE @kw OR d.TenDanhMuc LIKE @kw OR CAST(m.MaMon_ID AS nvarchar) LIKE @kw"
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
        LoadMenu(TextBox1.Text.Trim())
    End Sub

    ' Tải dữ liệu khi mở form
    Private Sub FormMon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMenu()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim f As New AddMon()
        f.ShowDialog()
        LoadMenu(TextBox1.Text.Trim()) ' nạp lại danh sách sau khi thêm
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Return

        ' Xử lý chọn icon SỬA
        If e.ColumnIndex = DataGridView1.Columns("colEdit").Index Then
            Dim maMon As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            Dim tenMon As String = DataGridView1.Rows(e.RowIndex).Cells("Tên").Value.ToString
            Dim donGia As Decimal = CDec(DataGridView1.Rows(e.RowIndex).Cells("DonGia").Value)
            Dim danhMuc As String = DataGridView1.Rows(e.RowIndex).Cells("DanhMuc").Value.ToString

            ' Lấy MaDanhMuc_ID cho combobox sửa, bạn cần sửa lại nếu combobox hiện tên
            Dim maDanhMuc As Integer = LayMaDanhMucID_tu_Ten(danhMuc) ' Viết hàm này nếu cần

            ' Mở form sửa AddMon với dữ liệu truyền qua constructor/các thuộc tính
            Dim f As New AddMon(maMon, tenMon, donGia, maDanhMuc)
            f.ShowDialog()
            LoadMenu(TextBox1.Text.Trim()) ' Nạp lại danh sách sau khi sửa
        End If

        ' Xử lý chọn icon XÓA
        If e.ColumnIndex = DataGridView1.Columns("colDelete").Index Then
            Dim maMon As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            If MessageBox.Show("Bạn có chắc muốn xoá món này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Using conn As New SqlConnection(connStr)
                        conn.Open()
                        Dim cmd As New SqlCommand("DELETE FROM MENU WHERE MaMon_ID=@id", conn)
                        cmd.Parameters.AddWithValue("@id", maMon)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Đã xoá món thành công!")
                    End Using
                    LoadMenu(TextBox1.Text.Trim())
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi xoá: " & ex.Message)
                End Try
            End If
        End If
    End Sub
    ' TRA MÃ DANH MỤC TỪ TÊN
    Private Function LayMaDanhMucID_tu_Ten(tenDM As String) As Integer
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT Madanhmuc_ID FROM DANHMUC WHERE TenDanhMuc = @ten", conn)
            cmd.Parameters.AddWithValue("@ten", tenDM)
            Dim obj = cmd.ExecuteScalar()
            If obj IsNot Nothing Then Return CInt(obj)
        End Using
        Return 0
    End Function
    ' Nếu muốn làm chức năng sửa/xóa bằng icon, bắt sự kiện CellContentClick (giống như ở FormDanhMuc)
End Class