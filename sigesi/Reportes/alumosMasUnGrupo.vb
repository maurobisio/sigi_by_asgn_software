﻿Imports MySql.Data.MySqlClient

Public Class alumosMasUnGrupo


    Private Sub cantidadAlumnosGrupo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gridLoad()
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

        Try
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre "
            command += "FROM ((grupo "
            command += "INNER JOIN tiene ON tiene.id_grupo = grupo.id_grupo) "
            command += "INNER JOIN pertenece ON pertenece.id_tiene = tiene.id_tiene) "
            command += "INNER JOIN usuario ON usuario.ci = pertenece.ci "
            command += "INNER JOIN rol ON rol.id_rol = usuario.id_rol "
            command += "WHERE rol.nombre_rol = 'Alumno/a' "
            command += "GROUP BY usuario.ci "
            command += "HAVING COUNT(grupo.id_grupo) > 1;"

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