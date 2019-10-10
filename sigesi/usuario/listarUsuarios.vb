Imports MySql.Data.MySqlClient

Public Class listarUsuarios
    
    Private Sub datagridview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Establece la conexón con el orgien de los datos
        Dim connection As New MySqlConnection
        'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
        Dim dataAdapter As New MySqlDataAdapter
        'Contiene los datos resultantes de ejecutar el comando SQL.
        Dim dataSet As New DataSet
        'Recupera datos del proceedor(SELECT * FROM ...)
        Dim command As String

        Try
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            command = "SELECT ci, primer_nombre, segundo_nombre,apellido, direccion, email, pass, nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "usuario")
            dgvLIstarUsuarios.DataSource = dataSet
            dgvLIstarUsuarios.DataMember = "usuario"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
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

    Private Sub btnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click

        altaUsuario.Show()


    End Sub

    


    Private Sub dgvLIstarUsuarios_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLIstarUsuarios.CellClick
        

    End Sub

    Private Sub dgvLIstarUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLIstarUsuarios.CellContentClick

    End Sub
End Class