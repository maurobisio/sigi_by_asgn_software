Imports MySql.Data.MySqlClient

Public Class altaMateriaGrupo

    Private Sub formHijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            dgvListarMateria.DataSource = dataSet
            dgvListarMateria.DataMember = "materia"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
            command = "SELECT id_grupo, nombre_grupo, turno, tipo_edificio FROM grupo INNER JOIN edificio ON grupo.id_edificio = edificio.id_edificio;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "grupo")
            dgvLIstarGrupo.DataSource = dataSet
            dgvLIstarGrupo.DataMember = "grupo"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCodGrup.Text = "" Or txtCodMat.Text = "" Then
            MsgBox("Seleccióne grupo y materia")
        Else
            'Establece la conexón con el orgien de los datos
            Dim connection As New MySqlConnection
            'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
            Dim dataAdapter As New MySqlDataAdapter
            'Contiene los datos resultantes de ejecutar el comando SQL.
            Dim dataSet As New DataSet
            'Recupera datos del proceedor(SELECT * FROM ...)
            Dim command As String
            Dim existe As Boolean = False

            Try
                connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
                command = "SELECT * FROM tiene WHERE "
                command += "id_grupo=" + txtCodGrup.Text
                command += " and id_materia =" + txtCodMat.Text
                command += ";"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "tiene")
                existe = (dataSet.Tables("tiene").Rows.Count <> 0)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            If Not existe Then
                Try
                    connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
                    command = "INSERT INTO tiene (id_grupo, id_materia) "
                    command += "VALUES ('" + txtCodGrup.Text
                    command += "', '" + txtCodMat.Text
                    command += "');"

                    dataAdapter = New MySqlDataAdapter(command, connection)
                    'Abrir la conexión
                    connection.Open()
                    'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                    dataAdapter.Fill(dataSet, "tiene")
                    MsgBox("La materia se agrego al grupo correctamente")
                    Call LimpiarForm(Me)

                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Este grupo ya tiene a esta materia asociada")
            End If
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        listarMateriaGrupo.dgvLoad()
        Me.Close()
    End Sub

    Private Sub dgvLIstarGrupo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLIstarGrupo.CellClick
        Dim i As Integer
        i = dgvLIstarGrupo.CurrentRow.Index
        txtCodGrup.Text = dgvLIstarGrupo.Item(0, i).Value()
    End Sub

    Private Sub dgvListarMateria_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarMateria.CellClick
        Dim i As Integer
        i = dgvListarMateria.CurrentRow.Index
        txtCodMat.Text = dgvListarMateria.Item(0, i).Value()
    End Sub
End Class