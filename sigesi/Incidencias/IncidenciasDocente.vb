
'*******************************CODIGO PARA SEGUNDA ENTREGA****************************************************
'Imports MySql.Data.MySqlClient
Public Class IncidenciasDocente


    '*******************************CODIGO PARA SEGUNDA ENTREGA****************************************************
    'Dim conexion As New MySqlConnection
    ' Dim datos As DataSet
    'Dim adaptador As New MySqlDataAdapter
   

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub menuDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged

    End Sub


    Private Sub btnSalones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGrupo.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        '*******************************CODIGO PARA SEGUNDA ENTREGA****************************************************
        'Try

        'conexion.ConnectionString = "Server=localhost;user=root;password=;database=sigesi"
        '  conexion.Open()
        '  Dim consulta As String
        ' consulta = "select * from alumnos where Curso = '" + cboCurso.Text + "' and Grupo = '" + cboGrupo.Text + "'"
        'adaptador = New MySqlDataAdapter(consulta, conexion)
        'datos = New DataSet
        'adaptador.Fill(datos, "alumnos")
        'dgvAlumno.DataSource = datos
        'dgvAlumno.DataMember = "alumnos"


        ' Catch ex As Exception
        'MsgBox(ex.Message)
        ' End Try


    End Sub

    

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Call LimpiarForm(Me)
        MsgBox("Se ha generado la incidencia")
    End Sub

    Private Sub dgvAlumno_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlumno.CellClick
        Dim i As Integer
        i = dgvAlumno.CurrentRow.Index
        txtCi.Text = dgvAlumno.Item(0, i).Value()
        txtNom.Text = dgvAlumno.Item(1, i).Value()
        txtApe.Text = dgvAlumno.Item(3, i).Value()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar2.Click
        Call LimpiarForm(Me)
        Dim obj As Control
        For Each obj In
                Me.grbBuscarAlumnos.Controls()
            If TypeOf (obj) Is TextBox Then obj.Text = ""
            If TypeOf (obj) Is ComboBox Then obj.Text = ""
        Next

        dgvAlumno.DataSource = Nothing
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInfo.Click

    End Sub



    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub


    Private Sub cboCurso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCurso.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboGrupo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGrupo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboIncidencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboIncidencia.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboIncidencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIncidencia.SelectedIndexChanged

    End Sub
End Class