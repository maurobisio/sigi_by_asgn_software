Imports MySql.Data.MySqlClient

Public Class altaInscripcion
    Dim id_tiene As Integer
    Dim id_materia As Integer
    Dim id_grupo As Integer
    Dim nombre_rol As String
    Dim ci = DBNull.Value.ToString

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
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            command = "SELECT id_grupo, nombre_grupo, turno FROM grupo;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "grupo")
            cboGrupo.DataSource = dataSet.Tables("grupo")
            cboGrupo.DisplayMember = "nombre_grupo"
            cboGrupo.ValueMember = "id_grupo"
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, usuario.apellido, usuario.email "
            command += "FROM (usuario "
            command += "INNER JOIN rol ON usuario.id_rol = rol.id_rol) "
            command += "WHERE rol.nombre_rol = 'Alumno/a'"
            command += " AND usuario.estado = '1'"
            command += ";"

            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "usuario")
            dgvListarAlumnos.DataSource = dataSet
            dgvListarAlumnos.DataMember = "usuario"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        cboRol.Items.Add("Docente")
        cboRol.Items.Add("Alumno/a")
        cboRol.SelectedIndex = 1


    End Sub

    Private Sub cboGrupo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrupo.TextChanged
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
            command = "SELECT materia.id_materia, materia.nom_materia "
            command += "FROM ((materia "
            command += "INNER JOIN tiene ON materia.id_materia = tiene.id_materia) "
            command += "INNER JOIN grupo ON grupo.id_grupo = tiene.id_grupo) "
            command += "WHERE grupo.id_grupo ='" + cboGrupo.SelectedValue.ToString
            command += "';"

            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "materia")
            cboMateria.DataSource = dataSet.Tables("materia")
            cboMateria.DisplayMember = "nom_materia"
            cboMateria.ValueMember = "id_materia"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        id_grupo = Convert.ToInt32(cboGrupo.SelectedValue)
        id_materia = Convert.ToInt32(cboMateria.SelectedValue)

        If txtLista.Text = "" Then
            MsgBox("Complete el número de lista")
        Else
            If (ci.ToString <> DBNull.Value.ToString) Then
                If (Not usuarioInscripto()) Then
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
                        command = "INSERT INTO pertenece (ci, id_tiene, nro_lista)"
                        command += "VALUES ('" + ci.ToString
                        command += "',(SELECT id_tiene FROM tiene "
                        command += "WHERE tiene.id_grupo =" + id_grupo.ToString
                        command += " AND tiene.id_materia =" + id_materia.ToString
                        command += "),'" + txtLista.Text
                        command += "');"

                        dataAdapter = New MySqlDataAdapter(command, connection)
                        'Abrir la conexión
                        connection.Open()
                        'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                        dataAdapter.Fill(dataSet, "edificio")
                        MsgBox("Inscripción ingresada correctamente")
                        Call LimpiarForm(Me)

                        connection.Close()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    listarInscripcion.gridLoad()
                Else
                    MsgBox("El usuario ya esta inscripto a la materia")
                End If

            Else
                MsgBox("Selecciones una fila")
            End If
        End If
    End Sub

    Private Function usuarioInscripto() As Boolean
        'controlar si no son vacios
        id_grupo = Convert.ToInt32(cboGrupo.SelectedValue)
        id_materia = Convert.ToInt32(cboMateria.SelectedValue)
        'MsgBox("grupo: " + cboGrupo.SelectedValue.ToString)
        'MsgBox("materia:" + cboMateria.SelectedValue.ToString)

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
            command = "SELECT * "
            command += "FROM ((tiene "
            command += "INNER JOIN pertenece ON tiene.id_tiene = pertenece.id_tiene) "
            command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
            command += "WHERE(tiene.id_materia =" + id_materia.ToString
            command += " AND tiene.id_grupo =" + id_grupo.ToString
            command += " AND pertenece.ci=" + ci.ToString
            command += ")"

            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "usuario")

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


    Private Sub dgvListarAlumnos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarAlumnos.CellClick
        Dim i As Integer
        i = dgvListarAlumnos.CurrentRow.Index
        ci = dgvListarAlumnos.Item(0, i).Value()
    End Sub

    Private Sub cboRol_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRol.TextChanged
        nombre_rol = cboRol.Text

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
            Command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, usuario.apellido, usuario.email "
            Command += "FROM (usuario "
            Command += "INNER JOIN rol ON usuario.id_rol = rol.id_rol) "
            command += "WHERE rol.nombre_rol = '" + nombre_rol.ToString
            command += "' AND usuario.estado = '1'"
            command += ";"

            dataAdapter = New MySqlDataAdapter(Command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(DataSet, "usuario")
            dgvListarAlumnos.DataSource = DataSet
            dgvListarAlumnos.DataMember = "usuario"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class