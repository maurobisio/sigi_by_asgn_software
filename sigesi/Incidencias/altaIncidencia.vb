Imports MySql.Data.MySqlClient

Public Class altaIncidencia

    Private Sub formHijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimeFecha.Format = DateTimePickerFormat.Custom
        DateTimeFecha.CustomFormat = "yyyy-MM-dd"

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
            command = "SELECT id_tipo_incidencia, nom_tipo FROM tipo_incidencia;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "grupo")
            cboTipoIncidencia.DataSource = dataSet.Tables("grupo")
            cboTipoIncidencia.DisplayMember = "nom_tipo"
            cboTipoIncidencia.ValueMember = "id_tipo_incidencia"
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCiAlumno.Text = "" Or txtCiAutoridad.Text = "" Or txtObservacion.Text = "" Then
            MsgBox("Complete todos los campos")
        Else
            If userExist(txtCiAlumno.Text, "Alumno/a") Then
                If userExist(txtCiAutoridad.Text, "Supervisor") Or userExist(txtCiAutoridad.Text, "Bedel") Or userExist(txtCiAutoridad.Text, "Director/a") Or userExist(txtCiAutoridad.Text, "Administrativo/a") Or userExist(txtCiAutoridad.Text, "Docente") Then
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
                        command = "INSERT INTO incidencia(id_alumno, id_autoridad, id_tipo_incidencia, observación, fecha) "
                        command += "VALUES ('" + txtCiAlumno.Text
                        command += "', '" + txtCiAutoridad.Text
                        command += "', '" + cboTipoIncidencia.SelectedValue.ToString
                        command += "', '" + txtObservacion.Text
                        command += "', '" + DateTimeFecha.Text
                        command += " 10:12:00');"

                        dataAdapter = New MySqlDataAdapter(command, connection)
                        'Abrir la conexión
                        connection.Open()
                        'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                        dataAdapter.Fill(dataSet, "usuario")
                        MsgBox("Usuario ingresado correctamente")
                        Call LimpiarForm(Me)

                        connection.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("No existe ese usuario como autoridad en el sistema")
                End If
            Else
                MsgBox("No existe el alumno")
            End If
        End If
    End Sub

    Private Function userExist(ByVal ci As Integer, ByVal rol_name As String) As Boolean
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
            command = "SELECT * FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol "
            command += "WHERE usuario.ci=" + ci.ToString
            command += " AND rol.nombre_rol='" + rol_name.ToString
            command += "';"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "usuario")
            'cerreamos la conexión
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If (dataSet.Tables("usuario").Rows.Count <> 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtCi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCiAlumno.KeyPress
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class