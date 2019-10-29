Imports MySql.Data.MySqlClient

Public Class top50AlumnosMejorNota


    Private Sub cantidadAlumnosGrupo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, AVG(registro.valor) "
            command += "FROM ((((tipo_registro "
            command += "INNER JOIN registro ON registro.id_tipo_registro = tipo_registro.id_tipo_registro) "
            command += "INNER JOIN pertenece ON pertenece.id_pertenece = registro.id_pertenece) "
            command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
            command += "INNER JOIN rol ON rol.id_rol = usuario.id_rol) "
            command += "WHERE tipo_registro.nom_registro = 'Calificación' AND rol.nombre_rol = 'Alumno/a' "
            command += "GROUP BY usuario.ci "
            command += "HAVING(AVG(registro.valor)) "
            command += "ORDER BY AVG(registro.valor) DESC "
            command += "LIMIT 10;"

            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "usuario")
            dgvLIstarCantidad.DataSource = dataSet
            dgvLIstarCantidad.DataMember = "usuario"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class