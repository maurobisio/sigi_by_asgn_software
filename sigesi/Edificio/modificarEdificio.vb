﻿Imports MySql.Data.MySqlClient

Public Class modificarEdificio

    Private id_edificio As Integer

    Private Sub dgvModificarUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGrid()
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
            command = "SELECT id_edificio, tipo_edificio FROM edificio;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "edificio")
            dgvModificarEd.DataSource = dataSet
            dgvModificarEd.DataMember = "edificio"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub dgvModificarUsu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModificarEd.CellClick
        Dim i As Integer
        i = dgvModificarEd.CurrentRow.Index
        id_edificio = dgvModificarEd.Item(0, i).Value()
        txtNom.Text = dgvModificarEd.Item(1, i).Value()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtNom.Text = "" Then
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
                command = "UPDATE edificio SET "
                command += "tipo_edificio='" + txtNom.Text
                command += "' WHERE id_edificio='" + id_edificio.ToString + "';"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "edificio")
                MsgBox("Edificio modificado correctamente")
                Call LimpiarForm(Me)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Call LimpiarForm(Me)
            loadGrid()
            listarEdificio.loadGrid()
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)
    End Sub

    Private Sub txtNom1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCod_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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