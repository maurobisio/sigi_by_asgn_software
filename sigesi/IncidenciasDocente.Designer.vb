<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidenciasDocente
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
        Me.dgvAlumno = New System.Windows.Forms.DataGridView()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.lblIncidencia = New System.Windows.Forms.Label()
        Me.cboIncidencia = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grbBuscarAlumnos = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gpb = New System.Windows.Forms.GroupBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.btnCancelar2 = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.grbBuscarAlumnos.SuspendLayout()
        Me.gpb.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAlumno
        '
        Me.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumno.Location = New System.Drawing.Point(41, 252)
        Me.dgvAlumno.Name = "dgvAlumno"
        Me.dgvAlumno.Size = New System.Drawing.Size(680, 106)
        Me.dgvAlumno.TabIndex = 4
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(38, 225)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(327, 15)
        Me.lblInfo.TabIndex = 23
        Me.lblInfo.Text = "Seleccione un alumno de la lista , para generar incidencia."
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
        Me.lblCurso.Location = New System.Drawing.Point(321, 45)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(70, 22)
        Me.lblCurso.TabIndex = 1
        Me.lblCurso.Text = "Curso:"
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
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.cboGrupo.Location = New System.Drawing.Point(426, 45)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(149, 23)
        Me.cboGrupo.TabIndex = 32
        '
        'lblApe
        '
        Me.lblApe.AutoSize = True
        Me.lblApe.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApe.ForeColor = System.Drawing.Color.White
        Me.lblApe.Location = New System.Drawing.Point(37, 116)
        Me.lblApe.Name = "lblApe"
        Me.lblApe.Size = New System.Drawing.Size(72, 17)
        Me.lblApe.TabIndex = 44
        Me.lblApe.Text = "Apellido"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.White
        Me.lblNom.Location = New System.Drawing.Point(37, 77)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(67, 17)
        Me.lblNom.TabIndex = 45
        Me.lblNom.Text = "Nombre"
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.ForeColor = System.Drawing.Color.White
        Me.lblCi.Location = New System.Drawing.Point(37, 44)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(30, 17)
        Me.lblCi.TabIndex = 46
        Me.lblCi.Text = "C.I."
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(141, 41)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.ReadOnly = True
        Me.txtCi.Size = New System.Drawing.Size(100, 23)
        Me.txtCi.TabIndex = 47
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(141, 113)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.ReadOnly = True
        Me.txtApe.Size = New System.Drawing.Size(100, 23)
        Me.txtApe.TabIndex = 48
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(141, 74)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(100, 23)
        Me.txtNom.TabIndex = 49
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(503, 488)
        Me.txtComentarios.MaxLength = 250
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(201, 20)
        Me.txtComentarios.TabIndex = 50
        '
        'lblIncidencia
        '
        Me.lblIncidencia.AutoSize = True
        Me.lblIncidencia.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncidencia.ForeColor = System.Drawing.Color.White
        Me.lblIncidencia.Location = New System.Drawing.Point(365, 446)
        Me.lblIncidencia.Name = "lblIncidencia"
        Me.lblIncidencia.Size = New System.Drawing.Size(110, 22)
        Me.lblIncidencia.TabIndex = 53
        Me.lblIncidencia.Text = "Incidencia:"
        '
        'cboIncidencia
        '
        Me.cboIncidencia.FormattingEnabled = True
        Me.cboIncidencia.Items.AddRange(New Object() {"Observacion", "Expulsion de clase", "Sancion"})
        Me.cboIncidencia.Location = New System.Drawing.Point(503, 447)
        Me.cboIncidencia.Name = "cboIncidencia"
        Me.cboIncidencia.Size = New System.Drawing.Size(149, 21)
        Me.cboIncidencia.TabIndex = 54
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.grbBuscarAlumnos)
        Me.Panel2.Controls.Add(Me.gpb)
        Me.Panel2.Controls.Add(Me.lblComentario)
        Me.Panel2.Controls.Add(Me.btnCancelar2)
        Me.Panel2.Controls.Add(Me.cboIncidencia)
        Me.Panel2.Controls.Add(Me.lblIncidencia)
        Me.Panel2.Controls.Add(Me.btnEnviar)
        Me.Panel2.Controls.Add(Me.txtComentarios)
        Me.Panel2.Controls.Add(Me.lblInfo)
        Me.Panel2.Controls.Add(Me.dgvAlumno)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 602)
        Me.Panel2.TabIndex = 9
        '
        'grbBuscarAlumnos
        '
        Me.grbBuscarAlumnos.Controls.Add(Me.btnCancelar)
        Me.grbBuscarAlumnos.Controls.Add(Me.cboCurso)
        Me.grbBuscarAlumnos.Controls.Add(Me.lblGrupo)
        Me.grbBuscarAlumnos.Controls.Add(Me.lblCurso)
        Me.grbBuscarAlumnos.Controls.Add(Me.cboGrupo)
        Me.grbBuscarAlumnos.Controls.Add(Me.btnBuscar)
        Me.grbBuscarAlumnos.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBuscarAlumnos.ForeColor = System.Drawing.Color.White
        Me.grbBuscarAlumnos.Location = New System.Drawing.Point(41, 36)
        Me.grbBuscarAlumnos.Name = "grbBuscarAlumnos"
        Me.grbBuscarAlumnos.Size = New System.Drawing.Size(584, 144)
        Me.grbBuscarAlumnos.TabIndex = 58
        Me.grbBuscarAlumnos.TabStop = False
        Me.grbBuscarAlumnos.Text = "Buscar alumno"
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
        Me.btnCancelar.Location = New System.Drawing.Point(98, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(165, 48)
        Me.btnCancelar.TabIndex = 81
        Me.btnCancelar.Text = "       Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        Me.btnBuscar.Location = New System.Drawing.Point(343, 89)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(195, 49)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "  Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gpb
        '
        Me.gpb.Controls.Add(Me.lblCi)
        Me.gpb.Controls.Add(Me.lblApe)
        Me.gpb.Controls.Add(Me.lblNom)
        Me.gpb.Controls.Add(Me.txtCi)
        Me.gpb.Controls.Add(Me.txtApe)
        Me.gpb.Controls.Add(Me.txtNom)
        Me.gpb.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpb.ForeColor = System.Drawing.Color.White
        Me.gpb.Location = New System.Drawing.Point(41, 415)
        Me.gpb.Name = "gpb"
        Me.gpb.Size = New System.Drawing.Size(259, 170)
        Me.gpb.TabIndex = 57
        Me.gpb.TabStop = False
        Me.gpb.Text = "Datos del alumno seleccionado"
        '
        'lblComentario
        '
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentario.ForeColor = System.Drawing.Color.White
        Me.lblComentario.Location = New System.Drawing.Point(365, 488)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(134, 22)
        Me.lblComentario.TabIndex = 56
        Me.lblComentario.Text = "Comentarios:"
        '
        'btnCancelar2
        '
        Me.btnCancelar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar2.FlatAppearance.BorderSize = 0
        Me.btnCancelar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelar2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar2.ForeColor = System.Drawing.Color.White
        Me.btnCancelar2.Image = Global.sigesi.My.Resources.Resources.icono_limpiar
        Me.btnCancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar2.Location = New System.Drawing.Point(355, 549)
        Me.btnCancelar2.Name = "btnCancelar2"
        Me.btnCancelar2.Size = New System.Drawing.Size(165, 48)
        Me.btnCancelar2.TabIndex = 55
        Me.btnCancelar2.Text = "       Cancelar"
        Me.btnCancelar2.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Image = Global.sigesi.My.Resources.Resources.icono2
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(547, 549)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(165, 48)
        Me.btnEnviar.TabIndex = 51
        Me.btnEnviar.Text = "       Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'IncidenciasDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 602)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IncidenciasDocente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuDocente"
        CType(Me.dgvAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.grbBuscarAlumnos.ResumeLayout(False)
        Me.grbBuscarAlumnos.PerformLayout()
        Me.gpb.ResumeLayout(False)
        Me.gpb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAlumno As System.Windows.Forms.DataGridView
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents lblIncidencia As System.Windows.Forms.Label
    Friend WithEvents cboIncidencia As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblComentario As System.Windows.Forms.Label
    Friend WithEvents grbBuscarAlumnos As System.Windows.Forms.GroupBox
    Friend WithEvents gpb As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
