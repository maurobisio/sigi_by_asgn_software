Public Class homeBedel

    Private Sub tmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFechaHora.Tick
       
        ' antes de codificar tengo q activar el timer , luego dentro del evento tick  coloco :
        lblHOra.Text = TimeOfDay
        lblFecha.Text = DateString
    End Sub
    Private Sub homeBedel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub lblHOra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHOra.Click

    End Sub

    Private Sub lblB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitulo.Click

    End Sub
End Class