Public Class splash

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' codigo de la  barra de progresso
        'ACA PROGRAMO EL TIEMPO DE LA BARRA
        ProgressBar1.Increment(2)

        lblPorcentaje.Text = ProgressBar1.Value & (" %")

        If ProgressBar1.Value = 100 Then
            lblPorcentaje.Text = "FINALIZANDO"


            Timer1.Enabled = False
            Me.Hide()
            idioma.Show()

        End If
    End Sub

    Private Sub lblPorcentaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPorcentaje.Click

    End Sub
End Class