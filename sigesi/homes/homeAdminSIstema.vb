Public Class homeAdminSIstema


    Private Sub tmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFechaHora.Tick

        ' antes de codificar tengo q activar el timer , luego dentro del evento tick  coloco :
        lblHOra.Text = TimeOfDay
        lblFecha.Text = DateString
    End Sub

    Private Sub lblHOra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHOra.Click

    End Sub

    Private Sub homeAdminSIstema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class