Imports System.Data.SqlClient

Public Class FormBanItem
    ' Nếu truyền thông tin từ ngoài vào hoặc cần refresh, có thể public Sub LoadBan()

    ' Khi load form sẽ nạp tất cả bàn
    Private Sub FormBanItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiBan()
    End Sub

    Private Sub HienThiBan()
        flpBan.Controls.Clear()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT MaBan_ID, TenBan, TrangThai FROM BAN", conn)
            Using rd = cmd.ExecuteReader()
                While rd.Read()
                    Dim maBan As Integer = rd("MaBan_ID")
                    Dim tenBan As String = rd("TenBan").ToString()
                    Dim trangThai As String = If(rd("TrangThai") IsNot Nothing, rd("TrangThai").ToString().Trim().ToLower(), "trống")

                    ' Panel chứa bàn
                    Dim uc As New Panel()
                    uc.Width = 110
                    uc.Height = 120
                    uc.Margin = New Padding(15, 10, 10, 10)
                    uc.BackColor = Color.Transparent

                    ' PictureBox icon bàn
                    Dim pic As New PictureBox()
                    pic.Size = New Size(90, 90)
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Top = 0
                    pic.Left = 10
                    If trangThai = "có khách" Then
                        pic.Image = My.Resources.ban_cokhach
                    Else
                        pic.Image = My.Resources.ban_trong
                    End If

                    ' Label tên bàn
                    Dim lbl As New Label()
                    lbl.Text = tenBan
                    lbl.Font = New Font("Segoe UI", 14, FontStyle.Bold)
                    lbl.ForeColor = Color.Black
                    lbl.BackColor = Color.Transparent
                    lbl.TextAlign = ContentAlignment.MiddleCenter
                    lbl.Width = uc.Width
                    lbl.Height = 35
                    lbl.Top = 80
                    lbl.Left = 0

                    uc.Controls.Add(pic)
                    uc.Controls.Add(lbl)
                    lbl.BringToFront()

                    ' Hover zoom cho bàn
                    Dim defaultSize As Size = pic.Size
                    Dim zoomSize As Size = New Size(105, 105)
                    Dim defaultLoc As Point = pic.Location
                    Dim zoomLoc As Point = New Point(pic.Left - 7, pic.Top - 7)
                    AddHandler pic.MouseEnter, Sub(s, eargs)
                                                   pic.Size = zoomSize
                                                   pic.Location = zoomLoc
                                               End Sub
                    AddHandler pic.MouseLeave, Sub(s, eargs)
                                                   pic.Size = defaultSize
                                                   pic.Location = defaultLoc
                                               End Sub

                    ' Sự kiện click PICK bàn: ẩn form Home, show đặt món, show lại sau khi order xong
                    AddHandler uc.Click, Sub(sender2, e2)
                                             MoDatMon(maBan)
                                         End Sub
                    AddHandler pic.Click, Sub(sender2, e2)
                                              MoDatMon(maBan)
                                          End Sub
                    AddHandler lbl.Click, Sub(sender2, e2)
                                              MoDatMon(maBan)
                                          End Sub

                    flpBan.Controls.Add(uc)
                End While
            End Using
        End Using
    End Sub

    Private Sub flpBan_Paint(sender As Object, e As PaintEventArgs) Handles flpBan.Paint

    End Sub
    '=== Logic ẩn Form1, gọi Form đặt món ===
    Private Sub MoDatMon(maBan As Integer)
        Dim mainForm = GetMainForm()
        If mainForm IsNot Nothing Then mainForm.Hide()
        Dim fDatMon As New FormDatMon(maBan)
        fDatMon.ShowDialog()
        If mainForm IsNot Nothing Then
            mainForm.Show()
            mainForm.AddControls(New FormHome()) ' Refresh lại bàn khi về trang chính
        End If
    End Sub

    Private Function GetMainForm() As Form1
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Form1 Then Return CType(frm, Form1)
        Next
        Return Nothing
    End Function
End Class