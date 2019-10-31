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
        listarInscripcion.gpbBuscarInscripciones.Text = sigesi.My.Resources.RecursoLenguajeESP.gpbBuscarAlumnos
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

        listarInscripcion.gpbBuscarInscripciones.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbBuscarInscripciones
        listarInscripcion.lblMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCurso
        listarInscripcion.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

        altaEdificio.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAltaEdificio
        altaEdificio.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        altaEdificio.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        altaEdificio.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAgregar

        bajaEdificio.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloBajaEdificio
        bajaEdificio.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        bajaEdificio.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        bajaEdificio.btnEliminar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEliminar

        listarEdificio.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja
        listarEdificio.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnModificar
        listarEdificio.btnBaja.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja

        modificarEdificio.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloModificarEdificio
        modificarEdificio.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        modificarEdificio.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        modificarEdificio.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnModificar
        modificarEdificio.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        modificarEdificio.lblAyuda.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAyudaModificarEdificio

        altaGrupo.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAltaGrupo
        altaGrupo.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        altaGrupo.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        altaGrupo.lblTurno.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTurno
        altaGrupo.lblEdificio.Text = sigesi.My.Resources.RecursoLenguajeENG.lblEdificio
        altaGrupo.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAgregar

        bajaGrupo.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloBajaGrupo
        bajaGrupo.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        bajaGrupo.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        bajaGrupo.btnEliminar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEliminar

        listarGrupo.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listarGrupo.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnModificar
        listarGrupo.btnBaja.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja

        modificarGrupo.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloModificarGrupo
        modificarGrupo.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        modificarGrupo.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        modificarGrupo.lblTurno.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTurno
        modificarGrupo.lblEdificio.Text = sigesi.My.Resources.RecursoLenguajeENG.lblEdificio
        modificarGrupo.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnModificar
        modificarGrupo.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        modificarGrupo.lblAyuda.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAyudaModificarGrupo

        altaMateria.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAltaGrupo
        altaMateria.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        altaMateria.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        altaMateria.lblYear.Text = sigesi.My.Resources.RecursoLenguajeENG.lblYear

        bajaMateria.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloBajaGrupo
        bajaMateria.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        bajaMateria.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        bajaMateria.btnEliminar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEliminar

        listarMateria.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listarMateria.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnModificar
        listarMateria.btnBaja.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja

        modificarMateria.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloModificarGrupo
        modificarMateria.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        modificarMateria.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        modificarMateria.lblYear.Text = sigesi.My.Resources.RecursoLenguajeENG.lblYear
        modificarMateria.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnModificar
        modificarMateria.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        modificarMateria.lblAyuda.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAyudaModificarGrupo

        altaMateriaGrupo.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAltaMateriaGrupo
        altaMateriaGrupo.lblGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblGrupo
        altaMateriaGrupo.lblMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.lblMateria
        altaMateriaGrupo.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAgregar

        listarMateriaGrupo.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listarMateriaGrupo.btnBaja.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja

        bajaMateriaGrupo.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloBajaMateriaGrupo
        bajaMateriaGrupo.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        bajaMateriaGrupo.btnEliminar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEliminar
        bajaMateriaGrupo.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar

        altaUsuario.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAltaUsuario
        altaUsuario.lblCi.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCi
        altaUsuario.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        altaUsuario.lblNom1.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom1
        altaUsuario.lblApe.Text = sigesi.My.Resources.RecursoLenguajeENG.lblApe
        altaUsuario.lblEmail.Text = sigesi.My.Resources.RecursoLenguajeENG.lblEmail
        altaUsuario.lblTel.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTel
        altaUsuario.lblDir.Text = sigesi.My.Resources.RecursoLenguajeENG.lblDir
        altaUsuario.lblRoll.Text = sigesi.My.Resources.RecursoLenguajeENG.lblRoll
        altaUsuario.lblPwd.Text = sigesi.My.Resources.RecursoLenguajeENG.lblPwd
        altaUsuario.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAgregar

        bajaUsuario.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloBajaUsuario
        bajaUsuario.lblCi.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCi
        bajaUsuario.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        bajaUsuario.btnEliminar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEliminar

        listarUsuarios.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listarUsuarios.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnModificar
        listarUsuarios.btnBaja.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja

        modificarUsuario.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloModificarUsuario
        modificarUsuario.lblAyuda.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAyudaModificarUsuario
        modificarUsuario.lblCi.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCi
        modificarUsuario.lblNom.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom
        modificarUsuario.lblNom1.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNom1
        modificarUsuario.lblApe.Text = sigesi.My.Resources.RecursoLenguajeENG.lblApe
        modificarUsuario.lblEmail.Text = sigesi.My.Resources.RecursoLenguajeENG.lblEmail
        modificarUsuario.lblTel.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTel
        modificarUsuario.lblDir.Text = sigesi.My.Resources.RecursoLenguajeENG.lblDir
        modificarUsuario.lblRoll.Text = sigesi.My.Resources.RecursoLenguajeENG.lblRoll
        modificarUsuario.lblPwd.Text = sigesi.My.Resources.RecursoLenguajeENG.lblPwd
        modificarUsuario.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        modificarUsuario.btnModificar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar

        altaIncidencia.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAltaIncidencia
        'altaIncidencia.lblCod.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCod
        altaIncidencia.lblObs.Text = sigesi.My.Resources.RecursoLenguajeENG.lblDesc
        altaIncidencia.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAgregar

        'listaIncidencias.gpbBuscarIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbBuscarIncidencia
        listaIncidencias.lblListaIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaIncidencia
        'listaIncidencias.lblGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblGrupo
        'listaIncidencias.lblMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.lblMateria
        'listaIncidencias.lblAlumno.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAlumno
        listaIncidencias.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listaIncidencias.btnBaja.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja
        'listaIncidencias.btnCancelar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCancelar
        listaIncidencias.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

        homeAdministrativo.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeAdministrativo
        homeAdminSIstema.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeAdminSistema
        homeBedel.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeBedel
        homeDIrector.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeDirector
        homeDocente.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeDirector

        menuAdministrativo.btnAlumno.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlumno
        menuAdministrativo.btnIncidencias.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuAdministrativo.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuAdministrativo.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuAdminSistema.btnUsuarios.Text = sigesi.My.Resources.RecursoLenguajeENG.btnUsuario
        menuAdminSistema.btnMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateria
        menuAdminSistema.btnGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnGrupo
        menuAdminSistema.btnIncidencias.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuAdminSistema.btnMateriaGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateriaGrupo
        menuAdminSistema.btnEdificio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEdificio
        menuAdminSistema.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuAdminSistema.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuAlumno.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuBedel.btnGestionInformes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnGestionInformes
        menuBedel.btnAlumno.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlumno
        menuBedel.btnSalones.Text = sigesi.My.Resources.RecursoLenguajeENG.btnSalones
        menuBedel.btnIncidencias.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuBedel.btnReportes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuBedel.btnGestionInformes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnGestionInformes
        menuBedel.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuBedel.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuDirector.btnAlumno.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlumno
        menuDirector.btnIncidencias.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuDirector.btnReportes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuDirector.btnSalones.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuDirector.btnGestionInformes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnGestionInformes
        menuDirector.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuDirector.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuDocente.btnReportes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuDocente.btnIncidencias.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuDocente.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuDocente.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class