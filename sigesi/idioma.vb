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
        listarUsuarios.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

        modificarUsuario.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloModificarUsuario
        modificarUsuario.lblAyuda.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAyudaModificarUsuario
        'modificarUsuario.lblCi.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCi
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

        altaIncidencia.lblCiAlumno.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCiAlumno
        altaIncidencia.lblCiAutoridad.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCiAutoridad
        altaIncidencia.lblTipoIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTipoIncidencia
        altaIncidencia.lblFecha.Text = sigesi.My.Resources.RecursoLenguajeENG.lblFecha
        altaIncidencia.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAltaIncidencia
        altaIncidencia.lblObs.Text = sigesi.My.Resources.RecursoLenguajeENG.lblDesc
        altaIncidencia.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAgregar

        listaIncidencias.lblListaIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaIncidencia
        listaIncidencias.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listaIncidencias.btnBaja.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBaja
        listaIncidencias.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

        listarInscripcion.gpbBuscarInscripciones.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbBuscarInscripciones
        listarInscripcion.lblGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblGrupo
        listarInscripcion.lblMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.lblMateria
        listarInscripcion.lblListaAlumnos.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaAlumnos
        listarInscripcion.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listarInscripcion.btnEliminar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEliminar
        listarInscripcion.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

        altaInscripcion.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAgregarInscripcion
        altaInscripcion.gpbDatos.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbDatos
        altaInscripcion.lblGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblGrupo
        altaInscripcion.lblMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.lblMateria
        altaInscripcion.lblListaAlumnos.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaAlumnos
        altaInscripcion.lblNumeroLista.Text = sigesi.My.Resources.RecursoLenguajeENG.lblNumeroLista
        altaInscripcion.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        altaInscripcion.lblListaAlumnos.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaAlumnos

        listarRegistro.gpbBuscarInscripciones.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbBuscarInscripciones
        listarRegistro.lblGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblGrupo
        listarRegistro.lblMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.lblMateria
        listarRegistro.lblListaInscriptos.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaInscriptos
        listarRegistro.lblListaRegistros.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaRegistros
        listarRegistro.btnAlta.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        listarRegistro.btnEliminar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEliminar
        listarRegistro.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar
        listarRegistro.btnBuscar2.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

        altaRegistro.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloAgregarInscripcion
        altaRegistro.gpbBuscarAlumno.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbBuscarAlumno
        altaRegistro.lblGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblGrupo
        altaRegistro.lblMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.lblMateria
        altaRegistro.lblListaAlumnos.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaAlumnos
        altaRegistro.lblTipoRegistro.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTipoRegistro
        altaRegistro.lbValor.Text = sigesi.My.Resources.RecursoLenguajeENG.lbValor
        altaRegistro.lblObs.Text = sigesi.My.Resources.RecursoLenguajeENG.lblDesc
        altaRegistro.lblFecha.Text = sigesi.My.Resources.RecursoLenguajeENG.lblFecha
        altaRegistro.btnAgregar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlta
        altaRegistro.lblListaAlumnos.Text = sigesi.My.Resources.RecursoLenguajeENG.lblListaAlumnos
        altaRegistro.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

        reporte.btnListarLosGrupos.Text = sigesi.My.Resources.RecursoLenguajeENG.btnListarLosGrupos
        reporte.btnCantidadAlumnosGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCantidadAlumnosGrupo
        reporte.btnAlumnosMasUnGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAlumnosMasUnGrupo
        reporte.btnTipoYCantidadInsc.Text = sigesi.My.Resources.RecursoLenguajeENG.btnTipoYCantidadInsc
        reporte.btnTop10MasFaltas.Text = sigesi.My.Resources.RecursoLenguajeENG.btnTop10MasFaltas
        reporte.btnTop50MejoresNotas.Text = sigesi.My.Resources.RecursoLenguajeENG.btnTop50MejoresNotas
        reporte.btnDocentesDictandoUna.Text = sigesi.My.Resources.RecursoLenguajeENG.btnDocentesDictandoUna
        reporte.btnBoletin.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBoletin
        reporte.btnEscolaridad.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEscolaridad

        homeAdministrativo.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeAdministrativo
        homeAdminSIstema.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeAdminSistema
        homeBedel.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeBedel
        homeDIrector.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeDirector
        homeDocente.lblTitulo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblTituloHomeDirector

        menuAdministrativo.btnReportes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuAdministrativo.btnRegistro.Text = sigesi.My.Resources.RecursoLenguajeENG.btnRegistro
        menuAdministrativo.btnIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuAdministrativo.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuAdministrativo.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuAdminSistema.btnInscripcion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInscripcion
        menuAdminSistema.btnReportes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuAdminSistema.btnRegistro.Text = sigesi.My.Resources.RecursoLenguajeENG.btnRegistro
        menuAdminSistema.btnUsuarios.Text = sigesi.My.Resources.RecursoLenguajeENG.btnUsuario
        menuAdminSistema.btnMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateria
        menuAdminSistema.btnGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnGrupo
        menuAdminSistema.btnIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuAdminSistema.btnMateriaGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateriaGrupo
        menuAdminSistema.btnEdificio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEdificio
        menuAdminSistema.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuAdminSistema.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuAlumno.btnSolicitaBoletin.Text = sigesi.My.Resources.RecursoLenguajeENG.btnSolicitaBoletin
        menuAlumno.btnSolicitarEscolaridad.Text = sigesi.My.Resources.RecursoLenguajeENG.btnSolicitarEscolaridad
        menuAlumno.btnSolicitarFichaAcumulativa.Text = sigesi.My.Resources.RecursoLenguajeENG.btnSolicitarFichaAcumulativa
        menuAlumno.btnPaseEgreso.Text = sigesi.My.Resources.RecursoLenguajeENG.btnPaseEgreso
        menuAlumno.btnSolicitarFormula69.Text = sigesi.My.Resources.RecursoLenguajeENG.btnSolicitarFormula69
        menuAlumno.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuBedel.btnInscripcion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInscripcion
        menuBedel.btnReportes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuBedel.btnRegistro.Text = sigesi.My.Resources.RecursoLenguajeENG.btnRegistro
        menuBedel.btnMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateria
        menuBedel.btnGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnGrupo
        menuBedel.btnIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuBedel.btnMateriaGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateriaGrupo
        menuBedel.btnEdificio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEdificio
        menuBedel.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuBedel.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuDirector.btnInscripcion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInscripcion
        menuDirector.btnReportes.Text = sigesi.My.Resources.RecursoLenguajeENG.btnReportes
        menuDirector.btnRegistro.Text = sigesi.My.Resources.RecursoLenguajeENG.btnRegistro
        menuDirector.btnUsuarios.Text = sigesi.My.Resources.RecursoLenguajeENG.btnUsuario
        menuDirector.btnMateria.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateria
        menuDirector.btnGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnGrupo
        menuDirector.btnIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuDirector.btnMateriaGrupo.Text = sigesi.My.Resources.RecursoLenguajeENG.btnMateriaGrupo
        menuDirector.btnEdificio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEdificio
        menuDirector.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuDirector.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

        menuDocente.btnRegistro.Text = sigesi.My.Resources.RecursoLenguajeENG.btnRegistro
        menuDocente.btnIncidencia.Text = sigesi.My.Resources.RecursoLenguajeENG.btnIncidencias
        menuDocente.btnInicio.Text = sigesi.My.Resources.RecursoLenguajeENG.btnInicio
        menuDocente.btnCerrarSesion.Text = sigesi.My.Resources.RecursoLenguajeENG.btnCerrarSesion

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class