<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altaGrupo))
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblEdificio = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.txtTurn = New System.Windows.Forms.TextBox()
        Me.ComboEdi = New System.Windows.Forms.ComboBox()
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
        'lblNom
        '
        resources.ApplyResources(Me.lblNom, "lblNom")
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.ForeColor = System.Drawing.Color.Black
        Me.lblNom.Name = "lblNom"
        '
        'lblEdificio
        '
        resources.ApplyResources(Me.lblEdificio, "lblEdificio")
        Me.lblEdificio.BackColor = System.Drawing.Color.Transparent
        Me.lblEdificio.ForeColor = System.Drawing.Color.Black
        Me.lblEdificio.Name = "lblEdificio"
        '
        'txtNom
        '
        resources.ApplyResources(Me.txtNom, "txtNom")
        Me.txtNom.Name = "txtNom"
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
        'lblTurno
        '
        resources.ApplyResources(Me.lblTurno, "lblTurno")
        Me.lblTurno.BackColor = System.Drawing.Color.Transparent
        Me.lblTurno.ForeColor = System.Drawing.Color.Black
        Me.lblTurno.Name = "lblTurno"
        '
        'txtTurn
        '
        resources.ApplyResources(Me.txtTurn, "txtTurn")
        Me.txtTurn.Name = "txtTurn"
        '
        'ComboEdi
        '
        Me.ComboEdi.FormattingEnabled = True
        resources.ApplyResources(Me.ComboEdi, "ComboEdi")
        Me.ComboEdi.Name = "ComboEdi"
        '
        'altaGrupo
        '
        Me.AcceptButton = Me.btnAgregar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.ComboEdi)
        Me.Controls.Add(Me.txtTurn)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblEdificio)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "altaGrupo"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblEdificio As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents txtTurn As System.Windows.Forms.TextBox
    Friend WithEvents ComboEdi As System.Windows.Forms.ComboBox
End Class
