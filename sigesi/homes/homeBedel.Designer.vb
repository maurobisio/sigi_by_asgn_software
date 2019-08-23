<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeBedel
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
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblE2 = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHOra = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrFechaHora
        '
        Me.tmrFechaHora.Enabled = True
        '
        'pic1
        '
        Me.pic1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic1.Image = Global.sigesi.My.Resources.Resources.asf
        Me.pic1.Location = New System.Drawing.Point(271, 103)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(196, 153)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 27
        Me.pic1.TabStop = False
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblB.Location = New System.Drawing.Point(122, 80)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(53, 55)
        Me.lblB.TabIndex = 32
        Me.lblB.Text = "B"
        '
        'lblE2
        '
        Me.lblE2.AutoSize = True
        Me.lblE2.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblE2.Location = New System.Drawing.Point(126, 137)
        Me.lblE2.Name = "lblE2"
        Me.lblE2.Size = New System.Drawing.Size(51, 55)
        Me.lblE2.TabIndex = 33
        Me.lblE2.Text = "E"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblD.Location = New System.Drawing.Point(122, 194)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(61, 55)
        Me.lblD.TabIndex = 34
        Me.lblD.Text = "D"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblE.Location = New System.Drawing.Point(126, 251)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(51, 55)
        Me.lblE.TabIndex = 35
        Me.lblE.Text = "E"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblL.Location = New System.Drawing.Point(126, 308)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(51, 55)
        Me.lblL.TabIndex = 36
        Me.lblL.Text = "L"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(298, 415)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(84, 28)
        Me.lblFecha.TabIndex = 38
        Me.lblFecha.Text = "--/--/--"
        '
        'lblHOra
        '
        Me.lblHOra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHOra.AutoSize = True
        Me.lblHOra.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHOra.ForeColor = System.Drawing.Color.White
        Me.lblHOra.Location = New System.Drawing.Point(316, 374)
        Me.lblHOra.Name = "lblHOra"
        Me.lblHOra.Size = New System.Drawing.Size(77, 28)
        Me.lblHOra.TabIndex = 37
        Me.lblHOra.Text = "00:00"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblB)
        Me.Panel1.Controls.Add(Me.lblE2)
        Me.Panel1.Controls.Add(Me.lblD)
        Me.Panel1.Controls.Add(Me.lblL)
        Me.Panel1.Controls.Add(Me.lblE)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(539, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 515)
        Me.Panel1.TabIndex = 39
        '
        'homeBedel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(739, 515)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHOra)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homeBedel"
        Me.Text = "homeBedel"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblE2 As System.Windows.Forms.Label
    Friend WithEvents lblD As System.Windows.Forms.Label
    Friend WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents lblL As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHOra As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
