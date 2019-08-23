<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuBedel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuBedel))
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.pnlIzquierda = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picIsgesi = New System.Windows.Forms.PictureBox()
        Me.btnGestionInformes = New System.Windows.Forms.Button()
        Me.btnreportes = New System.Windows.Forms.Button()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.btnIncidencias = New System.Windows.Forms.Button()
        Me.picAsgn = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesión = New System.Windows.Forms.Button()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnSalones = New System.Windows.Forms.Button()
        Me.pnlArriba.SuspendLayout()
        Me.pnlIzquierda.SuspendLayout()
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlArriba
        '
        Me.pnlArriba.BackColor = System.Drawing.Color.Black
        Me.pnlArriba.Controls.Add(Me.btnMinimizar)
        Me.pnlArriba.Controls.Add(Me.btnSalir)
        Me.pnlArriba.Controls.Add(Me.picIsgesi)
        Me.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArriba.Location = New System.Drawing.Point(214, 0)
        Me.pnlArriba.Name = "pnlArriba"
        Me.pnlArriba.Size = New System.Drawing.Size(735, 71)
        Me.pnlArriba.TabIndex = 23
        '
        'pnlCentral
        '
        Me.pnlCentral.BackColor = System.Drawing.Color.Black
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Location = New System.Drawing.Point(214, 71)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(735, 604)
        Me.pnlCentral.TabIndex = 24
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.pnlIzquierda.Controls.Add(Me.btnreportes)
        Me.pnlIzquierda.Controls.Add(Me.PctMenu)
        Me.pnlIzquierda.Controls.Add(Me.btnIncidencias)
        Me.pnlIzquierda.Controls.Add(Me.picAsgn)
        Me.pnlIzquierda.Controls.Add(Me.btnCerrarSesión)
        Me.pnlIzquierda.Controls.Add(Me.btnAlumnos)
        Me.pnlIzquierda.Controls.Add(Me.btnInicio)
        Me.pnlIzquierda.Controls.Add(Me.btnSalones)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.ForeColor = System.Drawing.Color.White
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(214, 675)
        Me.pnlIzquierda.TabIndex = 7
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.sigesi.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(641, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 13
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
        Me.btnSalir.Location = New System.Drawing.Point(687, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picIsgesi
        '
        Me.picIsgesi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picIsgesi.BackColor = System.Drawing.Color.Transparent
        Me.picIsgesi.Image = Global.sigesi.My.Resources.Resources.cooltext3309054766168343
        Me.picIsgesi.Location = New System.Drawing.Point(262, 6)
        Me.picIsgesi.Name = "picIsgesi"
        Me.picIsgesi.Size = New System.Drawing.Size(243, 62)
        Me.picIsgesi.TabIndex = 10
        Me.picIsgesi.TabStop = False
        '
        'btnGestionInformes
        '
        Me.btnGestionInformes.FlatAppearance.BorderSize = 0
        Me.btnGestionInformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGestionInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGestionInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionInformes.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionInformes.ForeColor = System.Drawing.Color.White
        Me.btnGestionInformes.Image = Global.sigesi.My.Resources.Resources.icono_gestion_x_40
        Me.btnGestionInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionInformes.Location = New System.Drawing.Point(2, 357)
        Me.btnGestionInformes.Name = "btnGestionInformes"
        Me.btnGestionInformes.Size = New System.Drawing.Size(217, 54)
        Me.btnGestionInformes.TabIndex = 38
        Me.btnGestionInformes.Text = "          Gestión e Informes"
        Me.btnGestionInformes.UseVisualStyleBackColor = True
        '
        'btnreportes
        '
        Me.btnreportes.FlatAppearance.BorderSize = 0
        Me.btnreportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnreportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportes.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportes.ForeColor = System.Drawing.Color.White
        Me.btnreportes.Image = Global.sigesi.My.Resources.Resources.depositphotos_116517602_stock_illustration_closed_spiral_notebook_and_pen_copy
        Me.btnreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreportes.Location = New System.Drawing.Point(0, 287)
        Me.btnreportes.Name = "btnreportes"
        Me.btnreportes.Size = New System.Drawing.Size(219, 54)
        Me.btnreportes.TabIndex = 37
        Me.btnreportes.Text = "      Reportes"
        Me.btnreportes.UseVisualStyleBackColor = True
        '
        'PctMenu
        '
        Me.PctMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PctMenu.BackColor = System.Drawing.Color.Transparent
        Me.PctMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctMenu.Image = Global.sigesi.My.Resources.Resources.Mobile_Menu_Icon
        Me.PctMenu.Location = New System.Drawing.Point(164, 7)
        Me.PctMenu.Name = "PctMenu"
        Me.PctMenu.Size = New System.Drawing.Size(47, 40)
        Me.PctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctMenu.TabIndex = 36
        Me.PctMenu.TabStop = False
        '
        'btnIncidencias
        '
        Me.btnIncidencias.FlatAppearance.BorderSize = 0
        Me.btnIncidencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnIncidencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncidencias.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncidencias.ForeColor = System.Drawing.Color.White
        Me.btnIncidencias.Image = Global.sigesi.My.Resources.Resources.icono_incidencia_50_2
        Me.btnIncidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncidencias.Location = New System.Drawing.Point(2, 221)
        Me.btnIncidencias.Name = "btnIncidencias"
        Me.btnIncidencias.Size = New System.Drawing.Size(217, 54)
        Me.btnIncidencias.TabIndex = 35
        Me.btnIncidencias.Text = "         Incidencias"
        Me.btnIncidencias.UseVisualStyleBackColor = True
        '
        'picAsgn
        '
        Me.picAsgn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picAsgn.Image = Global.sigesi.My.Resources.Resources.logo_asgn_gr2
        Me.picAsgn.Location = New System.Drawing.Point(0, 633)
        Me.picAsgn.Name = "picAsgn"
        Me.picAsgn.Size = New System.Drawing.Size(214, 42)
        Me.picAsgn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsgn.TabIndex = 8
        Me.picAsgn.TabStop = False
        '
        'btnCerrarSesión
        '
        Me.btnCerrarSesión.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesión.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrarSesión.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesión.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesión.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesión.Image = Global.sigesi.My.Resources.Resources.icono_candado_40
        Me.btnCerrarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesión.Location = New System.Drawing.Point(-2, 545)
        Me.btnCerrarSesión.Name = "btnCerrarSesión"
        Me.btnCerrarSesión.Size = New System.Drawing.Size(221, 48)
        Me.btnCerrarSesión.TabIndex = 34
        Me.btnCerrarSesión.Text = "         Cerrar sesíon"
        Me.btnCerrarSesión.UseVisualStyleBackColor = True
        '
        'btnAlumnos
        '
        Me.btnAlumnos.FlatAppearance.BorderSize = 0
        Me.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumnos.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnos.ForeColor = System.Drawing.Color.White
        Me.btnAlumnos.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumnos.Location = New System.Drawing.Point(0, 107)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(217, 54)
        Me.btnAlumnos.TabIndex = 33
        Me.btnAlumnos.Text = "      Alumnos"
        Me.btnAlumnos.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = Global.sigesi.My.Resources.Resources.icono_house
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(-3, 485)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(217, 54)
        Me.btnInicio.TabIndex = 31
        Me.btnInicio.Text = " Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnSalones
        '
        Me.btnSalones.FlatAppearance.BorderSize = 0
        Me.btnSalones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalones.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalones.ForeColor = System.Drawing.Color.White
        Me.btnSalones.Image = Global.sigesi.My.Resources.Resources.ICONO_SALONES
        Me.btnSalones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalones.Location = New System.Drawing.Point(0, 161)
        Me.btnSalones.Name = "btnSalones"
        Me.btnSalones.Size = New System.Drawing.Size(217, 54)
        Me.btnSalones.TabIndex = 32
        Me.btnSalones.Text = "    Salones"
        Me.btnSalones.UseVisualStyleBackColor = True
        '
        'menuBedel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 675)
        Me.Controls.Add(Me.pnlCentral)
        Me.Controls.Add(Me.pnlArriba)
        Me.Controls.Add(Me.pnlIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menuBedel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuBedel"
        Me.pnlArriba.ResumeLayout(False)
        Me.pnlIzquierda.ResumeLayout(False)
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Friend WithEvents picAsgn As System.Windows.Forms.PictureBox
    Friend WithEvents picIsgesi As System.Windows.Forms.PictureBox
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pnlCentral As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnIncidencias As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesión As System.Windows.Forms.Button
    Friend WithEvents btnAlumnos As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnSalones As System.Windows.Forms.Button
    Friend WithEvents PctMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents btnreportes As System.Windows.Forms.Button
    Friend WithEvents btnGestionInformes As System.Windows.Forms.Button
End Class
