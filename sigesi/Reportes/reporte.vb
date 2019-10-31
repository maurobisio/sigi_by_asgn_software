Imports MySql.Data.MySqlClient

Public Class reporte

    Private Sub btnCantidadAlumnosGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCantidadAlumnosGrupo.Click
        menuAdminSistema.abrirFormPanel(cantidadAlumnosGrupo)
    End Sub

    Private Sub btnAlumnosMasUnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumnosMasUnGrupo.Click
        alumosMasUnGrupo.gridLoad()
        menuAdminSistema.abrirFormPanel(alumosMasUnGrupo)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarLosGrupos.Click
        menuAdminSistema.abrirFormPanel(listarGrupo)
    End Sub

    Private Sub btnTipoYCantidadInsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoYCantidadInsc.Click
        menuAdminSistema.abrirFormPanel(cantidadIncidenciasPorTipo2019)
    End Sub

    Private Sub btnDocentesDictandoUna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocentesDictandoUna.Click
        menuAdminSistema.abrirFormPanel(docenteDictaSolaMateria)
    End Sub

    Private Sub btnTop10MasFaltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop10MasFaltas.Click
        menuAdminSistema.abrirFormPanel(top10AlumnosMasFaltas)
    End Sub

    Private Sub btnTop50MejoresNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop50MejoresNotas.Click
        menuAdminSistema.abrirFormPanel(top50AlumnosMejorNota)
    End Sub

    Private Sub btnBoletin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoletin.Click
        menuAdminSistema.abrirFormPanel(boletin)
    End Sub

    Private Sub btnEscolaridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscolaridad.Click
        menuAdminSistema.abrirFormPanel(escolaridad)
    End Sub
End Class