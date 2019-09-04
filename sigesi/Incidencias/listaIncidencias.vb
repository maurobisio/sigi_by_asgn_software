
'*******************************CODIGO PARA LA SEGUNDA ENTREGA DEL PROYECTO****************************************************
'Imports MySql.Data.MySqlClient
Public Class listaIncidencias

    '*******************************CODIGO PARA LA SEGUNDA ENTREGA DEL PROYECTO****************************************************
    ' Dim conexion As New MySqlConnection
    ' Dim datos As DataSet
    ' Dim adaptador As New MySqlDataAdapter
    Private Sub btnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'altaAlumno.Show()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'modificarAlumno.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarAlumnos.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        menuBedel.Show()



    End Sub



    Private Sub listarAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '*******************************CODIGO PARA LA SEGUNDA ENTREGA DEL PROYECTO****************************************************

        '  Try

        'conexion.ConnectionString = "Server=localhost;user=root;password=;database=sigesi"
        ' conexion.Open()
        ' Dim consulta As String
        ' consulta = "select * from alumnos"
        ' adaptador = New MySqlDataAdapter(consulta, conexion)
        ' datos = New DataSet
        ' adaptador.Fill(datos, "alumnos")
        'dgvListarAlumnos.DataSource = datos
        ' dgvListarAlumnos.DataMember = "alumnos"


        'Catch ex As Exception
        'MsgBox(ex.Message)
        ' End Try


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        altaIncidencia.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'modificarAlumno.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub
End Class