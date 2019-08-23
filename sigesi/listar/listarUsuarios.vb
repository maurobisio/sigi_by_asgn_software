'*********************************** codigo para la segunda entrega del proyecto ******************************************************
'Imports MySql.Data


'Imports MySql.Data.MySqlClient
Public Class listarUsuarios
    '*********************************** codigo para la segunda entrega del proyecto ******************************************************
    'Dim conexion As New MySqlConnection
    'Dim datos As DataSet
    'Dim adaptador As New MySqlDataAdapter
    Private Sub datagridview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '*********************************** codigo para la segunda entrega del proyecto ******************************************************

        'Try

        'conexion.ConnectionString = "Server=localhost;user=root;password=;database=isgesi"
        ' conexion.Open()
        ' Dim consulta As String
        ' consulta = "select * from usuarios"
        ' adaptador = New MySqlDataAdapter(consulta, conexion)
        ' datos = New DataSet
        ' adaptador.Fill(datos, "usuarios")
        ' dgvLIstarUsuarios.DataSource = datos
        'dgvLIstarUsuarios.DataMember = "usuarios"


        'Catch ex As Exception
        'MsgBox(ex.Message)
        ' End Try





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        bajaUsuario.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        modificarUsuario.Show()

    End Sub


    Private Sub btnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cierro todos los formularios
        Me.Close()

    End Sub

    Private Sub btnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarUsuario.Click

        altaUsuario.Show()


    End Sub

    


    Private Sub dgvLIstarUsuarios_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLIstarUsuarios.CellClick
        

    End Sub

    Private Sub dgvLIstarUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLIstarUsuarios.CellContentClick

    End Sub
End Class