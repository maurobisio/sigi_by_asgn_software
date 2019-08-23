<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestioneInformes
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
        Me.gpbInformes = New System.Windows.Forms.GroupBox()
        Me.btnSemanales = New System.Windows.Forms.Button()
        Me.btnFinales = New System.Windows.Forms.Button()
        Me.btnMensuales = New System.Windows.Forms.Button()
        Me.btntrimestrales = New System.Windows.Forms.Button()
        Me.gpbGestionar = New System.Windows.Forms.GroupBox()
        Me.btnCalificaciones = New System.Windows.Forms.Button()
        Me.btnAsistencias = New System.Windows.Forms.Button()
        Me.gpbBuscarAlumnos = New System.Windows.Forms.GroupBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.gpbInformes.SuspendLayout()
        Me.gpbGestionar.SuspendLayout()
        Me.gpbBuscarAlumnos.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbInformes
        '
        Me.gpbInformes.Controls.Add(Me.btnSemanales)
        Me.gpbInformes.Controls.Add(Me.btnFinales)
        Me.gpbInformes.Controls.Add(Me.btnMensuales)
        Me.gpbInformes.Controls.Add(Me.btntrimestrales)
        Me.gpbInformes.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbInformes.ForeColor = System.Drawing.Color.White
        Me.gpbInformes.Location = New System.Drawing.Point(41, 424)
        Me.gpbInformes.Name = "gpbInformes"
        Me.gpbInformes.Size = New System.Drawing.Size(384, 150)
        Me.gpbInformes.TabIndex = 68
        Me.gpbInformes.TabStop = False
        Me.gpbInformes.Text = "Informes"
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
        'btntrimestrales
        '
        Me.btntrimestrales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntrimestrales.FlatAppearance.BorderSize = 0
        Me.btntrimestrales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btntrimestrales.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btntrimestrales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntrimestrales.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntrimestrales.ForeColor = System.Drawing.Color.White
        Me.btntrimestrales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntrimestrales.Location = New System.Drawing.Point(222, 31)
        Me.btntrimestrales.Name = "btntrimestrales"
        Me.btntrimestrales.Size = New System.Drawing.Size(136, 44)
        Me.btntrimestrales.TabIndex = 44
        Me.btntrimestrales.Text = "Trimestrales"
        Me.btntrimestrales.UseVisualStyleBackColor = True
        '
        'gpbGestionar
        '
        Me.gpbGestionar.Controls.Add(Me.btnCalificaciones)
        Me.gpbGestionar.Controls.Add(Me.btnAsistencias)
        Me.gpbGestionar.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbGestionar.ForeColor = System.Drawing.Color.White
        Me.gpbGestionar.Location = New System.Drawing.Point(41, 283)
        Me.gpbGestionar.Name = "gpbGestionar"
        Me.gpbGestionar.Size = New System.Drawing.Size(653, 86)
        Me.gpbGestionar.TabIndex = 67
        Me.gpbGestionar.TabStop = False
        Me.gpbGestionar.Text = "Gestionar"
        '
        'btnCalificaciones
        '
        Me.btnCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalificaciones.FlatAppearance.BorderSize = 0
        Me.btnCalificaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalificaciones.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalificaciones.ForeColor = System.Drawing.Color.White
        Me.btnCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalificaciones.Location = New System.Drawing.Point(365, 22)
        Me.btnCalificaciones.Name = "btnCalificaciones"
        Me.btnCalificaciones.Size = New System.Drawing.Size(240, 44)
        Me.btnCalificaciones.TabIndex = 41
        Me.btnCalificaciones.Text = "calificaciones"
        Me.btnCalificaciones.UseVisualStyleBackColor = True
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
        'gpbBuscarAlumnos
        '
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboCurso)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblCurso)
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarAlumnos.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarAlumnos.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarAlumnos.Location = New System.Drawing.Point(41, 68)
        Me.gpbBuscarAlumnos.Name = "gpbBuscarAlumnos"
        Me.gpbBuscarAlumnos.Size = New System.Drawing.Size(444, 130)
        Me.gpbBuscarAlumnos.TabIndex = 65
        Me.gpbBuscarAlumnos.TabStop = False
        Me.gpbBuscarAlumnos.Text = "Buscar alumno"
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboCurso.Location = New System.Drawing.Point(114, 45)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(149, 23)
        Me.cboCurso.TabIndex = 25
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.White
        Me.lblGrupo.Location = New System.Drawing.Point(9, 41)
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
        Me.lblCurso.Location = New System.Drawing.Point(9, 89)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(70, 22)
        Me.lblCurso.TabIndex = 1
        Me.lblCurso.Text = "Curso:"
        '
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.cboGrupo.Location = New System.Drawing.Point(114, 89)
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
        Me.btnBuscar.Location = New System.Drawing.Point(308, 62)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(119, 49)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "         Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'pct1
        '
        Me.pct1.Image = Global.sigesi.My.Resources.Resources.depositphotos_116517602_stock_illustration_closed_spiral_notebook_and_pen_copy1
        Me.pct1.Location = New System.Drawing.Point(554, 17)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(146, 127)
        Me.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct1.TabIndex = 66
        Me.pct1.TabStop = False
        '
        'GestioneInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(752, 610)
        Me.Controls.Add(Me.gpbInformes)
        Me.Controls.Add(Me.gpbGestionar)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.gpbBuscarAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestioneInformes"
        Me.Text = "Form1"
        Me.gpbInformes.ResumeLayout(False)
        Me.gpbGestionar.ResumeLayout(False)
        Me.gpbBuscarAlumnos.ResumeLayout(False)
        Me.gpbBuscarAlumnos.PerformLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbInformes As System.Windows.Forms.GroupBox
    Friend WithEvents btnSemanales As System.Windows.Forms.Button
    Friend WithEvents btnFinales As System.Windows.Forms.Button
    Friend WithEvents btnMensuales As System.Windows.Forms.Button
    Friend WithEvents btntrimestrales As System.Windows.Forms.Button
    Friend WithEvents gpbGestionar As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalificaciones As System.Windows.Forms.Button
    Friend WithEvents btnAsistencias As System.Windows.Forms.Button
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents gpbBuscarAlumnos As System.Windows.Forms.GroupBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
