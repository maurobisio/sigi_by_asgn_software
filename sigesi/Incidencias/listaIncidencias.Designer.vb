<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaIncidencias
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
        Me.dgvListarAlumnos = New System.Windows.Forms.DataGridView()
        Me.lblListaIncidencia = New System.Windows.Forms.Label()
        Me.gpbBuscarIncidencia = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarIncidencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListarAlumnos
        '
        Me.dgvListarAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvListarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarAlumnos.Location = New System.Drawing.Point(27, 254)
        Me.dgvListarAlumnos.Name = "dgvListarAlumnos"
        Me.dgvListarAlumnos.ReadOnly = True
        Me.dgvListarAlumnos.Size = New System.Drawing.Size(491, 166)
        Me.dgvListarAlumnos.TabIndex = 4
        '
        'lblListaIncidencia
        '
        Me.lblListaIncidencia.AutoSize = True
        Me.lblListaIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaIncidencia.ForeColor = System.Drawing.Color.White
        Me.lblListaIncidencia.Location = New System.Drawing.Point(39, 226)
        Me.lblListaIncidencia.Name = "lblListaIncidencia"
        Me.lblListaIncidencia.Size = New System.Drawing.Size(191, 25)
        Me.lblListaIncidencia.TabIndex = 3
        Me.lblListaIncidencia.Text = "Lista de Incidencia"
        '
        'gpbBuscarIncidencia
        '
        Me.gpbBuscarIncidencia.Controls.Add(Me.ComboBox1)
        Me.gpbBuscarIncidencia.Controls.Add(Me.lblAlumno)
        Me.gpbBuscarIncidencia.Controls.Add(Me.btnCancelar)
        Me.gpbBuscarIncidencia.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarIncidencia.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarIncidencia.Controls.Add(Me.cboCurso)
        Me.gpbBuscarIncidencia.Controls.Add(Me.lblGrupo)
        Me.gpbBuscarIncidencia.Controls.Add(Me.lblMateria)
        Me.gpbBuscarIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarIncidencia.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarIncidencia.Location = New System.Drawing.Point(27, 33)
        Me.gpbBuscarIncidencia.Name = "gpbBuscarIncidencia"
        Me.gpbBuscarIncidencia.Size = New System.Drawing.Size(616, 172)
        Me.gpbBuscarIncidencia.TabIndex = 59
        Me.gpbBuscarIncidencia.TabStop = False
        Me.gpbBuscarIncidencia.Text = "Buscar Incidencias"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.ComboBox1.Location = New System.Drawing.Point(377, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 28)
        Me.ComboBox1.TabIndex = 62
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumno.ForeColor = System.Drawing.Color.White
        Me.lblAlumno.Location = New System.Drawing.Point(272, 77)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(81, 24)
        Me.lblAlumno.TabIndex = 61
        Me.lblAlumno.Text = "Alumno:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.sigesi.My.Resources.Resources.icono_limpiar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(74, 109)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(165, 48)
        Me.btnCancelar.TabIndex = 60
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
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.sigesi.My.Resources.Resources.icono_lupa
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(400, 109)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(195, 49)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "  Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.cboGrupo.Location = New System.Drawing.Point(377, 42)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(149, 28)
        Me.cboGrupo.TabIndex = 32
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboCurso.Location = New System.Drawing.Point(109, 42)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(149, 28)
        Me.cboCurso.TabIndex = 25
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.White
        Me.lblGrupo.Location = New System.Drawing.Point(12, 42)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(68, 24)
        Me.lblGrupo.TabIndex = 0
        Me.lblGrupo.Text = "Grupo:"
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMateria.ForeColor = System.Drawing.Color.White
        Me.lblMateria.Location = New System.Drawing.Point(272, 42)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(76, 24)
        Me.lblMateria.TabIndex = 1
        Me.lblMateria.Text = "Materia:"
        '
        'btnAlta
        '
        Me.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAlta.BackColor = System.Drawing.Color.Black
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnAlta.Image = Global.sigesi.My.Resources.Resources.icono_agregar_ususario_50
        Me.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlta.Location = New System.Drawing.Point(524, 254)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(199, 69)
        Me.btnAlta.TabIndex = 6
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnBaja
        '
        Me.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBaja.BackColor = System.Drawing.Color.Black
        Me.btnBaja.FlatAppearance.BorderSize = 0
        Me.btnBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnBaja.Image = Global.sigesi.My.Resources.Resources.eliminar_usuario
        Me.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaja.Location = New System.Drawing.Point(524, 329)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(199, 57)
        Me.btnBaja.TabIndex = 60
        Me.btnBaja.Text = " Baja"
        Me.btnBaja.UseVisualStyleBackColor = False
        '
        'listaIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 448)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.gpbBuscarIncidencia)
        Me.Controls.Add(Me.lblListaIncidencia)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.dgvListarAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "listaIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listarAlumno"
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarIncidencia.ResumeLayout(False)
        Me.gpbBuscarIncidencia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListarAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents lblListaIncidencia As System.Windows.Forms.Label
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents gpbBuscarIncidencia As System.Windows.Forms.GroupBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblMateria As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlumno As System.Windows.Forms.Label
End Class
