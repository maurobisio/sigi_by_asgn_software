﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.PnlCentral = New System.Windows.Forms.Panel()
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.picIsgesi = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnIncidencias = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnAlumno = New System.Windows.Forms.Button()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.btnIncio = New System.Windows.Forms.Button()
        Me.picAsgn = New System.Windows.Forms.PictureBox()
        Me.pnlIzquierda.SuspendLayout()
        Me.pnlArriba.SuspendLayout()
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlIzquierda
        '
        Me.pnlIzquierda.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlIzquierda.Controls.Add(Me.btnIncidencias)
        Me.pnlIzquierda.Controls.Add(Me.btnCerrarSesion)
        Me.pnlIzquierda.Controls.Add(Me.btnAlumno)
        Me.pnlIzquierda.Controls.Add(Me.PctMenu)
        Me.pnlIzquierda.Controls.Add(Me.btnIncio)
        Me.pnlIzquierda.Controls.Add(Me.picAsgn)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.ForeColor = System.Drawing.Color.White
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(214, 677)
        Me.pnlIzquierda.TabIndex = 8
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
        Me.btnIncidencias.Location = New System.Drawing.Point(-3, 189)
        Me.btnIncidencias.Name = "btnIncidencias"
        Me.btnIncidencias.Size = New System.Drawing.Size(217, 54)
        Me.btnIncidencias.TabIndex = 39
        Me.btnIncidencias.Text = "         Incidencias"
        Me.btnIncidencias.UseVisualStyleBackColor = True
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(-3, 343)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(221, 48)
        Me.btnCerrarSesion.TabIndex = 38
        Me.btnCerrarSesion.Text = "         Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnAlumno
        '
        Me.btnAlumno.FlatAppearance.BorderSize = 0
        Me.btnAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumno.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumno.ForeColor = System.Drawing.Color.White
        Me.btnAlumno.Image = Global.sigesi.My.Resources.Resources.ICONO_USUARIOS_50X50
        Me.btnAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumno.Location = New System.Drawing.Point(-5, 112)
        Me.btnAlumno.Name = "btnAlumno"
        Me.btnAlumno.Size = New System.Drawing.Size(217, 54)
        Me.btnAlumno.TabIndex = 37
        Me.btnAlumno.Text = "      Alumnos"
        Me.btnAlumno.UseVisualStyleBackColor = True
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
        'btnIncio
        '
        Me.btnIncio.FlatAppearance.BorderSize = 0
        Me.btnIncio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnIncio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnIncio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncio.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncio.ForeColor = System.Drawing.Color.White
        Me.btnIncio.Image = Global.sigesi.My.Resources.Resources.icono_house
        Me.btnIncio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncio.Location = New System.Drawing.Point(-3, 266)
        Me.btnIncio.Name = "btnIncio"
        Me.btnIncio.Size = New System.Drawing.Size(217, 54)
        Me.btnIncio.TabIndex = 36
        Me.btnIncio.Text = " Inicio"
        Me.btnIncio.UseVisualStyleBackColor = True
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
        Me.pnlArriba.ResumeLayout(False)
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Friend WithEvents picAsgn As System.Windows.Forms.PictureBox
    Friend WithEvents btnIncidencias As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents btnAlumno As System.Windows.Forms.Button
    Friend WithEvents btnIncio As System.Windows.Forms.Button
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents PctMenu As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents PnlCentral As System.Windows.Forms.Panel
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents picIsgesi As System.Windows.Forms.PictureBox
End Class
