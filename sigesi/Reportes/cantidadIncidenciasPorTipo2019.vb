Imports MySql.Data.MySqlClient

Public Class cantidadIncidenciasPorTipo2019

    
    Private Sub cantidadAlumnosGrupo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            command = "SELECT tipo_incidencia.id_tipo_incidencia, tipo_incidencia.nom_tipo, COUNT(incidencia.id_incidencia) "
            command += "FROM (incidencia "
            command += "INNER JOIN tipo_incidencia ON tipo_incidencia.id_tipo_incidencia = incidencia.id_tipo_incidencia) "
            command += "WHERE YEAR(incidencia.fecha) = '2019' "
            command += "GROUP BY tipo_incidencia.id_tipo_incidencia "
            command += "HAVING(COUNT(incidencia.id_incidencia));"

            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "grupo")
            dgvLIstarCantidad.DataSource = dataSet
            dgvLIstarCantidad.DataMember = "grupo"

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class