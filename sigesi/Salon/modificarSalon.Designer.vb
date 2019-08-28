<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarSalon
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNomNu = New System.Windows.Forms.TextBox()
        Me.lblNOmnuevo = New System.Windows.Forms.Label()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.txtCodNu = New System.Windows.Forms.TextBox()
        Me.lblCod2 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lblCodigoSalon = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNomNu
        '
        Me.txtNomNu.Location = New System.Drawing.Point(155, 290)
        Me.txtNomNu.MaxLength = 20
        Me.txtNomNu.Name = "txtNomNu"
        Me.txtNomNu.Size = New System.Drawing.Size(173, 20)
        Me.txtNomNu.TabIndex = 63
        '
        'lblNOmnuevo
        '
        Me.lblNOmnuevo.AutoSize = True
        Me.lblNOmnuevo.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOmnuevo.ForeColor = System.Drawing.Color.White
        Me.lblNOmnuevo.Location = New System.Drawing.Point(20, 290)
        Me.lblNOmnuevo.Name = "lblNOmnuevo"
        Me.lblNOmnuevo.Size = New System.Drawing.Size(122, 20)
        Me.lblNOmnuevo.TabIndex = 62
        Me.lblNOmnuevo.Text = "Nómbre nuevo:"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(97, 39)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(198, 22)
        Me.lbltitulo.TabIndex = 61
        Me.lbltitulo.Text = "MODIFICAR SALÓN"
        '
        'txtCodNu
        '
        Me.txtCodNu.Location = New System.Drawing.Point(155, 258)
        Me.txtCodNu.MaxLength = 20
        Me.txtCodNu.Name = "txtCodNu"
        Me.txtCodNu.Size = New System.Drawing.Size(173, 20)
        Me.txtCodNu.TabIndex = 60
        '
        'lblCod2
        '
        Me.lblCod2.AutoSize = True
        Me.lblCod2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod2.ForeColor = System.Drawing.Color.White
        Me.lblCod2.Location = New System.Drawing.Point(20, 258)
        Me.lblCod2.Name = "lblCod2"
        Me.lblCod2.Size = New System.Drawing.Size(123, 20)
        Me.lblCod2.TabIndex = 59
        Me.lblCod2.Text = "Código nuevo :"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(238, 133)
        Me.txtCod.MaxLength = 20
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(137, 20)
        Me.txtCod.TabIndex = 68
        '
        'lblCodigoSalon
        '
        Me.lblCodigoSalon.AutoSize = True
        Me.lblCodigoSalon.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoSalon.ForeColor = System.Drawing.Color.White
        Me.lblCodigoSalon.Location = New System.Drawing.Point(20, 133)
        Me.lblCodigoSalon.Name = "lblCodigoSalon"
        Me.lblCodigoSalon.Size = New System.Drawing.Size(202, 20)
        Me.lblCodigoSalon.TabIndex = 67
        Me.lblCodigoSalon.Text = "Ingrese código de salón :"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(347, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 66
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.sigesi.My.Resources.Resources.icono_limpiar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(24, 346)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(165, 48)
        Me.btnCancelar.TabIndex = 65
        Me.btnCancelar.Text = "       Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Image = Global.sigesi.My.Resources.Resources.icono2
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(210, 346)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(165, 48)
        Me.btnEnviar.TabIndex = 64
        Me.btnEnviar.Text = "       Modificar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'ModificarSalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(387, 424)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCodigoSalon)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtNomNu)
        Me.Controls.Add(Me.lblNOmnuevo)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.txtCodNu)
        Me.Controls.Add(Me.lblCod2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarSalon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarSalon"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents txtNomNu As System.Windows.Forms.TextBox
    Friend WithEvents lblNOmnuevo As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents txtCodNu As System.Windows.Forms.TextBox
    Friend WithEvents lblCod2 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoSalon As System.Windows.Forms.Label
End Class
