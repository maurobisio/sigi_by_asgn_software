<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f1
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
        Me.btnIdioma = New System.Windows.Forms.Button()
        Me.btnHola = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIdioma
        '
        Me.btnIdioma.Location = New System.Drawing.Point(12, 146)
        Me.btnIdioma.Name = "btnIdioma"
        Me.btnIdioma.Size = New System.Drawing.Size(75, 23)
        Me.btnIdioma.TabIndex = 0
        Me.btnIdioma.Text = "Button1"
        Me.btnIdioma.UseVisualStyleBackColor = True
        '
        'btnHola
        '
        Me.btnHola.Location = New System.Drawing.Point(164, 146)
        Me.btnHola.Name = "btnHola"
        Me.btnHola.Size = New System.Drawing.Size(75, 23)
        Me.btnHola.TabIndex = 1
        Me.btnHola.Text = "hola"
        Me.btnHola.UseVisualStyleBackColor = True
        '
        'f1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnHola)
        Me.Controls.Add(Me.btnIdioma)
        Me.Name = "f1"
        Me.Text = "f1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIdioma As System.Windows.Forms.Button
    Friend WithEvents btnHola As System.Windows.Forms.Button
End Class
