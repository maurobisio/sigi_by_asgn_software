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
    Private Function idioma_es()

        login.lblUsu.Text = sigesi.My.Resources.RecursoLenguajeESP.lblUsu
        login.lblPwd.Text = sigesi.My.Resources.RecursoLenguajeESP.lblPwd
        login.btnAtras.Text = sigesi.My.Resources.RecursoLenguajeESP.btnAtras
        login.btnEntrar.Text = sigesi.My.Resources.RecursoLenguajeESP.btnEntrar
        listarAlumno.gpbBuscarAlumnos.Text = sigesi.My.Resources.RecursoLenguajeESP.gpbBuscarAlumnos
    End Function



    Private Sub BtnEng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEng.Click

        System.Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("En")
        idioma_en()

        login.Show()
    End Sub
    Private Function idioma_en()
        '(nombre_del_formulario).(nombre_del_objeto).Text = (nombre_del_proyecto).My.Resources.(nombre_de_recursos).(nombre_del_objeto)

        selecUsu.lblSelecUsu.Text = sigesi.My.Resources.RecursoLenguajeENG.lblAdminSist
        selecUsu.lblAdministrativo.Text = sigesi.My.Resources.RecursoLenguajeENG.lblDirector
        login.lblUsu.Text = sigesi.My.Resources.RecursoLenguajeENG.lblUsu
        login.lblPwd.Text = sigesi.My.Resources.RecursoLenguajeENG.lblPwd
        login.btnAtras.Text = sigesi.My.Resources.RecursoLenguajeENG.btnAtras
        login.btnEntrar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnEntrar
        listarAlumno.gpbBuscarAlumnos.Text = sigesi.My.Resources.RecursoLenguajeENG.gpbBuscarAlumnos
        listarAlumno.lblCurso.Text = sigesi.My.Resources.RecursoLenguajeENG.lblCurso
        listarAlumno.btnBuscar.Text = sigesi.My.Resources.RecursoLenguajeENG.btnBuscar

    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class