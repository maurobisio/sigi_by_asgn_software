Imports MySql.Data.MySqlClient

Public Class listarUsuarios

    Shared Property rol As Object



    Private Sub datagridview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gridLoad()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        bajaUsuario.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        modificarUsuario.rol = rol
        modificarUsuario.Show()

    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cierro todos los formularios
        Me.Close()
    End Sub

    Private Sub btnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        altaUsuario.rol = rol
        altaUsuario.Show()
    End Sub

    Public Sub gridLoad()
        'Establece la conexón con el orgien de los datos
        Dim connection As New MySqlConnection
        'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
        Dim dataAdapter As New MySqlDataAdapter
        'Contiene los datos resultantes de ejecutar el comando SQL.
        Dim dataSet As New DataSet
        'Recupera datos del proceedor(SELECT * FROM ...)
        Dim command As String
        If rol = 2 Or rol = 3 Then
            Try
                connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                command = "SELECT ci, primer_nombre, segundo_nombre,apellido, direccion, email, telefono, pass, nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol "
                command += "WHERE estado = '1'"
                command += " AND rol.nombre_rol ='Alumno/a';"
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
        Else
            Try
                connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                command = "SELECT ci, primer_nombre, segundo_nombre,apellido, direccion, email, telefono, pass, nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol "
                command += "WHERE estado = '1';"
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
            
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If (txtCi.Text = "") Then
            gridLoad()
        Else
            'Establece la conexón con el orgien de los datos
            Dim connection As New MySqlConnection
            'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
            Dim dataAdapter As New MySqlDataAdapter
            'Contiene los datos resultantes de ejecutar el comando SQL.
            Dim dataSet As New DataSet
            'Recupera datos del proceedor(SELECT * FROM ...)
            Dim command As String

            If rol = 2 Or rol = 3 Then
                Try
                    connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                    command = "SELECT ci, primer_nombre, segundo_nombre,apellido, direccion, email, telefono, pass, nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol "
                    command += "WHERE ci=" + txtCi.Text
                    command += " AND estado = '1'"
                    command += " AND rol.nombre_rol ='Alumno/a';"
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
            Else
                Try
                    connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                    command = "SELECT ci, primer_nombre, segundo_nombre,apellido, direccion, email, telefono, pass, nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol "
                    command += "WHERE ci=" + txtCi.Text
                    command += " AND estado = '1';"
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
            End If
        End If
    End Sub
End Class