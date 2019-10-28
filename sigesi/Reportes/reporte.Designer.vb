<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte
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
        Me.btnCantidadAlumnosGrupo = New System.Windows.Forms.Button()
        Me.btnAlumnosMasUnGrupo = New System.Windows.Forms.Button()
        Me.btnTipoYCantidadInsc = New System.Windows.Forms.Button()
        Me.btnTop10MasFaltas = New System.Windows.Forms.Button()
        Me.btnTop50MejoresNotas = New System.Windows.Forms.Button()
        Me.btnDocentesDictandoUna = New System.Windows.Forms.Button()
        Me.btnBoletin = New System.Windows.Forms.Button()
        Me.btnListarLosGrupos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCantidadAlumnosGrupo
        '
        Me.btnCantidadAlumnosGrupo.BackColor = System.Drawing.Color.White
        Me.btnCantidadAlumnosGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCantidadAlumnosGrupo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCantidadAlumnosGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCantidadAlumnosGrupo.Location = New System.Drawing.Point(62, 83)
        Me.btnCantidadAlumnosGrupo.Name = "btnCantidadAlumnosGrupo"
        Me.btnCantidadAlumnosGrupo.Size = New System.Drawing.Size(269, 32)
        Me.btnCantidadAlumnosGrupo.TabIndex = 10
        Me.btnCantidadAlumnosGrupo.Text = "Cantidad de alumnos por grupo"
        Me.btnCantidadAlumnosGrupo.UseVisualStyleBackColor = False
        '
        'btnAlumnosMasUnGrupo
        '
        Me.btnAlumnosMasUnGrupo.BackColor = System.Drawing.Color.White
        Me.btnAlumnosMasUnGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlumnosMasUnGrupo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAlumnosMasUnGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAlumnosMasUnGrupo.Location = New System.Drawing.Point(62, 121)
        Me.btnAlumnosMasUnGrupo.Name = "btnAlumnosMasUnGrupo"
        Me.btnAlumnosMasUnGrupo.Size = New System.Drawing.Size(307, 32)
        Me.btnAlumnosMasUnGrupo.TabIndex = 11
        Me.btnAlumnosMasUnGrupo.Text = "Alumnos Cursando mas de un grupo"
        Me.btnAlumnosMasUnGrupo.UseVisualStyleBackColor = False
        '
        'btnTipoYCantidadInsc
        '
        Me.btnTipoYCantidadInsc.BackColor = System.Drawing.Color.White
        Me.btnTipoYCantidadInsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTipoYCantidadInsc.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTipoYCantidadInsc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTipoYCantidadInsc.Location = New System.Drawing.Point(62, 159)
        Me.btnTipoYCantidadInsc.Name = "btnTipoYCantidadInsc"
        Me.btnTipoYCantidadInsc.Size = New System.Drawing.Size(338, 32)
        Me.btnTipoYCantidadInsc.TabIndex = 12
        Me.btnTipoYCantidadInsc.Text = "Tipo y cantidad de incidencias año 2019"
        Me.btnTipoYCantidadInsc.UseVisualStyleBackColor = False
        '
        'btnTop10MasFaltas
        '
        Me.btnTop10MasFaltas.BackColor = System.Drawing.Color.White
        Me.btnTop10MasFaltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTop10MasFaltas.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTop10MasFaltas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTop10MasFaltas.Location = New System.Drawing.Point(62, 197)
        Me.btnTop10MasFaltas.Name = "btnTop10MasFaltas"
        Me.btnTop10MasFaltas.Size = New System.Drawing.Size(269, 32)
        Me.btnTop10MasFaltas.TabIndex = 13
        Me.btnTop10MasFaltas.Text = "Top 10 alumnos con más faltas"
        Me.btnTop10MasFaltas.UseVisualStyleBackColor = False
        '
        'btnTop50MejoresNotas
        '
        Me.btnTop50MejoresNotas.BackColor = System.Drawing.Color.White
        Me.btnTop50MejoresNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTop50MejoresNotas.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTop50MejoresNotas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTop50MejoresNotas.Location = New System.Drawing.Point(62, 235)
        Me.btnTop50MejoresNotas.Name = "btnTop50MejoresNotas"
        Me.btnTop50MejoresNotas.Size = New System.Drawing.Size(269, 32)
        Me.btnTop50MejoresNotas.TabIndex = 14
        Me.btnTop50MejoresNotas.Text = "50 alumnos con mejores notas"
        Me.btnTop50MejoresNotas.UseVisualStyleBackColor = False
        '
        'btnDocentesDictandoUna
        '
        Me.btnDocentesDictandoUna.BackColor = System.Drawing.Color.White
        Me.btnDocentesDictandoUna.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDocentesDictandoUna.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDocentesDictandoUna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDocentesDictandoUna.Location = New System.Drawing.Point(62, 273)
        Me.btnDocentesDictandoUna.Name = "btnDocentesDictandoUna"
        Me.btnDocentesDictandoUna.Size = New System.Drawing.Size(307, 32)
        Me.btnDocentesDictandoUna.TabIndex = 15
        Me.btnDocentesDictandoUna.Text = "Docentes dictando una sola materia"
        Me.btnDocentesDictandoUna.UseVisualStyleBackColor = False
        '
        'btnBoletin
        '
        Me.btnBoletin.BackColor = System.Drawing.Color.White
        Me.btnBoletin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBoletin.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBoletin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBoletin.Location = New System.Drawing.Point(62, 311)
        Me.btnBoletin.Name = "btnBoletin"
        Me.btnBoletin.Size = New System.Drawing.Size(75, 32)
        Me.btnBoletin.TabIndex = 16
        Me.btnBoletin.Text = "Boletin"
        Me.btnBoletin.UseVisualStyleBackColor = False
        '
        'btnListarLosGrupos
        '
        Me.btnListarLosGrupos.BackColor = System.Drawing.Color.White
        Me.btnListarLosGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnListarLosGrupos.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnListarLosGrupos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnListarLosGrupos.Location = New System.Drawing.Point(62, 45)
        Me.btnListarLosGrupos.Name = "btnListarLosGrupos"
        Me.btnListarLosGrupos.Size = New System.Drawing.Size(252, 32)
        Me.btnListarLosGrupos.TabIndex = 17
        Me.btnListarLosGrupos.Text = "Listar los grupos del Instituto"
        Me.btnListarLosGrupos.UseVisualStyleBackColor = False
        '
        'reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(746, 372)
        Me.Controls.Add(Me.btnListarLosGrupos)
        Me.Controls.Add(Me.btnBoletin)
        Me.Controls.Add(Me.btnDocentesDictandoUna)
        Me.Controls.Add(Me.btnTop50MejoresNotas)
        Me.Controls.Add(Me.btnTop10MasFaltas)
        Me.Controls.Add(Me.btnTipoYCantidadInsc)
        Me.Controls.Add(Me.btnAlumnosMasUnGrupo)
        Me.Controls.Add(Me.btnCantidadAlumnosGrupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reporte"
        Me.Text = "datagridview"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCantidadAlumnosGrupo As System.Windows.Forms.Button
    Friend WithEvents btnAlumnosMasUnGrupo As System.Windows.Forms.Button
    Friend WithEvents btnTipoYCantidadInsc As System.Windows.Forms.Button
    Friend WithEvents btnTop10MasFaltas As System.Windows.Forms.Button
    Friend WithEvents btnTop50MejoresNotas As System.Windows.Forms.Button
    Friend WithEvents btnDocentesDictandoUna As System.Windows.Forms.Button
    Friend WithEvents btnBoletin As System.Windows.Forms.Button
    Friend WithEvents btnListarLosGrupos As System.Windows.Forms.Button
End Class
