Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class altaUsuario

    Private Sub formHijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtApe.Text = "" Or txtCi.Text = "" Or txtDir.Text = "" Or txtEmail.Text = "" Or txtNom1.Text = "" Or cboRoll.Text = "" Or txtNom.Text = "" Or txtPwd.Text = "" Or txtTel.Text = "" Then
            MsgBox("Complete todos los campos")
        Else
            If validate_ci(txtCi.Text) Then
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
                    command += "', '" + txtNom.Text
                    command += "','" + txtNom1.Text
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
            Else
                MsgBox("La cedula de identidad es invalida")
            End If
        End If
    End Sub


    Dim provi As Integer, coefi As Integer, digito As Integer, resul As Integer, acum As Integer
    Dim cociente As Integer, codveri As Integer, cedula As String

    Public Function clean_ci(ByVal ci As String) As String
        Return ci.Replace("-", "").Replace(".", "")
    End Function

    Public Function validation_digit(ByVal ci As String) As Integer
        Dim a As Integer = 0
        Dim i As Integer

        MsgBox(Len(ci))
        MsgBox(ci)
        If Len(ci) <= 6 Then
            For i = Len(ci) To 6
                ci = "0" + ci
            Next
        End If

        For i = 0 To 6
            a += (Convert.ToInt32("" + "2987634"(i)) * Convert.ToInt32("" + ci(i)))
        Next
        MsgBox(a)
        a = a Mod 10
        MsgBox(a)
        If (a Mod 10 = 0) Then
            Return 0
        Else
            Return (10 - a) Mod 10
        End If

    End Function

    Function validate_ci(ByVal ci As String) As Boolean
        ci = Me.clean_ci(ci)
        Dim dig = Convert.ToInt32("" + ci(Len(ci) - 1))
        Dim pattern As String = "/[0-9]$/"
        Dim replacement As String = ""
        Dim rgx As Regex = New Regex(pattern)
        ci = rgx.Replace(ci, replacement)
        Return (dig = validation_digit(ci))
    End Function



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

    Private Sub txtNom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress, txtApe.KeyPress
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