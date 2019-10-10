<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarEdificio
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
        Me.dgvLIstarEdificio = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        CType(Me.dgvLIstarEdificio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLIstarEdificio
        '
        Me.dgvLIstarEdificio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvLIstarEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLIstarEdificio.Location = New System.Drawing.Point(60, 21)
        Me.dgvLIstarEdificio.Name = "dgvLIstarEdificio"
        Me.dgvLIstarEdificio.ReadOnly = True
        Me.dgvLIstarEdificio.Size = New System.Drawing.Size(434, 328)
        Me.dgvLIstarEdificio.TabIndex = 2
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificar.BackColor = System.Drawing.Color.Black
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnModificar.Image = Global.sigesi.My.Resources.Resources.icono_nuev
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(519, 159)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(199, 59)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "         Modificar "
        Me.btnModificar.UseVisualStyleBackColor = False
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
        Me.btnAlta.Location = New System.Drawing.Point(519, 64)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(199, 69)
        Me.btnAlta.TabIndex = 2
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
        Me.btnBaja.Location = New System.Drawing.Point(519, 242)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(199, 57)
        Me.btnBaja.TabIndex = 1
        Me.btnBaja.Text = " Baja"
        Me.btnBaja.UseVisualStyleBackColor = False
        '
        'listarEdificio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(746, 372)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.dgvLIstarEdificio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "listarEdificio"
        Me.Text = "datagridview"
        CType(Me.dgvLIstarEdificio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents dgvLIstarEdificio As System.Windows.Forms.DataGridView
    Friend WithEvents btnAlta As System.Windows.Forms.Button
End Class
