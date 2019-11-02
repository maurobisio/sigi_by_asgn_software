<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuDocente
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
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PctMenu = New System.Windows.Forms.PictureBox()
        Me.picASgn = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.tmrOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.pnlArriba = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picIsgesi = New System.Windows.Forms.PictureBox()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.btnIncidencia = New System.Windows.Forms.Button()
        Me.pnlIzquierda.SuspendLayout()
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picASgn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlArriba.SuspendLayout()
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlIzquierda
        '
        Me.pnlIzquierda.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlIzquierda.Controls.Add(Me.btnIncidencia)
        Me.pnlIzquierda.Controls.Add(Me.btnRegistro)
        Me.pnlIzquierda.Controls.Add(Me.btnInicio)
        Me.pnlIzquierda.Controls.Add(Me.PctMenu)
        Me.pnlIzquierda.Controls.Add(Me.picASgn)
        Me.pnlIzquierda.Controls.Add(Me.btnCerrarSesion)
        Me.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlIzquierda.ForeColor = System.Drawing.Color.White
        Me.pnlIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.pnlIzquierda.Name = "pnlIzquierda"
        Me.pnlIzquierda.Size = New System.Drawing.Size(214, 715)
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
        Me.btnRegistro.Location = New System.Drawing.Point(0, 133)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(218, 54)
        Me.btnRegistro.TabIndex = 57
        Me.btnRegistro.Text = "Registros"
        Me.btnRegistro.UseVisualStyleBackColor = True
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
        Me.btnInicio.Location = New System.Drawing.Point(3, 537)
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
        'picASgn
        '
        Me.picASgn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picASgn.Image = Global.sigesi.My.Resources.Resources.logo_asgn_gr2
        Me.picASgn.Location = New System.Drawing.Point(0, 673)
        Me.picASgn.Name = "picASgn"
        Me.picASgn.Size = New System.Drawing.Size(214, 42)
        Me.picASgn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picASgn.TabIndex = 8
        Me.picASgn.TabStop = False
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 619)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(218, 48)
        Me.btnCerrarSesion.TabIndex = 34
        Me.btnCerrarSesion.Text = "         Cerrar sesíon"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'tmrOcultarMenu
        '
        '
        'tmrMostrarMenu
        '
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
        Me.pnlArriba.Size = New System.Drawing.Size(735, 67)
        Me.pnlArriba.TabIndex = 17
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.sigesi.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(643, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 16
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
        Me.btnSalir.Location = New System.Drawing.Point(689, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picIsgesi
        '
        Me.picIsgesi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picIsgesi.BackColor = System.Drawing.Color.Transparent
        Me.picIsgesi.Image = Global.sigesi.My.Resources.Resources.cooltext3309054766168345
        Me.picIsgesi.Location = New System.Drawing.Point(243, 3)
        Me.picIsgesi.Name = "picIsgesi"
        Me.picIsgesi.Size = New System.Drawing.Size(241, 61)
        Me.picIsgesi.TabIndex = 14
        Me.picIsgesi.TabStop = False
        '
        'pnlCentral
        '
        Me.pnlCentral.BackColor = System.Drawing.Color.Black
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Location = New System.Drawing.Point(214, 67)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(735, 648)
        Me.pnlCentral.TabIndex = 38
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
        Me.btnIncidencia.Location = New System.Drawing.Point(0, 73)
        Me.btnIncidencia.Name = "btnIncidencia"
        Me.btnIncidencia.Size = New System.Drawing.Size(218, 54)
        Me.btnIncidencia.TabIndex = 58
        Me.btnIncidencia.Text = "Incidencias"
        Me.btnIncidencia.UseVisualStyleBackColor = True
        '
        'menuDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 715)
        Me.Controls.Add(Me.pnlCentral)
        Me.Controls.Add(Me.pnlArriba)
        Me.Controls.Add(Me.pnlIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuDocente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuDocente"
        Me.pnlIzquierda.ResumeLayout(False)
        CType(Me.PctMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picASgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlArriba.ResumeLayout(False)
        CType(Me.picIsgesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIzquierda As System.Windows.Forms.Panel
    Friend WithEvents PctMenu As System.Windows.Forms.PictureBox
    Friend WithEvents picASgn As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents tmrOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents picIsgesi As System.Windows.Forms.PictureBox
    Friend WithEvents pnlArriba As System.Windows.Forms.Panel
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents pnlCentral As System.Windows.Forms.Panel
    Friend WithEvents btnIncidencia As System.Windows.Forms.Button
End Class
