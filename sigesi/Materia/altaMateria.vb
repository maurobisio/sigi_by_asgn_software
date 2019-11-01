Imports MySql.Data.MySqlClient

Public Class altaMateria

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCod.Text = "" Or txtNom.Text = "" Or txtAño.Text = "" Then
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
                connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                command = "INSERT INTO materia (id_materia, nom_materia, año) "
                command += "VALUES ('" + txtCod.Text
                command += "', '" + txtNom.Text
                command += "', '" + txtAño.Text + "');"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "usuario")
                MsgBox("Materia ingresada correctamente")
                Call LimpiarForm(Me)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            listarMateria.loadGrid()
        End If
    End Sub
End Class