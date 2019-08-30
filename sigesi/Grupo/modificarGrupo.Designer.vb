<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarGrupo
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
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNom1 = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.cboRoll = New System.Windows.Forms.ComboBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.dgvModificarUsu = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
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
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.Black
        Me.lbl6.Location = New System.Drawing.Point(108, 425)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(89, 18)
        Me.lbl6.TabIndex = 40
        Me.lbl6.Text = "Direccción"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(223, 422)
        Me.txtDir.MaxLength = 50
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(127, 20)
        Me.txtDir.TabIndex = 6
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(108, 355)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(50, 18)
        Me.lbl4.TabIndex = 38
        Me.lbl4.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(223, 352)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(127, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtNom1
        '
        Me.txtNom1.Location = New System.Drawing.Point(223, 243)
        Me.txtNom1.MaxLength = 20
        Me.txtNom1.Name = "txtNom1"
        Me.txtNom1.Size = New System.Drawing.Size(127, 20)
        Me.txtNom1.TabIndex = 1
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(223, 489)
        Me.txtPwd.MaxLength = 20
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(127, 20)
        Me.txtPwd.TabIndex = 8
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(108, 319)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(67, 18)
        Me.lbl3.TabIndex = 33
        Me.lbl3.Text = "Apellido"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(94, 245)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(123, 18)
        Me.lbl2.TabIndex = 32
        Me.lbl2.Text = "Primer Nombre"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(108, 211)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 18)
        Me.lbl1.TabIndex = 31
        Me.lbl1.Text = "C.I."
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Black
        Me.lbl5.Location = New System.Drawing.Point(108, 390)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(74, 18)
        Me.lbl5.TabIndex = 30
        Me.lbl5.Text = "Teléfono"
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
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.BackColor = System.Drawing.Color.Transparent
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.Black
        Me.lbl7.Location = New System.Drawing.Point(109, 460)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(38, 18)
        Me.lbl7.TabIndex = 28
        Me.lbl7.Text = "Roll"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(276, 562)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(199, 32)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Modificar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(223, 316)
        Me.txtApe.MaxLength = 20
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(127, 20)
        Me.txtApe.TabIndex = 3
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(223, 208)
        Me.txtCi.MaxLength = 8
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(127, 20)
        Me.txtCi.TabIndex = 0
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.BackColor = System.Drawing.Color.Transparent
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.Black
        Me.lbl9.Location = New System.Drawing.Point(109, 492)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(95, 18)
        Me.lbl9.TabIndex = 24
        Me.lbl9.Text = "Contraseña"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(78, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Segundo Nombre"
        '
        'txtNom2
        '
        Me.txtNom2.Location = New System.Drawing.Point(221, 284)
        Me.txtNom2.MaxLength = 20
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(127, 20)
        Me.txtNom2.TabIndex = 2
        '
        'modificarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(487, 606)
        Me.Controls.Add(Me.txtNom2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.dgvModificarUsu)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNom1)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.cboRoll)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lbl9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modificarGrupo"
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
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNom1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents cboRoll As System.Windows.Forms.ComboBox
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents dgvModificarUsu As System.Windows.Forms.DataGridView
    Friend WithEvents lblAyuda As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom2 As System.Windows.Forms.TextBox
End Class
