<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormThongKe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnThongKeSoLuong = New System.Windows.Forms.Button()
        Me.btnThongKeDoanhThu = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnThongKeSoLuong
        '
        Me.btnThongKeSoLuong.BackColor = System.Drawing.Color.Silver
        Me.btnThongKeSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnThongKeSoLuong.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThongKeSoLuong.Location = New System.Drawing.Point(45, 12)
        Me.btnThongKeSoLuong.Name = "btnThongKeSoLuong"
        Me.btnThongKeSoLuong.Size = New System.Drawing.Size(224, 61)
        Me.btnThongKeSoLuong.TabIndex = 0
        Me.btnThongKeSoLuong.Text = "Thống kê số lượng theo ngày"
        Me.btnThongKeSoLuong.UseVisualStyleBackColor = False
        '
        'btnThongKeDoanhThu
        '
        Me.btnThongKeDoanhThu.BackColor = System.Drawing.Color.Silver
        Me.btnThongKeDoanhThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnThongKeDoanhThu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThongKeDoanhThu.Location = New System.Drawing.Point(637, 12)
        Me.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu"
        Me.btnThongKeDoanhThu.Size = New System.Drawing.Size(224, 61)
        Me.btnThongKeDoanhThu.TabIndex = 1
        Me.btnThongKeDoanhThu.Text = "Thống kê doanh thu theo món"
        Me.btnThongKeDoanhThu.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Location = New System.Drawing.Point(1, 79)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(911, 295)
        Me.pnlMain.TabIndex = 3
        '
        'FormThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 377)
        Me.Controls.Add(Me.btnThongKeDoanhThu)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.btnThongKeSoLuong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormThongKe"
        Me.Text = "FormThongKe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnThongKeSoLuong As Button
    Friend WithEvents btnThongKeDoanhThu As Button
    Friend WithEvents pnlMain As Panel
End Class
