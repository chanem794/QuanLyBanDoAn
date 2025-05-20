Imports System.Data.SqlClient

Public Class FormTKTM

    ' Tải danh sách món ăn vào ComboBox, thêm tùy chọn "Tất cả món ăn"
    Private Sub LoadMonAn()
        Try
            Using conn As New SqlConnection(connStr)
                Dim sql As String = "SELECT MaMon_ID, TenMon FROM MENU"
                Using adapter As New SqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    ' Thêm mục "Tất cả món ăn"
                    Dim allRow As DataRow = dt.NewRow()
                    allRow("MaMon_ID") = 0
                    allRow("TenMon") = "Tất cả món ăn"
                    dt.Rows.InsertAt(allRow, 0)
                    cboMonAn.DataSource = dt
                    cboMonAn.DisplayMember = "TenMon"
                    cboMonAn.ValueMember = "MaMon_ID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    ' Tải dữ liệu doanh thu theo món ăn và khoảng thời gian
    Private Sub LoadDoanhThu(Optional maMon As Integer = 0, Optional tuNgay As Date? = Nothing, Optional denNgay As Date? = Nothing)
        Try
            Using conn As New SqlConnection(connStr)
                Dim sql As String = "SELECT CONVERT(date, hd.NgayBan) AS [Ngày], SUM(ct.SoLuong * m.DonGia) AS [Doanh Thu] " &
                                   "FROM CHITIETHOADON ct " &
                                   "JOIN MENU m ON ct.MaMon_ID = m.MaMon_ID " &
                                   "JOIN HOADON hd ON ct.MaHoaDon_ID = hd.MaHoaDon_ID"

                Dim conditions As New List(Of String)
                Dim parameters As New List(Of SqlParameter)

                ' Lọc theo món ăn
                If maMon <> 0 Then
                    conditions.Add("m.MaMon_ID = @MaMon")
                    parameters.Add(New SqlParameter("@MaMon", maMon))
                End If

                ' Lọc theo ngày
                If tuNgay.HasValue Then
                    conditions.Add("hd.NgayBan >= @TuNgay")
                    parameters.Add(New SqlParameter("@TuNgay", tuNgay.Value.Date))
                End If
                If denNgay.HasValue Then
                    conditions.Add("hd.NgayBan <= @DenNgay")
                    parameters.Add(New SqlParameter("@DenNgay", denNgay.Value.Date.AddDays(1).AddTicks(-1)))
                End If

                If conditions.Count > 0 Then
                    sql &= " WHERE " & String.Join(" AND ", conditions)
                End If

                sql &= " GROUP BY CONVERT(date, hd.NgayBan)"

                Using adapter As New SqlDataAdapter(sql, conn)
                    adapter.SelectCommand.Parameters.AddRange(parameters.ToArray())
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvDoanhThu.DataSource = dt
                    CustomizeDataGridView()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    ' Tùy chỉnh DataGridView
    Private Sub CustomizeDataGridView()
        If dgvDoanhThu.Columns.Count > 0 Then
            With dgvDoanhThu
                .Columns("Ngày").HeaderText = "Ngày"
                .Columns("Doanh Thu").HeaderText = "Doanh Thu"
            End With
        End If
    End Sub

    ' Load form
    Private Sub FormTKTM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMonAn()
        LoadDoanhThu()

        ' Thiết lập mặc định từ 01/01/2020 đến hiện tại
        dtpTuNgay.Value = New Date(2020, 1, 1)
        dtpDenNgay.Value = Date.Now

        ' Bật chế độ checkbox để người dùng có thể bỏ chọn ngày
        dtpTuNgay.ShowCheckBox = True
        dtpDenNgay.ShowCheckBox = True
        dtpTuNgay.Checked = False
        dtpDenNgay.Checked = False
    End Sub

    ' Xử lý nút Thống kê
    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim maMon As Integer = 0
        If cboMonAn.SelectedValue IsNot Nothing Then
            maMon = CInt(cboMonAn.SelectedValue)
        End If

        ' Nếu người dùng không chọn ngày => gán mặc định
        Dim tuNgay As Date? = If(dtpTuNgay.Checked, dtpTuNgay.Value.Date, New Date(2020, 1, 1))
        Dim denNgay As Date? = If(dtpDenNgay.Checked, dtpDenNgay.Value.Date, Date.Now)

        LoadDoanhThu(maMon, tuNgay, denNgay)
    End Sub

End Class
