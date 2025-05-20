Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu

Public Class FormDatMon
    Private MaBan As Integer
    Private MaHoaDon As Integer = 0 ' <= mã hóa đơn hiện tại
    Private gioHang As New List(Of CartItem)
    Private tongTien As Decimal = 0
    ' Dùng class mô tả item giỏ hàng
    Public Class CartItem
        Public Property MaMon As Integer
        Public Property TenMon As String
        Public Property DonGia As Decimal
        Public Property SoLuong As Integer
    End Class

    ' --- BỔ SUNG ---
    ' Khi click món thì gọi: AddMonToCart(maMon, tenMon, donGia)
    ' Để demo dễ: hãy gọi CapNhatGioHang() mỗi lần form load
    Private Sub FormDatMon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kiểm tra Hóa đơn chưa thanh toán cho maBan này
        MaHoaDon = GetOrCreateHoaDon(MaBan)
        If MaHoaDon = 0 Then
            ' Nếu không có, tạo hóa đơn mới
            MaHoaDon = TaoHoaDonMoi(MaBan)
        End If
        LoadChiTietHoaDon(MaHoaDon)
        ' Load danh mục, menu như bình thường
        LoadDanhMucMon()
        LoadMenuTatCa()
        CapNhatGioHang()
    End Sub
    Private Function TaoHoaDonMoi(maBan As Integer) As Integer
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd = New SqlCommand("INSERT INTO HOADON (MaBan_ID, TongTien, NgayBan, TrangThai) OUTPUT INSERTED.MaHoaDon_ID VALUES (@maban, 0, GETDATE(), 0)", conn)
            cmd.Parameters.AddWithValue("@maban", maBan)
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function
    Private Function GetOrCreateHoaDon(maBan As Integer) As Integer
        Using conn As New SqlConnection(connStr)
            conn.Open()
            ' Tuy database không có trạng thái hóa đơn, hãy giả định hóa đơn đang thanh toán sẽ có MaBan_ID và có dòng chi tiết hoặc chưa có TổngTiền
            Dim cmd = New SqlCommand("SELECT TOP 1 MaHoaDon_ID FROM HOADON WHERE MaBan_ID=@mb AND TongTien=0", conn)
            cmd.Parameters.AddWithValue("@mb", maBan)
            Dim obj = cmd.ExecuteScalar()
            If obj IsNot Nothing Then Return CInt(obj)
            ' Nếu không có thì tạo mới
            cmd = New SqlCommand("INSERT INTO HOADON (MaBan_ID, TongTien, NgayBan) OUTPUT INSERTED.MaHoaDon_ID VALUES (@mb, 0, GETDATE())", conn)
            cmd.Parameters.AddWithValue("@mb", maBan)
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function
    Private Sub LoadChiTietHoaDon(maHoaDon As Integer)
        gioHang.Clear()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand(
            "SELECT c.MaMon_ID, m.TenMon, m.DonGia, c.SoLuong FROM CHITIETHOADON c JOIN MENU m ON c.MaMon_ID=m.MaMon_ID WHERE c.MaHoaDon_ID=@id", conn)
            cmd.Parameters.AddWithValue("@id", maHoaDon)
            Using rd = cmd.ExecuteReader()
                While rd.Read()
                    gioHang.Add(New CartItem With {
                    .MaMon = CInt(rd("MaMon_ID")),
                    .TenMon = rd("TenMon").ToString(),
                    .DonGia = CDec(rd("DonGia")),
                    .SoLuong = CInt(rd("SoLuong"))
                })
                End While
            End Using
        End Using
    End Sub
    Public Sub New(_maBan As Integer)
        InitializeComponent()
        MaBan = _maBan
    End Sub
    Private Sub LoadDanhMucMon()
        For i = pnDanhMuc.Controls.Count - 1 To 0 Step -1
            Dim ctrl = pnDanhMuc.Controls(i)
            If TypeOf ctrl Is Button Then
                pnDanhMuc.Controls.Remove(ctrl)
            End If
        Next

        Dim y As Integer = 0
        ' Nút "Tất cả"
        Dim btnAll As New Button()
        btnAll.Text = "Tất cả"
        btnAll.Width = pnDanhMuc.Width - pnlOnButtonPosition.Width - 6
        btnAll.Height = 45
        btnAll.Top = y
        btnAll.Left = pnlOnButtonPosition.Width + 2
        btnAll.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        btnAll.ForeColor = Color.White
        btnAll.FlatStyle = FlatStyle.Flat
        btnAll.FlatAppearance.BorderSize = 0
        AddHandler btnAll.Click, Sub()
                                     ChonDanhMuc(0)
                                     pnlOnButtonPosition.Height = btnAll.Height
                                     pnlOnButtonPosition.Top = btnAll.Top
                                 End Sub
        pnDanhMuc.Controls.Add(btnAll)
        y += btnAll.Height + 2

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT Madanhmuc_ID, TenDanhMuc FROM DANHMUC", conn)
            Using rd = cmd.ExecuteReader()
                While rd.Read()
                    Dim maDM As Integer = CInt(rd("Madanhmuc_ID"))
                    Dim tenDM As String = rd("TenDanhMuc").ToString()
                    Dim btnDM As New Button()
                    btnDM.Text = tenDM
                    btnDM.Tag = maDM
                    btnDM.Width = pnDanhMuc.Width - pnlOnButtonPosition.Width - 6
                    btnDM.Height = 45
                    btnDM.Top = y
                    btnDM.Left = pnlOnButtonPosition.Width + 2
                    btnDM.Font = New Font("Segoe UI", 14, FontStyle.Bold)
                    btnDM.ForeColor = Color.White
                    btnDM.FlatStyle = FlatStyle.Flat
                    btnDM.FlatAppearance.BorderSize = 0
                    AddHandler btnDM.Click, Sub()
                                                ChonDanhMuc(maDM)
                                                pnlOnButtonPosition.Height = btnDM.Height
                                                pnlOnButtonPosition.Top = btnDM.Top
                                            End Sub
                    pnDanhMuc.Controls.Add(btnDM)
                    y += btnDM.Height + 2
                End While
            End Using
        End Using

        pnlOnButtonPosition.Height = btnAll.Height
        pnlOnButtonPosition.Top = btnAll.Top
        pnDanhMuc.Controls.SetChildIndex(pnlOnButtonPosition, 0)
    End Sub

    Private Sub ChonDanhMuc(maDM As Integer)
        If maDM = 0 Then
            LoadMenuTatCa()
        Else
            LoadMenuTheoDanhMuc(maDM)
        End If
    End Sub

    Private Sub LoadMenuTatCa()
        flpMenu.Controls.Clear()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM MENU", conn)
            Using rd = cmd.ExecuteReader()
                While rd.Read()
                    AddMonToFlowLayout(rd)
                End While
            End Using
        End Using
    End Sub

    Private Sub LoadMenuTheoDanhMuc(maDM As Integer)
        flpMenu.Controls.Clear()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM MENU WHERE MaDanhMuc_ID=@madm", conn)
            cmd.Parameters.AddWithValue("@madm", maDM)
            Using rd = cmd.ExecuteReader()
                While rd.Read()
                    AddMonToFlowLayout(rd)
                End While
            End Using
        End Using
    End Sub

    ' ==== HIỆU ỨNG CLICK MÓN ĂN ====
    Private Sub HieuUngMon(pn As Panel)
        pn.BackColor = Color.FromArgb(255, 240, 210)   ' Nhẹ nhàng
    End Sub
    Private Sub HieuUngMonReset(pn As Panel)
        pn.BackColor = Color.White
    End Sub

    Private Sub AddMonToFlowLayout(rd As SqlDataReader)
        Dim pn As New Panel()
        pn.Width = 140
        pn.Height = 190
        pn.BorderStyle = BorderStyle.FixedSingle
        pn.BackColor = Color.White
        pn.Margin = New Padding(10, 10, 10, 10)

        Dim pic As New PictureBox()
        pic.Width = 120
        pic.Height = 100
        pic.Top = 5
        pic.Left = 10
        pic.SizeMode = PictureBoxSizeMode.Zoom
        If Not IsDBNull(rd("HinhAnhMon")) Then
            Dim bytes = CType(rd("HinhAnhMon"), Byte())
            Using ms As New MemoryStream(bytes)
                pic.Image = Image.FromStream(ms)
            End Using
        Else
            pic.Image = Nothing
        End If

        Dim lblTen As New Label()
        lblTen.Width = 130
        lblTen.Height = 30
        lblTen.Top = pic.Top + pic.Height + 5
        lblTen.Left = 5
        lblTen.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTen.Text = rd("TenMon").ToString()
        lblTen.TextAlign = ContentAlignment.MiddleCenter

        Dim lblGia As New Label()
        lblGia.Width = 130
        lblGia.Height = 22
        lblGia.Top = lblTen.Top + lblTen.Height + 3
        lblGia.Left = 5
        lblGia.Font = New Font("Segoe UI", 11, FontStyle.Italic)
        lblGia.ForeColor = Color.Green
        lblGia.TextAlign = ContentAlignment.MiddleCenter
        lblGia.Text = String.Format("{0:#,0}", rd("DonGia")) & " đ"

        Dim maMon As Integer = CInt(rd("MaMon_ID"))
        Dim tenMon As String = rd("TenMon").ToString()
        Dim donGia As Decimal = CDec(rd("DonGia"))
        For Each c As Control In New Control() {pic, lblTen, lblGia}
            AddHandler c.MouseClick,
            Sub(s, e)
                HieuUngMonReset(pn)
                AddMonToCart(maMon, tenMon, donGia)
            End Sub
            'Reset hiệu ứng sau khi click
            AddHandler c.MouseDown,
                Sub(s, e)
                    HieuUngMon(pn)
                End Sub
        Next


        pn.Controls.Add(pic)
        pn.Controls.Add(lblTen)
        pn.Controls.Add(lblGia)
        flpMenu.Controls.Add(pn)
    End Sub
    Private Sub AddMonToCart(maMon As Integer, tenMon As String, donGia As Decimal)
        Dim item = gioHang.FirstOrDefault(Function(x) x.MaMon = maMon)
        If item IsNot Nothing Then
            item.SoLuong += 1
            UpdateChiTietSoLuong(MaHoaDon, maMon, item.SoLuong)
        Else
            gioHang.Add(New CartItem With {.MaMon = maMon, .TenMon = tenMon, .DonGia = donGia, .SoLuong = 1})
            InsertChiTietHoaDon(MaHoaDon, maMon, 1)
        End If
        CapNhatGioHang()
    End Sub

    Private Sub UpdateChiTietSoLuong(maHoaDon As Integer, maMon As Integer, soLuong As Integer)
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("UPDATE CHITIETHOADON SET SoLuong=@sl WHERE MaHoaDon_ID=@hd AND MaMon_ID=@mm", conn)
            cmd.Parameters.AddWithValue("@sl", soLuong)
            cmd.Parameters.AddWithValue("@hd", maHoaDon)
            cmd.Parameters.AddWithValue("@mm", maMon)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub InsertChiTietHoaDon(maHoaDon As Integer, maMon As Integer, soLuong As Integer)
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("INSERT INTO CHITIETHOADON (MaHoaDon_ID, MaMon_ID, SoLuong) VALUES (@hd, @mm, @sl)", conn)
            cmd.Parameters.AddWithValue("@hd", maHoaDon)
            cmd.Parameters.AddWithValue("@mm", maMon)
            cmd.Parameters.AddWithValue("@sl", soLuong)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    ' Gọi AddMonToCart ở sự kiện click của từng card panel (như hướng dẫn trước, bạn đã làm!)

    ' Vẽ lại panel giỏ hàng mỗi khi có thay đổi
    Private Sub CapNhatGioHang()
        pnCart.Controls.Clear()
        Dim y As Integer = 5
        tongTien = 0
        For Each item As CartItem In gioHang
            Dim pnlItem As New Panel()
            pnlItem.Width = pnCart.Width - 10
            pnlItem.Height = 38
            pnlItem.Top = y
            pnlItem.Left = 5
            pnlItem.BackColor = Color.WhiteSmoke

            ' Tên món
            Dim lblTen As New Label()
            lblTen.Text = item.TenMon
            lblTen.Width = 120
            lblTen.Left = 0
            lblTen.Top = 8
            lblTen.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            ' Nút trừ
            Dim btnTru As New Button()
            btnTru.Text = "-"
            btnTru.Width = 26
            btnTru.Height = 26
            btnTru.Left = 125
            btnTru.Top = 5
            btnTru.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            AddHandler btnTru.Click, Sub(s, e)
                                         If item.SoLuong > 1 Then
                                             item.SoLuong -= 1
                                         Else
                                             gioHang.Remove(item)
                                         End If
                                         CapNhatGioHang()
                                     End Sub

            ' Số lượng
            Dim txtSL As New TextBox()
            txtSL.Text = item.SoLuong.ToString()
            txtSL.Width = 28
            txtSL.Left = 155
            txtSL.Top = 7
            txtSL.TextAlign = HorizontalAlignment.Center
            txtSL.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            AddHandler txtSL.KeyDown, Sub(s, e)
                                          If e.KeyCode = Keys.Enter Then
                                              Dim sl As Integer
                                              If Integer.TryParse(txtSL.Text, sl) AndAlso sl > 0 Then
                                                  item.SoLuong = sl
                                                  CapNhatGioHang()
                                              Else
                                                  txtSL.Text = item.SoLuong.ToString()
                                              End If
                                          End If
                                      End Sub

            ' Nút cộng
            Dim btnCong As New Button()
            btnCong.Text = "+"
            btnCong.Width = 26
            btnCong.Height = 26
            btnCong.Left = 185
            btnCong.Top = 5
            btnCong.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            AddHandler btnCong.Click, Sub(s, e)
                                          item.SoLuong += 1
                                          CapNhatGioHang()
                                      End Sub

            ' Thành tiền
            Dim lblTien As New Label()
            lblTien.Text = String.Format("{0:#,0} đ", item.SoLuong * item.DonGia)
            lblTien.Left = 215
            lblTien.Width = 90
            lblTien.Top = 8
            lblTien.Font = New Font("Segoe UI", 10)
            lblTien.TextAlign = ContentAlignment.MiddleRight

            ' Nút Xóa
            Dim btnXoa As New Button()
            btnXoa.Text = "X"
            btnXoa.Width = 26
            btnXoa.Height = 26
            btnXoa.Left = pnlItem.Width - btnXoa.Width - 3
            btnXoa.Top = 5
            btnXoa.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btnXoa.BackColor = Color.IndianRed
            btnXoa.ForeColor = Color.White
            AddHandler btnXoa.Click, Sub(s, e)
                                         gioHang.Remove(item)
                                         CapNhatGioHang()
                                     End Sub

            pnlItem.Controls.Add(lblTen)
            pnlItem.Controls.Add(btnTru)
            pnlItem.Controls.Add(txtSL)
            pnlItem.Controls.Add(btnCong)
            pnlItem.Controls.Add(lblTien)
            pnlItem.Controls.Add(btnXoa)

            pnCart.Controls.Add(pnlItem)
            y += pnlItem.Height + 4

            tongTien += item.SoLuong * item.DonGia
        Next

        lblTongTien.Text = String.Format("Tổng tiền: {0:#,0} đ", tongTien)
    End Sub
    Private Sub flpMenu_Paint(sender As Object, e As PaintEventArgs) Handles flpMenu.Paint

    End Sub

    Private Sub pnCart_Paint(sender As Object, e As PaintEventArgs) Handles pnCart.Paint

    End Sub

    Private Sub lblTongTien_Click(sender As Object, e As EventArgs) Handles lblTongTien.Click

    End Sub

    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        If gioHang.Count = 0 Then
            MessageBox.Show("Chưa có món nào trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim res = MessageBox.Show("Tổng tiền hóa đơn là " & tongTien.ToString("#,0") & " đ." & vbCrLf & "Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo)
        If res = DialogResult.Yes Then
            ' Thanh toán: cập nhật tổng tiền, xóa hết món khỏi bill, set bàn trống
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim cmdBill As New SqlCommand("UPDATE HOADON SET TongTien=@tt, NgayBan=GETDATE() WHERE MaHoaDon_ID=@id", conn)
                cmdBill.Parameters.AddWithValue("@tt", tongTien)
                cmdBill.Parameters.AddWithValue("@id", MaHoaDon)
                cmdBill.ExecuteNonQuery()
                Dim cmdBan As New SqlCommand("UPDATE BAN SET TrangThai=N'Trống' WHERE MaBan_ID=@id", conn)
                cmdBan.Parameters.AddWithValue("@id", MaBan)
                cmdBan.ExecuteNonQuery()
            End Using
            Me.Close()
        Else
            ' Thanh toán sau! Set bàn vẫn là "Có khách", bill giữ nguyên
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim cmdBan As New SqlCommand("UPDATE BAN SET TrangThai=N'Có khách' WHERE MaBan_ID=@id", conn)
                cmdBan.Parameters.AddWithValue("@id", MaBan)
                cmdBan.ExecuteNonQuery()
            End Using
            Me.Close()
        End If
    End Sub
End Class