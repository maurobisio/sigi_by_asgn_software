<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaMateriaGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altaMateriaGrupo))
        Me.txtCodGrup = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.txtCodMat = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvLIstarGrupo = New System.Windows.Forms.DataGridView()
        Me.dgvListarMateria = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLIstarGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListarMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodGrup
        '
        resources.ApplyResources(Me.txtCodGrup, "txtCodGrup")
        Me.txtCodGrup.Name = "txtCodGrup"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblCi
        '
        resources.ApplyResources(Me.lblCi, "lblCi")
        Me.lblCi.BackColor = System.Drawing.Color.Transparent
        Me.lblCi.ForeColor = System.Drawing.Color.Black
        Me.lblCi.Name = "lblCi"
        '
        'lblMateria
        '
        resources.ApplyResources(Me.lblMateria, "lblMateria")
        Me.lblMateria.BackColor = System.Drawing.Color.Transparent
        Me.lblMateria.ForeColor = System.Drawing.Color.Black
        Me.lblMateria.Name = "lblMateria"
        '
        'txtCodMat
        '
        resources.ApplyResources(Me.txtCodMat, "txtCodMat")
        Me.txtCodMat.Name = "txtCodMat"
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Name = "lblTitulo"
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.Image = Global.sigesi.My.Resources.Resources.Icono_cerrar_FN
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgvLIstarGrupo
        '
        resources.ApplyResources(Me.dgvLIstarGrupo, "dgvLIstarGrupo")
        Me.dgvLIstarGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLIstarGrupo.Name = "dgvLIstarGrupo"
        Me.dgvLIstarGrupo.ReadOnly = True
        '
        'dgvListarMateria
        '
        resources.ApplyResources(Me.dgvListarMateria, "dgvListarMateria")
        Me.dgvListarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarMateria.Name = "dgvListarMateria"
        Me.dgvListarMateria.ReadOnly = True
        '
        'altaMateriaGrupo
        '
        Me.AcceptButton = Me.btnAgregar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.dgvListarMateria)
        Me.Controls.Add(Me.dgvLIstarGrupo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtCodMat)
        Me.Controls.Add(Me.lblMateria)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCodGrup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "altaMateriaGrupo"
        Me.TopMost = True
        CType(Me.dgvLIstarGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListarMateria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodGrup As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents lblMateria As System.Windows.Forms.Label
    Friend WithEvents txtCodMat As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dgvLIstarGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvListarMateria As System.Windows.Forms.DataGridView
End Class
