Imports System.Data.SqlClient
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

End Class
