Public Class GestioneInformes

    Private Sub cboCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedIndexChanged

    End Sub

    Private Sub cboGrupo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGrupo.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboCurso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCurso.KeyPress
        e.Handled = True

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpbGestionar.Enter

    End Sub
End Class