<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarUsuario
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.cboRoll = New System.Windows.Forms.ComboBox()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.dgvModificarUsu = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblNom1 = New System.Windows.Forms.Label()
        Me.txtNom1 = New System.Windows.Forms.TextBox()
        CType(Me.dgvModificarUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitulo.Location = New System.Drawing.Point(110, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(245, 31)
        Me.lblTitulo.TabIndex = 42
        Me.lblTitulo.Text = "Modificar  usuario"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(223, 387)
        Me.txtTel.MaxLength = 9
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(127, 20)
        Me.txtTel.TabIndex = 5
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.BackColor = System.Drawing.Color.Transparent
        Me.lblDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDir.ForeColor = System.Drawing.Color.Black
        Me.lblDir.Location = New System.Drawing.Point(108, 425)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(89, 18)
        Me.lblDir.TabIndex = 40
        Me.lblDir.Text = "Direccción"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(223, 422)
        Me.txtDir.MaxLength = 50
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(127, 20)
        Me.txtDir.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(108, 355)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(50, 18)
        Me.lblEmail.TabIndex = 38
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(223, 352)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(127, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(223, 243)
        Me.txtNom.MaxLength = 20
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(127, 20)
        Me.txtNom.TabIndex = 1
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(223, 489)
        Me.txtPwd.MaxLength = 20
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(127, 20)
        Me.txtPwd.TabIndex = 8
        '
        'lblApe
        '
        Me.lblApe.AutoSize = True
        Me.lblApe.BackColor = System.Drawing.Color.Transparent
        Me.lblApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApe.ForeColor = System.Drawing.Color.Black
        Me.lblApe.Location = New System.Drawing.Point(108, 319)
        Me.lblApe.Name = "lblApe"
        Me.lblApe.Size = New System.Drawing.Size(67, 18)
        Me.lblApe.TabIndex = 33
        Me.lblApe.Text = "Apellido"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.Black
        Me.lblNom.Location = New System.Drawing.Point(94, 245)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(123, 18)
        Me.lblNom.TabIndex = 32
        Me.lblNom.Text = "Primer Nombre"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.BackColor = System.Drawing.Color.Transparent
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.Black
        Me.lblTel.Location = New System.Drawing.Point(108, 390)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(74, 18)
        Me.lblTel.TabIndex = 30
        Me.lblTel.Text = "Teléfono"
        '
        'cboRoll
        '
        Me.cboRoll.FormattingEnabled = True
        Me.cboRoll.Items.AddRange(New Object() {"Administrador de sistema", "Director/a", "Bedel", "Administrativo/a", "Docente", "Alumno/a"})
        Me.cboRoll.Location = New System.Drawing.Point(221, 456)
        Me.cboRoll.Name = "cboRoll"
        Me.cboRoll.Size = New System.Drawing.Size(129, 21)
        Me.cboRoll.TabIndex = 7
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.BackColor = System.Drawing.Color.Transparent
        Me.lblRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll.ForeColor = System.Drawing.Color.Black
        Me.lblRoll.Location = New System.Drawing.Point(109, 460)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(38, 18)
        Me.lblRoll.TabIndex = 28
        Me.lblRoll.Text = "Roll"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnModificar.Location = New System.Drawing.Point(276, 562)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(199, 32)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(223, 316)
        Me.txtApe.MaxLength = 20
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(127, 20)
        Me.txtApe.TabIndex = 3
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.BackColor = System.Drawing.Color.Transparent
        Me.lblPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwd.ForeColor = System.Drawing.Color.Black
        Me.lblPwd.Location = New System.Drawing.Point(109, 492)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(95, 18)
        Me.lblPwd.TabIndex = 24
        Me.lblPwd.Text = "Contraseña"
        '
        'dgvModificarUsu
        '
        Me.dgvModificarUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModificarUsu.Location = New System.Drawing.Point(29, 88)
        Me.dgvModificarUsu.Name = "dgvModificarUsu"
        Me.dgvModificarUsu.Size = New System.Drawing.Size(446, 101)
        Me.dgvModificarUsu.TabIndex = 44
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(445, 7)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 43
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.BackColor = System.Drawing.Color.Transparent
        Me.lblAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.Black
        Me.lblAyuda.Location = New System.Drawing.Point(26, 71)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(283, 13)
        Me.lblAyuda.TabIndex = 45
        Me.lblAyuda.Text = "Para modificar, seleccione un usuario de la lista."
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCancelar.Location = New System.Drawing.Point(12, 562)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(193, 32)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblNom1
        '
        Me.lblNom1.AutoSize = True
        Me.lblNom1.BackColor = System.Drawing.Color.Transparent
        Me.lblNom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom1.ForeColor = System.Drawing.Color.Black
        Me.lblNom1.Location = New System.Drawing.Point(78, 284)
        Me.lblNom1.Name = "lblNom1"
        Me.lblNom1.Size = New System.Drawing.Size(139, 18)
        Me.lblNom1.TabIndex = 47
        Me.lblNom1.Text = "Segundo Nombre"
        '
        'txtNom1
        '
        Me.txtNom1.Location = New System.Drawing.Point(221, 284)
        Me.txtNom1.MaxLength = 20
        Me.txtNom1.Name = "txtNom1"
        Me.txtNom1.Size = New System.Drawing.Size(127, 20)
        Me.txtNom1.TabIndex = 2
        '
        'modificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(487, 606)
        Me.Controls.Add(Me.txtNom1)
        Me.Controls.Add(Me.lblNom1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.dgvModificarUsu)
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
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.cboRoll)
        Me.Controls.Add(Me.lblRoll)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.lblPwd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ve"
        Me.TopMost = True
        CType(Me.dgvModificarUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents cboRoll As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoll As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents dgvModificarUsu As System.Windows.Forms.DataGridView
    Friend WithEvents lblAyuda As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblNom1 As System.Windows.Forms.Label
    Friend WithEvents txtNom1 As System.Windows.Forms.TextBox
End Class
