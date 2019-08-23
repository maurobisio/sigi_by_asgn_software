Public Class login

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()


    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Hide()
        idioma.Show()



    End Sub

    Private Sub lblUsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsu.Click

    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        If txtUsu.Text = "" And txtPwd.Text = "" Then
            MsgBox("Ingrese nombre de Usuario y Contraseña")
        Else
            If txtUsu.Text = "" Then
                MsgBox("Ingrese nombre de Usuario ")
            ElseIf txtPwd.Text = "" Then
                MsgBox("Ingrese Contraseña")

            End If

        End If

        Dim MiSingleton As Singleton = Singleton.Instance
        'Ejemplo de llamada de un Metodo de Singleton
        MiSingleton.HacerAlgo()

        If txtUsu.Text = "docente" And txtPwd.Text = "docente" Then
            txtUsu.Text = ""
            txtPwd.Text = ""
            Me.Hide()
            menuDocente.Show()
        Else

        End If
        If txtUsu.Text = "director" And txtPwd.Text = "director" Then
            txtUsu.Text = ""
            txtPwd.Text = ""
            Me.Hide()

            menuDirector.Show()
        Else

        End If
        If txtUsu.Text = "root" And txtPwd.Text = "root" Then
            txtUsu.Text = ""
            txtPwd.Text = ""
            Me.Hide()
            menuAdminSistema.Show()
        Else

        End If
        If txtUsu.Text = "bedel" And txtPwd.Text = "bedel" Then
            txtUsu.Text = ""
            txtPwd.Text = ""
            Me.Hide()
            menuBedel.Show()
        Else

        End If
        If txtUsu.Text = "administrativo" And txtPwd.Text = "administrativo" Then
            txtUsu.Text = ""
            txtPwd.Text = ""
            Me.Hide()
            menuAdministrativo.Show()
        Else
            If txtUsu.Text = "alumno" And txtPwd.Text = "alumno" Then
                txtUsu.Text = ""
                txtPwd.Text = ""
                Me.Hide()
                menuAlumno.Show()
            Else
                If txtPwd.Text <> "" And txtUsu.Text <> "" Then


                    MsgBox("Contraseña o usuario incorretos")
                End If
            End If
        End If
    End Sub
End Class