Public Class menuAlumno

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

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMail.Click
        MsgBox("Solicitud ingresada. En 24hs, llegara a su correo electronico")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        login.Show()

    End Sub
End Class