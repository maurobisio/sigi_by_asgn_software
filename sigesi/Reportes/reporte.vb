Imports MySql.Data.MySqlClient

Public Class reporte

    Private Sub btnCantidadAlumnosGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCantidadAlumnosGrupo.Click
        menuAdminSistema.abrirFormPanel(cantidadAlumnosGrupo)
    End Sub

    Private Sub btnAlumnosMasUnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumnosMasUnGrupo.Click
        menuAdminSistema.abrirFormPanel(alumosMasUnGrupo)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarLosGrupos.Click
        menuAdminSistema.abrirFormPanel(listarGrupo)
    End Sub
End Class