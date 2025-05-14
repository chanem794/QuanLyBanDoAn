<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnDeserts = New System.Windows.Forms.Button()
        Me.btnFoods = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlLeftSide.SuspendLayout()
        Me.pnlOnButtonPosition.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.Label19)
        Me.pnlLeftSide.Controls.Add(Me.Label16)
        Me.pnlLeftSide.Controls.Add(Me.btnDrinks)
        Me.pnlLeftSide.Controls.Add(Me.btnDeserts)
        Me.pnlLeftSide.Controls.Add(Me.btnFoods)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(267, 566)
        Me.pnlLeftSide.TabIndex = 1
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlOnButtonPosition.Controls.Add(Me.pnlTopSide)
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 98)
        Me.pnlOnButtonPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(13, 46)
        Me.pnlOnButtonPosition.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(125, 43)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 36)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "App"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(47, 43)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 36)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "food"
        '
        'btnDrinks
        '
        Me.btnDrinks.FlatAppearance.BorderSize = 0
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDrinks.Location = New System.Drawing.Point(0, 154)
        Me.btnDrinks.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(267, 46)
        Me.btnDrinks.TabIndex = 4
        Me.btnDrinks.Text = "   Drinks"
        Me.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'btnDeserts
        '
        Me.btnDeserts.FlatAppearance.BorderSize = 0
        Me.btnDeserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeserts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeserts.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeserts.Location = New System.Drawing.Point(0, 209)
        Me.btnDeserts.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeserts.Name = "btnDeserts"
        Me.btnDeserts.Size = New System.Drawing.Size(267, 46)
        Me.btnDeserts.TabIndex = 2
        Me.btnDeserts.Text = "   Deserts"
        Me.btnDeserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeserts.UseVisualStyleBackColor = True
        '
        'btnFoods
        '
        Me.btnFoods.FlatAppearance.BorderSize = 0
        Me.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFoods.Location = New System.Drawing.Point(0, 98)
        Me.btnFoods.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFoods.Name = "btnFoods"
        Me.btnFoods.Size = New System.Drawing.Size(267, 46)
        Me.btnFoods.TabIndex = 0
        Me.btnFoods.Text = "   Foods"
        Me.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFoods.UseVisualStyleBackColor = True
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(13, 36)
        Me.pnlTopSide.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(267, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 36)
        Me.Panel1.TabIndex = 2
        '
        'pnlHome
        '
        Me.pnlHome.Controls.Add(Me.Label15)
        Me.pnlHome.Location = New System.Drawing.Point(267, 43)
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(892, 523)
        Me.pnlHome.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(380, 52)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 31)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "About Me"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 566)
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        Me.pnlOnButtonPosition.ResumeLayout(False)
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlOnButtonPosition As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnDeserts As Button
    Friend WithEvents btnFoods As Button
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlHome As Panel
    Friend WithEvents Label15 As Label
End Class
