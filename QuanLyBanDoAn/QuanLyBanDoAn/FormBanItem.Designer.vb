<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBanItem
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
        Me.flpBan = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flpBan
        '
        Me.flpBan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpBan.Location = New System.Drawing.Point(0, 0)
        Me.flpBan.Name = "flpBan"
        Me.flpBan.Size = New System.Drawing.Size(800, 450)
        Me.flpBan.TabIndex = 1
        '
        'FormBanItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.flpBan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBanItem"
        Me.Text = "FormBanItem"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpBan As FlowLayoutPanel
End Class
