Imports MySql.Data.MySqlClient

Public Class cantidadAlumnosGrupo

    
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
            connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
            command = "SELECT grupo.id_grupo, grupo.nombre_grupo, COUNT(pertenece.id_pertenece) "
            command += "FROM ((grupo "
            command += "INNER JOIN tiene ON tiene.id_grupo = grupo.id_grupo) "
            command += "INNER JOIN pertenece ON pertenece.id_tiene = tiene.id_tiene) "
            command += "GROUP BY grupo.id_grupo "
            command += "HAVING(COUNT(pertenece.id_pertenece));"

            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "grupo")
            dgvLIstarCantidad.DataSource = dataSet
            dgvLIstarCantidad.DataMember = "grupo"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class