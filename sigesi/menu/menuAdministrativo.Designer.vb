<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAdministrativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuAdministrativo))
        Me.pnlIzquierda = New System.Windows.Forms.Panel()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.btnIncidencia = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnInscripcion = New System.Windows.Forms.Button()
        Me.btnMateriaGrupo = New System.Windows.Forms.Button()
        Me.btnEdificio = New System.Windows.Forms.Button()
        Me.btnGrupo = New System.Windows.Forms.Button()
        Me.btnMateria = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.picAsgn = New System.Windows.Forms.PictureBox()
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.picIsgesi = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.PnlCentral = New System.Windows.Forms.Panel()
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.btnUsuarios = New System.Windows.Forms.Button()
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
        Me.pnlIzquierda.Controls.Add(Me.btnRegistro)
        Me.pnlIzquierda.Controls.Add(Me.btnIncidencia)
        Me.pnlIzquierda.Controls.Add(Me.btnReportes)
        Me.pnlIzquierda.Controls.Add(Me.btnInscripcion)
        Me.pnlIzquierda.Controls.Add(Me.btnMateriaGrupo)
        Me.pnlIzquierda.Controls.Add(Me.btnEdificio)
        Me.pnlIzquierda.Controls.Add(Me.btnGrupo)
        Me.pnlIzquierda.Controls.Add(Me.btnMateria)
        Me.pnlIzquierda.Controls.Add(Me.btnInicio)
        Me.pnlIzquierda.Controls.Add(Me.btnUsuarios)
        Me.pnlIzquierda.Controls.Add(Me.btnCerrarSesion)
        Me.pnlIzquierda.Controls.Add(Me.PctMenu)
        Me.pnlIzquierda.Controls.Add(Me.picAsgn)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.ForeColor = System.Drawing.Color.White
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(214, 677)
        Me.pnlIzquierda.TabIndex = 8
        '
        'btnRegistro
        '
        Me.btnRegistro.FlatAppearance.BorderSize = 0
        Me.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.Image = Global.sigesi.My.Resources.Resources.icono_gestion_x_40
        Me.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.Location = New System.Drawing.Point(0, 418)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(218, 54)
        Me.btnRegistro.TabIndex = 57
        Me.btnRegistro.Text = "Registros"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'btnIncidencia
        '
        Me.btnIncidencia.FlatAppearance.BorderSize = 0
        Me.btnIncidencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnIncidencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncidencia.ForeColor = System.Drawing.Color.White
        Me.btnIncidencia.Image = Global.sigesi.My.Resources.Resources.icono_incidencia_50_
        Me.btnIncidencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncidencia.Location = New System.Drawing.Point(0, 358)
        Me.btnIncidencia.Name = "btnIncidencia"
        Me.btnIncidencia.Size = New System.Drawing.Size(218, 54)
        Me.btnIncidencia.TabIndex = 56
        Me.btnIncidencia.Text = "Incidencias"
        Me.btnIncidencia.UseVisualStyleBackColor = True
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
        Me.btnReportes.Location = New System.Drawing.Point(0, 469)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(218, 54)
        Me.btnReportes.TabIndex = 55
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnInscripcion
        '
        Me.btnInscripcion.FlatAppearance.BorderSize = 0
        Me.btnInscripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInscripcion.ForeColor = System.Drawing.Color.White
        Me.btnInscripcion.Image = Global.sigesi.My.Resources.Resources.icono_gestion_x_40
        Me.btnInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInscripcion.Location = New System.Drawing.Point(0, 298)
        Me.btnInscripcion.Name = "btnInscripcion"
        Me.btnInscripcion.Size = New System.Drawing.Size(218, 54)
        Me.btnInscripcion.TabIndex = 54
        Me.btnInscripcion.Text = "Inscripciones"
        Me.btnInscripcion.UseVisualStyleBackColor = True
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
        Me.btnMateriaGrupo.Location = New System.Drawing.Point(-4, 204)
        Me.btnMateriaGrupo.Name = "btnMateriaGrupo"
        Me.btnMateriaGrupo.Size = New System.Drawing.Size(247, 54)
        Me.btnMateriaGrupo.TabIndex = 53
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
        Me.btnEdificio.Image = Global.sigesi.My.Resources.Resources.Icono_Restaurar
        Me.btnEdificio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdificio.Location = New System.Drawing.Point(0, 251)
        Me.btnEdificio.Name = "btnEdificio"
        Me.btnEdificio.Size = New System.Drawing.Size(218, 54)
        Me.btnEdificio.TabIndex = 52
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
        Me.btnGrupo.Image = Global.sigesi.My.Resources.Resources.ICONO_SALONES
        Me.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrupo.Location = New System.Drawing.Point(0, 155)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(218, 54)
        Me.btnGrupo.TabIndex = 51
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
        Me.btnMateria.Image = Global.sigesi.My.Resources.Resources.icono_incidencia_50_
        Me.btnMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMateria.Location = New System.Drawing.Point(-3, 109)
        Me.btnMateria.Name = "btnMateria"
        Me.btnMateria.Size = New System.Drawing.Size(218, 54)
        Me.btnMateria.TabIndex = 50
        Me.btnMateria.Text = "Materia"
        Me.btnMateria.UseVisualStyleBackColor = True
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
        Me.btnInicio.Location = New System.Drawing.Point(0, 529)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(218, 54)
        Me.btnInicio.TabIndex = 49
        Me.btnInicio.Text = "  Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = Global.sigesi.My.Resources.Resources.icono_candado_40
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 581)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(221, 48)
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
        Me.PctMenu.TabIndex = 42
        Me.PctMenu.TabStop = False
        '
        'picAsgn
        '
        Me.picAsgn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picAsgn.Image = Global.sigesi.My.Resources.Resources.logo_asgn_gr2
        Me.picAsgn.Location = New System.Drawing.Point(0, 635)
        Me.picAsgn.Name = "picAsgn"
        Me.picAsgn.Size = New System.Drawing.Size(214, 42)
        Me.picAsgn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsgn.TabIndex = 8
        Me.picAsgn.TabStop = False
        '
        'pnlArriba
        '
        Me.pnlArriba.Controls.Add(Me.picIsgesi)
        Me.pnlArriba.Controls.Add(Me.btnSalir)
        Me.pnlArriba.Controls.Add(Me.btnMinimizar)
        Me.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArriba.Location = New System.Drawing.Point(214, 0)
        Me.pnlArriba.Name = "pnlArriba"
        Me.pnlArriba.Size = New System.Drawing.Size(735, 67)
        Me.pnlArriba.TabIndex = 9
        '
        'picIsgesi
        '
        Me.picIsgesi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picIsgesi.BackColor = System.Drawing.Color.Transparent
        Me.picIsgesi.Image = Global.sigesi.My.Resources.Resources.cooltext330905476616834
        Me.picIsgesi.Location = New System.Drawing.Point(228, -3)
        Me.picIsgesi.Name = "picIsgesi"
        Me.picIsgesi.Size = New System.Drawing.Size(235, 64)
        Me.picIsgesi.TabIndex = 9
        Me.picIsgesi.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Location = New System.Drawing.Point(683, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "         "
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.sigesi.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(627, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 41
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'PnlCentral
        '
        Me.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlCentral.Location = New System.Drawing.Point(214, 67)
        Me.PnlCentral.Name = "PnlCentral"
        Me.PnlCentral.Size = New System.Drawing.Size(735, 610)
        Me.PnlCentral.TabIndex = 10
        '
        'tmrMostrarMenu
        '
        '
        'tmrOcultarMenu
        '
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
        Me.btnUsuarios.Location = New System.Drawing.Point(-3, 59)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(218, 54)
        Me.btnUsuarios.TabIndex = 48
        Me.btnUsuarios.Text = "     Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'menuAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(949, 677)
        Me.Controls.Add(Me.PnlCentral)
        Me.Controls.Add(Me.pnlArriba)
        Me.Controls.Add(Me.pnlIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "menuAdministrativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuAdministrativo"
        Me.pnlIzquierda.ResumeLayout(False)
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlArriba.ResumeLayout(False)
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Friend WithEvents picAsgn As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents PctMenu As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents PnlCentral As System.Windows.Forms.Panel
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents picIsgesi As System.Windows.Forms.PictureBox
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents btnIncidencia As System.Windows.Forms.Button
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents btnInscripcion As System.Windows.Forms.Button
    Friend WithEvents btnMateriaGrupo As System.Windows.Forms.Button
    Friend WithEvents btnEdificio As System.Windows.Forms.Button
    Friend WithEvents btnGrupo As System.Windows.Forms.Button
    Friend WithEvents btnMateria As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
End Class
