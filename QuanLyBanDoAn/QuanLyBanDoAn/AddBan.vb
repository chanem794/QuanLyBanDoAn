Imports System.Data.SqlClient
Imports System.IO

Public Class AddBan
    Private isEdit As Boolean = False
    Private _maBan As Integer

    ' Dùng cho thêm mới
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Dùng cho sửa bàn
    Public Sub New(maBan As Integer, tenBan As String, trangThai As String)
        InitializeComponent()
        isEdit = True
        _maBan = maBan
        TextBox1.Text = maBan.ToString()
        TextBox2.Text = tenBan
        TextBox1.Enabled = False
        btnLuu.Text = "Lưu"
        ComboBox1.SelectedItem = trangThai
    End Sub

    Private Sub AddBan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load trạng thái vào ComboBox
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Trống")
        ComboBox1.Items.Add("Có khách")
        If Not isEdit Then
            ComboBox1.SelectedIndex = 0 ' Mặc định chọn "Trống" khi thêm mới
        End If
    End Sub

    ' Nút lưu (dùng cho cả thêm & sửa)
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim maBan As Integer
        If isEdit Then
            maBan = _maBan
        Else
            If Not Integer.TryParse(TextBox1.Text.Trim, maBan) Then
                MessageBox.Show("Mã bàn phải là số!")
                TextBox1.Focus()
                Return
            End If
        End If

        Dim tenBan As String = TextBox2.Text.Trim
        If tenBan = "" Then
            MessageBox.Show("Nhập tên bàn!")
            TextBox2.Focus()
            Return
        End If

        If ComboBox1.SelectedIndex < 0 Then
            MessageBox.Show("Chọn trạng thái!")
            ComboBox1.Focus()
            Return
        End If
        Dim trangThai As String = ComboBox1.SelectedItem.ToString()

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim sql As String
                If isEdit Then
                    sql = "UPDATE BAN SET TenBan=@ten, TrangThai=@trangthai WHERE MaBan_ID=@ma"
                Else
                    sql = "INSERT INTO BAN (MaBan_ID, TenBan, TrangThai) VALUES (@ma, @ten, @trangthai)"
                End If
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ma", maBan)
                    cmd.Parameters.AddWithValue("@ten", tenBan)
                    cmd.Parameters.AddWithValue("@trangthai", trangThai)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(If(isEdit, "Đã sửa bàn thành công!", "Thêm bàn thành công!"))
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi lưu: " & ex.Message)
        End Try
    End Sub
End Class