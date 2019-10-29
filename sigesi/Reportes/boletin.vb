﻿Imports MySql.Data.MySqlClient

Public Class boletin


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
            command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, materia.nom_materia, grupo.nombre_grupo, AVG(registro.valor) "
            command += "FROM (((((((tipo_registro "
            command += "INNER JOIN registro ON registro.id_tipo_registro = tipo_registro.id_tipo_registro) "
            command += "INNER JOIN pertenece ON pertenece.id_pertenece = registro.id_pertenece) "
            command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
            command += "INNER JOIN rol ON rol.id_rol = usuario.id_rol) "
            command += "INNER JOIN tiene ON pertenece.id_tiene = tiene.id_tiene) "
            command += "INNER JOIN materia ON materia.id_materia = tiene.id_materia) "
            command += "INNER JOIN grupo ON grupo.id_grupo = tiene.id_grupo) "
            command += "WHERE tipo_registro.nom_registro = 'Calificación' AND rol.nombre_rol = 'Alumno/a' "
            command += "GROUP BY pertenece.id_pertenece "
            command += "HAVING(AVG(registro.valor));"

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