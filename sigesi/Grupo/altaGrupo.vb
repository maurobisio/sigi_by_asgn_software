Imports MySql.Data.MySqlClient

Public Class altaGrupo

    Private Sub formHijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtApe.Text = "" Or txtCi.Text = "" Or txtDir.Text = "" Or txtEmail.Text = "" Or txtNom2.Text = "" Or cboRoll.Text = "" Or txtNom1.Text = "" Or txtPwd.Text = "" Or txtTel.Text = "" Then
            MsgBox("Complete todos los campos")
        Else
            'Establece la conexón con el orgien de los datos
            Dim connection As New MySqlConnection
            'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
            Dim dataAdapter As New MySqlDataAdapter
            'Contiene los datos resultantes de ejecutar el comando SQL.
            Dim dataSet As New DataSet
            'Recupera datos del proceedor(SELECT * FROM ...)
            Dim command As String

            Dim rol As String = ""
            Select Case cboRoll.Text
                Case "Administrador de sistema"
                    rol = "0"
                Case "Director/a"
                    rol = "1"
                Case "Bedel"
                    rol = "2"
                Case "Administrativo/a"
                    rol = "3"
                Case "Docente"
                    rol = "4"
                Case "Alumno/a"
                    rol = "5"
            End Select

            Try
                connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                command = "INSERT INTO usuario (ci, primer_nombre, segundo_nombre, apellido, direccion, email, pass, id_rol) "
                command += "VALUES ('" + txtCi.Text
                command += "', '" + txtNom1.Text
                command += "','" + txtNom2.Text
                command += "', '" + txtApe.Text
                command += "', '" + txtDir.Text
                command += "', '" + txtEmail.Text
                command += "', '" + txtPwd.Text
                command += "', '" + rol + "');"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "usuario")
                MsgBox("Usuario ingresado correctamente")
                Call LimpiarForm(Me)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If


        



        '*********************************** codigo para la segunda entrega del proyecto ******************************************************Try

        'conexion.ConnectionString = "Server=localhost;user=root;password=;database=isgesi"
        'conexion.Open()
        'Dim consulta As String
        'agrego en la tabla d la base
        'consulta = "insert into  usuarios (CI,Nombre,Apellido,Email,Teléfono,Dirección,Roll,Usuario,Contraseña) values ('" + txtCi.Text + "','" + txtNom.Text + "', '" + txtApe.Text + "','" + txtEmail.Text + "','" + txtTel.Text + "','" + txtDir.Text + "','" + cboRoll.Text + "','" + txtUsu.Text + "','" + txtPwd.Text + "');"
        ' adaptador = New MySqlDataAdapter(consulta, conexion)
        ' datos = New DataSet
        ' adaptador.Fill(datos, "usuarios")


        ' MsgBox("Usuario ingresado correctamente")
        ' Catch ex As Exception
        'MsgBox(ex.Message)
        'conexion.Close()

        'End Try
        'Dim x As Control
        'For Each x In Me.Controls
        'If TypeOf x Is System.Windows.Forms.TextBox Then x.Text = ""
        'If TypeOf x Is System.Windows.Forms.ComboBox Then x.Text = ""
        'Next

        

    End Sub

    Private Sub txtCi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCi.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtCi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCi.KeyPress
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If
    End Sub

    Private Sub txtTel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTel.TextChanged

    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If
    End Sub

    Private Sub txtNom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom1.KeyPress, txtApe.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub cboRoll_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRoll.KeyPress
        e.Handled = True

    End Sub
End Class