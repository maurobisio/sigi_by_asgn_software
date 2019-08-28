Public Class homeAdministrativo

    Private Sub tmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFechaHora.Tick

        ' antes de codificar tengo q activar el timer , luego dentro del evento tick  coloco :
        lblHOra.Text = TimeOfDay
        lblFecha.Text = DateString
    End Sub
End Class