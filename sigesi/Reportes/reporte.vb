Imports MySql.Data.MySqlClient

Public Class reporte

    Private Sub btnCantidadAlumnosGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCantidadAlumnosGrupo.Click
        menuAdminSistema.abrirFormPanel(New cantidadAlumnosGrupo)
    End Sub

    Private Sub btnAlumnosMasUnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumnosMasUnGrupo.Click
        'alumosMasUnGrupo.gridLoad()
        menuAdminSistema.abrirFormPanel(New alumosMasUnGrupo)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarLosGrupos.Click
        menuAdminSistema.abrirFormPanel(New listarGrupo)
    End Sub

    Private Sub btnTipoYCantidadInsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoYCantidadInsc.Click
        menuAdminSistema.abrirFormPanel(New cantidadIncidenciasPorTipo2019)
    End Sub

    Private Sub btnDocentesDictandoUna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocentesDictandoUna.Click
        menuAdminSistema.abrirFormPanel(New docenteDictaSolaMateria)
    End Sub

    Private Sub btnTop10MasFaltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop10MasFaltas.Click
        menuAdminSistema.abrirFormPanel(New top10AlumnosMasFaltas)
    End Sub

    Private Sub btnTop50MejoresNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop50MejoresNotas.Click
        menuAdminSistema.abrirFormPanel(New top50AlumnosMejorNota)
    End Sub

    Private Sub btnBoletin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoletin.Click
        menuAdminSistema.abrirFormPanel(New boletin)
    End Sub

    Private Sub btnEscolaridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscolaridad.Click
        menuAdminSistema.abrirFormPanel(New escolaridad)
    End Sub
End Class