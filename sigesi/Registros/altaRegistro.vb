Imports MySql.Data.MySqlClient

Public Class altaRegistro
    Dim id_tiene As Integer
    Dim id_materia As Integer
    Dim id_grupo As Integer
    Dim nombre_rol As String
    Dim ci = DBNull.Value.ToString

    Private Sub formHijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DateTimeFecha.Format = DateTimePickerFormat.Custom
        DateTimeFecha.CustomFormat = "yyyy-MM-dd"

        cboRol.Items.Add("Docente")
        cboRol.Items.Add("Alumno/a")
        cboRol.SelectedIndex = 1

        id_grupo = Convert.ToInt32(cboGrupo.SelectedValue)
        id_materia = Convert.ToInt32(cboMateria.SelectedValue)

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
            command += "FROM (((tiene "
            command += "INNER JOIN pertenece ON tiene.id_tiene = pertenece.id_tiene) "
            command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
            command += "INNER JOIN rol ON usuario.id_rol = rol.id_rol) "
            command += "WHERE tiene.id_materia =" + id_materia.ToString
            command += " AND tiene.id_grupo =" + id_grupo.ToString
            command += " AND rol.nombre_rol = '" + cboRol.Text.ToString
            command += "' AND usuario.estado = '1'"
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

        'Establece la conexón con el orgien de los datos
        connection = New MySqlConnection
        'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
        dataAdapter = New MySqlDataAdapter
        'Contiene los datos resultantes de ejecutar el comando SQL.
        dataSet = New DataSet
        'Recupera datos del proceedor(SELECT * FROM ...)
        command = ""

        Try
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            command = "SELECT id_tipo_registro, nom_registro FROM tipo_registro;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "tipo_registro")
            cboTipoRegistro.DataSource = dataSet.Tables("tipo_registro")
            cboTipoRegistro.DisplayMember = "nom_registro"
            cboTipoRegistro.ValueMember = "id_tipo_registro"
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

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
            'MsgBox(command)
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

        If txtValor.Text = "" Then
            MsgBox("Complete el valor")
        Else
            If (ci.ToString <> DBNull.Value.ToString) Then

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
                    command = "INSERT INTO registro(id_pertenece, id_tipo_registro,valor, observacion, fecha) "
                    command += "VALUES ("
                    command += "(SELECT pertenece.id_pertenece "
                    command += "FROM (tiene "
                    command += "INNER JOIN pertenece ON tiene.id_tiene = pertenece.id_tiene) "
                    command += "WHERE tiene.id_grupo =" + id_grupo.ToString
                    command += " AND tiene.id_materia=" + id_materia.ToString
                    command += " AND pertenece.ci =" + ci.ToString
                    command += "), '" + cboTipoRegistro.SelectedValue.ToString
                    command += "', '" + txtValor.Text
                    command += "', '" + txtObservacion.Text
                    command += "', '" + DateTimeFecha.Text
                    command += " 10:12:00');"

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
            Else
                MsgBox("Selecciones una fila")
            End If
        End If
    End Sub

    Private Sub dgvListarAlumnos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarAlumnos.CellClick
        Dim i As Integer
        i = dgvListarAlumnos.CurrentRow.Index
        ci = dgvListarAlumnos.Item(0, i).Value()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        id_grupo = Convert.ToInt32(cboGrupo.SelectedValue)
        id_materia = Convert.ToInt32(cboMateria.SelectedValue)
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
            command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, usuario.apellido, usuario.email "
            command += "FROM (((tiene "
            command += "INNER JOIN pertenece ON tiene.id_tiene = pertenece.id_tiene) "
            command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
            command += "INNER JOIN rol ON usuario.id_rol = rol.id_rol) "
            command += "WHERE tiene.id_materia =" + id_materia.ToString
            command += " AND tiene.id_grupo =" + id_grupo.ToString
            command += " AND rol.nombre_rol = '" + cboRol.Text.ToString
            command += "' AND usuario.estado = '1'"
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
    End Sub
End Class