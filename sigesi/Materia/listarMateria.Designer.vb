<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarMateria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.dgvListar = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnModificar.Location = New System.Drawing.Point(473, 147)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(199, 59)
        Me.btnModificar.TabIndex = 3
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
        Me.btnAlta.Location = New System.Drawing.Point(473, 52)
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
        Me.btnBaja.Location = New System.Drawing.Point(473, 230)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(199, 57)
        Me.btnBaja.TabIndex = 4
        Me.btnBaja.Text = " Baja"
        Me.btnBaja.UseVisualStyleBackColor = False
        '
        'dgvListar
        '
        Me.dgvListar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListar.Location = New System.Drawing.Point(14, 9)
        Me.dgvListar.Name = "dgvListar"
        Me.dgvListar.ReadOnly = True
        Me.dgvListar.Size = New System.Drawing.Size(434, 328)
        Me.dgvListar.TabIndex = 5
        '
        'listarMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(687, 347)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.dgvListar)
        Me.Name = "listarMateria"
        Me.Text = "listarMateria"
        CType(Me.dgvListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents dgvListar As System.Windows.Forms.DataGridView
End Class
