Imports MySql.Data.MySqlClient

Public Class altaEdificio

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtNom.Text = "" Then
            MsgBox("Complete todos los campos")
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
                command = "INSERT INTO edificio (tipo_edificio) "
                command += "VALUES ('" + txtNom.Text
                command += "');"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "edificio")
                MsgBox("Edificio ingresado correctamente")
                Call LimpiarForm(Me)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            listarEdificio.loadGrid()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtCod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtNom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class