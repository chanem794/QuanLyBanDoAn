Imports System.Data.SqlClient
Public Class FormTKSL


    ' Tải dữ liệu thống kê số lượng món ăn theo ngày
    Private Sub LoadSoLuongMon(Optional selectedDate As Date = Nothing)
        Try
            Using conn As New SqlConnection(connStr)
                Dim sql As String = "SELECT m.TenMon AS [Tên Món], SUM(ct.SoLuong) AS [Số Lượng] " &
                                   "FROM CHITIETHOADON ct " &
                                   "JOIN MENU m ON ct.MaMon_ID = m.MaMon_ID " &
                                   "JOIN HOADON hd ON ct.MaHoaDon_ID = hd.MaHoaDon_ID"

                If selectedDate <> Nothing Then
                    sql &= " WHERE CONVERT(date, hd.NgayBan) = @Ngay"
                End If

                sql &= " GROUP BY m.TenMon"

                Using adapter As New SqlDataAdapter(sql, conn)
                    If selectedDate <> Nothing Then
                        adapter.SelectCommand.Parameters.AddWithValue("@Ngay", selectedDate.Date)
                    End If
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvSoLuongMon.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub FormThongKeSoLuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSoLuongMon() ' Tải dữ liệu mặc định (tất cả ngày)
    End Sub

    Private Sub btnThongKeNgay_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        LoadSoLuongMon(dtpNgay.Value.Date) ' Tải dữ liệu theo ngày được chọn
    End Sub
End Class