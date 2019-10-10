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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgvModificarGru = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ComboEdi = New System.Windows.Forms.ComboBox()
        Me.txtturn = New System.Windows.Forms.TextBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.txtNom1 = New System.Windows.Forms.TextBox()
        Me.lblEdificio = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        CType(Me.dgvModificarGru, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(223, 31)
        Me.lblTitulo.TabIndex = 42
        Me.lblTitulo.Text = "Modificar  grupo"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnModificar.Location = New System.Drawing.Point(225, 307)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(199, 32)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'dgvModificarGru
        '
        Me.dgvModificarGru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModificarGru.Location = New System.Drawing.Point(29, 88)
        Me.dgvModificarGru.Name = "dgvModificarGru"
        Me.dgvModificarGru.Size = New System.Drawing.Size(446, 101)
        Me.dgvModificarGru.TabIndex = 44
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
        Me.btnCancelar.Location = New System.Drawing.Point(26, 307)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(193, 32)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'ComboEdi
        '
        Me.ComboEdi.FormattingEnabled = True
        Me.ComboEdi.Location = New System.Drawing.Point(118, 279)
        Me.ComboEdi.Name = "ComboEdi"
        Me.ComboEdi.Size = New System.Drawing.Size(191, 21)
        Me.ComboEdi.TabIndex = 53
        '
        'txtturn
        '
        Me.txtturn.Location = New System.Drawing.Point(118, 251)
        Me.txtturn.MaxLength = 50
        Me.txtturn.Name = "txtturn"
        Me.txtturn.Size = New System.Drawing.Size(191, 20)
        Me.txtturn.TabIndex = 48
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.BackColor = System.Drawing.Color.Transparent
        Me.lblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTurno.ForeColor = System.Drawing.Color.Black
        Me.lblTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTurno.Location = New System.Drawing.Point(36, 250)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(52, 18)
        Me.lblTurno.TabIndex = 52
        Me.lblTurno.Text = "Turno"
        '
        'txtNom1
        '
        Me.txtNom1.Location = New System.Drawing.Point(118, 222)
        Me.txtNom1.MaxLength = 50
        Me.txtNom1.Name = "txtNom1"
        Me.txtNom1.Size = New System.Drawing.Size(191, 20)
        Me.txtNom1.TabIndex = 47
        '
        'lblEdificio
        '
        Me.lblEdificio.AutoSize = True
        Me.lblEdificio.BackColor = System.Drawing.Color.Transparent
        Me.lblEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEdificio.ForeColor = System.Drawing.Color.Black
        Me.lblEdificio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEdificio.Location = New System.Drawing.Point(37, 277)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(64, 18)
        Me.lblEdificio.TabIndex = 51
        Me.lblEdificio.Text = "Edificio"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNom.ForeColor = System.Drawing.Color.Black
        Me.lblNom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNom.Location = New System.Drawing.Point(36, 223)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(68, 18)
        Me.lblNom.TabIndex = 50
        Me.lblNom.Text = "Nombre"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCod.ForeColor = System.Drawing.Color.Black
        Me.lblCod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCod.Location = New System.Drawing.Point(37, 198)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(62, 18)
        Me.lblCod.TabIndex = 49
        Me.lblCod.Text = "Código"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(118, 196)
        Me.txtCod.MaxLength = 8
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(191, 20)
        Me.txtCod.TabIndex = 46
        '
        'modificarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(487, 357)
        Me.Controls.Add(Me.ComboEdi)
        Me.Controls.Add(Me.txtturn)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.txtNom1)
        Me.Controls.Add(Me.lblEdificio)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.dgvModificarGru)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modificarGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ve"
        Me.TopMost = True
        CType(Me.dgvModificarGru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgvModificarGru As System.Windows.Forms.DataGridView
    Friend WithEvents lblAyuda As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ComboEdi As System.Windows.Forms.ComboBox
    Friend WithEvents txtturn As System.Windows.Forms.TextBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents txtNom1 As System.Windows.Forms.TextBox
    Friend WithEvents lblEdificio As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
End Class
