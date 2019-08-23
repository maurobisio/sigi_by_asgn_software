<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteDocente
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
        Me.gpbBuscarAlumnos = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.lblgrupo = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gpbGgestionar = New System.Windows.Forms.GroupBox()
        Me.btnCalificar = New System.Windows.Forms.Button()
        Me.btnAsistencias = New System.Windows.Forms.Button()
        Me.btnSemanales = New System.Windows.Forms.Button()
        Me.btnMensuales = New System.Windows.Forms.Button()
        Me.btnTrimestrales = New System.Windows.Forms.Button()
        Me.btnFinales = New System.Windows.Forms.Button()
        Me.gpbInformes = New System.Windows.Forms.GroupBox()
        Me.picLIbro = New System.Windows.Forms.PictureBox()
        Me.gpbBuscarAlumnos.SuspendLayout()
        Me.gpbGgestionar.SuspendLayout()
        Me.gpbInformes.SuspendLayout()
        CType(Me.picLIbro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbBuscarAlumnos
        '
        Me.gpbBuscarAlumnos.Controls.Add(Me.btnCancelar)
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboCurso)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblgrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblCurso)
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarAlumnos.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarAlumnos.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarAlumnos.Location = New System.Drawing.Point(53, 130)
        Me.gpbBuscarAlumnos.Name = "gpbBuscarAlumnos"
        Me.gpbBuscarAlumnos.Size = New System.Drawing.Size(464, 178)
        Me.gpbBuscarAlumnos.TabIndex = 59
        Me.gpbBuscarAlumnos.TabStop = False
        Me.gpbBuscarAlumnos.Text = "Buscar alumno"
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
        Me.btnCancelar.Location = New System.Drawing.Point(305, 113)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 48)
        Me.btnCancelar.TabIndex = 81
        Me.btnCancelar.Text = "       Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboCurso.Location = New System.Drawing.Point(114, 52)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(149, 23)
        Me.cboCurso.TabIndex = 25
        '
        'lblgrupo
        '
        Me.lblgrupo.AutoSize = True
        Me.lblgrupo.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrupo.ForeColor = System.Drawing.Color.White
        Me.lblgrupo.Location = New System.Drawing.Point(9, 53)
        Me.lblgrupo.Name = "lblgrupo"
        Me.lblgrupo.Size = New System.Drawing.Size(74, 22)
        Me.lblgrupo.TabIndex = 0
        Me.lblgrupo.Text = "Grupo:"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.ForeColor = System.Drawing.Color.White
        Me.lblCurso.Location = New System.Drawing.Point(13, 103)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(70, 22)
        Me.lblCurso.TabIndex = 1
        Me.lblCurso.Text = "Curso:"
        '
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.cboGrupo.Location = New System.Drawing.Point(114, 102)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(149, 23)
        Me.cboGrupo.TabIndex = 32
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.sigesi.My.Resources.Resources.icono_lupa
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(305, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(153, 49)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "    Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gpbGgestionar
        '
        Me.gpbGgestionar.Controls.Add(Me.btnCalificar)
        Me.gpbGgestionar.Controls.Add(Me.btnAsistencias)
        Me.gpbGgestionar.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbGgestionar.ForeColor = System.Drawing.Color.White
        Me.gpbGgestionar.Location = New System.Drawing.Point(53, 366)
        Me.gpbGgestionar.Name = "gpbGgestionar"
        Me.gpbGgestionar.Size = New System.Drawing.Size(653, 86)
        Me.gpbGgestionar.TabIndex = 63
        Me.gpbGgestionar.TabStop = False
        Me.gpbGgestionar.Text = "Gestionar"
        '
        'btnCalificar
        '
        Me.btnCalificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalificar.FlatAppearance.BorderSize = 0
        Me.btnCalificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCalificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalificar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalificar.ForeColor = System.Drawing.Color.White
        Me.btnCalificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalificar.Location = New System.Drawing.Point(365, 22)
        Me.btnCalificar.Name = "btnCalificar"
        Me.btnCalificar.Size = New System.Drawing.Size(240, 44)
        Me.btnCalificar.TabIndex = 41
        Me.btnCalificar.Text = "calificaciones"
        Me.btnCalificar.UseVisualStyleBackColor = True
        '
        'btnAsistencias
        '
        Me.btnAsistencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsistencias.FlatAppearance.BorderSize = 0
        Me.btnAsistencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAsistencias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencias.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistencias.ForeColor = System.Drawing.Color.White
        Me.btnAsistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsistencias.Location = New System.Drawing.Point(64, 22)
        Me.btnAsistencias.Name = "btnAsistencias"
        Me.btnAsistencias.Size = New System.Drawing.Size(240, 44)
        Me.btnAsistencias.TabIndex = 40
        Me.btnAsistencias.Text = "Asistencias"
        Me.btnAsistencias.UseVisualStyleBackColor = True
        '
        'btnSemanales
        '
        Me.btnSemanales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSemanales.FlatAppearance.BorderSize = 0
        Me.btnSemanales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSemanales.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnSemanales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemanales.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemanales.ForeColor = System.Drawing.Color.White
        Me.btnSemanales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSemanales.Location = New System.Drawing.Point(31, 31)
        Me.btnSemanales.Name = "btnSemanales"
        Me.btnSemanales.Size = New System.Drawing.Size(138, 44)
        Me.btnSemanales.TabIndex = 42
        Me.btnSemanales.Text = "Semanales"
        Me.btnSemanales.UseVisualStyleBackColor = True
        '
        'btnMensuales
        '
        Me.btnMensuales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMensuales.FlatAppearance.BorderSize = 0
        Me.btnMensuales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMensuales.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnMensuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMensuales.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMensuales.ForeColor = System.Drawing.Color.White
        Me.btnMensuales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMensuales.Location = New System.Drawing.Point(31, 81)
        Me.btnMensuales.Name = "btnMensuales"
        Me.btnMensuales.Size = New System.Drawing.Size(138, 44)
        Me.btnMensuales.TabIndex = 43
        Me.btnMensuales.Text = "Mensuales"
        Me.btnMensuales.UseVisualStyleBackColor = True
        '
        'btnTrimestrales
        '
        Me.btnTrimestrales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrimestrales.FlatAppearance.BorderSize = 0
        Me.btnTrimestrales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnTrimestrales.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnTrimestrales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrimestrales.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrimestrales.ForeColor = System.Drawing.Color.White
        Me.btnTrimestrales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrimestrales.Location = New System.Drawing.Point(222, 31)
        Me.btnTrimestrales.Name = "btnTrimestrales"
        Me.btnTrimestrales.Size = New System.Drawing.Size(136, 44)
        Me.btnTrimestrales.TabIndex = 44
        Me.btnTrimestrales.Text = "Trimestrales"
        Me.btnTrimestrales.UseVisualStyleBackColor = True
        '
        'btnFinales
        '
        Me.btnFinales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinales.FlatAppearance.BorderSize = 0
        Me.btnFinales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFinales.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnFinales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinales.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinales.ForeColor = System.Drawing.Color.White
        Me.btnFinales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinales.Location = New System.Drawing.Point(222, 81)
        Me.btnFinales.Name = "btnFinales"
        Me.btnFinales.Size = New System.Drawing.Size(136, 44)
        Me.btnFinales.TabIndex = 45
        Me.btnFinales.Text = "Finales"
        Me.btnFinales.UseVisualStyleBackColor = True
        '
        'gpbInformes
        '
        Me.gpbInformes.Controls.Add(Me.btnSemanales)
        Me.gpbInformes.Controls.Add(Me.btnFinales)
        Me.gpbInformes.Controls.Add(Me.btnMensuales)
        Me.gpbInformes.Controls.Add(Me.btnTrimestrales)
        Me.gpbInformes.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbInformes.ForeColor = System.Drawing.Color.White
        Me.gpbInformes.Location = New System.Drawing.Point(53, 507)
        Me.gpbInformes.Name = "gpbInformes"
        Me.gpbInformes.Size = New System.Drawing.Size(384, 150)
        Me.gpbInformes.TabIndex = 64
        Me.gpbInformes.TabStop = False
        Me.gpbInformes.Text = "Informes"
        '
        'picLIbro
        '
        Me.picLIbro.Image = Global.sigesi.My.Resources.Resources.depositphotos_116517602_stock_illustration_closed_spiral_notebook_and_pen_copy1
        Me.picLIbro.Location = New System.Drawing.Point(572, 89)
        Me.picLIbro.Name = "picLIbro"
        Me.picLIbro.Size = New System.Drawing.Size(146, 127)
        Me.picLIbro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLIbro.TabIndex = 62
        Me.picLIbro.TabStop = False
        '
        'reporteDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 715)
        Me.Controls.Add(Me.gpbInformes)
        Me.Controls.Add(Me.gpbGgestionar)
        Me.Controls.Add(Me.picLIbro)
        Me.Controls.Add(Me.gpbBuscarAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reporteDocente"
        Me.Text = "reporteDocente"
        Me.gpbBuscarAlumnos.ResumeLayout(False)
        Me.gpbBuscarAlumnos.PerformLayout()
        Me.gpbGgestionar.ResumeLayout(False)
        Me.gpbInformes.ResumeLayout(False)
        CType(Me.picLIbro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbBuscarAlumnos As System.Windows.Forms.GroupBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblgrupo As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents picLIbro As System.Windows.Forms.PictureBox
    Friend WithEvents gpbGgestionar As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalificar As System.Windows.Forms.Button
    Friend WithEvents btnAsistencias As System.Windows.Forms.Button
    Friend WithEvents btnSemanales As System.Windows.Forms.Button
    Friend WithEvents btnMensuales As System.Windows.Forms.Button
    Friend WithEvents btnTrimestrales As System.Windows.Forms.Button
    Friend WithEvents btnFinales As System.Windows.Forms.Button
    Friend WithEvents gpbInformes As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
