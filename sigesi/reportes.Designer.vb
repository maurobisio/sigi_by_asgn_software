<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportes
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
        Me.btnBoletin = New System.Windows.Forms.Button()
        Me.btnFichaAcumulativa = New System.Windows.Forms.Button()
        Me.btnNotificarIncidencias = New System.Windows.Forms.Button()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.gpbGestionInformes = New System.Windows.Forms.GroupBox()
        Me.gpbBuscarAlumnos = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGrupo = New System.Windows.Forms.Button()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.picLibro = New System.Windows.Forms.PictureBox()
        Me.gpbGestionInformes.SuspendLayout()
        Me.gpbBuscarAlumnos.SuspendLayout()
        CType(Me.picLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBoletin
        '
        Me.btnBoletin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBoletin.FlatAppearance.BorderSize = 0
        Me.btnBoletin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBoletin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnBoletin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBoletin.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoletin.ForeColor = System.Drawing.Color.White
        Me.btnBoletin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBoletin.Location = New System.Drawing.Point(39, 118)
        Me.btnBoletin.Name = "btnBoletin"
        Me.btnBoletin.Size = New System.Drawing.Size(240, 44)
        Me.btnBoletin.TabIndex = 37
        Me.btnBoletin.Text = "Boletín de Calificaciones"
        Me.btnBoletin.UseVisualStyleBackColor = True
        '
        'btnFichaAcumulativa
        '
        Me.btnFichaAcumulativa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFichaAcumulativa.FlatAppearance.BorderSize = 0
        Me.btnFichaAcumulativa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFichaAcumulativa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnFichaAcumulativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFichaAcumulativa.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichaAcumulativa.ForeColor = System.Drawing.Color.White
        Me.btnFichaAcumulativa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFichaAcumulativa.Location = New System.Drawing.Point(328, 52)
        Me.btnFichaAcumulativa.Name = "btnFichaAcumulativa"
        Me.btnFichaAcumulativa.Size = New System.Drawing.Size(240, 44)
        Me.btnFichaAcumulativa.TabIndex = 38
        Me.btnFichaAcumulativa.Text = "Ficha acumulativa"
        Me.btnFichaAcumulativa.UseVisualStyleBackColor = True
        '
        'btnNotificarIncidencias
        '
        Me.btnNotificarIncidencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotificarIncidencias.FlatAppearance.BorderSize = 0
        Me.btnNotificarIncidencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnNotificarIncidencias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnNotificarIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificarIncidencias.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotificarIncidencias.ForeColor = System.Drawing.Color.White
        Me.btnNotificarIncidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotificarIncidencias.Location = New System.Drawing.Point(39, 52)
        Me.btnNotificarIncidencias.Name = "btnNotificarIncidencias"
        Me.btnNotificarIncidencias.Size = New System.Drawing.Size(240, 44)
        Me.btnNotificarIncidencias.TabIndex = 39
        Me.btnNotificarIncidencias.Text = "Notificar incidencias"
        Me.btnNotificarIncidencias.UseVisualStyleBackColor = True
        '
        'btnMail
        '
        Me.btnMail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMail.FlatAppearance.BorderSize = 0
        Me.btnMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMail.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMail.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMail.ForeColor = System.Drawing.Color.White
        Me.btnMail.Image = Global.sigesi.My.Resources.Resources.icono_mail
        Me.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMail.Location = New System.Drawing.Point(326, 118)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(242, 44)
        Me.btnMail.TabIndex = 40
        Me.btnMail.Text = " Enviar email"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'gpbGestionInformes
        '
        Me.gpbGestionInformes.Controls.Add(Me.btnNotificarIncidencias)
        Me.gpbGestionInformes.Controls.Add(Me.btnBoletin)
        Me.gpbGestionInformes.Controls.Add(Me.btnMail)
        Me.gpbGestionInformes.Controls.Add(Me.btnFichaAcumulativa)
        Me.gpbGestionInformes.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbGestionInformes.ForeColor = System.Drawing.Color.White
        Me.gpbGestionInformes.Location = New System.Drawing.Point(26, 331)
        Me.gpbGestionInformes.Name = "gpbGestionInformes"
        Me.gpbGestionInformes.Size = New System.Drawing.Size(616, 190)
        Me.gpbGestionInformes.TabIndex = 41
        Me.gpbGestionInformes.TabStop = False
        Me.gpbGestionInformes.Text = "Gestión de informes"
        '
        'gpbBuscarAlumnos
        '
        Me.gpbBuscarAlumnos.Controls.Add(Me.btnCancelar)
        Me.gpbBuscarAlumnos.Controls.Add(Me.btnGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboCurso)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblCurso)
        Me.gpbBuscarAlumnos.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarAlumnos.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarAlumnos.Location = New System.Drawing.Point(26, 78)
        Me.gpbBuscarAlumnos.Name = "gpbBuscarAlumnos"
        Me.gpbBuscarAlumnos.Size = New System.Drawing.Size(517, 172)
        Me.gpbBuscarAlumnos.TabIndex = 60
        Me.gpbBuscarAlumnos.TabStop = False
        Me.gpbBuscarAlumnos.Text = "Buscar alumno"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.sigesi.My.Resources.Resources.icono_limpiar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(328, 94)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(167, 48)
        Me.btnCancelar.TabIndex = 60
        Me.btnCancelar.Text = "       Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrupo
        '
        Me.btnGrupo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrupo.FlatAppearance.BorderSize = 0
        Me.btnGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupo.ForeColor = System.Drawing.Color.White
        Me.btnGrupo.Image = Global.sigesi.My.Resources.Resources.icono_lupa
        Me.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrupo.Location = New System.Drawing.Point(328, 29)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(167, 49)
        Me.btnGrupo.TabIndex = 36
        Me.btnGrupo.Text = "     Buscar "
        Me.btnGrupo.UseVisualStyleBackColor = True
        '
        'cboGrupo
        '
        Me.cboGrupo.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.cboGrupo.Location = New System.Drawing.Point(96, 94)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(187, 23)
        Me.cboGrupo.TabIndex = 32
        '
        'cboCurso
        '
        Me.cboCurso.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboCurso.Location = New System.Drawing.Point(96, 55)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(183, 23)
        Me.cboCurso.TabIndex = 25
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.White
        Me.lblGrupo.Location = New System.Drawing.Point(12, 56)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(74, 22)
        Me.lblGrupo.TabIndex = 0
        Me.lblGrupo.Text = "Grupo:"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.ForeColor = System.Drawing.Color.White
        Me.lblCurso.Location = New System.Drawing.Point(16, 95)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(70, 22)
        Me.lblCurso.TabIndex = 1
        Me.lblCurso.Text = "Curso:"
        '
        'picLibro
        '
        Me.picLibro.Image = Global.sigesi.My.Resources.Resources.depositphotos_116517602_stock_illustration_closed_spiral_notebook_and_pen_copy1
        Me.picLibro.Location = New System.Drawing.Point(577, 12)
        Me.picLibro.Name = "picLibro"
        Me.picLibro.Size = New System.Drawing.Size(146, 127)
        Me.picLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLibro.TabIndex = 61
        Me.picLibro.TabStop = False
        '
        'reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 579)
        Me.Controls.Add(Me.picLibro)
        Me.Controls.Add(Me.gpbBuscarAlumnos)
        Me.Controls.Add(Me.gpbGestionInformes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reportes"
        Me.Text = "picture"
        Me.gpbGestionInformes.ResumeLayout(False)
        Me.gpbBuscarAlumnos.ResumeLayout(False)
        Me.gpbBuscarAlumnos.PerformLayout()
        CType(Me.picLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBoletin As System.Windows.Forms.Button
    Friend WithEvents btnFichaAcumulativa As System.Windows.Forms.Button
    Friend WithEvents btnNotificarIncidencias As System.Windows.Forms.Button
    Friend WithEvents btnMail As System.Windows.Forms.Button
    Friend WithEvents gpbGestionInformes As System.Windows.Forms.GroupBox
    Friend WithEvents gpbBuscarAlumnos As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrupo As System.Windows.Forms.Button
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents picLibro As System.Windows.Forms.PictureBox
End Class
