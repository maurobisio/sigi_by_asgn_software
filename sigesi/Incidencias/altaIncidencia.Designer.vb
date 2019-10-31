<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaIncidencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altaIncidencia))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblCiAlumno = New System.Windows.Forms.Label()
        Me.txtCiAlumno = New System.Windows.Forms.TextBox()
        Me.lblCiAutoridad = New System.Windows.Forms.Label()
        Me.txtCiAutoridad = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.DateTimeFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblTipoIncidencia = New System.Windows.Forms.Label()
        Me.cboTipoIncidencia = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblObs
        '
        resources.ApplyResources(Me.lblObs, "lblObs")
        Me.lblObs.BackColor = System.Drawing.Color.Transparent
        Me.lblObs.ForeColor = System.Drawing.Color.Black
        Me.lblObs.Name = "lblObs"
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
        'DateTimeFecha
        '
        resources.ApplyResources(Me.DateTimeFecha, "DateTimeFecha")
        Me.DateTimeFecha.Name = "DateTimeFecha"
        '
        'lblCiAlumno
        '
        resources.ApplyResources(Me.lblCiAlumno, "lblCiAlumno")
        Me.lblCiAlumno.BackColor = System.Drawing.Color.Transparent
        Me.lblCiAlumno.ForeColor = System.Drawing.Color.Black
        Me.lblCiAlumno.Name = "lblCiAlumno"
        '
        'txtCiAlumno
        '
        resources.ApplyResources(Me.txtCiAlumno, "txtCiAlumno")
        Me.txtCiAlumno.Name = "txtCiAlumno"
        '
        'lblCiAutoridad
        '
        resources.ApplyResources(Me.lblCiAutoridad, "lblCiAutoridad")
        Me.lblCiAutoridad.BackColor = System.Drawing.Color.Transparent
        Me.lblCiAutoridad.ForeColor = System.Drawing.Color.Black
        Me.lblCiAutoridad.Name = "lblCiAutoridad"
        '
        'txtCiAutoridad
        '
        resources.ApplyResources(Me.txtCiAutoridad, "txtCiAutoridad")
        Me.txtCiAutoridad.Name = "txtCiAutoridad"
        '
        'lblFecha
        '
        resources.ApplyResources(Me.lblFecha, "lblFecha")
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Name = "lblFecha"
        '
        'txtObservacion
        '
        resources.ApplyResources(Me.txtObservacion, "txtObservacion")
        Me.txtObservacion.Name = "txtObservacion"
        '
        'DateTimeFechaDesde
        '
        resources.ApplyResources(Me.DateTimeFechaDesde, "DateTimeFechaDesde")
        Me.DateTimeFechaDesde.Name = "DateTimeFechaDesde"
        '
        'lblTipoIncidencia
        '
        resources.ApplyResources(Me.lblTipoIncidencia, "lblTipoIncidencia")
        Me.lblTipoIncidencia.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoIncidencia.ForeColor = System.Drawing.Color.Black
        Me.lblTipoIncidencia.Name = "lblTipoIncidencia"
        '
        'cboTipoIncidencia
        '
        Me.cboTipoIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoIncidencia.FormattingEnabled = True
        Me.cboTipoIncidencia.Items.AddRange(New Object() {resources.GetString("cboTipoIncidencia.Items"), resources.GetString("cboTipoIncidencia.Items1"), resources.GetString("cboTipoIncidencia.Items2"), resources.GetString("cboTipoIncidencia.Items3"), resources.GetString("cboTipoIncidencia.Items4"), resources.GetString("cboTipoIncidencia.Items5"), resources.GetString("cboTipoIncidencia.Items6"), resources.GetString("cboTipoIncidencia.Items7")})
        resources.ApplyResources(Me.cboTipoIncidencia, "cboTipoIncidencia")
        Me.cboTipoIncidencia.Name = "cboTipoIncidencia"
        '
        'altaIncidencia
        '
        Me.AcceptButton = Me.btnAgregar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.cboTipoIncidencia)
        Me.Controls.Add(Me.lblTipoIncidencia)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtCiAutoridad)
        Me.Controls.Add(Me.lblCiAutoridad)
        Me.Controls.Add(Me.DateTimeFecha)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.lblCiAlumno)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCiAlumno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "altaIncidencia"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents DateTimeFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCiAlumno As System.Windows.Forms.Label
    Friend WithEvents txtCiAlumno As System.Windows.Forms.TextBox
    Friend WithEvents lblCiAutoridad As System.Windows.Forms.Label
    Friend WithEvents txtCiAutoridad As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents DateTimeFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTipoIncidencia As System.Windows.Forms.Label
    Friend WithEvents cboTipoIncidencia As System.Windows.Forms.ComboBox
End Class
