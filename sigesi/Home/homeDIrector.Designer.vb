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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
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
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl1.Location = New System.Drawing.Point(138, 52)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(59, 55)
        Me.lbl1.TabIndex = 20
        Me.lbl1.Text = "D"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl3.Location = New System.Drawing.Point(151, 162)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(40, 55)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "r"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl2.Location = New System.Drawing.Point(151, 107)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(34, 55)
        Me.lbl2.TabIndex = 22
        Me.lbl2.Text = "i"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl5.Location = New System.Drawing.Point(147, 258)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(48, 55)
        Me.lbl5.TabIndex = 23
        Me.lbl5.Text = "c"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl4.Location = New System.Drawing.Point(146, 203)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(51, 55)
        Me.lbl4.TabIndex = 24
        Me.lbl4.Text = "e"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl6.Location = New System.Drawing.Point(151, 313)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(37, 55)
        Me.lbl6.TabIndex = 25
        Me.lbl6.Text = "t"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl7.Location = New System.Drawing.Point(146, 356)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(51, 55)
        Me.lbl7.TabIndex = 26
        Me.lbl7.Text = "o"
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl8.Location = New System.Drawing.Point(151, 407)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(40, 55)
        Me.lbl8.TabIndex = 27
        Me.lbl8.Text = "r"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Controls.Add(Me.lbl8)
        Me.Panel1.Controls.Add(Me.lbl5)
        Me.Panel1.Controls.Add(Me.lbl4)
        Me.Panel1.Controls.Add(Me.lbl3)
        Me.Panel1.Controls.Add(Me.lbl6)
        Me.Panel1.Controls.Add(Me.lbl2)
        Me.Panel1.Controls.Add(Me.lbl7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(567, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 585)
        Me.Panel1.TabIndex = 28
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHOra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homeDIrector"
        Me.Text = "homeDIrector"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHOra As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
