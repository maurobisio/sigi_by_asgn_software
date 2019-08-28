<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeDocente
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHOra = New System.Windows.Forms.Label()
        Me.tmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Black
        Me.lbl1.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl1.Location = New System.Drawing.Point(39, 146)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(61, 55)
        Me.lbl1.TabIndex = 45
        Me.lbl1.Text = "D"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Black
        Me.lbl5.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl5.Location = New System.Drawing.Point(45, 338)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(55, 55)
        Me.lbl5.TabIndex = 48
        Me.lbl5.Text = "n"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Black
        Me.lbl4.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl4.Location = New System.Drawing.Point(44, 285)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(49, 55)
        Me.lbl4.TabIndex = 49
        Me.lbl4.Text = "e"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Black
        Me.lbl3.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl3.Location = New System.Drawing.Point(46, 238)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(48, 55)
        Me.lbl3.TabIndex = 46
        Me.lbl3.Text = "c"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Black
        Me.lbl6.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl6.Location = New System.Drawing.Point(46, 391)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(43, 55)
        Me.lbl6.TabIndex = 50
        Me.lbl6.Text = "t"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Black
        Me.lbl2.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl2.Location = New System.Drawing.Point(45, 187)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(52, 55)
        Me.lbl2.TabIndex = 47
        Me.lbl2.Text = "o"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.BackColor = System.Drawing.Color.Black
        Me.lbl7.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl7.Location = New System.Drawing.Point(44, 436)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(49, 55)
        Me.lbl7.TabIndex = 51
        Me.lbl7.Text = "e"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Controls.Add(Me.lbl7)
        Me.Panel1.Controls.Add(Me.lbl5)
        Me.Panel1.Controls.Add(Me.lbl2)
        Me.Panel1.Controls.Add(Me.lbl4)
        Me.Panel1.Controls.Add(Me.lbl6)
        Me.Panel1.Controls.Add(Me.lbl3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(553, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 557)
        Me.Panel1.TabIndex = 52
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(265, 507)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(84, 28)
        Me.lblFecha.TabIndex = 54
        Me.lblFecha.Text = "--/--/--"
        '
        'lblHOra
        '
        Me.lblHOra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHOra.AutoSize = True
        Me.lblHOra.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHOra.ForeColor = System.Drawing.Color.White
        Me.lblHOra.Location = New System.Drawing.Point(265, 464)
        Me.lblHOra.Name = "lblHOra"
        Me.lblHOra.Size = New System.Drawing.Size(77, 28)
        Me.lblHOra.TabIndex = 53
        Me.lblHOra.Text = "00:00"
        '
        'tmrFechaHora
        '
        Me.tmrFechaHora.Enabled = True
        '
        'pic1
        '
        Me.pic1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic1.BackColor = System.Drawing.Color.Black
        Me.pic1.Image = Global.sigesi.My.Resources.Resources.home_docente
        Me.pic1.Location = New System.Drawing.Point(116, 77)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(398, 314)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 44
        Me.pic1.TabStop = False
        '
        'homeDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(675, 557)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHOra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pic1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homeDocente"
        Me.Text = "homeDocente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHOra As System.Windows.Forms.Label
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
End Class
