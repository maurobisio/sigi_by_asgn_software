<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cantidadAlumnosGrupo
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
        CType(Me.dgvLIstarCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLIstarCantidad
        '
        Me.dgvLIstarCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvLIstarCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLIstarCantidad.Location = New System.Drawing.Point(12, 12)
        Me.dgvLIstarCantidad.Name = "dgvLIstarCantidad"
        Me.dgvLIstarCantidad.ReadOnly = True
        Me.dgvLIstarCantidad.Size = New System.Drawing.Size(722, 348)
        Me.dgvLIstarCantidad.TabIndex = 2
        '
        'cantidadAlumnosGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(746, 372)
        Me.Controls.Add(Me.dgvLIstarCantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cantidadAlumnosGrupo"
        Me.Text = "datagridview"
        CType(Me.dgvLIstarCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvLIstarCantidad As System.Windows.Forms.DataGridView
End Class
