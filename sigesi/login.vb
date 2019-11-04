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
            Else
                If txtPwd.Text = "" Then
                    MsgBox("Ingrese Contraseña")
                Else
                    If validate_ci(txtUsu.Text) Then
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
                            command = "SELECT * FROM usuario WHERE ci='" & txtUsu.Text & "' and pass='" & txtPwd.Text & "';"
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
                                        menuBedel.ci = dataSet.Tables("usuario").Rows(0)("ci")
                                    Case 3
                                        Me.Hide()
                                        menuAdministrativo.Show()
                                        menuAdministrativo.ci = dataSet.Tables("usuario").Rows(0)("ci")
                                    Case 4
                                        Me.Hide()
                                        menuDocente.Show()
                                    Case 5
                                        Me.Hide()

                                        menuAlumno.ci = dataSet.Tables("usuario").Rows(0)("ci")
                                        menuAlumno.Show()
                                End Select
                            Else
                                MsgBox("Ci y/o Contraseña no válidos", "Sistema")

                            End If
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    Else
                        MsgBox("La Ci ingresada no es valida")
                    End If
                End If
            End If
        End If
    End Sub

    Public Function clean_ci(ByVal ci As String) As String
        Return ci.Replace("-", "").Replace(".", "")
    End Function

    Public Function validation_digit(ByVal ci As String) As Integer
        Dim a As Integer = 0
        Dim i As Integer

        If Len(ci) <= 6 Then
            For i = Len(ci) To 6
                ci = "0" + ci
            Next
        End If

        For i = 0 To 6
            a += (Convert.ToInt32("" + "2987634"(i)) * Convert.ToInt32("" + ci(i)))
        Next

        a = a Mod 10
        If (a Mod 10 = 0) Then
            Return 0
        Else
            Return (10 - a) Mod 10
        End If

    End Function

    Function validate_ci(ByVal ci As String) As Boolean
        ci = Me.clean_ci(ci)
        Dim dig = Convert.ToInt32("" + ci(Len(ci) - 1))
        Dim pattern As String = "/[0-9]$/"
        Dim replacement As String = ""
        Dim rgx As Regex = New Regex(pattern)
        ci = rgx.Replace(ci, replacement)
        Return (dig = validation_digit(ci))
    End Function

End Class