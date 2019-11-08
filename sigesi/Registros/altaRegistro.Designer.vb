<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altaRegistro))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gpbBuscarAlumno = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.cboMateria = New System.Windows.Forms.ComboBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.lblListaAlumnos = New System.Windows.Forms.Label()
        Me.dgvListarAlumnos = New System.Windows.Forms.DataGridView()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lbValor = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.cboTipoRegistro = New System.Windows.Forms.ComboBox()
        Me.lblTipoRegistro = New System.Windows.Forms.Label()
        Me.gpbBuscarAlumno.SuspendLayout()
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Name = "lblTitulo"
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'gpbBuscarAlumno
        '
        Me.gpbBuscarAlumno.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarAlumno.Controls.Add(Me.Label1)
        Me.gpbBuscarAlumno.Controls.Add(Me.cboRol)
        Me.gpbBuscarAlumno.Controls.Add(Me.cboMateria)
        Me.gpbBuscarAlumno.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarAlumno.Controls.Add(Me.lblGrupo)
        Me.gpbBuscarAlumno.Controls.Add(Me.lblMateria)
        resources.ApplyResources(Me.gpbBuscarAlumno, "gpbBuscarAlumno")
        Me.gpbBuscarAlumno.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarAlumno.Name = "gpbBuscarAlumno"
        Me.gpbBuscarAlumno.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Black
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.sigesi.My.Resources.Resources.icono_lupa
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'cboRol
        '
        Me.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRol.FormattingEnabled = True
        resources.ApplyResources(Me.cboRol, "cboRol")
        Me.cboRol.Name = "cboRol"
        '
        'cboMateria
        '
        Me.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateria.FormattingEnabled = True
        resources.ApplyResources(Me.cboMateria, "cboMateria")
        Me.cboMateria.Name = "cboMateria"
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.FormattingEnabled = True
        resources.ApplyResources(Me.cboGrupo, "cboGrupo")
        Me.cboGrupo.Name = "cboGrupo"
        '
        'lblGrupo
        '
        resources.ApplyResources(Me.lblGrupo, "lblGrupo")
        Me.lblGrupo.ForeColor = System.Drawing.Color.White
        Me.lblGrupo.Name = "lblGrupo"
        '
        'lblMateria
        '
        resources.ApplyResources(Me.lblMateria, "lblMateria")
        Me.lblMateria.ForeColor = System.Drawing.Color.White
        Me.lblMateria.Name = "lblMateria"
        '
        'lblListaAlumnos
        '
        resources.ApplyResources(Me.lblListaAlumnos, "lblListaAlumnos")
        Me.lblListaAlumnos.ForeColor = System.Drawing.Color.White
        Me.lblListaAlumnos.Name = "lblListaAlumnos"
        '
        'dgvListarAlumnos
        '
        resources.ApplyResources(Me.dgvListarAlumnos, "dgvListarAlumnos")
        Me.dgvListarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarAlumnos.Name = "dgvListarAlumnos"
        Me.dgvListarAlumnos.ReadOnly = True
        '
        'txtValor
        '
        resources.ApplyResources(Me.txtValor, "txtValor")
        Me.txtValor.Name = "txtValor"
        '
        'lbValor
        '
        resources.ApplyResources(Me.lbValor, "lbValor")
        Me.lbValor.BackColor = System.Drawing.Color.Transparent
        Me.lbValor.ForeColor = System.Drawing.Color.Black
        Me.lbValor.Name = "lbValor"
        '
        'lblFecha
        '
        resources.ApplyResources(Me.lblFecha, "lblFecha")
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Name = "lblFecha"
        '
        'DateTimeFecha
        '
        resources.ApplyResources(Me.DateTimeFecha, "DateTimeFecha")
        Me.DateTimeFecha.Name = "DateTimeFecha"
        '
        'txtObservacion
        '
        resources.ApplyResources(Me.txtObservacion, "txtObservacion")
        Me.txtObservacion.Name = "txtObservacion"
        '
        'lblObs
        '
        resources.ApplyResources(Me.lblObs, "lblObs")
        Me.lblObs.BackColor = System.Drawing.Color.Transparent
        Me.lblObs.ForeColor = System.Drawing.Color.Black
        Me.lblObs.Name = "lblObs"
        '
        'cboTipoRegistro
        '
        Me.cboTipoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRegistro.FormattingEnabled = True
        Me.cboTipoRegistro.Items.AddRange(New Object() {resources.GetString("cboTipoRegistro.Items"), resources.GetString("cboTipoRegistro.Items1"), resources.GetString("cboTipoRegistro.Items2"), resources.GetString("cboTipoRegistro.Items3"), resources.GetString("cboTipoRegistro.Items4"), resources.GetString("cboTipoRegistro.Items5"), resources.GetString("cboTipoRegistro.Items6"), resources.GetString("cboTipoRegistro.Items7")})
        resources.ApplyResources(Me.cboTipoRegistro, "cboTipoRegistro")
        Me.cboTipoRegistro.Name = "cboTipoRegistro"
        '
        'lblTipoRegistro
        '
        resources.ApplyResources(Me.lblTipoRegistro, "lblTipoRegistro")
        Me.lblTipoRegistro.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoRegistro.ForeColor = System.Drawing.Color.Black
        Me.lblTipoRegistro.Name = "lblTipoRegistro"
        '
        'altaRegistro
        '
        Me.AcceptButton = Me.btnAgregar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.cboTipoRegistro)
        Me.Controls.Add(Me.lblTipoRegistro)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.DateTimeFecha)
        Me.Controls.Add(Me.lbValor)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.gpbBuscarAlumno)
        Me.Controls.Add(Me.lblListaAlumnos)
        Me.Controls.Add(Me.dgvListarAlumnos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "altaRegistro"
        Me.TopMost = True
        Me.gpbBuscarAlumno.ResumeLayout(False)
        Me.gpbBuscarAlumno.PerformLayout()
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents gpbBuscarAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblMateria As System.Windows.Forms.Label
    Friend WithEvents lblListaAlumnos As System.Windows.Forms.Label
    Friend WithEvents dgvListarAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents cboMateria As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lbValor As System.Windows.Forms.Label
    Friend WithEvents cboRol As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents DateTimeFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents cboTipoRegistro As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoRegistro As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
