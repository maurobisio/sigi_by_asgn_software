﻿Imports MySql.Data.MySqlClient

Public Class escolaridad

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtCi.Text = "" Then
            MsgBox("Ingrese la cedula de identidad del alumno")
        Else
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
                command = "SELECT * FROM usuario WHERE ci='" + txtCi.Text + "';"
                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "usuario")
                'cerreamos la conexión
                connection.Close()
                'Las Tablas, filas y columnas del DataSet se pueden acceder por su índice o por su nombre dataSet.Tables("usuario").Rows[n]
                'Encontro un usuario'
                If (dataSet.Tables("usuario").Rows.Count = 0) Then
                    MsgBox("No existe el estudiante ingrese una ci valida")
                Else
                    Try
                        'Establece la conexón con el orgien de los datos
                        connection = New MySqlConnection
                        'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
                        dataAdapter = New MySqlDataAdapter
                        'Contiene los datos resultantes de ejecutar el comando SQL.
                        dataSet = New DataSet
                        'Recupera datos del proceedor(SELECT * FROM ...)
                        command = ""

                        connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
                        command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, materia.nom_materia, materia.año, grupo.nombre_grupo, registro.valor "
                        command += "FROM (((((((tipo_registro "
                        command += "INNER JOIN registro ON registro.id_tipo_registro = tipo_registro.id_tipo_registro) "
                        command += "INNER JOIN pertenece ON pertenece.id_pertenece = registro.id_pertenece) "
                        command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
                        command += "INNER JOIN rol ON rol.id_rol = usuario.id_rol) "
                        command += "INNER JOIN tiene ON pertenece.id_tiene = tiene.id_tiene) "
                        command += "INNER JOIN materia ON materia.id_materia = tiene.id_materia) "
                        command += "INNER JOIN grupo ON grupo.id_grupo = tiene.id_grupo) "
                        command += "WHERE tipo_registro.nom_registro = 'Calificación Final' AND rol.nombre_rol = 'Alumno/a' AND usuario.ci='" + txtCi.Text + "' "
                        command += "GROUP BY pertenece.id_pertenece;"

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
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class