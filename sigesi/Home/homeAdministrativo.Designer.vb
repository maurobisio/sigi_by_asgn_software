<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeAdministrativo
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
        Me.components = New System.ComponentModel.Container()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHOra = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.Image = Global.sigesi.My.Resources.Resources.final3
        Me.pic1.Location = New System.Drawing.Point(502, 132)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(186, 144)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(5, 543)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(84, 28)
        Me.lblFecha.TabIndex = 23
        Me.lblFecha.Text = "--/--/--"
        '
        'lblHOra
        '
        Me.lblHOra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHOra.AutoSize = True
        Me.lblHOra.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHOra.ForeColor = System.Drawing.Color.White
        Me.lblHOra.Location = New System.Drawing.Point(12, 498)
        Me.lblHOra.Name = "lblHOra"
        Me.lblHOra.Size = New System.Drawing.Size(77, 28)
        Me.lblHOra.TabIndex = 22
        Me.lblHOra.Text = "00:00"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Lucida Bright", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(317, 327)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(374, 55)
        Me.lblTitulo.TabIndex = 21
        Me.lblTitulo.Text = "Administrativo"
        '
        'tmrFechaHora
        '
        Me.tmrFechaHora.Enabled = True
        '
        'homeAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(735, 579)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHOra)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homeAdministrativo"
        Me.Text = "homeAdministrativo"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHOra As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
End Class
