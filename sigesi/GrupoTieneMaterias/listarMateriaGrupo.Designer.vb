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
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
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
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarUsuario.BackColor = System.Drawing.Color.Black
        Me.btnAgregarUsuario.FlatAppearance.BorderSize = 0
        Me.btnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarUsuario.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregarUsuario.Image = Global.sigesi.My.Resources.Resources.icono_agregar_ususario_50
        Me.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(519, 64)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(199, 69)
        Me.btnAgregarUsuario.TabIndex = 2
        Me.btnAgregarUsuario.Text = "Alta"
        Me.btnAgregarUsuario.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.Color.Black
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Controls.Add(Me.btnAgregarUsuario)
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
    Friend WithEvents btnAgregarUsuario As System.Windows.Forms.Button
End Class
