<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajaMateria
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelar.Location = New System.Drawing.Point(14, 134)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(188, 26)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(226, 93)
        Me.txtCod.MaxLength = 50
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(220, 20)
        Me.txtCod.TabIndex = 14
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCod.ForeColor = System.Drawing.Color.Black
        Me.lblCod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCod.Location = New System.Drawing.Point(11, 95)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(206, 18)
        Me.lblCod.TabIndex = 13
        Me.lblCod.Text = "Ingrese Código de Materia"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminar.Location = New System.Drawing.Point(226, 134)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(188, 26)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitulo.Location = New System.Drawing.Point(119, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(217, 31)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Baja de Materia"
        '
        'bajaMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(453, 179)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "bajaMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bajaMateria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
