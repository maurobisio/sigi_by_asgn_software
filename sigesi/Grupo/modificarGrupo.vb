Imports MySql.Data.MySqlClient

Public Class modificarGrupo

    Private id_grupo As Integer

    Dim dataSetEdificio As New DataSet
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
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            command = "SELECT id_grupo, nombre_grupo, turno, tipo_edificio FROM grupo INNER JOIN edificio ON grupo.id_edificio = edificio.id_edificio;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "grupo")
            dgvModificarGru.DataSource = dataSet
            dgvModificarGru.DataMember = "grupo"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            command = "SELECT id_edificio, tipo_edificio FROM edificio;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSetEdificio, "edificio")
            ComboEdi.DataSource = dataSetEdificio.Tables("edificio")
            ComboEdi.DisplayMember = "tipo_edificio"
            ComboEdi.ValueMember = "tipo_edificio"
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub dgvModificarUsu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModificarGru.CellClick
        Dim i As Integer
        i = dgvModificarGru.CurrentRow.Index
        id_grupo = dgvModificarGru.Item(0, i).Value()
        txtNom1.Text = dgvModificarGru.Item(1, i).Value()
        txtturn.Text = dgvModificarGru.Item(2, i).Value()
        ComboEdi.Text = dgvModificarGru.Item(3, i).Value()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtNom1.Text = "" Or txtturn.Text = "" Or ComboEdi.Text = "" Then
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

            Dim dt As DataTable
            dt = dataSetEdificio.Tables("edificio")

            Dim rows = dt.Select("tipo_edificio ='" + ComboEdi.Text + "'")
            Dim id = 0
            For Each row In rows
                '' Do whatever with these records.
                '' e.g
                id = row("id_edificio")
            Next

            Try
                connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                command = "UPDATE grupo SET "
                command += "nombre_grupo='" + txtNom1.Text
                command += "', turno='" + txtturn.Text
                command += "', id_edificio='" + id.ToString
                command += "' WHERE id_grupo='" + id_grupo.ToString + "';"
                'id_edificio tiene que ser el id del texto seleccionado, para eso obtengo el id donde 

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "usuario")
                MsgBox("Grupo modificado correctamente")
                Call LimpiarForm(Me)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Call LimpiarForm(Me)
            loadGrid()
            listarGrupo.gridLoad()
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)
    End Sub


    Private Sub txtCod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNom1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class