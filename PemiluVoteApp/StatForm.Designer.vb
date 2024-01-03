<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Jam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIPM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pilihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Jam, Me.NIPM, Me.Column2, Me.Kelas, Me.Pilihan})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(616, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'Timer1
        '
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pusat", "No. 1", "No. 2", "No. 3", "No. 4", "No. 5"})
        Me.ComboBox1.Location = New System.Drawing.Point(637, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(634, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pilih jenis hasil yang ingin anda lihat :"
        '
        'Jam
        '
        Me.Jam.HeaderText = "Jam"
        Me.Jam.Name = "Jam"
        Me.Jam.ReadOnly = True
        Me.Jam.Width = 85
        '
        'NIPM
        '
        Me.NIPM.HeaderText = "NIPM"
        Me.NIPM.Name = "NIPM"
        Me.NIPM.ReadOnly = True
        Me.NIPM.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 275
        '
        'Kelas
        '
        Me.Kelas.HeaderText = "Kelas/Jabatan"
        Me.Kelas.Name = "Kelas"
        Me.Kelas.ReadOnly = True
        Me.Kelas.Width = 85
        '
        'Pilihan
        '
        Me.Pilihan.HeaderText = "Pilihan"
        Me.Pilihan.Name = "Pilihan"
        Me.Pilihan.ReadOnly = True
        Me.Pilihan.Width = 45
        '
        'StatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.Name = "StatForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hasil Pemilihan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Jam As DataGridViewTextBoxColumn
    Friend WithEvents NIPM As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Kelas As DataGridViewTextBoxColumn
    Friend WithEvents Pilihan As DataGridViewTextBoxColumn
End Class
