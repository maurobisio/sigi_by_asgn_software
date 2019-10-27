Imports MySql.Data.MySqlClient

Public Class login

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()


    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Hide()
        idioma.Show()



    End Sub

    Private Sub lblUsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsu.Click

    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        If txtUsu.Text = "" And txtPwd.Text = "" Then
            MsgBox("Ingrese nombre de Usuario y Contraseña")
        Else
            If txtUsu.Text = "" Then
                MsgBox("Ingrese nombre de Usuario ")
            Else
                If txtPwd.Text = "" Then
                    MsgBox("Ingrese Contraseña")
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
                        connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                        command = "SELECT * FROM usuario WHERE email='" & txtUsu.Text & "' and pass='" & txtPwd.Text & "';"
                        dataAdapter = New MySqlDataAdapter(command, connection)
                        'Abrir la conexión
                        connection.Open()
                        'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                        dataAdapter.Fill(dataSet, "usuario")
                        'cerreamos la conexión
                        connection.Close()
                        'Las Tablas, filas y columnas del DataSet se pueden acceder por su índice o por su nombre dataSet.Tables("usuario").Rows[n]
                        'Encontro un usuario'
                        If (dataSet.Tables("usuario").Rows.Count <> 0) Then
                            MsgBox("Bienviendo al Sistema " & dataSet.Tables("usuario").Rows(0)("primer_nombre") & " " & dataSet.Tables("usuario").Rows(0)("apellido"))

                            'obtengo el rol del usuario'
                            Dim user_rol = dataSet.Tables("usuario").Rows(0)("id_rol")
                            MsgBox(user_rol)

                            Select Case user_rol
                                Case 0
                                    Me.Hide()
                                    menuAdminSistema.Show()
                                Case 1
                                    Me.Hide()
                                    menuDirector.Show()
                                Case 2
                                    Me.Hide()
                                    menuBedel.Show()
                                Case 3
                                    Me.Hide()
                                    menuAdministrativo.Show()
                                Case 4
                                    Me.Hide()
                                    menuDocente.Show()
                                Case 5
                                    Me.Hide()
                                    menuAlumno.Show()
                            End Select
                        Else
                        MsgBox("Usuario y/o Contraseña no válidos", "Sistema")

                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        menuAdminSistema.Show()
    End Sub
End Class