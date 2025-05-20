<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDatMon
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
        Me.pnDanhMuc = New System.Windows.Forms.Panel()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.flpMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnCart = New System.Windows.Forms.Panel()
        Me.lblTongTien = New System.Windows.Forms.Label()
        Me.btnThanhToan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnDanhMuc.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnDanhMuc
        '
        Me.pnDanhMuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnDanhMuc.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnDanhMuc.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnDanhMuc.Location = New System.Drawing.Point(0, 0)
        Me.pnDanhMuc.Margin = New System.Windows.Forms.Padding(4)
        Me.pnDanhMuc.Name = "pnDanhMuc"
        Me.pnDanhMuc.Size = New System.Drawing.Size(186, 610)
        Me.pnDanhMuc.TabIndex = 2
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 2)
        Me.pnlOnButtonPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(13, 46)
        Me.pnlOnButtonPosition.TabIndex = 1
        '
        'flpMenu
        '
        Me.flpMenu.AutoScroll = True
        Me.flpMenu.Location = New System.Drawing.Point(193, 34)
        Me.flpMenu.Name = "flpMenu"
        Me.flpMenu.Size = New System.Drawing.Size(568, 576)
        Me.flpMenu.TabIndex = 5
        '
        'pnCart
        '
        Me.pnCart.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnCart.Location = New System.Drawing.Point(767, 0)
        Me.pnCart.Name = "pnCart"
        Me.pnCart.Size = New System.Drawing.Size(505, 512)
        Me.pnCart.TabIndex = 4
        '
        'lblTongTien
        '
        Me.lblTongTien.AutoSize = True
        Me.lblTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTongTien.Location = New System.Drawing.Point(767, 515)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(86, 29)
        Me.lblTongTien.TabIndex = 0
        Me.lblTongTien.Text = "Label1"
        '
        'btnThanhToan
        '
        Me.btnThanhToan.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnThanhToan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanhToan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnThanhToan.Location = New System.Drawing.Point(767, 543)
        Me.btnThanhToan.Name = "btnThanhToan"
        Me.btnThanhToan.Size = New System.Drawing.Size(505, 67)
        Me.btnThanhToan.TabIndex = 1
        Me.btnThanhToan.Text = "Thanh Toán"
        Me.btnThanhToan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tìm Kiếm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(293, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(468, 30)
        Me.TextBox1.TabIndex = 8
        '
        'FormDatMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 610)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTongTien)
        Me.Controls.Add(Me.btnThanhToan)
        Me.Controls.Add(Me.flpMenu)
        Me.Controls.Add(Me.pnCart)
        Me.Controls.Add(Me.pnDanhMuc)
        Me.Name = "FormDatMon"
        Me.Text = "FormDatMon"
        Me.pnDanhMuc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnDanhMuc As Panel
    Friend WithEvents pnlOnButtonPosition As Panel
    Friend WithEvents flpMenu As FlowLayoutPanel
    Friend WithEvents pnCart As Panel
    Friend WithEvents lblTongTien As Label
    Friend WithEvents btnThanhToan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
