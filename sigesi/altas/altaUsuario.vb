'*********************************** codigo para la segunda entrega del proyecto ******************************************************Imports MySql.Data
'Imports MySql.Data.MySqlClient


Public Class altaUsuario
    '*********************************** codigo para la segunda entrega del proyecto ******************************************************
    'Dim conexion As New MySqlConnection
    ' Dim datos As DataSet
    ' Dim adaptador As New MySqlDataAdapter
    Private Sub formHijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
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

        If txtApe.Text = "" Or txtCi.Text = "" Or txtDir.Text = "" Or txtEmail.Text = "" Or txtUsu.Text = "" Or cboRoll.Text = "" Or txtNom.Text = "" Or txtPwd.Text = "" Or txtTel.Text = "" Then

            MsgBox("Complete todos los campos")
        ElseIf MsgBox("Usuario ingresado") Then
            Call LimpiarForm(Me)

        End If

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