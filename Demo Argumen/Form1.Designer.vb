<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDemoArgumen
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
        Me.tombolDemo1 = New System.Windows.Forms.Button()
        Me.tombolDemo2 = New System.Windows.Forms.Button()
        Me.tombolDemo3 = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.listNilai = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'tombolDemo1
        '
        Me.tombolDemo1.Location = New System.Drawing.Point(13, 13)
        Me.tombolDemo1.Name = "tombolDemo1"
        Me.tombolDemo1.Size = New System.Drawing.Size(91, 30)
        Me.tombolDemo1.TabIndex = 0
        Me.tombolDemo1.Text = "Demo 1"
        Me.tombolDemo1.UseVisualStyleBackColor = True
        '
        'tombolDemo2
        '
        Me.tombolDemo2.Location = New System.Drawing.Point(13, 71)
        Me.tombolDemo2.Name = "tombolDemo2"
        Me.tombolDemo2.Size = New System.Drawing.Size(91, 30)
        Me.tombolDemo2.TabIndex = 1
        Me.tombolDemo2.Text = "Demo 2"
        Me.tombolDemo2.UseVisualStyleBackColor = True
        '
        'tombolDemo3
        '
        Me.tombolDemo3.Location = New System.Drawing.Point(13, 128)
        Me.tombolDemo3.Name = "tombolDemo3"
        Me.tombolDemo3.Size = New System.Drawing.Size(91, 30)
        Me.tombolDemo3.TabIndex = 2
        Me.tombolDemo3.Text = "Demo 3"
        Me.tombolDemo3.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(12, 216)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(91, 30)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'listNilai
        '
        Me.listNilai.FormattingEnabled = True
        Me.listNilai.Location = New System.Drawing.Point(131, 13)
        Me.listNilai.Name = "listNilai"
        Me.listNilai.Size = New System.Drawing.Size(141, 238)
        Me.listNilai.TabIndex = 4
        '
        'FormDemoArgumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 258)
        Me.Controls.Add(Me.listNilai)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolDemo3)
        Me.Controls.Add(Me.tombolDemo2)
        Me.Controls.Add(Me.tombolDemo1)
        Me.Name = "FormDemoArgumen"
        Me.Text = "Demo Argumen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tombolDemo1 As System.Windows.Forms.Button
    Friend WithEvents tombolDemo2 As System.Windows.Forms.Button
    Friend WithEvents tombolDemo3 As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button
    Friend WithEvents listNilai As System.Windows.Forms.ListBox

End Class
