<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuDirector
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
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.pnlIzquierda = New System.Windows.Forms.Panel()
        Me.btnGestionInformes = New System.Windows.Forms.Button()
        Me.btnAlumn = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnIncidencias = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnSalones = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.picAsgn = New System.Windows.Forms.PictureBox()
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.pnlIzquierda.SuspendLayout()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlArriba.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMostrarMenu
        '
        '
        'tmrOcultarMenu
        '
        '
        'pnlIzquierda
        '
        Me.pnlIzquierda.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlIzquierda.Controls.Add(Me.btnGestionInformes)
        Me.pnlIzquierda.Controls.Add(Me.btnAlumn)
        Me.pnlIzquierda.Controls.Add(Me.btnReportes)
        Me.pnlIzquierda.Controls.Add(Me.btnIncidencias)
        Me.pnlIzquierda.Controls.Add(Me.btnCerrarSesion)
        Me.pnlIzquierda.Controls.Add(Me.btnSalones)
        Me.pnlIzquierda.Controls.Add(Me.btnInicio)
        Me.pnlIzquierda.Controls.Add(Me.PctMenu)
        Me.pnlIzquierda.Controls.Add(Me.picAsgn)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.ForeColor = System.Drawing.Color.White
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(214, 681)
        Me.pnlIzquierda.TabIndex = 7
        '
        'btnGestionInformes
        '
        Me.btnGestionInformes.FlatAppearance.BorderSize = 0
        Me.btnGestionInformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGestionInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGestionInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionInformes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionInformes.ForeColor = System.Drawing.Color.White
        Me.btnGestionInformes.Image = Global.sigesi.My.Resources.Resources.icono_gestion_x_40
        Me.btnGestionInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionInformes.Location = New System.Drawing.Point(0, 383)
        Me.btnGestionInformes.Name = "btnGestionInformes"
        Me.btnGestionInformes.Size = New System.Drawing.Size(214, 54)
        Me.btnGestionInformes.TabIndex = 42
        Me.btnGestionInformes.Text = "       Gestión e Informes"
        Me.btnGestionInformes.UseVisualStyleBackColor = True
        '
        'btnAlumn
        '
        Me.btnAlumn.FlatAppearance.BorderSize = 0
        Me.btnAlumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAlumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAlumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumn.ForeColor = System.Drawing.Color.White
        Me.btnAlumn.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnAlumn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumn.Location = New System.Drawing.Point(-3, 131)
        Me.btnAlumn.Name = "btnAlumn"
        Me.btnAlumn.Size = New System.Drawing.Size(217, 54)
        Me.btnAlumn.TabIndex = 40
        Me.btnAlumn.Text = "      Alumnos"
        Me.btnAlumn.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = Global.sigesi.My.Resources.Resources.depositphotos_116517602_stock_illustration_closed_spiral_notebook_and_pen_copy
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(-2, 257)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(219, 54)
        Me.btnReportes.TabIndex = 39
        Me.btnReportes.Text = "      Reportes"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnIncidencias
        '
        Me.btnIncidencias.FlatAppearance.BorderSize = 0
        Me.btnIncidencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnIncidencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncidencias.ForeColor = System.Drawing.Color.White
        Me.btnIncidencias.Image = Global.sigesi.My.Resources.Resources.icono_incidencia_50_2
        Me.btnIncidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncidencias.Location = New System.Drawing.Point(0, 194)
        Me.btnIncidencias.Name = "btnIncidencias"
        Me.btnIncidencias.Size = New System.Drawing.Size(217, 54)
        Me.btnIncidencias.TabIndex = 38
        Me.btnIncidencias.Text = "         Incidencias"
        Me.btnIncidencias.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = Global.sigesi.My.Resources.Resources.icono_candado_40
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(-2, 579)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(219, 48)
        Me.btnCerrarSesion.TabIndex = 30
        Me.btnCerrarSesion.Text = "         Cerrar seccion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnSalones
        '
        Me.btnSalones.FlatAppearance.BorderSize = 0
        Me.btnSalones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalones.ForeColor = System.Drawing.Color.White
        Me.btnSalones.Image = Global.sigesi.My.Resources.Resources.ICONO_SALONES
        Me.btnSalones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalones.Location = New System.Drawing.Point(0, 320)
        Me.btnSalones.Name = "btnSalones"
        Me.btnSalones.Size = New System.Drawing.Size(211, 54)
        Me.btnSalones.TabIndex = 28
        Me.btnSalones.Text = "   Salones"
        Me.btnSalones.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = Global.sigesi.My.Resources.Resources.icono_house
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(-2, 515)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(214, 54)
        Me.btnInicio.TabIndex = 27
        Me.btnInicio.Text = "  Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'PctMenu
        '
        Me.PctMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PctMenu.BackColor = System.Drawing.Color.Transparent
        Me.PctMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctMenu.Image = Global.sigesi.My.Resources.Resources.Mobile_Menu_Icon
        Me.PctMenu.Location = New System.Drawing.Point(167, 12)
        Me.PctMenu.Name = "PctMenu"
        Me.PctMenu.Size = New System.Drawing.Size(44, 33)
        Me.PctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctMenu.TabIndex = 26
        Me.PctMenu.TabStop = False
        '
        'picAsgn
        '
        Me.picAsgn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picAsgn.Image = Global.sigesi.My.Resources.Resources.logo_asgn_gr2
        Me.picAsgn.Location = New System.Drawing.Point(0, 639)
        Me.picAsgn.Name = "picAsgn"
        Me.picAsgn.Size = New System.Drawing.Size(214, 42)
        Me.picAsgn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsgn.TabIndex = 8
        Me.picAsgn.TabStop = False
        '
        'pnlArriba
        '
        Me.pnlArriba.BackColor = System.Drawing.Color.Black
        Me.pnlArriba.Controls.Add(Me.btnMinimizar)
        Me.pnlArriba.Controls.Add(Me.btnSalir)
        Me.pnlArriba.Controls.Add(Me.pic1)
        Me.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArriba.Location = New System.Drawing.Point(214, 0)
        Me.pnlArriba.Name = "pnlArriba"
        Me.pnlArriba.Size = New System.Drawing.Size(735, 71)
        Me.pnlArriba.TabIndex = 10
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.sigesi.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(636, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 17
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
        Me.btnSalir.Location = New System.Drawing.Point(692, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.Image = Global.sigesi.My.Resources.Resources.cooltext3309054766168344
        Me.pic1.Location = New System.Drawing.Point(247, 3)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(237, 65)
        Me.pic1.TabIndex = 18
        Me.pic1.TabStop = False
        '
        'pnlCentral
        '
        Me.pnlCentral.BackColor = System.Drawing.Color.Black
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Location = New System.Drawing.Point(214, 71)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(735, 610)
        Me.pnlCentral.TabIndex = 11
        '
        'menuDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 681)
        Me.Controls.Add(Me.pnlCentral)
        Me.Controls.Add(Me.pnlArriba)
        Me.Controls.Add(Me.pnlIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuDirector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuDirector"
        Me.pnlIzquierda.ResumeLayout(False)
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlArriba.ResumeLayout(False)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Friend WithEvents picAsgn As System.Windows.Forms.PictureBox
    Friend WithEvents PctMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnSalones As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents btnIncidencias As System.Windows.Forms.Button
    Friend WithEvents btnAlumn As System.Windows.Forms.Button
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCentral As System.Windows.Forms.Panel
    Friend WithEvents btnGestionInformes As System.Windows.Forms.Button
End Class
