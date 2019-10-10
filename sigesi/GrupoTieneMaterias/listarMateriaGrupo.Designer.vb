<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarMateriaGrupo
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
        Me.dgvLIstarMatGrup = New System.Windows.Forms.DataGridView()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvLIstarMatGrup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLIstarMatGrup
        '
        Me.dgvLIstarMatGrup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvLIstarMatGrup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLIstarMatGrup.Location = New System.Drawing.Point(60, 21)
        Me.dgvLIstarMatGrup.Name = "dgvLIstarMatGrup"
        Me.dgvLIstarMatGrup.ReadOnly = True
        Me.dgvLIstarMatGrup.Size = New System.Drawing.Size(434, 328)
        Me.dgvLIstarMatGrup.TabIndex = 2
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
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.Color.Black
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.Image = Global.sigesi.My.Resources.Resources.eliminar_usuario
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(519, 139)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(199, 57)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = " Baja"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'listarMateriaGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(746, 372)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvLIstarMatGrup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "listarMateriaGrupo"
        Me.Text = "datagridview"
        CType(Me.dgvLIstarMatGrup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgvLIstarMatGrup As System.Windows.Forms.DataGridView
    Friend WithEvents btnAlta As System.Windows.Forms.Button
End Class
