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
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picIsgesi = New System.Windows.Forms.PictureBox()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
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
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.picAsgn = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.pnlArriba.SuspendLayout()
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIzquierda.SuspendLayout()
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
        Me.pnlIzquierda.Controls.Add(Me.btnUsuarios)
        Me.pnlIzquierda.Controls.Add(Me.btnRegistro)
        Me.pnlIzquierda.Controls.Add(Me.btnIncidencia)
        Me.pnlIzquierda.Controls.Add(Me.btnReportes)
        Me.pnlIzquierda.Controls.Add(Me.btnInscripcion)
        Me.pnlIzquierda.Controls.Add(Me.btnMateriaGrupo)
        Me.pnlIzquierda.Controls.Add(Me.btnEdificio)
        Me.pnlIzquierda.Controls.Add(Me.btnGrupo)
        Me.pnlIzquierda.Controls.Add(Me.btnMateria)
        Me.pnlIzquierda.Controls.Add(Me.btnInicio)
        Me.pnlIzquierda.Controls.Add(Me.PctMenu)
        Me.pnlIzquierda.Controls.Add(Me.picAsgn)
        Me.pnlIzquierda.Controls.Add(Me.btnCerrarSesion)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.ForeColor = System.Drawing.Color.White
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(214, 675)
        Me.pnlIzquierda.TabIndex = 7
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
        Me.btnRegistro.Location = New System.Drawing.Point(2, 408)
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
        Me.btnIncidencia.Location = New System.Drawing.Point(2, 348)
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
        Me.btnReportes.Location = New System.Drawing.Point(-2, 459)
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
        Me.btnInscripcion.Location = New System.Drawing.Point(2, 288)
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
        Me.btnMateriaGrupo.Location = New System.Drawing.Point(-2, 194)
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
        Me.btnEdificio.Location = New System.Drawing.Point(2, 241)
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
        Me.btnGrupo.Location = New System.Drawing.Point(2, 145)
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
        Me.btnMateria.Location = New System.Drawing.Point(-1, 99)
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
        Me.btnInicio.Location = New System.Drawing.Point(0, 519)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(218, 54)
        Me.btnInicio.TabIndex = 49
        Me.btnInicio.Text = "  Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(3, 568)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(221, 48)
        Me.btnCerrarSesion.TabIndex = 34
        Me.btnCerrarSesion.Text = "         Cerrar sesíon"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
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
        Me.btnUsuarios.Location = New System.Drawing.Point(-1, 53)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(218, 54)
        Me.btnUsuarios.TabIndex = 58
        Me.btnUsuarios.Text = "     Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
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
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIzquierda.ResumeLayout(False)
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
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents PctMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
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
