<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeAdminSIstema
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
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHOra = New System.Windows.Forms.Label()
        Me.tmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(563, 206)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(84, 28)
        Me.lblFecha.TabIndex = 20
        Me.lblFecha.Text = "--/--/--"
        '
        'lblHOra
        '
        Me.lblHOra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHOra.AutoSize = True
        Me.lblHOra.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHOra.ForeColor = System.Drawing.Color.White
        Me.lblHOra.Location = New System.Drawing.Point(581, 159)
        Me.lblHOra.Name = "lblHOra"
        Me.lblHOra.Size = New System.Drawing.Size(77, 28)
        Me.lblHOra.TabIndex = 19
        Me.lblHOra.Text = "00:00"
        '
        'tmrFechaHora
        '
        Me.tmrFechaHora.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 348)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 82)
        Me.Panel1.TabIndex = 21
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(70, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(630, 55)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Administrador de Sistema"
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.Image = Global.sigesi.My.Resources.Resources.s_employee_module
        Me.pic1.Location = New System.Drawing.Point(248, 68)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(201, 204)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'homeAdminSIstema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(729, 430)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHOra)
        Me.Controls.Add(Me.pic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homeAdminSIstema"
        Me.Text = "homeAdminSIstema"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHOra As System.Windows.Forms.Label
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
