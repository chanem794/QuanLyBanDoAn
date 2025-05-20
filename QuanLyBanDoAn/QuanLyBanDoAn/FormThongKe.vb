Imports System.Data.SqlClient

Public Class FormThongKe
    Public Sub AddControls(f As Form)
        pnlMain.Controls.Clear()
        f.Dock = DockStyle.Fill
        f.TopLevel = False
        pnlMain.Controls.Add(f)
        f.Show()
    End Sub
    Private Sub FormThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddControls(New FormTKSL())
        btnThongKeSoLuong.BackColor = Color.FromArgb(39, 67, 129)
        btnThongKeDoanhThu.BackColor = Color.Silver
    End Sub

    Private Sub btnThongKeDoanhThu_Click(sender As Object, e As EventArgs) Handles btnThongKeDoanhThu.Click
        AddControls(New FormTKTM())
        btnThongKeDoanhThu.BackColor = Color.FromArgb(39, 67, 129)
        btnThongKeSoLuong.BackColor = Color.Silver
    End Sub

    Private Sub btnThongKeSoLuong_Click(sender As Object, e As EventArgs) Handles btnThongKeSoLuong.Click
        AddControls(New FormTKSL())
        btnThongKeSoLuong.BackColor = Color.FromArgb(39, 67, 129)
        btnThongKeDoanhThu.BackColor = Color.Silver
    End Sub

End Class