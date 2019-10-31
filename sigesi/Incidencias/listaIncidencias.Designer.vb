<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaIncidencias
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
        Me.dgvListarIncidencias = New System.Windows.Forms.DataGridView()
        Me.lblListaIncidencia = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgvListarIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListarIncidencias
        '
        Me.dgvListarIncidencias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvListarIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarIncidencias.Location = New System.Drawing.Point(12, 135)
        Me.dgvListarIncidencias.Name = "dgvListarIncidencias"
        Me.dgvListarIncidencias.ReadOnly = True
        Me.dgvListarIncidencias.Size = New System.Drawing.Size(517, 376)
        Me.dgvListarIncidencias.TabIndex = 4
        '
        'lblListaIncidencia
        '
        Me.lblListaIncidencia.AutoSize = True
        Me.lblListaIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaIncidencia.ForeColor = System.Drawing.Color.White
        Me.lblListaIncidencia.Location = New System.Drawing.Point(28, 107)
        Me.lblListaIncidencia.Name = "lblListaIncidencia"
        Me.lblListaIncidencia.Size = New System.Drawing.Size(191, 25)
        Me.lblListaIncidencia.TabIndex = 3
        Me.lblListaIncidencia.Text = "Lista de Incidencia"
        '
        'btnAlta
        '
        Me.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAlta.BackColor = System.Drawing.Color.Black
        Me.btnAlta.FlatAppearance.BorderSize = 0
        Me.btnAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlta.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnAlta.Image = Global.sigesi.My.Resources.Resources.icono_agregar_ususario_50
        Me.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlta.Location = New System.Drawing.Point(535, 134)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(199, 69)
        Me.btnAlta.TabIndex = 6
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnBaja
        '
        Me.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBaja.BackColor = System.Drawing.Color.Black
        Me.btnBaja.FlatAppearance.BorderSize = 0
        Me.btnBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnBaja.Image = Global.sigesi.My.Resources.Resources.eliminar_usuario
        Me.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaja.Location = New System.Drawing.Point(535, 209)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(199, 57)
        Me.btnBaja.TabIndex = 60
        Me.btnBaja.Text = " Baja"
        Me.btnBaja.UseVisualStyleBackColor = False
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCi.ForeColor = System.Drawing.Color.White
        Me.lblCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCi.Location = New System.Drawing.Point(30, 70)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(34, 18)
        Me.lblCi.TabIndex = 63
        Me.lblCi.Text = "C.I."
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(70, 70)
        Me.txtCi.MaxLength = 8
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(191, 20)
        Me.txtCi.TabIndex = 62
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
        Me.btnBuscar.Location = New System.Drawing.Point(280, 54)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(195, 49)
        Me.btnBuscar.TabIndex = 61
        Me.btnBuscar.Text = "  Buscar "
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'listaIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 523)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.lblListaIncidencia)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.dgvListarIncidencias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "listaIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listarAlumno"
        CType(Me.dgvListarIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListarIncidencias As System.Windows.Forms.DataGridView
    Friend WithEvents lblListaIncidencia As System.Windows.Forms.Label
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
