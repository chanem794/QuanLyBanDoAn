Imports System.Data.SqlClient

Public Class FormHome
<<<<<<< HEAD
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HienThiBan()
    End Sub

<<<<<<< HEAD
    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        AddControls(New FormThongKe())
        btnThongKe.BackColor = Color.FromArgb(39, 67, 129)
        btnKinhDoanh.BackColor = Color.Silver
=======
    Private Sub HienThiBan()
        flpBan.Controls.Clear()

        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT MaBan_ID, TenBan, TrangThai FROM BAN", conn)
            Using rd = cmd.ExecuteReader()
                While rd.Read()
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

                    ' Label tên bàn (chữ to, đậm, bring to front)
                    Dim lbl As New Label()
                    lbl.Text = tenBan
                    lbl.Font = New Font("Segoe UI", 14, FontStyle.Bold)    ' <-- chỉnh size chữ tại đây!
                    lbl.ForeColor = Color.Black
                    lbl.BackColor = Color.Transparent
                    lbl.TextAlign = ContentAlignment.MiddleCenter
                    lbl.Width = uc.Width
                    lbl.Height = 35
                    lbl.Top = 80                                              ' Vị trí sát dưới icon
                    lbl.Left = 0

                    ' Thứ tự add: add PictureBox trước, rồi add Label => label nằm trên cùng panel
                    uc.Controls.Add(pic)
                    uc.Controls.Add(lbl)
                    lbl.BringToFront()              ' Đảm bảo nằm trên ảnh

                    ' (Optional) Hover zoom nhẹ khi rê chuột vào pic
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

                    ' Click vào bàn
                    AddHandler uc.Click, Sub(s, ev)
                                             MessageBox.Show("Bạn vừa chọn: " & tenBan)
                                         End Sub

                    flpBan.Controls.Add(uc)
                End While
            End Using
        End Using
>>>>>>> parent of 463841e (Done Gọi Bàn)
=======
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

>>>>>>> parent of f1d6714 (Merge pull request #6 from chanem794/feature-menu)
    End Sub
End Class