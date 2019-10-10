<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAdminSistema
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
        Me.pnlIzquierda = New System.Windows.Forms.Panel()
        Me.btnIncidencias = New System.Windows.Forms.Button()
        Me.btnMateriaGrupo = New System.Windows.Forms.Button()
        Me.btnEdificio = New System.Windows.Forms.Button()
        Me.btnGrupo = New System.Windows.Forms.Button()
        Me.btnMateria = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.picAsgn = New System.Windows.Forms.PictureBox()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picIsgesi = New System.Windows.Forms.PictureBox()
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.pnlIzquierda.SuspendLayout()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlArriba.SuspendLayout()
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlIzquierda
        '
        Me.pnlIzquierda.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlIzquierda.Controls.Add(Me.btnIncidencias)
        Me.pnlIzquierda.Controls.Add(Me.btnMateriaGrupo)
        Me.pnlIzquierda.Controls.Add(Me.btnEdificio)
        Me.pnlIzquierda.Controls.Add(Me.btnGrupo)
        Me.pnlIzquierda.Controls.Add(Me.btnMateria)
        Me.pnlIzquierda.Controls.Add(Me.btnCerrarSesion)
        Me.pnlIzquierda.Controls.Add(Me.PctMenu)
        Me.pnlIzquierda.Controls.Add(Me.btnInicio)
        Me.pnlIzquierda.Controls.Add(Me.btnUsuarios)
        Me.pnlIzquierda.Controls.Add(Me.picAsgn)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(214, 573)
        Me.pnlIzquierda.TabIndex = 0
        '
        'btnIncidencias
        '
        Me.btnIncidencias.FlatAppearance.BorderSize = 0
        Me.btnIncidencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnIncidencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncidencias.ForeColor = System.Drawing.Color.White
        Me.btnIncidencias.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnIncidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncidencias.Location = New System.Drawing.Point(3, 216)
        Me.btnIncidencias.Name = "btnIncidencias"
        Me.btnIncidencias.Size = New System.Drawing.Size(218, 54)
        Me.btnIncidencias.TabIndex = 43
        Me.btnIncidencias.Text = "Incidencias"
        Me.btnIncidencias.UseVisualStyleBackColor = True
        '
        'btnMateriaGrupo
        '
        Me.btnMateriaGrupo.FlatAppearance.BorderSize = 0
        Me.btnMateriaGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMateriaGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMateriaGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMateriaGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateriaGrupo.ForeColor = System.Drawing.Color.White
        Me.btnMateriaGrupo.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnMateriaGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMateriaGrupo.Location = New System.Drawing.Point(0, 276)
        Me.btnMateriaGrupo.Name = "btnMateriaGrupo"
        Me.btnMateriaGrupo.Size = New System.Drawing.Size(247, 54)
        Me.btnMateriaGrupo.TabIndex = 42
        Me.btnMateriaGrupo.Text = "Materias Grupo"
        Me.btnMateriaGrupo.UseVisualStyleBackColor = True
        '
        'btnEdificio
        '
        Me.btnEdificio.FlatAppearance.BorderSize = 0
        Me.btnEdificio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEdificio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdificio.ForeColor = System.Drawing.Color.White
        Me.btnEdificio.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnEdificio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdificio.Location = New System.Drawing.Point(0, 336)
        Me.btnEdificio.Name = "btnEdificio"
        Me.btnEdificio.Size = New System.Drawing.Size(218, 54)
        Me.btnEdificio.TabIndex = 41
        Me.btnEdificio.Text = "Edificio"
        Me.btnEdificio.UseVisualStyleBackColor = True
        '
        'btnGrupo
        '
        Me.btnGrupo.FlatAppearance.BorderSize = 0
        Me.btnGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupo.ForeColor = System.Drawing.Color.White
        Me.btnGrupo.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrupo.Location = New System.Drawing.Point(3, 167)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(218, 54)
        Me.btnGrupo.TabIndex = 40
        Me.btnGrupo.Text = "Grupo"
        Me.btnGrupo.UseVisualStyleBackColor = True
        '
        'btnMateria
        '
        Me.btnMateria.FlatAppearance.BorderSize = 0
        Me.btnMateria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMateria.ForeColor = System.Drawing.Color.White
        Me.btnMateria.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMateria.Location = New System.Drawing.Point(0, 121)
        Me.btnMateria.Name = "btnMateria"
        Me.btnMateria.Size = New System.Drawing.Size(218, 54)
        Me.btnMateria.TabIndex = 39
        Me.btnMateria.Text = "Materia"
        Me.btnMateria.UseVisualStyleBackColor = True
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(3, 477)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(215, 48)
        Me.btnCerrarSesion.TabIndex = 38
        Me.btnCerrarSesion.Text = "         Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'PctMenu
        '
        Me.PctMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PctMenu.BackColor = System.Drawing.Color.Transparent
        Me.PctMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctMenu.Image = Global.sigesi.My.Resources.Resources.Mobile_Menu_Icon
        Me.PctMenu.Location = New System.Drawing.Point(164, 12)
        Me.PctMenu.Name = "PctMenu"
        Me.PctMenu.Size = New System.Drawing.Size(47, 40)
        Me.PctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctMenu.TabIndex = 37
        Me.PctMenu.TabStop = False
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
        Me.btnInicio.Location = New System.Drawing.Point(0, 417)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(218, 54)
        Me.btnInicio.TabIndex = 35
        Me.btnInicio.Text = "  Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(3, 75)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(218, 54)
        Me.btnUsuarios.TabIndex = 34
        Me.btnUsuarios.Text = "     Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'picAsgn
        '
        Me.picAsgn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picAsgn.Image = Global.sigesi.My.Resources.Resources.logo_asgn_gr2
        Me.picAsgn.Location = New System.Drawing.Point(0, 531)
        Me.picAsgn.Name = "picAsgn"
        Me.picAsgn.Size = New System.Drawing.Size(214, 42)
        Me.picAsgn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsgn.TabIndex = 32
        Me.picAsgn.TabStop = False
        '
        'pnlCentral
        '
        Me.pnlCentral.BackColor = System.Drawing.Color.Black
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Location = New System.Drawing.Point(214, 59)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(738, 514)
        Me.pnlCentral.TabIndex = 0
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
        Me.pnlArriba.Size = New System.Drawing.Size(738, 59)
        Me.pnlArriba.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.sigesi.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(643, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 35
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
        Me.btnSalir.Location = New System.Drawing.Point(689, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picIsgesi
        '
        Me.picIsgesi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picIsgesi.BackColor = System.Drawing.Color.Transparent
        Me.picIsgesi.Image = Global.sigesi.My.Resources.Resources.cooltext3309054766168341
        Me.picIsgesi.Location = New System.Drawing.Point(240, 0)
        Me.picIsgesi.Name = "picIsgesi"
        Me.picIsgesi.Size = New System.Drawing.Size(259, 59)
        Me.picIsgesi.TabIndex = 33
        Me.picIsgesi.TabStop = False
        '
        'tmrOcultarMenu
        '
        '
        'tmrMostrarMenu
        '
        '
        'menuAdminSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 573)
        Me.Controls.Add(Me.pnlCentral)
        Me.Controls.Add(Me.pnlArriba)
        Me.Controls.Add(Me.pnlIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuAdminSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuAdminSistema"
        Me.pnlIzquierda.ResumeLayout(False)
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlArriba.ResumeLayout(False)
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Friend WithEvents pnlCentral As System.Windows.Forms.Panel
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents picAsgn As System.Windows.Forms.PictureBox
    Friend WithEvents picIsgesi As System.Windows.Forms.PictureBox
    Friend WithEvents PctMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnMateria As System.Windows.Forms.Button
    Friend WithEvents btnGrupo As System.Windows.Forms.Button
    Friend WithEvents btnEdificio As System.Windows.Forms.Button
    Friend WithEvents btnMateriaGrupo As System.Windows.Forms.Button
    Friend WithEvents btnIncidencias As System.Windows.Forms.Button
End Class
