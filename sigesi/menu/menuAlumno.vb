
Imports MySql.Data.MySqlClient

Public Class menuAlumno

    Shared Property ci As Object

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub menuAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        login.Show()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        login.Close()


    End Sub

    Private Sub btnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub tmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFechaHora.Tick
        ' antes de codificar tengo q activar el timer , luego dentro del evento tick  coloco :
        lblHOra.Text = TimeOfDay
        lblFecha.Text = DateString
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Solicitud ingresada. En 24hs, llegara a su correo electronico")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        login.Show()

    End Sub

    Private Sub btnSolicitaBoletin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitaBoletin.Click
        If MessageBox.Show("¿Seguro desea Solicitar el boletin?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            altaIncidencia(4, "Solicitud de Boletin")
            MsgBox("Su solicitud fue realizada con existo")
        End If
    End Sub

    Private Sub btnSolicitarEscolaridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitarEscolaridad.Click
        If MessageBox.Show("¿Seguro desea Solicitar la escolaridad?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            altaIncidencia(6, "Escolaridad")
            MsgBox("Su solicitud fue realizada con existo")
        End If
    End Sub

    Private Sub btnSolicitarFichaAcumulativa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitarFichaAcumulativa.Click
        If MessageBox.Show("¿Seguro desea Solicitar la ficha acumulativa?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            altaIncidencia(8, "Ficha Acumulativa")
            MsgBox("Su solicitud fue realizada con existo")
        End If
    End Sub

    Private Sub btnPaseEgreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaseEgreso.Click
        If MessageBox.Show("¿Seguro desea Solicitar el pase de egreso?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            altaIncidencia(7, "Pase Egreso")
            MsgBox("Su solicitud fue realizada con existo")
        End If
    End Sub

    Private Sub btnSolicitarFormula69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitarFormula69.Click
        If MessageBox.Show("¿Seguro desea Solicitar la formula 69?", "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            altaIncidencia(5, "Formula 69")
            MsgBox("Su solicitud fue realizada con existo")
        End If
    End Sub

    Private Sub altaIncidencia(ByVal id_tipo_incidencia As Integer, ByVal nom_tipo As String)

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
            command = "INSERT INTO incidencia(id_alumno, id_autoridad, id_tipo_incidencia, observación, fecha) "
            command += "VALUES ('" + ci.ToString
            command += "', '" + "0"
            command += "', '" + id_tipo_incidencia.ToString
            command += "', '" + nom_tipo.ToString
            command += "', '" + DateTime.Now.ToString("yyyy-MM-dd")
            command += " 10:12:00');"

            dataAdapter = New MySqlDataAdapter(command, connection)
            'Abrir la conexión
            connection.Open()
            'Llenamos el dataSet con el método Fill() del objeto dataAdapter
            dataAdapter.Fill(dataSet, "incidencia")
            Call LimpiarForm(Me)

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class