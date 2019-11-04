<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altaUsuario))
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblNom1 = New System.Windows.Forms.Label()
        Me.txtNom1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPwd
        '
        resources.ApplyResources(Me.lblPwd, "lblPwd")
        Me.lblPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblPwd.ForeColor = System.Drawing.Color.Black
        Me.lblPwd.Name = "lblPwd"
        '
        'txtCi
        '
        resources.ApplyResources(Me.txtCi, "txtCi")
        Me.txtCi.Name = "txtCi"
        '
        'txtApe
        '
        resources.ApplyResources(Me.txtApe, "txtApe")
        Me.txtApe.Name = "txtApe"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblRoll
        '
        resources.ApplyResources(Me.lblRoll, "lblRoll")
        Me.lblRoll.BackColor = System.Drawing.Color.Transparent
        Me.lblRoll.ForeColor = System.Drawing.Color.Black
        Me.lblRoll.Name = "lblRoll"
        '
        'cboRol
        '
        Me.cboRol.FormattingEnabled = True
        Me.cboRol.Items.AddRange(New Object() {resources.GetString("cboRol.Items"), resources.GetString("cboRol.Items1"), resources.GetString("cboRol.Items2"), resources.GetString("cboRol.Items3"), resources.GetString("cboRol.Items4"), resources.GetString("cboRol.Items5")})
        resources.ApplyResources(Me.cboRol, "cboRol")
        Me.cboRol.Name = "cboRol"
        '
        'lblTel
        '
        resources.ApplyResources(Me.lblTel, "lblTel")
        Me.lblTel.BackColor = System.Drawing.Color.Transparent
        Me.lblTel.ForeColor = System.Drawing.Color.Black
        Me.lblTel.Name = "lblTel"
        '
        'lblCi
        '
        resources.ApplyResources(Me.lblCi, "lblCi")
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.ForeColor = System.Drawing.Color.Black
        Me.lblCi.Name = "lblCi"
        '
        'lblNom
        '
        resources.ApplyResources(Me.lblNom, "lblNom")
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.ForeColor = System.Drawing.Color.Black
        Me.lblNom.Name = "lblNom"
        '
        'lblApe
        '
        resources.ApplyResources(Me.lblApe, "lblApe")
        Me.lblApe.BackColor = System.Drawing.Color.Transparent
        Me.lblApe.ForeColor = System.Drawing.Color.Black
        Me.lblApe.Name = "lblApe"
        '
        'txtPwd
        '
        resources.ApplyResources(Me.txtPwd, "txtPwd")
        Me.txtPwd.Name = "txtPwd"
        '
        'txtNom
        '
        resources.ApplyResources(Me.txtNom, "txtNom")
        Me.txtNom.Name = "txtNom"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.Name = "txtEmail"
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Name = "lblEmail"
        '
        'txtDir
        '
        resources.ApplyResources(Me.txtDir, "txtDir")
        Me.txtDir.Name = "txtDir"
        '
        'lblDir
        '
        resources.ApplyResources(Me.lblDir, "lblDir")
        Me.lblDir.BackColor = System.Drawing.Color.Transparent
        Me.lblDir.ForeColor = System.Drawing.Color.Black
        Me.lblDir.Name = "lblDir"
        '
        'txtTel
        '
        resources.ApplyResources(Me.txtTel, "txtTel")
        Me.txtTel.Name = "txtTel"
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
        'lblNom1
        '
        resources.ApplyResources(Me.lblNom1, "lblNom1")
        Me.lblNom1.BackColor = System.Drawing.Color.Transparent
        Me.lblNom1.ForeColor = System.Drawing.Color.Black
        Me.lblNom1.Name = "lblNom1"
        '
        'txtNom1
        '
        resources.ApplyResources(Me.txtNom1, "txtNom1")
        Me.txtNom1.Name = "txtNom1"
        '
        'altaUsuario
        '
        Me.AcceptButton = Me.btnAgregar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.txtNom1)
        Me.Controls.Add(Me.lblNom1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.lblApe)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.cboRol)
        Me.Controls.Add(Me.lblRoll)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lblPwd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "altaUsuario"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblRoll As System.Windows.Forms.Label
    Friend WithEvents cboRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblNom1 As System.Windows.Forms.Label
    Friend WithEvents txtNom1 As System.Windows.Forms.TextBox
End Class
