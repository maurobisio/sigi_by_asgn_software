<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bajaUsuario))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Name = "lblTitulo"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblCi
        '
        resources.ApplyResources(Me.lblCi, "lblCi")
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.ForeColor = System.Drawing.Color.White
        Me.lblCi.Name = "lblCi"
        '
        'txtCi
        '
        resources.ApplyResources(Me.txtCi, "txtCi")
        Me.txtCi.Name = "txtCi"
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        resources.ApplyResources(Me.btnMax, "btnMax")
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMax.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN1
        Me.btnMax.Name = "btnMax"
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'lblNom
        '
        resources.ApplyResources(Me.lblNom, "lblNom")
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.ForeColor = System.Drawing.Color.White
        Me.lblNom.Name = "lblNom"
        '
        'txtNom
        '
        resources.ApplyResources(Me.txtNom, "txtNom")
        Me.txtNom.Name = "txtNom"
        '
        'bajaUsuario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bajaUsuario"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents btnMax As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
End Class
