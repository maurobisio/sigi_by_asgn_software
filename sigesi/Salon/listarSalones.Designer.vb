<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIstarSalones
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
        Me.dgvListarSalones = New System.Windows.Forms.DataGridView()
        Me.btnAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblListaSalones = New System.Windows.Forms.Label()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvListarSalones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListarSalones
        '
        Me.dgvListarSalones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvListarSalones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarSalones.Location = New System.Drawing.Point(62, 227)
        Me.dgvListarSalones.Name = "dgvListarSalones"
        Me.dgvListarSalones.ReadOnly = True
        Me.dgvListarSalones.Size = New System.Drawing.Size(352, 270)
        Me.dgvListarSalones.TabIndex = 3
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarUsuario.BackColor = System.Drawing.Color.White
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarUsuario.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(507, 315)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(131, 32)
        Me.btnAgregarUsuario.TabIndex = 2
        Me.btnAgregarUsuario.Text = "Agregar "
        Me.btnAgregarUsuario.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.Location = New System.Drawing.Point(507, 364)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(131, 32)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar "
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnModificar.Location = New System.Drawing.Point(507, 413)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(131, 32)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar "
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'lblListaSalones
        '
        Me.lblListaSalones.AutoSize = True
        Me.lblListaSalones.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaSalones.ForeColor = System.Drawing.Color.White
        Me.lblListaSalones.Location = New System.Drawing.Point(167, 173)
        Me.lblListaSalones.Name = "lblListaSalones"
        Me.lblListaSalones.Size = New System.Drawing.Size(156, 22)
        Me.lblListaSalones.TabIndex = 7
        Me.lblListaSalones.Text = "Lista de salones"
        '
        'pic2
        '
        Me.pic2.Image = Global.sigesi.My.Resources.Resources.depositphotos_18324989_stock_photo_dictionary_blue_glossy_icon_on1
        Me.pic2.Location = New System.Drawing.Point(62, 143)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(82, 61)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 6
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.sigesi.My.Resources.Resources.classroom_icon
        Me.pic1.Location = New System.Drawing.Point(507, 59)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(196, 112)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 5
        Me.pic1.TabStop = False
        '
        'LIstarSalones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(751, 588)
        Me.Controls.Add(Me.lblListaSalones)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.dgvListarSalones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LIstarSalones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIstarSalones"
        CType(Me.dgvListarSalones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListarSalones As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblListaSalones As System.Windows.Forms.Label
End Class
