Imports System.Data.SqlClient
Imports System.IO

Public Class AddMon
    Private isEdit As Boolean = False
    Private _maMon As Integer
    Private imageBytes() As Byte = Nothing

    ' Dùng cho thêm mới
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Dùng cho sửa món
    Public Sub New(maMon As Integer, tenMon As String, donGia As Decimal, maDanhMuc As Integer)
        InitializeComponent()
        isEdit = True
        _maMon = maMon
        TextBox1.Text = maMon.ToString()
        TextBox2.Text = tenMon
        TextBox3.Text = donGia.ToString()
        TextBox1.Enabled = False
        btnLuu.Text = "Lưu"

        ' --> THÊM ĐOẠN CODE NÀY để lấy ảnh từ DB
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT HinhAnhMon FROM MENU WHERE MaMon_ID=@id", conn)
            cmd.Parameters.AddWithValue("@id", maMon)
            Dim obj = cmd.ExecuteScalar()
            If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
                imageBytes = CType(obj, Byte())
                Dim ms As New MemoryStream(imageBytes)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                PictureBox1.Image = Nothing
                imageBytes = Nothing
            End If
        End Using
    End Sub

    Private Sub AddMon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load danh mục vào ComboBox
        Using conn As New SqlConnection(connStr)
            Dim cmd As New SqlCommand("SELECT Madanhmuc_ID, TenDanhMuc FROM DANHMUC", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "TenDanhMuc"
            ComboBox1.ValueMember = "Madanhmuc_ID"
        End Using
        ' Nếu là sửa thì set ComboBox đúng
        If isEdit AndAlso _maMon <> 0 Then
            ComboBox1.SelectedValue = LayMaDanhMucID_CuaMon(_maMon)
        End If
    End Sub

    ' Lấy mã danh mục cho món sửa
    Private Function LayMaDanhMucID_CuaMon(maMon As Integer) As Integer
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT MaDanhMuc_ID FROM MENU WHERE MaMon_ID=@maMon", conn)
            cmd.Parameters.AddWithValue("@maMon", maMon)
            Dim obj = cmd.ExecuteScalar()
            If obj IsNot Nothing Then Return CInt(obj)
        End Using
        Return 0
    End Function

    ' Nút chọn ảnh
    Private Sub btnChonAnh_Click(sender As Object, e As EventArgs) Handles btnChonAnh.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            imageBytes = File.ReadAllBytes(ofd.FileName)
        End If
    End Sub

    ' Nút lưu (dùng cho cả thêm & sửa)
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim maMon As Integer
        If isEdit Then
            maMon = _maMon
        Else
            If Not Integer.TryParse(TextBox1.Text.Trim, maMon) Then
                MessageBox.Show("Mã món phải là số!")
                TextBox1.Focus()
                Return
            End If
        End If

        Dim tenMon As String = TextBox2.Text.Trim
        If tenMon = "" Then
            MessageBox.Show("Nhập tên món!")
            TextBox2.Focus()
            Return
        End If
        Dim gia As Decimal
        If Not Decimal.TryParse(TextBox3.Text.Trim, gia) Then
            MessageBox.Show("Giá phải là số!")
            TextBox3.Focus()
            Return
        End If

        If ComboBox1.SelectedIndex < 0 Then
            MessageBox.Show("Chọn danh mục!")
            ComboBox1.Focus()
            Return
        End If
        Dim maDanhMuc As Integer = CInt(ComboBox1.SelectedValue)

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim sql As String
                If isEdit Then
                    sql = "UPDATE MENU SET TenMon=@ten, DonGia=@gia, HinhAnhMon=@anh, MaDanhMuc_ID=@dm WHERE MaMon_ID=@ma"
                Else
                    sql = "INSERT INTO MENU (MaMon_ID, TenMon, DonGia, HinhAnhMon, MaDanhMuc_ID) VALUES (@ma, @ten, @gia, @anh, @dm)"
                End If
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ma", maMon)
                    cmd.Parameters.AddWithValue("@ten", tenMon)
                    cmd.Parameters.AddWithValue("@gia", gia)
                    If imageBytes IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@anh", imageBytes)
                    Else
                        cmd.Parameters.Add("@anh", SqlDbType.VarBinary).Value = DBNull.Value
                    End If
                    cmd.Parameters.AddWithValue("@dm", maDanhMuc)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(If(isEdit, "Đã sửa món thành công!", "Thêm món thành công!"))
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi lưu: " & ex.Message)
        End Try
    End Sub
End Class