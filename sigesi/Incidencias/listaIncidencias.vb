
Imports MySql.Data.MySqlClient

Public Class listaIncidencias

    Dim id_incidencia = DBNull.Value.ToString
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        menuBedel.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        altaIncidencia.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'modificarAlumno.Show()
    End Sub

    Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If (txtCi.Text = "") Then
            MsgBox("Ingrese una cedula de identidad valida")
        Else
            loadGrid(txtCi.Text)
        End If
    End Sub

    Private Sub loadGrid(ByVal id_incidencia As String)
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
            command = "SELECT incidencia.id_incidencia, tipo_incidencia.nom_tipo, incidencia.observación, incidencia.fecha, incidencia.id_autoridad, usuario.primer_nombre, usuario.segundo_nombre "
            command += "FROM ((incidencia "
            command += "INNER JOIN usuario ON usuario.ci = incidencia.id_autoridad) "
            command += "INNER JOIN tipo_incidencia ON incidencia.id_tipo_incidencia = tipo_incidencia.id_tipo_incidencia) "
            command += "WHERE incidencia.id_alumno =" + id_incidencia.ToString
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

    Private Sub dgvListarIncidencias_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarIncidencias.CellClick
        Dim i As Integer
        i = dgvListarIncidencias.CurrentRow.Index
        id_incidencia = dgvListarIncidencias.Item(0, i).Value()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If MessageBox.Show("¿Seguro desea dar de baja?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            If (id_incidencia.ToString <> DBNull.Value.ToString) Then
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
                    command = "DELETE FROM incidencia "
                    command += "WHERE incidencia.id_incidencia =" + id_incidencia.ToString
                    command += ";"

                    dataAdapter = New MySqlDataAdapter(command, connection)
                    'Abrir la conexión
                    connection.Open()
                    'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                    dataAdapter.Fill(dataSet, "tiene")
                    MsgBox("Incidencia borrada correctamente")
                    loadGrid(txtCi.Text)

                    connection.Close()
                    'dgvLoad()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Else
                MsgBox("Selecciones una fila")
            End If
        End If
    End Sub
End Class