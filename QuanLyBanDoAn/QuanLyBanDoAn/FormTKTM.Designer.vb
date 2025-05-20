<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTKTM
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
        Me.cboMonAn = New System.Windows.Forms.ComboBox()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.dgvDoanhThu = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMonAn
        '
        Me.cboMonAn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboMonAn.FormattingEnabled = True
        Me.cboMonAn.Location = New System.Drawing.Point(108, 27)
        Me.cboMonAn.Name = "cboMonAn"
        Me.cboMonAn.Size = New System.Drawing.Size(135, 33)
        Me.cboMonAn.TabIndex = 0
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpTuNgay.Location = New System.Drawing.Point(282, 33)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(135, 22)
        Me.dtpTuNgay.TabIndex = 1
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpDenNgay.Location = New System.Drawing.Point(446, 33)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(135, 22)
        Me.dtpDenNgay.TabIndex = 2
        '
        'btnThongKe
        '
        Me.btnThongKe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnThongKe.Location = New System.Drawing.Point(646, 27)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(135, 33)
        Me.btnThongKe.TabIndex = 3
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'dgvDoanhThu
        '
        Me.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhThu.Location = New System.Drawing.Point(267, 93)
        Me.dgvDoanhThu.Name = "dgvDoanhThu"
        Me.dgvDoanhThu.RowHeadersWidth = 51
        Me.dgvDoanhThu.RowTemplate.Height = 24
        Me.dgvDoanhThu.Size = New System.Drawing.Size(358, 229)
        Me.dgvDoanhThu.TabIndex = 4
        '
        'FormTKTM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 356)
        Me.Controls.Add(Me.dgvDoanhThu)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.dtpDenNgay)
        Me.Controls.Add(Me.dtpTuNgay)
        Me.Controls.Add(Me.cboMonAn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTKTM"
        Me.Text = "FormTKTM"
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboMonAn As ComboBox
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents btnThongKe As Button
    Friend WithEvents dgvDoanhThu As DataGridView
End Class
