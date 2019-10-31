<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boletin
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
        Me.dgvLIstarCantidad = New System.Windows.Forms.DataGridView()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.DateTimeFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFechaHasta = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvLIstarCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLIstarCantidad
        '
        Me.dgvLIstarCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvLIstarCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLIstarCantidad.Location = New System.Drawing.Point(12, 183)
        Me.dgvLIstarCantidad.Name = "dgvLIstarCantidad"
        Me.dgvLIstarCantidad.ReadOnly = True
        Me.dgvLIstarCantidad.Size = New System.Drawing.Size(722, 343)
        Me.dgvLIstarCantidad.TabIndex = 2
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.AutoSize = True
        Me.lblFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblFechaDesde.ForeColor = System.Drawing.Color.White
        Me.lblFechaDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFechaDesde.Location = New System.Drawing.Point(25, 106)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(129, 24)
        Me.lblFechaDesde.TabIndex = 37
        Me.lblFechaDesde.Text = "Fecha Desde:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.sigesi.My.Resources.Resources.icono_lupa
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(401, 118)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(195, 49)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.Text = "  Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCi.ForeColor = System.Drawing.Color.White
        Me.lblCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCi.Location = New System.Drawing.Point(112, 72)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(34, 18)
        Me.lblCi.TabIndex = 39
        Me.lblCi.Text = "C.I."
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(160, 72)
        Me.txtCi.MaxLength = 8
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(191, 20)
        Me.txtCi.TabIndex = 38
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblFechaHasta.ForeColor = System.Drawing.Color.White
        Me.lblFechaHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFechaHasta.Location = New System.Drawing.Point(33, 143)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(121, 24)
        Me.lblFechaHasta.TabIndex = 42
        Me.lblFechaHasta.Text = "Fecha Hasta:"
        '
        'DateTimeFechaDesde
        '
        Me.DateTimeFechaDesde.Location = New System.Drawing.Point(160, 110)
        Me.DateTimeFechaDesde.Name = "DateTimeFechaDesde"
        Me.DateTimeFechaDesde.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeFechaDesde.TabIndex = 43
        '
        'DateTimeFechaHasta
        '
        Me.DateTimeFechaHasta.Location = New System.Drawing.Point(160, 147)
        Me.DateTimeFechaHasta.Name = "DateTimeFechaHasta"
        Me.DateTimeFechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeFechaHasta.TabIndex = 44
        '
        'boletin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(746, 602)
        Me.Controls.Add(Me.DateTimeFechaHasta)
        Me.Controls.Add(Me.DateTimeFechaDesde)
        Me.Controls.Add(Me.lblFechaHasta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lblFechaDesde)
        Me.Controls.Add(Me.dgvLIstarCantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "boletin"
        Me.Text = "datagridview"
        CType(Me.dgvLIstarCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLIstarCantidad As System.Windows.Forms.DataGridView
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents DateTimeFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimeFechaHasta As System.Windows.Forms.DateTimePicker
End Class
