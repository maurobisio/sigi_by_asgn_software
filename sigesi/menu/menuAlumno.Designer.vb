<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAlumno
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHOra = New System.Windows.Forms.Label()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.btnSolicitaBoletin = New System.Windows.Forms.Button()
        Me.btnSolicitarEscolaridad = New System.Windows.Forms.Button()
        Me.btnSolicitarFichaAcumulativa = New System.Windows.Forms.Button()
        Me.btnPaseEgreso = New System.Windows.Forms.Button()
        Me.btnSolicitarFormula69 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'tmrFechaHora
        '
        Me.tmrFechaHora.Enabled = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.sigesi.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(760, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 16
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(806, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnCerrarSesion)
        Me.Panel1.Controls.Add(Me.pic2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 432)
        Me.Panel1.TabIndex = 7
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = Global.sigesi.My.Resources.Resources.icono_candado_40
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 303)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(221, 48)
        Me.btnCerrarSesion.TabIndex = 35
        Me.btnCerrarSesion.Text = "         Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'pic2
        '
        Me.pic2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pic2.Image = Global.sigesi.My.Resources.Resources.logo_asgn_gr2
        Me.pic2.Location = New System.Drawing.Point(0, 390)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(212, 42)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 8
        Me.pic2.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFecha.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(406, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(147, 28)
        Me.lblFecha.TabIndex = 11
        Me.lblFecha.Text = "--/--/--"
        '
        'lblHOra
        '
        Me.lblHOra.AutoSize = True
        Me.lblHOra.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHOra.ForeColor = System.Drawing.Color.White
        Me.lblHOra.Location = New System.Drawing.Point(227, 10)
        Me.lblHOra.Name = "lblHOra"
        Me.lblHOra.Size = New System.Drawing.Size(63, 22)
        Me.lblHOra.TabIndex = 10
        Me.lblHOra.Text = "00:00"
        '
        'pic3
        '
        Me.pic3.BackColor = System.Drawing.Color.Transparent
        Me.pic3.Image = Global.sigesi.My.Resources.Resources.ultima1
        Me.pic3.Location = New System.Drawing.Point(617, 75)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(183, 181)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 16
        Me.pic3.TabStop = False
        '
        'btnSolicitaBoletin
        '
        Me.btnSolicitaBoletin.BackColor = System.Drawing.Color.White
        Me.btnSolicitaBoletin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSolicitaBoletin.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSolicitaBoletin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSolicitaBoletin.Location = New System.Drawing.Point(267, 88)
        Me.btnSolicitaBoletin.Name = "btnSolicitaBoletin"
        Me.btnSolicitaBoletin.Size = New System.Drawing.Size(151, 32)
        Me.btnSolicitaBoletin.TabIndex = 36
        Me.btnSolicitaBoletin.Text = "Solicitar Boletin"
        Me.btnSolicitaBoletin.UseVisualStyleBackColor = False
        '
        'btnSolicitarEscolaridad
        '
        Me.btnSolicitarEscolaridad.BackColor = System.Drawing.Color.White
        Me.btnSolicitarEscolaridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSolicitarEscolaridad.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSolicitarEscolaridad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSolicitarEscolaridad.Location = New System.Drawing.Point(267, 126)
        Me.btnSolicitarEscolaridad.Name = "btnSolicitarEscolaridad"
        Me.btnSolicitarEscolaridad.Size = New System.Drawing.Size(191, 32)
        Me.btnSolicitarEscolaridad.TabIndex = 37
        Me.btnSolicitarEscolaridad.Text = "Solicitar Escolaridad"
        Me.btnSolicitarEscolaridad.UseVisualStyleBackColor = False
        '
        'btnSolicitarFichaAcumulativa
        '
        Me.btnSolicitarFichaAcumulativa.BackColor = System.Drawing.Color.White
        Me.btnSolicitarFichaAcumulativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSolicitarFichaAcumulativa.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSolicitarFichaAcumulativa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSolicitarFichaAcumulativa.Location = New System.Drawing.Point(267, 164)
        Me.btnSolicitarFichaAcumulativa.Name = "btnSolicitarFichaAcumulativa"
        Me.btnSolicitarFichaAcumulativa.Size = New System.Drawing.Size(237, 32)
        Me.btnSolicitarFichaAcumulativa.TabIndex = 38
        Me.btnSolicitarFichaAcumulativa.Text = "Solicitar Ficha Acumulativa"
        Me.btnSolicitarFichaAcumulativa.UseVisualStyleBackColor = False
        '
        'btnPaseEgreso
        '
        Me.btnPaseEgreso.BackColor = System.Drawing.Color.White
        Me.btnPaseEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPaseEgreso.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPaseEgreso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPaseEgreso.Location = New System.Drawing.Point(267, 202)
        Me.btnPaseEgreso.Name = "btnPaseEgreso"
        Me.btnPaseEgreso.Size = New System.Drawing.Size(191, 32)
        Me.btnPaseEgreso.TabIndex = 39
        Me.btnPaseEgreso.Text = "Solicitar Pase Egreso"
        Me.btnPaseEgreso.UseVisualStyleBackColor = False
        '
        'btnSolicitarFormula69
        '
        Me.btnSolicitarFormula69.BackColor = System.Drawing.Color.White
        Me.btnSolicitarFormula69.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSolicitarFormula69.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSolicitarFormula69.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSolicitarFormula69.Location = New System.Drawing.Point(267, 244)
        Me.btnSolicitarFormula69.Name = "btnSolicitarFormula69"
        Me.btnSolicitarFormula69.Size = New System.Drawing.Size(191, 32)
        Me.btnSolicitarFormula69.TabIndex = 40
        Me.btnSolicitarFormula69.Text = "Solicitar Formula 69"
        Me.btnSolicitarFormula69.UseVisualStyleBackColor = False
        '
        'menuAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(863, 432)
        Me.Controls.Add(Me.btnSolicitarFormula69)
        Me.Controls.Add(Me.btnPaseEgreso)
        Me.Controls.Add(Me.btnSolicitarFichaAcumulativa)
        Me.Controls.Add(Me.btnSolicitarEscolaridad)
        Me.Controls.Add(Me.btnSolicitaBoletin)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblHOra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuAlumno"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHOra As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSolicitaBoletin As System.Windows.Forms.Button
    Friend WithEvents btnSolicitarEscolaridad As System.Windows.Forms.Button
    Friend WithEvents btnSolicitarFichaAcumulativa As System.Windows.Forms.Button
    Friend WithEvents btnPaseEgreso As System.Windows.Forms.Button
    Friend WithEvents btnSolicitarFormula69 As System.Windows.Forms.Button
End Class
