<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaAlumno
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
        Me.lblCi = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblSegNom = New System.Windows.Forms.Label()
        Me.lblApe = New System.Windows.Forms.Label()
        Me.lblSegApe = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtNom1 = New System.Windows.Forms.TextBox()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cboTurno = New System.Windows.Forms.ComboBox()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.lblGrado = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(9, 99)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(31, 20)
        Me.lblCi.TabIndex = 0
        Me.lblCi.Text = "C.I."
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(9, 135)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(119, 20)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Primer nombre"
        '
        'lblSegNom
        '
        Me.lblSegNom.AutoSize = True
        Me.lblSegNom.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegNom.Location = New System.Drawing.Point(9, 169)
        Me.lblSegNom.Name = "lblSegNom"
        Me.lblSegNom.Size = New System.Drawing.Size(138, 20)
        Me.lblSegNom.TabIndex = 2
        Me.lblSegNom.Text = "Segundo nombre"
        '
        'lblApe
        '
        Me.lblApe.AutoSize = True
        Me.lblApe.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApe.Location = New System.Drawing.Point(9, 203)
        Me.lblApe.Name = "lblApe"
        Me.lblApe.Size = New System.Drawing.Size(126, 20)
        Me.lblApe.TabIndex = 3
        Me.lblApe.Text = "Primer apellido"
        '
        'lblSegApe
        '
        Me.lblSegApe.AutoSize = True
        Me.lblSegApe.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegApe.Location = New System.Drawing.Point(9, 236)
        Me.lblSegApe.Name = "lblSegApe"
        Me.lblSegApe.Size = New System.Drawing.Size(145, 20)
        Me.lblSegApe.TabIndex = 4
        Me.lblSegApe.Text = "Segundo apellido"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(9, 269)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(146, 20)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Fecha Nacimiento"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(9, 304)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(54, 20)
        Me.lblTurno.TabIndex = 6
        Me.lblTurno.Text = "Turno"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.Location = New System.Drawing.Point(9, 336)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(54, 20)
        Me.lblCurso.TabIndex = 7
        Me.lblCurso.Text = "Curso"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(190, 99)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(263, 20)
        Me.txtCI.TabIndex = 8
        '
        'txtNom1
        '
        Me.txtNom1.Location = New System.Drawing.Point(190, 133)
        Me.txtNom1.MaxLength = 50
        Me.txtNom1.Name = "txtNom1"
        Me.txtNom1.Size = New System.Drawing.Size(263, 20)
        Me.txtNom1.TabIndex = 9
        '
        'txtNom2
        '
        Me.txtNom2.Location = New System.Drawing.Point(190, 169)
        Me.txtNom2.MaxLength = 50
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(263, 20)
        Me.txtNom2.TabIndex = 10
        '
        'txtApe2
        '
        Me.txtApe2.Location = New System.Drawing.Point(190, 236)
        Me.txtApe2.MaxLength = 50
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(263, 20)
        Me.txtApe2.TabIndex = 11
        '
        'txtApe1
        '
        Me.txtApe1.Location = New System.Drawing.Point(190, 203)
        Me.txtApe1.MaxLength = 50
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(263, 20)
        Me.txtApe1.TabIndex = 12
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(190, 267)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(263, 20)
        Me.dtpFecha.TabIndex = 14
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Black
        Me.lblTitulo.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(112, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(241, 27)
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "ALTA DE ALUMNO"
        '
        'cboTurno
        '
        Me.cboTurno.FormattingEnabled = True
        Me.cboTurno.Items.AddRange(New Object() {"Matutino", "Diurno", "Vespertino", "Nocturno"})
        Me.cboTurno.Location = New System.Drawing.Point(190, 302)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(263, 21)
        Me.cboTurno.TabIndex = 21
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboCurso.Location = New System.Drawing.Point(190, 333)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(263, 21)
        Me.cboCurso.TabIndex = 22
        '
        'cboGrado
        '
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto"})
        Me.cboGrado.Location = New System.Drawing.Point(190, 396)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(263, 21)
        Me.cboGrado.TabIndex = 24
        '
        'lblGrado
        '
        Me.lblGrado.AutoSize = True
        Me.lblGrado.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrado.Location = New System.Drawing.Point(9, 399)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(57, 20)
        Me.lblGrado.TabIndex = 23
        Me.lblGrado.Text = "Grado"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(9, 439)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(78, 20)
        Me.lblTel.TabIndex = 26
        Me.lblTel.Text = "Teléfono"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(190, 437)
        Me.txtTel.MaxLength = 9
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(263, 20)
        Me.txtTel.TabIndex = 25
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(9, 472)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(50, 20)
        Me.lblMail.TabIndex = 28
        Me.lblMail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(190, 470)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 20)
        Me.txtEmail.TabIndex = 27
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(9, 369)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(57, 20)
        Me.lblGrupo.TabIndex = 30
        Me.lblGrupo.Text = "Grupo"
        '
        'cboGrupo
        '
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Items.AddRange(New Object() {"3if", "2ij", "1id"})
        Me.cboGrupo.Location = New System.Drawing.Point(190, 366)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(263, 21)
        Me.cboGrupo.TabIndex = 31
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(409, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 36
        Me.btnSalir.UseVisualStyleBackColor = True
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
        Me.btnCancelar.Location = New System.Drawing.Point(72, 533)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(165, 48)
        Me.btnCancelar.TabIndex = 59
        Me.btnCancelar.Text = "       Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Image = Global.sigesi.My.Resources.Resources.icono2
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(291, 533)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(165, 48)
        Me.btnEnviar.TabIndex = 58
        Me.btnEnviar.Text = "       Agregar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'altaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(468, 599)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cboGrupo)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.cboGrado)
        Me.Controls.Add(Me.lblGrado)
        Me.Controls.Add(Me.cboCurso)
        Me.Controls.Add(Me.cboTurno)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtApe1)
        Me.Controls.Add(Me.txtApe2)
        Me.Controls.Add(Me.txtNom2)
        Me.Controls.Add(Me.txtNom1)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblSegApe)
        Me.Controls.Add(Me.lblApe)
        Me.Controls.Add(Me.lblSegNom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCi)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "altaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarAlumno"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblSegNom As System.Windows.Forms.Label
    Friend WithEvents lblApe As System.Windows.Forms.Label
    Friend WithEvents lblSegApe As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents txtNom1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNom2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents cboTurno As System.Windows.Forms.ComboBox
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrado As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
End Class
