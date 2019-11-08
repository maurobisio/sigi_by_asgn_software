<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarIncidencia
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
        Me.dgvListarIncidencias = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cboTipoIncidencia = New System.Windows.Forms.ComboBox()
        Me.lblTipoIncidencia = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.RichTextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgvListarIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvListarIncidencias
        '
        Me.dgvListarIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarIncidencias.Location = New System.Drawing.Point(29, 142)
        Me.dgvListarIncidencias.Name = "dgvListarIncidencias"
        Me.dgvListarIncidencias.Size = New System.Drawing.Size(446, 140)
        Me.dgvListarIncidencias.TabIndex = 44
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
        Me.lblAyuda.Location = New System.Drawing.Point(26, 125)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(307, 13)
        Me.lblAyuda.TabIndex = 45
        Me.lblAyuda.Text = "Para modificar, seleccione una incidencia de la lista."
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
        'cboTipoIncidencia
        '
        Me.cboTipoIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoIncidencia.FormattingEnabled = True
        Me.cboTipoIncidencia.Items.AddRange(New Object() {"E.M.T.", "Administración", "Electrónica", "Mecánica", "Ciclo básico", "Bachillerato Humanistico", "Bachillerato  Biológico", "Bachillerato Medicina"})
        Me.cboTipoIncidencia.Location = New System.Drawing.Point(156, 288)
        Me.cboTipoIncidencia.Name = "cboTipoIncidencia"
        Me.cboTipoIncidencia.Size = New System.Drawing.Size(209, 21)
        Me.cboTipoIncidencia.TabIndex = 56
        '
        'lblTipoIncidencia
        '
        Me.lblTipoIncidencia.AutoSize = True
        Me.lblTipoIncidencia.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTipoIncidencia.ForeColor = System.Drawing.Color.Black
        Me.lblTipoIncidencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoIncidencia.Location = New System.Drawing.Point(6, 287)
        Me.lblTipoIncidencia.Name = "lblTipoIncidencia"
        Me.lblTipoIncidencia.Size = New System.Drawing.Size(144, 18)
        Me.lblTipoIncidencia.TabIndex = 55
        Me.lblTipoIncidencia.Text = "Tipo de Incidencia"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(116, 341)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(327, 218)
        Me.txtObservacion.TabIndex = 54
        Me.txtObservacion.Text = ""
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFecha.Location = New System.Drawing.Point(45, 315)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 18)
        Me.lblFecha.TabIndex = 53
        Me.lblFecha.Text = "Fecha"
        '
        'DateTimeFecha
        '
        Me.DateTimeFecha.Location = New System.Drawing.Point(158, 315)
        Me.DateTimeFecha.Name = "DateTimeFecha"
        Me.DateTimeFecha.Size = New System.Drawing.Size(172, 20)
        Me.DateTimeFecha.TabIndex = 52
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.BackColor = System.Drawing.Color.Transparent
        Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblObs.ForeColor = System.Drawing.Color.Black
        Me.lblObs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObs.Location = New System.Drawing.Point(6, 341)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(103, 18)
        Me.lblObs.TabIndex = 51
        Me.lblObs.Text = "Observación"
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCi.ForeColor = System.Drawing.Color.White
        Me.lblCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCi.Location = New System.Drawing.Point(30, 79)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(34, 18)
        Me.lblCi.TabIndex = 66
        Me.lblCi.Text = "C.I."
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(70, 79)
        Me.txtCi.MaxLength = 8
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(191, 20)
        Me.txtCi.TabIndex = 65
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.sigesi.My.Resources.Resources.icono_lupa
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(280, 63)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(195, 49)
        Me.btnBuscar.TabIndex = 64
        Me.btnBuscar.Text = "  Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'modificarIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(487, 606)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cboTipoIncidencia)
        Me.Controls.Add(Me.lblTipoIncidencia)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.DateTimeFecha)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.dgvListarIncidencias)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modificarIncidencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ve"
        Me.TopMost = True
        CType(Me.dgvListarIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgvListarIncidencias As System.Windows.Forms.DataGridView
    Friend WithEvents lblAyuda As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cboTipoIncidencia As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoIncidencia As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents DateTimeFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
