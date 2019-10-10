Imports MySql.Data.MySqlClient

Public Class listarMateriaGrupo
    Dim id_tiene = DBNull.Value.ToString
    Private Sub datagridview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            command = "SELECT id_tiene, nombre_grupo, nom_materia FROM tiene INNER JOIN materia ON tiene.id_materia = materia.id_materia INNER JOIN grupo ON tiene.id_grupo = grupo.id_grupo;"
            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "tiene")
            dgvLIstarMatGrup.DataSource = dataSet
            dgvLIstarMatGrup.DataMember = "tiene"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Seguro desea dar de baja?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
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
                    connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                    command = "DELETE FROM tiene WHERE id_tiene= '" + id_tiene.ToString + "' ;"

                    dataAdapter = New MySqlDataAdapter(command, connection)
                    'Abrir la conexión
                    connection.Open()
                    'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                    dataAdapter.Fill(dataSet, "tiene")
                    MsgBox("Relación Materia - Grupo borrada correctamente")
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

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cierro todos los formularios
        Me.Close()
    End Sub

    Private Sub btnAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        altaMateriaGrupo.Show()
    End Sub

    Private Sub dgvLIstarMatGrup_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLIstarMatGrup.CellClick
        Dim i As Integer
        i = dgvLIstarMatGrup.CurrentRow.Index
        id_tiene = dgvLIstarMatGrup.Item(0, i).Value()
    End Sub
End Class