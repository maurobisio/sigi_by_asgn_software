Public Class idioma
   

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEsp.Click

        System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("Es")
        idioma_es()
        Me.Hide()

        login.Show()

    End Sub
    Private Sub idioma_es()

        login.lblUsu.Text = sigesi.My.Resources.RecursoLenguajeESP.lblUsu
        login.lblPwd.Text = sigesi.My.Resources.RecursoLenguajeESP.lblPwd
        login.btnAtras.Text = sigesi.My.Resources.RecursoLenguajeESP.btnAtras
        login.btnEntrar.Text = sigesi.My.Resources.RecursoLenguajeESP.btnEntrar
        listarInscripcion.gpbBuscarAlumnos.Text = sigesi.My.Resources.RecursoLenguajeESP.gpbBuscarAlumnos
    End Sub



    Private Sub BtnEng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEng.Click

        System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("En")
        idioma_en()

        login.Show()
    End Sub
    Private Sub idioma_en()
        '(nombre_del_formulario).(nombre_del_objeto).Text = (nombre_del_proyecto).My.Resources.(nombre_de_recursos).(nombre_del_objeto)

        selecUsu.lblSelecUsu.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAdminSist
        selecUsu.lblAdministrativo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblDirector
        login.lblUsu.Text = sigesi.My.Resources.RecursoLenguajeENG.lblUsu
        login.lblPwd.Text = sigesi.My.Resources.RecursoLenguajeENG.lblPwd
        login.btnAtras.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAtras
        login.btnEntrar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEntrar
        listarInscripcion.gpbBuscarAlumnos.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbBuscarAlumnos
        listarInscripcion.lblCurso.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCurso
        listarInscripcion.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar
        altaEdificio.lblTitulo.Text
        altaEdificio.lblCod.Text
        altaEdificio.lblNom.Text
        altaEdificio.btnAgregar.Text

        bajaEdificio.lblTitulo.Text
        bajaEdificio.lblCod.Text
        bajaEdificio.btnCancelar.Text
        bajaEdificio.btnEliminar.Text

        listaEdificio.btnAlta.Text()
        listaEdificio.btnModificar.Text()
        listaEdificio.btnBaja.Text()

        modificarEdificio.lblTitulo.Text
        modificarEdificio.lblCod.Text
        modificarEdificio.lblNom.Text
        modificarEdificio.btnModificar.Text
        modificarEdificio.btnCancelar.Text
        modificarEdificio.lblAyuda.Text

        altaGrupo.lblTitulo.Text
        altaGrupo.lblCod.Text
        altaGrupo.lblNom.Text
        altaGrupo.lblTurno.Text
        altaGrupo.lblEdificio.Text
        altaGrupo.btnAgregar.Text

        bajaGrupo.lblTitulo.Text
        bajaGrupo.lblCod.Text
        bajaGrupo.btnCancelar.Text
        bajaGrupo.btnEliminar.Text

        listarGrupo.btnAlta.Text
        listarGrupo.btnModificar.Text
        listarGrupo.btnBaja.Text

        modificarGrupo.lblTitulo.Text
        modificarGrupo.lblCod.Text
        modificarGrupo.lblNom.Text
        modificarGrupo.lblTurno.Text
        modificarGrupo.lblEdificio.Text
        modificarGrupo.btnModificar.Text
        modificarGrupo.btnCancelar.Text
        modificarGrupo.lblAyuda.Text

        altaMateriaGrpo.lblTitulo.Text()
        altaMateriaGrpo.lblGrupo.Text()
        altaMateriaGrpo.lblMateria.Text()
        altaMateriaGrpo.btnAgregar.Text()

        listarMateriaGrupo.btnAlta.Text
        listarMateriaGrupo.btnBaja.Text()

        altaUsuario.lblTitulo.Text
        altaUsuario.lblCi.Text
        altaUsuario.lblNom.Text
        altaUsuario.lblNom1.Text
        altaUsuario.lblApe.Text
        altaUsuario.lblEmail.Text
        altaUsuario.lblTel.Text
        altaUsuario.lblDir.Text
        altaUsuario.lblRoll.Text
        altaUsuario.lblPwd.Text
        altaUsuario.btnAgregar.Text

        bajaUsuario.lblTitulo.Text
        bajaUsuario.lblCi.Text
        bajaUsuario.btnCancelar.Text
        bajaUsuario.btnEliminar.Text

        listarUsuario.btnAlta.Text()
        listarUsuario.btnModificars.Text()
        listarUsuario.btnBaja.Text()

        modificarUsuario.lblTitulo.Text
        modificarUsuario.lblAyuda.Text
        modificarUsuario.lblCi.Text
        modificarUsuario.lblNom.Text
        modificarUsuario.lblNom1.Text
        modificarUsuario.lblApe.Text
        modificarUsuario.lblEmail.Text
        modificarUsuario.lblTel.Text
        modificarUsuario.lblDir.Text
        modificarUsuario.lblRoll.Text
        modificarUsuario.lblPwd.Text
        modificarUsuario.btnCancelar.Text
        modificarUsuario.btnModificar.Text

        altaIncidencia.lblTitulo.Text
        altaIncidencia.lblCod.Text
        altaIncidencia.lblDesc.Text
        altaIncidencia.btnAgregar.Text

        listaIncidencias.gpbBuscarAlumnos.Text
        listaIncidencias.lblListaIncidencia.Text
        listaIncidencias.lblGrupo.Text
        listaIncidencias.lblMateria.Text
        listaIncidencias.lblAlumno.Text
        listaIncidencias.btnAlta.Text
        listaIncidencias.btnBaja.Text
        listaIncidencias.btnCancelar.Text
        listaIncidencias.btnBuscar.Text

        homeAdministrativo.lblTitulo.Text
        homeAdminSIstema.lblTitulo.Text
        homeBedel.lblTitulo.Text
        homeDIrector.lblTitulo.Text
        homeDocente.lblTitulo.Text

        menuAdministrativo.btnAlumno
        menuAdministrativo.btnIncidencias
        menuAdministrativo.btnInicio()
        menuAdministrativo.btnCerrarSesion

        menuAdminSistema.btnMateria
        menuAdminSistema.btnMateria
        menuAdminSistema.btnGrupo
        menuAdminSistema.btnIncidencias
        menuAdminSistema.btnMateriaGrupo
        menuAdminSistema.btnEdificio
        menuAdminSistema.btnInicio
        menuAdminSistema.btnCerrarSesion

        menuAlumno.btnCerrarSesion

        menuBedel.btnGestionInformes
        menuBedel.btnAlumno
        menuBedel.btnSalones
        menuBedel.btnIncidencias
        menuBedel.btnReportes
        menuBedel.btnGestiónEInformes()
        menuBedel.btnInicio
        menuBedel.btnCerrarSesion()

        menuDirector.btnAlumno()
        menuDirector.btnIncidencias
        menuDirector.btnReportes
        menuDirector.btnSalones
        menuDirector.btnGestionInformes
        menuDirector.btnInicio
        menuDirector.btnCerrarSesion

        menuDocente.btnReportes
        menuDocente.btnIncidencias
        menuDocente.btnInicio
        menuDocente.btnCerrarSesion


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class