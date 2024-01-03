<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "e-Voting Application"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pilihlah jenis PC anda"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Server"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 63)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Client"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(98, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 63)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pilihlah opsi ini apabila PC ini digunakan untuk memantau hasil pemilu." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jika and" &
    "a memilih ini, diharapkan untuk mempersiapkan foto calon, nama calon, dan visi m" &
    "isi calon dalam bentuk txt"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(98, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(314, 63)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pilihlah opsi ini apabila PC ini digunakan untuk memilih calon." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apabila anda mem" &
    "ilih ini, diharapkan untuk sudah mempersipakan foto, nama, dan visi misi calon d" &
    "i PC server"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(17, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 63)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Offline Mode"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(98, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(314, 63)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pilihlah opsi ini apabila anda menggunakan PC ini hanya untuk satu orang atau sat" &
    "u tempat dalam memilih." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contoh : Hanya untuk pimpinan Pesantren, instansi terte" &
    "ntu"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(337, 291)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 326)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StartPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kiat Mulai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
End Class
