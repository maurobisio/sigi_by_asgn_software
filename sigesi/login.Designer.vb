<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.pnlIzquierda = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picIsgn = New System.Windows.Forms.PictureBox()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.txtUsu = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.lblUsu = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.picCandado = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lnsPwd = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnsUsuario = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlIzquierda.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIsgn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlCentral.SuspendLayout()
        CType(Me.picCandado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlIzquierda
        '
        Me.pnlIzquierda.BackColor = System.Drawing.Color.Black
        Me.pnlIzquierda.Controls.Add(Me.btnAtras)
        Me.pnlIzquierda.Controls.Add(Me.picLogo)
        Me.pnlIzquierda.Controls.Add(Me.picIsgn)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(239, 446)
        Me.pnlIzquierda.TabIndex = 1
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.ForeColor = System.Drawing.Color.White
        Me.btnAtras.Image = Global.sigesi.My.Resources.Resources.atras_60z60_icono
        Me.btnAtras.Location = New System.Drawing.Point(86, 202)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(69, 90)
        Me.btnAtras.TabIndex = 31
        Me.btnAtras.Text = "Volver"
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picLogo.Image = Global.sigesi.My.Resources.Resources.logo_asgn_ultima_azul1
        Me.picLogo.Location = New System.Drawing.Point(0, 381)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(239, 65)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'picIsgn
        '
        Me.picIsgn.BackColor = System.Drawing.Color.Transparent
        Me.picIsgn.Dock = System.Windows.Forms.DockStyle.Top
        Me.picIsgn.Image = Global.sigesi.My.Resources.Resources.logo_sigesi1
        Me.picIsgn.Location = New System.Drawing.Point(0, 0)
        Me.picIsgn.Name = "picIsgn"
        Me.picIsgn.Size = New System.Drawing.Size(239, 91)
        Me.picIsgn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIsgn.TabIndex = 0
        Me.picIsgn.TabStop = False
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPwd.ForeColor = System.Drawing.Color.White
        Me.lblPwd.Location = New System.Drawing.Point(84, 304)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(152, 24)
        Me.lblPwd.TabIndex = 2
        Me.lblPwd.Text = "CONTRASEÑA"
        '
        'txtUsu
        '
        Me.txtUsu.BackColor = System.Drawing.Color.Black
        Me.txtUsu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsu.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.txtUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsu.ForeColor = System.Drawing.Color.White
        Me.txtUsu.Location = New System.Drawing.Point(241, 259)
        Me.txtUsu.MaxLength = 50
        Me.txtUsu.Name = "txtUsu"
        Me.txtUsu.Size = New System.Drawing.Size(528, 19)
        Me.txtUsu.TabIndex = 1
        Me.txtUsu.UseWaitCursor = True
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.Color.Black
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.ForeColor = System.Drawing.Color.White
        Me.txtPwd.Location = New System.Drawing.Point(241, 295)
        Me.txtPwd.MaxLength = 50
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(528, 19)
        Me.txtPwd.TabIndex = 2
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.DimGray
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(88, 389)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(689, 33)
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'lblUsu
        '
        Me.lblUsu.AutoSize = True
        Me.lblUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsu.ForeColor = System.Drawing.Color.White
        Me.lblUsu.Location = New System.Drawing.Point(84, 268)
        Me.lblUsu.Name = "lblUsu"
        Me.lblUsu.Size = New System.Drawing.Size(100, 24)
        Me.lblUsu.TabIndex = 3
        Me.lblUsu.Text = "USUARIO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnMinimizar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(870, 50)
        Me.Panel1.TabIndex = 9
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.sigesi.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(766, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 17
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(821, 7)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.TabStop = False
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pnlCentral
        '
        Me.pnlCentral.BackColor = System.Drawing.Color.Black
        Me.pnlCentral.Controls.Add(Me.Button1)
        Me.pnlCentral.Controls.Add(Me.picCandado)
        Me.pnlCentral.Controls.Add(Me.Panel1)
        Me.pnlCentral.Controls.Add(Me.lblUsu)
        Me.pnlCentral.Controls.Add(Me.btnEntrar)
        Me.pnlCentral.Controls.Add(Me.txtPwd)
        Me.pnlCentral.Controls.Add(Me.txtUsu)
        Me.pnlCentral.Controls.Add(Me.lblPwd)
        Me.pnlCentral.Controls.Add(Me.ShapeContainer1)
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCentral.Location = New System.Drawing.Point(239, 0)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(870, 446)
        Me.pnlCentral.TabIndex = 2
        '
        'picCandado
        '
        Me.picCandado.Image = Global.sigesi.My.Resources.Resources.Preddeyspadlock
        Me.picCandado.Location = New System.Drawing.Point(367, 79)
        Me.picCandado.Name = "picCandado"
        Me.picCandado.Size = New System.Drawing.Size(141, 102)
        Me.picCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCandado.TabIndex = 8
        Me.picCandado.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lnsPwd, Me.lnsUsuario, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(870, 446)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'lnsPwd
        '
        Me.lnsPwd.BorderColor = System.Drawing.Color.White
        Me.lnsPwd.Name = "lnsPwd"
        Me.lnsPwd.X1 = 241
        Me.lnsPwd.X2 = 776
        Me.lnsPwd.Y1 = 322
        Me.lnsPwd.Y2 = 322
        '
        'lnsUsuario
        '
        Me.lnsUsuario.BorderColor = System.Drawing.Color.White
        Me.lnsUsuario.Name = "lnsUsuario"
        Me.lnsUsuario.X1 = 241
        Me.lnsUsuario.X2 = 774
        Me.lnsUsuario.Y1 = 284
        Me.lnsUsuario.Y2 = 284
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 90
        Me.LineShape2.X2 = 90
        Me.LineShape2.Y1 = 90
        Me.LineShape2.Y2 = 90
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 752
        Me.LineShape1.X2 = 662
        Me.LineShape1.Y1 = 220
        Me.LineShape1.Y2 = 220
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(91, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(689, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 446)
        Me.Controls.Add(Me.pnlCentral)
        Me.Controls.Add(Me.pnlIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginBedel"
        Me.pnlIzquierda.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIsgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlCentral.ResumeLayout(False)
        Me.pnlCentral.PerformLayout()
        CType(Me.picCandado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Friend WithEvents picIsgn As System.Windows.Forms.PictureBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents txtUsu As System.Windows.Forms.TextBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents lblUsu As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents picCandado As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCentral As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lnsPwd As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnsUsuario As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
