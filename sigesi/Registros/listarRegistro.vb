﻿
Imports MySql.Data.MySqlClient

Public Class listarRegistro
    Dim id_tiene As Integer
    Dim id_registro As Integer
    Dim id_materia As Integer
    Dim id_grupo As Integer
    Dim ci = DBNull.Value.ToString


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        menuBedel.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        'Tiene que controlar que no puede cursar Materias de Distintos Grupos en el mismo turno.
        altaRegistro.Show()

        'altaAlumno.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LimpiarForm(Me)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
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
            connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
            command = "SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, usuario.apellido, usuario.email "
            command += "FROM ((tiene "
            command += "INNER JOIN pertenece ON tiene.id_tiene = pertenece.id_tiene) "
            command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
            command += "WHERE(tiene.id_materia =" + id_materia.ToString
            command += " AND tiene.id_grupo =" + id_grupo.ToString
            command += " AND usuario.estado = '1'"
            command += ")"

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

    Private Sub listarInscripcion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        'Establece la conexón con el orgien de los datos
        connection = New MySqlConnection
        'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
        dataAdapter = New MySqlDataAdapter
        'Contiene los datos resultantes de ejecutar el comando SQL.
        dataSet = New DataSet
        'Recupera datos del proceedor(SELECT * FROM ...)
        command = ""
        Try
            connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
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
            connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
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

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro desea dar de baja el registro " + id_registro.ToString + "?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            If (id_tiene.ToString <> DBNull.Value.ToString) Then
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
                    command = "DELETE FROM registro "
                    command += "WHERE registro.id_registro = " + id_registro.ToString
                    command += ";"
                    'MsgBox(command)
                    dataAdapter = New MySqlDataAdapter(command, connection)
                    'Abrir la conexión
                    connection.Open()
                    'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                    dataAdapter.Fill(dataSet, "tiene")
                    MsgBox("Registro borrado correctamente")
                    Call LimpiarForm(Me)

                    connection.Close()
                    'dgvLoad()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Else
                MsgBox("Selecciones un Registro")
            End If
        End If
    End Sub

    Private Sub dgvListarAlumnos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarAlumnos.CellClick
        Dim i As Integer
        i = dgvListarAlumnos.CurrentRow.Index
        ci = dgvListarAlumnos.Item(0, i).Value()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar2.Click
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
                connection.ConnectionString = "server = " + sigesi.My.Resources.server + ";database= " + sigesi.My.Resources.databasename + "; user id=" + sigesi.My.Resources.userid + "; password=" + sigesi.My.Resources.password + ";"
                command = "SELECT registro.id_registro, tipo_registro.nom_registro, registro.valor, registro.fecha, registro.observacion "
                command += "FROM (((((((materia "
                command += "INNER JOIN tiene ON materia.id_materia = tiene.id_materia) "
                command += "INNER JOIN grupo ON grupo.id_grupo = tiene.id_grupo) "
                command += "INNER JOIN pertenece ON pertenece.id_tiene = tiene.id_tiene) "
                command += "INNER JOIN usuario ON usuario.ci = pertenece.ci) "
                command += "INNER JOIN rol ON usuario.id_rol = rol.id_rol) "
                command += "INNER JOIN registro ON registro.id_pertenece = pertenece.id_pertenece) "
                command += "INNER JOIN tipo_registro ON registro.id_tipo_registro = tipo_registro.id_tipo_registro) "
                command += "WHERE grupo.id_grupo =" + cboGrupo.SelectedValue.ToString
                command += " AND materia.id_materia =" + cboMateria.SelectedValue.ToString
                command += " AND rol.nombre_rol ='Alumno/a' AND usuario.ci=" + ci.ToString
                command += ";"
                'MsgBox(command)
                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "registro")
                dgvListarRegistros.DataSource = dataSet
                dgvListarRegistros.DataMember = "registro"

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Seleccione un usuario")
        End If
    End Sub


    Private Sub dgvListarRegistros_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarRegistros.CellClick
        Dim j As Integer
        j = dgvListarRegistros.CurrentRow.Index
        id_registro = dgvListarRegistros.Item(0, j).Value()
    End Sub
End Class