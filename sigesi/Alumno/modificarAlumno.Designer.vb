<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarAlumno
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
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.cboTurno = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
        Me.txtNom1 = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.cboGrupo.Location = New System.Drawing.Point(186, 378)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(263, 21)
        Me.cboGrupo.TabIndex = 77
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(186, 482)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 20)
        Me.txtEmail.TabIndex = 76
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(186, 449)
        Me.txtTel.MaxLength = 9
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(263, 20)
        Me.txtTel.TabIndex = 75
        '
        'cboGrado
        '
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto"})
        Me.cboGrado.Location = New System.Drawing.Point(186, 408)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(263, 21)
        Me.cboGrado.TabIndex = 74
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboCurso.Location = New System.Drawing.Point(186, 345)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(263, 21)
        Me.cboCurso.TabIndex = 73
        '
        'cboTurno
        '
        Me.cboTurno.FormattingEnabled = True
        Me.cboTurno.Items.AddRange(New Object() {"Matutino", "Diurno", "Vespertino", "Nocturno"})
        Me.cboTurno.Location = New System.Drawing.Point(186, 314)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(263, 21)
        Me.cboTurno.TabIndex = 72
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Black
        Me.lbl1.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(77, 25)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(287, 27)
        Me.lbl1.TabIndex = 71
        Me.lbl1.Text = "MODIFICAR  ALUMNO"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(186, 279)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(263, 20)
        Me.dtpFecha.TabIndex = 70
        '
        'txtApe1
        '
        Me.txtApe1.Location = New System.Drawing.Point(186, 215)
        Me.txtApe1.MaxLength = 50
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(263, 20)
        Me.txtApe1.TabIndex = 69
        '
        'txtApe2
        '
        Me.txtApe2.Location = New System.Drawing.Point(186, 248)
        Me.txtApe2.MaxLength = 50
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(263, 20)
        Me.txtApe2.TabIndex = 68
        '
        'txtNom2
        '
        Me.txtNom2.Location = New System.Drawing.Point(186, 181)
        Me.txtNom2.MaxLength = 50
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(263, 20)
        Me.txtNom2.TabIndex = 67
        '
        'txtNom1
        '
        Me.txtNom1.Location = New System.Drawing.Point(186, 145)
        Me.txtNom1.MaxLength = 50
        Me.txtNom1.Name = "txtNom1"
        Me.txtNom1.Size = New System.Drawing.Size(263, 20)
        Me.txtNom1.TabIndex = 66
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(186, 111)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(263, 20)
        Me.txtCI.TabIndex = 65
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.White
        Me.lbl9.Location = New System.Drawing.Point(14, 379)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(60, 18)
        Me.lbl9.TabIndex = 92
        Me.lbl9.Text = "Grupo"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.White
        Me.lbl12.Location = New System.Drawing.Point(14, 482)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(49, 18)
        Me.lbl12.TabIndex = 91
        Me.lbl12.Text = "Email"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.Color.White
        Me.lbl11.Location = New System.Drawing.Point(14, 449)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(81, 18)
        Me.lbl11.TabIndex = 90
        Me.lbl11.Text = "Teléfono"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.White
        Me.lbl10.Location = New System.Drawing.Point(14, 409)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(58, 18)
        Me.lbl10.TabIndex = 89
        Me.lbl10.Text = "Grado"
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.White
        Me.lbl8.Location = New System.Drawing.Point(14, 346)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(58, 18)
        Me.lbl8.TabIndex = 88
        Me.lbl8.Text = "Curso"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.White
        Me.lbl7.Location = New System.Drawing.Point(14, 314)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(57, 18)
        Me.lbl7.TabIndex = 87
        Me.lbl7.Text = "Turno"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(14, 279)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(149, 18)
        Me.lbl6.TabIndex = 86
        Me.lbl6.Text = "Fecha Nacimiento"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(14, 246)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(145, 18)
        Me.lbl5.TabIndex = 85
        Me.lbl5.Text = "Segundo apellido"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(14, 213)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(127, 18)
        Me.lbl4.TabIndex = 84
        Me.lbl4.Text = "Primer apellido"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(14, 179)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(144, 18)
        Me.lbl3.TabIndex = 83
        Me.lbl3.Text = "Segundo nombre"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(14, 145)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(126, 18)
        Me.lbl2.TabIndex = 82
        Me.lbl2.Text = "Primer nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "C.I."
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.sigesi.My.Resources.Resources.icono_limpiar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(66, 538)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(165, 48)
        Me.btnCancelar.TabIndex = 80
        Me.btnCancelar.Text = "       Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.sigesi.My.Resources.Resources.icono2
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(260, 538)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(165, 48)
        Me.btnModificar.TabIndex = 79
        Me.btnModificar.Text = "       Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(417, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 78
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'modificarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(461, 596)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cboGrupo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.cboGrado)
        Me.Controls.Add(Me.cboCurso)
        Me.Controls.Add(Me.cboTurno)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtApe1)
        Me.Controls.Add(Me.txtApe2)
        Me.Controls.Add(Me.txtNom2)
        Me.Controls.Add(Me.txtNom1)
        Me.Controls.Add(Me.txtCI)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modificarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificarAlumno"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNom2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNom1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
