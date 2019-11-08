
Imports MySql.Data.MySqlClient
Public Class modificarMateria
    Private id_materia As Integer
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtNom.Text = "" Or txtAño.Text = "" Then
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
                command = "UPDATE materia SET "
                command += "nom_materia='" + txtNom.Text
                command += "', año='" + txtAño.Text
                command += "' WHERE id_materia='" + id_materia.ToString + "';"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "materia")
                MsgBox("Materia modificada correctamente")
                Call LimpiarForm(Me)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Call LimpiarForm(Me)
            loadGrid()
            listarMateria.loadGrid()
        End If

    End Sub

    Sub loadGrid()
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
            command = "SELECT id_materia, nom_materia, año FROM materia;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "materia")
            dgvModificarUsu.DataSource = dataSet
            dgvModificarUsu.DataMember = "materia"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub modificarMateria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
    End Sub

    Private Sub dgvModificarUsu_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModificarUsu.CellClick
        Dim i As Integer
        i = dgvModificarUsu.CurrentRow.Index
        id_materia = dgvModificarUsu.Item(0, i).Value()
        txtNom.Text = dgvModificarUsu.Item(1, i).Value()
        txtAño.Text = dgvModificarUsu.Item(2, i).Value()
    End Sub
End Class