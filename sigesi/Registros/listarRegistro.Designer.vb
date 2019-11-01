<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarRegistro
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
        Me.lblListaInscriptos = New System.Windows.Forms.Label()
        Me.gpbBuscarInscripciones = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboMateria = New System.Windows.Forms.ComboBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvListarRegistros = New System.Windows.Forms.DataGridView()
        Me.lblListaRegistros = New System.Windows.Forms.Label()
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarInscripciones.SuspendLayout()
        CType(Me.dgvListarRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListarAlumnos
        '
        Me.dgvListarAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvListarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarAlumnos.Location = New System.Drawing.Point(27, 196)
        Me.dgvListarAlumnos.Name = "dgvListarAlumnos"
        Me.dgvListarAlumnos.ReadOnly = True
        Me.dgvListarAlumnos.Size = New System.Drawing.Size(491, 103)
        Me.dgvListarAlumnos.TabIndex = 4
        '
        'lblListaInscriptos
        '
        Me.lblListaInscriptos.AutoSize = True
        Me.lblListaInscriptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaInscriptos.ForeColor = System.Drawing.Color.White
        Me.lblListaInscriptos.Location = New System.Drawing.Point(30, 168)
        Me.lblListaInscriptos.Name = "lblListaInscriptos"
        Me.lblListaInscriptos.Size = New System.Drawing.Size(186, 25)
        Me.lblListaInscriptos.TabIndex = 3
        Me.lblListaInscriptos.Text = "Lista de Inscriptos"
        '
        'gpbBuscarInscripciones
        '
        Me.gpbBuscarInscripciones.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarInscripciones.Controls.Add(Me.cboMateria)
        Me.gpbBuscarInscripciones.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarInscripciones.Controls.Add(Me.lblGrupo)
        Me.gpbBuscarInscripciones.Controls.Add(Me.lblMateria)
        Me.gpbBuscarInscripciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarInscripciones.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarInscripciones.Location = New System.Drawing.Point(27, 33)
        Me.gpbBuscarInscripciones.Name = "gpbBuscarInscripciones"
        Me.gpbBuscarInscripciones.Size = New System.Drawing.Size(696, 123)
        Me.gpbBuscarInscripciones.TabIndex = 59
        Me.gpbBuscarInscripciones.TabStop = False
        Me.gpbBuscarInscripciones.Text = "Buscar Inscripciones"
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
        Me.btnBuscar.Location = New System.Drawing.Point(354, 68)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(160, 40)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "  Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cboMateria
        '
        Me.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateria.FormattingEnabled = True
        Me.cboMateria.Location = New System.Drawing.Point(86, 76)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Size = New System.Drawing.Size(250, 28)
        Me.cboMateria.TabIndex = 32
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(86, 42)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(250, 28)
        Me.cboGrupo.TabIndex = 25
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
        Me.lblMateria.Location = New System.Drawing.Point(4, 80)
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
        Me.btnAlta.Location = New System.Drawing.Point(524, 355)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(199, 69)
        Me.btnAlta.TabIndex = 6
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.Color.Black
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.Image = Global.sigesi.My.Resources.Resources.eliminar_usuario
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(524, 430)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(199, 57)
        Me.btnEliminar.TabIndex = 60
        Me.btnEliminar.Text = " Baja"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.sigesi.My.Resources.Resources.icono_lupa
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(524, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 40)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "  Buscar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvListarRegistros
        '
        Me.dgvListarRegistros.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvListarRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarRegistros.Location = New System.Drawing.Point(27, 358)
        Me.dgvListarRegistros.Name = "dgvListarRegistros"
        Me.dgvListarRegistros.ReadOnly = True
        Me.dgvListarRegistros.Size = New System.Drawing.Size(491, 210)
        Me.dgvListarRegistros.TabIndex = 61
        '
        'lblListaRegistros
        '
        Me.lblListaRegistros.AutoSize = True
        Me.lblListaRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaRegistros.ForeColor = System.Drawing.Color.White
        Me.lblListaRegistros.Location = New System.Drawing.Point(31, 330)
        Me.lblListaRegistros.Name = "lblListaRegistros"
        Me.lblListaRegistros.Size = New System.Drawing.Size(185, 25)
        Me.lblListaRegistros.TabIndex = 62
        Me.lblListaRegistros.Text = "Lista de Registros"
        '
        'listarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 580)
        Me.Controls.Add(Me.lblListaRegistros)
        Me.Controls.Add(Me.dgvListarRegistros)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.gpbBuscarInscripciones)
        Me.Controls.Add(Me.lblListaInscriptos)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.dgvListarAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "listarRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listarAlumno"
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarInscripciones.ResumeLayout(False)
        Me.gpbBuscarInscripciones.PerformLayout()
        CType(Me.dgvListarRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListarAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents lblListaInscriptos As System.Windows.Forms.Label
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents gpbBuscarInscripciones As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblMateria As System.Windows.Forms.Label
    Friend WithEvents cboMateria As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvListarRegistros As System.Windows.Forms.DataGridView
    Friend WithEvents lblListaRegistros As System.Windows.Forms.Label
End Class
