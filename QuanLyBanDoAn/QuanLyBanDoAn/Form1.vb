Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Private connStr As String = "Data Source=localhost.;Initial Catalog=QuanLyBanDoAn;Integrated Security=True"
    ' Method to add Controls in Main Form
    Public Sub AddControls(f As Form)
        CenterPanel.Controls.Clear()
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        CenterPanel.Controls.Add(f)
        f.Show()
    End Sub
    Sub CapNhatAnhMonDemo()
        ' Bảng ánh xạ mã món sang resource ảnh
        Dim monAnh As New Dictionary(Of Integer, Image) From {
        {1, My.Resources.mon1},
        {2, My.Resources.mon2},
        {3, My.Resources.mon3},
        {4, My.Resources.mon4},
        {5, My.Resources.mon5},
        {6, My.Resources.mon6},
        {7, My.Resources.mon7},
        {8, My.Resources.mon8},
        {9, My.Resources.mon9},
        {10, My.Resources.mon10}
    }

        Using conn As New SqlConnection(connStr)
            conn.Open()
            For Each kvp In monAnh
                Dim id As Integer = kvp.Key
                Dim img As Image = kvp.Value
                ' Chuyển ảnh thành byte
                Dim ms As New MemoryStream()
                img.Save(ms, Imaging.ImageFormat.Png)
                Dim bytes() As Byte = ms.ToArray()
                ' Update ảnh vào món
                Dim cmd As New SqlCommand("UPDATE MENU SET HinhAnhMon=@img WHERE MaMon_ID=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@img", bytes)
                cmd.ExecuteNonQuery()
            Next
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CapNhatAnhMonDemo()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlOnButtonPosition.Height = btnHome.Height
        pnlOnButtonPosition.Top = btnHome.Top
        AddControls(New FormHome())
        Label2.Text = "Home"
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btnDanhMuc_Click(sender As Object, e As EventArgs) Handles btnDanhMuc.Click
        pnlOnButtonPosition.Height = btnDanhMuc.Height
        pnlOnButtonPosition.Top = btnDanhMuc.Top
        AddControls(New FormDanhMuc())
        Label2.Text = "Danh Mục"
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnMon_Click(sender As Object, e As EventArgs) Handles btnMon.Click
        pnlOnButtonPosition.Height = btnMon.Height
        pnlOnButtonPosition.Top = btnMon.Top
        AddControls(New FormMon())
        Label2.Text = "Món"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnBan_Click(sender As Object, e As EventArgs) Handles btnBan.Click
        pnlOnButtonPosition.Height = btnBan.Height
        pnlOnButtonPosition.Top = btnBan.Top
        AddControls(New FormBan())
        Label2.Text = "Bàn"
    End Sub
End Class
