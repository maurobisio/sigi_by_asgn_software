Public Class bajaSalon

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If (txtCod.Text = "") Then
            MsgBox("Ingrese el código del salón")
        ElseIf txtCod.Text <> "" Then
            MsgBox("Se ha eliminado el salón")
            txtCod.Text = ""

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtCod.Text = ""
    End Sub
End Class