<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeDIrector
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHOra = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFechaHora
        '
        Me.tmrFechaHora.Enabled = True
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(334, 444)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(75, 29)
        Me.lblFecha.TabIndex = 18
        Me.lblFecha.Text = "--/--/--"
        '
        'lblHOra
        '
        Me.lblHOra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHOra.AutoSize = True
        Me.lblHOra.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHOra.ForeColor = System.Drawing.Color.White
        Me.lblHOra.Location = New System.Drawing.Point(338, 407)
        Me.lblHOra.Name = "lblHOra"
        Me.lblHOra.Size = New System.Drawing.Size(71, 29)
        Me.lblHOra.TabIndex = 16
        Me.lblHOra.Text = "00:00"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(264, 328)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(275, 55)
        Me.lblTitulo.TabIndex = 20
        Me.lblTitulo.Text = "DIRECTOR"
        '
        'pic1
        '
        Me.pic1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic1.Image = Global.sigesi.My.Resources.Resources.directorfinal_azul_nuevo
        Me.pic1.Location = New System.Drawing.Point(299, 165)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(194, 137)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 19
        Me.pic1.TabStop = False
        '
        'homeDIrector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(786, 585)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHOra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homeDIrector"
        Me.Text = "homeDIrector"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHOra As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
