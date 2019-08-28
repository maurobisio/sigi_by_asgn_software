<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarAlumno
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
        Me.lblListaAlumnos = New System.Windows.Forms.Label()
        Me.gpbBuscarAlumnos = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarAlumnos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListarAlumnos
        '
        Me.dgvListarAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvListarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarAlumnos.Location = New System.Drawing.Point(8, 369)
        Me.dgvListarAlumnos.Name = "dgvListarAlumnos"
        Me.dgvListarAlumnos.ReadOnly = True
        Me.dgvListarAlumnos.Size = New System.Drawing.Size(491, 166)
        Me.dgvListarAlumnos.TabIndex = 4
        '
        'lblListaAlumnos
        '
        Me.lblListaAlumnos.AutoSize = True
        Me.lblListaAlumnos.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaAlumnos.ForeColor = System.Drawing.Color.White
        Me.lblListaAlumnos.Location = New System.Drawing.Point(4, 321)
        Me.lblListaAlumnos.Name = "lblListaAlumnos"
        Me.lblListaAlumnos.Size = New System.Drawing.Size(179, 23)
        Me.lblListaAlumnos.TabIndex = 3
        Me.lblListaAlumnos.Text = "Lista de alumnos"
        '
        'gpbBuscarAlumnos
        '
        Me.gpbBuscarAlumnos.Controls.Add(Me.btnCancelar)
        Me.gpbBuscarAlumnos.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.cboCurso)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblGrupo)
        Me.gpbBuscarAlumnos.Controls.Add(Me.lblCurso)
        Me.gpbBuscarAlumnos.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarAlumnos.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarAlumnos.Location = New System.Drawing.Point(27, 56)
        Me.gpbBuscarAlumnos.Name = "gpbBuscarAlumnos"
        Me.gpbBuscarAlumnos.Size = New System.Drawing.Size(616, 172)
        Me.gpbBuscarAlumnos.TabIndex = 59
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
        Me.btnBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cboGrupo.Location = New System.Drawing.Point(429, 46)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(149, 26)
        Me.cboGrupo.TabIndex = 32
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboCurso.Location = New System.Drawing.Point(109, 42)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(149, 26)
        Me.cboCurso.TabIndex = 25
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.White
        Me.lblGrupo.Location = New System.Drawing.Point(12, 42)
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
        Me.lblCurso.Location = New System.Drawing.Point(324, 46)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(70, 22)
        Me.lblCurso.TabIndex = 1
        Me.lblCurso.Text = "Curso:"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificar.BackColor = System.Drawing.Color.Black
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnModificar.Image = Global.sigesi.My.Resources.Resources.icono_nuev
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(532, 384)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(199, 59)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "         Modificar "
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAlta.BackColor = System.Drawing.Color.Black
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnAlta.Image = Global.sigesi.My.Resources.Resources.icono_agregar_ususario_50
        Me.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlta.Location = New System.Drawing.Point(532, 466)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(199, 69)
        Me.btnAlta.TabIndex = 6
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'listarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 650)
        Me.Controls.Add(Me.gpbBuscarAlumnos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblListaAlumnos)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.dgvListarAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "listarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listarAlumno"
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarAlumnos.ResumeLayout(False)
        Me.gpbBuscarAlumnos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListarAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents lblListaAlumnos As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents gpbBuscarAlumnos As System.Windows.Forms.GroupBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
