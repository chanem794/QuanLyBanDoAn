Imports System.Data.SqlClient
Imports System.Drawing

Public Class FormHome
    Public Sub AddControls(f As Form)
        PanelHome.Controls.Clear()
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        PanelHome.Controls.Add(f)
        f.Show()
    End Sub
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddControls(New FormBanItem())

    End Sub
    Private Sub btnKinhDoanh_Click(sender As Object, e As EventArgs) Handles btnKinhDoanh.Click
        AddControls(New FormBanItem())
        btnKinhDoanh.BackColor = Color.FromArgb(39, 67, 129)
        btnThongKe.BackColor = Color.Silver
    End Sub
    Private Sub PanelHome_Paint(sender As Object, e As PaintEventArgs) Handles PanelHome.Paint

    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        'AddControls(New FormThongKe())
        btnThongKe.BackColor = Color.FromArgb(39, 67, 129)
        btnKinhDoanh.BackColor = Color.Silver
    End Sub
End Class