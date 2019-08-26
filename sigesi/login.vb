Imports MySql.Data.MySqlClient

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

        Dim connection As New MySqlConnection
        Dim dataAdapter As New MySqlDataAdapter
        Dim dataSet As New DataSet
        Dim sql As String
        Dim switch As Boolean = False

        Try
            connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
            sql = "SELECT * FROM usuario WHERE email='" & txtUsu.Text & "' and pass='" & txtPwd.Text & "';"
            MessageBox.Show(sql)
            dataAdapter = New MySqlDataAdapter(sql, connection)
            connection.Open()
            dataAdapter.Fill(dataSet, "usuario")
            If (dataSet.Tables("usuario").Rows.Count <> 0) Then
                'Encontro un usuario'
                Dim reader = dataAdapter
                MessageBox.Show("Bienviendo al Sistema" & , "Sistema")
                switch = True
            Else
                MessageBox.Show("Usuario y/o Passoword no válidos", "Sistema")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        'Dim MiSingleton As Singleton = Singleton.Instance
        'Ejemplo de llamada de un Metodo de Singleton
        'MiSingleton.HacerAlgo()

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