<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaInscripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altaInscripcion))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gpbBuscarInscripciones = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.cboMateria = New System.Windows.Forms.ComboBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.lblListaAlumnos = New System.Windows.Forms.Label()
        Me.dgvListarAlumnos = New System.Windows.Forms.DataGridView()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.gpbBuscarInscripciones.SuspendLayout()
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
        'gpbBuscarInscripciones
        '
        Me.gpbBuscarInscripciones.Controls.Add(Me.Label1)
        Me.gpbBuscarInscripciones.Controls.Add(Me.cboRol)
        Me.gpbBuscarInscripciones.Controls.Add(Me.cboMateria)
        Me.gpbBuscarInscripciones.Controls.Add(Me.cboGrupo)
        Me.gpbBuscarInscripciones.Controls.Add(Me.lblGrupo)
        Me.gpbBuscarInscripciones.Controls.Add(Me.lblMateria)
        resources.ApplyResources(Me.gpbBuscarInscripciones, "gpbBuscarInscripciones")
        Me.gpbBuscarInscripciones.ForeColor = System.Drawing.Color.White
        Me.gpbBuscarInscripciones.Name = "gpbBuscarInscripciones"
        Me.gpbBuscarInscripciones.TabStop = False
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
        Me.cboMateria.Items.AddRange(New Object() {resources.GetString("cboMateria.Items"), resources.GetString("cboMateria.Items1"), resources.GetString("cboMateria.Items2")})
        resources.ApplyResources(Me.cboMateria, "cboMateria")
        Me.cboMateria.Name = "cboMateria"
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {resources.GetString("cboGrupo.Items"), resources.GetString("cboGrupo.Items1"), resources.GetString("cboGrupo.Items2"), resources.GetString("cboGrupo.Items3"), resources.GetString("cboGrupo.Items4"), resources.GetString("cboGrupo.Items5"), resources.GetString("cboGrupo.Items6"), resources.GetString("cboGrupo.Items7")})
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
        'txtLista
        '
        resources.ApplyResources(Me.txtLista, "txtLista")
        Me.txtLista.Name = "txtLista"
        '
        'lblLista
        '
        resources.ApplyResources(Me.lblLista, "lblLista")
        Me.lblLista.BackColor = System.Drawing.Color.Transparent
        Me.lblLista.ForeColor = System.Drawing.Color.Black
        Me.lblLista.Name = "lblLista"
        '
        'altaInscripcion
        '
        Me.AcceptButton = Me.btnAgregar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.gpbBuscarInscripciones)
        Me.Controls.Add(Me.lblListaAlumnos)
        Me.Controls.Add(Me.dgvListarAlumnos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "altaInscripcion"
        Me.TopMost = True
        Me.gpbBuscarInscripciones.ResumeLayout(False)
        Me.gpbBuscarInscripciones.PerformLayout()
        CType(Me.dgvListarAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents gpbBuscarInscripciones As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblMateria As System.Windows.Forms.Label
    Friend WithEvents lblListaAlumnos As System.Windows.Forms.Label
    Friend WithEvents dgvListarAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents cboMateria As System.Windows.Forms.ComboBox
    Friend WithEvents txtLista As System.Windows.Forms.TextBox
    Friend WithEvents lblLista As System.Windows.Forms.Label
    Friend WithEvents cboRol As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
