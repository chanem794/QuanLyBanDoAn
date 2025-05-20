<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDanhMuc
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tên = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(608, 63)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(64, 30)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "+"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(113, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(489, 30)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.QuanLyBanDoAn.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.QuanLyBanDoAn.My.Resources.Resources.icons8_delete_30
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Tên, Me.colEdit, Me.colDelete})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 323)
        Me.DataGridView1.TabIndex = 3
        '
        'id
        '
        Me.id.DataPropertyName = "Madanhmuc_ID"
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 125
        '
        'Tên
        '
        Me.Tên.DataPropertyName = "TenDanhMuc"
        Me.Tên.HeaderText = "Tên"
        Me.Tên.MinimumWidth = 6
        Me.Tên.Name = "Tên"
        Me.Tên.ReadOnly = True
        Me.Tên.Width = 125
        '
        'colEdit
        '
        Me.colEdit.HeaderText = ""
        Me.colEdit.Image = Global.QuanLyBanDoAn.My.Resources.Resources.icons8_edit_30
        Me.colEdit.MinimumWidth = 6
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Width = 125
        '
        'colDelete
        '
        Me.colDelete.HeaderText = ""
        Me.colDelete.Image = Global.QuanLyBanDoAn.My.Resources.Resources.icons8_delete_30
        Me.colDelete.MinimumWidth = 6
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Width = 125
        '
        'FormDanhMuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnThem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDanhMuc"
        Me.Text = "FormDanhMuc"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents btnThem As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Tên As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colDelete As DataGridViewImageColumn
End Class
