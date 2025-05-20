<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTKSL
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
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.dgvSoLuongMon = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSoLuongMon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgay
        '
        Me.dtpNgay.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpNgay.Location = New System.Drawing.Point(382, 28)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(246, 22)
        Me.dtpNgay.TabIndex = 0
        '
        'btnThongKe
        '
        Me.btnThongKe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnThongKe.Location = New System.Drawing.Point(647, 20)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(205, 37)
        Me.btnThongKe.TabIndex = 1
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'dgvSoLuongMon
        '
        Me.dgvSoLuongMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSoLuongMon.Location = New System.Drawing.Point(265, 67)
        Me.dgvSoLuongMon.Name = "dgvSoLuongMon"
        Me.dgvSoLuongMon.RowHeadersWidth = 51
        Me.dgvSoLuongMon.RowTemplate.Height = 24
        Me.dgvSoLuongMon.Size = New System.Drawing.Size(363, 227)
        Me.dgvSoLuongMon.TabIndex = 2
        '
        'FormTKSL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 321)
        Me.Controls.Add(Me.dgvSoLuongMon)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.dtpNgay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTKSL"
        Me.Text = "FormTKSL"
        CType(Me.dgvSoLuongMon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents btnThongKe As Button
    Friend WithEvents dgvSoLuongMon As DataGridView
End Class
