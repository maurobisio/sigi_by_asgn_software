Public Class reporteDocente

    Private Sub cboCurso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCurso.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboGrupo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGrupo.KeyPress
        e.Handled = True
    End Sub

    Private Sub reporteDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class