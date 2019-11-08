Imports MySql.Data.MySqlClient

Public Class modificarIncidencia

    Dim id_incidencia = DBNull.Value.ToString

    Private Sub dgvModificarUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
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

    Private Sub dgvModificarUsu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarIncidencias.CellClick
        Dim i As Integer
        i = dgvListarIncidencias.CurrentRow.Index
        id_incidencia = dgvListarIncidencias.Item(0, i).Value()
        cboTipoIncidencia.SelectedValue = dgvListarIncidencias.Item(1, i).Value()
        txtObservacion.Text = dgvListarIncidencias.Item(3, i).Value()
        DateTimeFecha.Text = dgvListarIncidencias.Item(4, i).Value()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtObservacion.Text = "" Or DateTimeFecha.Text = "" Then
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
                command = "UPDATE incidencia SET "
                command += "id_tipo_incidencia='" + cboTipoIncidencia.SelectedValue.ToString
                command += "' , observación='" + txtObservacion.Text.ToString
                command += "' , fecha='" + DateTimeFecha.Text
                command += " 10:12:00' "
                command += "WHERE incidencia.id_incidencia ='" + id_incidencia.ToString + "';"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "incidencia")
                MsgBox("Incidencia modificada correctamente")

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            loadGrid(txtCi.Text)
            listarUsuarios.gridLoad()
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)
    End Sub

    Private Sub txtCi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If (txtCi.Text = "") Then
            MsgBox("Ingrese una cedula de identidad valida")
        Else
            loadGrid(txtCi.Text)
        End If
    End Sub

    Private Sub loadGrid(ByVal id_alumno As String)
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
            command = "SELECT incidencia.id_incidencia, incidencia.id_tipo_incidencia, tipo_incidencia.nom_tipo, incidencia.observación, incidencia.fecha, incidencia.id_autoridad, usuario.primer_nombre, usuario.segundo_nombre "
            command += "FROM ((incidencia "
            command += "INNER JOIN usuario ON usuario.ci = incidencia.id_autoridad) "
            command += "INNER JOIN tipo_incidencia ON incidencia.id_tipo_incidencia = tipo_incidencia.id_tipo_incidencia) "
            command += "WHERE incidencia.id_alumno =" + id_alumno.ToString
            command += ";"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "incidencia")
            dgvListarIncidencias.DataSource = dataSet
            dgvListarIncidencias.DataMember = "incidencia"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class