<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnKinhDoanh = New System.Windows.Forms.Button()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.PanelHome = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnKinhDoanh
        '
        Me.btnKinhDoanh.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnKinhDoanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKinhDoanh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnKinhDoanh.Location = New System.Drawing.Point(12, 12)
        Me.btnKinhDoanh.Name = "btnKinhDoanh"
        Me.btnKinhDoanh.Size = New System.Drawing.Size(225, 45)
        Me.btnKinhDoanh.TabIndex = 1
        Me.btnKinhDoanh.Text = "Kinh Doanh"
        Me.btnKinhDoanh.UseVisualStyleBackColor = False
        '
        'btnThongKe
        '
        Me.btnThongKe.BackColor = System.Drawing.Color.Silver
        Me.btnThongKe.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThongKe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThongKe.Location = New System.Drawing.Point(243, 12)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(225, 45)
        Me.btnThongKe.TabIndex = 2
        Me.btnThongKe.Text = "Thống Kê"
        Me.btnThongKe.UseVisualStyleBackColor = False
        '
        'PanelHome
        '
        Me.PanelHome.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelHome.Location = New System.Drawing.Point(0, 75)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(804, 414)
        Me.PanelHome.TabIndex = 3
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 489)
        Me.Controls.Add(Me.PanelHome)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.btnKinhDoanh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormHome"
        Me.Text = "FormHome"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnKinhDoanh As Button
    Friend WithEvents btnThongKe As Button
    Friend WithEvents PanelHome As Panel
End Class
