<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
<<<<<<< HEAD
        Me.flpBan = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flpBan
        '
<<<<<<< HEAD
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
        Me.PanelHome.Location = New System.Drawing.Point(0, 80)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(800, 370)
        Me.PanelHome.TabIndex = 3
=======
        Me.flpBan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpBan.Location = New System.Drawing.Point(12, 68)
        Me.flpBan.Name = "flpBan"
        Me.flpBan.Size = New System.Drawing.Size(776, 370)
        Me.flpBan.TabIndex = 0
>>>>>>> parent of 463841e (Done Gọi Bàn)
=======
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(366, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
>>>>>>> parent of f1d6714 (Merge pull request #6 from chanem794/feature-menu)
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(804, 489)
=======
        Me.ClientSize = New System.Drawing.Size(800, 450)
>>>>>>> parent of 230a0dd (Merge pull request #8 from chanem794/thongke)
        Me.Controls.Add(Me.PanelHome)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.btnKinhDoanh)
=======
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.flpBan)
>>>>>>> parent of 463841e (Done Gọi Bàn)
=======
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
>>>>>>> parent of f1d6714 (Merge pull request #6 from chanem794/feature-menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormHome"
        Me.Text = "FormHome"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents flpBan As FlowLayoutPanel
=======
    Friend WithEvents Label1 As Label
>>>>>>> parent of f1d6714 (Merge pull request #6 from chanem794/feature-menu)
End Class
