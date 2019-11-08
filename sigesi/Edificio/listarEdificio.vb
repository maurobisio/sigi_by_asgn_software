Imports MySql.Data.MySqlClient

Public Class listarEdificio
    Private id_edificio = DBNull.Value.ToString
    Private Sub datagridview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGrid()
    End Sub

    Public Sub loadGrid()
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
            command = "SELECT id_edificio, tipo_edificio FROM edificio;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "edificio")
            dgvLIstarEdificio.DataSource = dataSet
            dgvLIstarEdificio.DataMember = "edificio"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If MessageBox.Show("¿Seguro desea dar de baja?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            If (id_edificio.ToString <> DBNull.Value.ToString) Then
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
                    command = "DELETE  FROM edificio  WHERE id_edificio= '" + id_edificio.ToString + "' ;"

                    dataAdapter = New MySqlDataAdapter(command, connection)
                    'Abrir la conexión
                    connection.Open()
                    'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                    dataAdapter.Fill(dataSet, "edificio")
                    MsgBox("Edificio borrado correctamente")
                    Call LimpiarForm(Me)

                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                loadGrid()
            Else
                MsgBox("Seleccione un edificio")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        modificarEdificio.Show()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cierro todos los formularios
        Me.Close()
    End Sub

    Private Sub btnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        altaEdificio.Show()
    End Sub

    Private Sub dgvLIstarEdificio_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLIstarEdificio.CellClick
        Dim i As Integer
        i = dgvLIstarEdificio.CurrentRow.Index
        id_edificio = dgvLIstarEdificio.Item(0, i).Value()
    End Sub
End Class