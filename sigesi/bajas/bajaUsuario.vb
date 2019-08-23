'*****************codigo para la segunda entrega del proyecto******************
'Imports MySql.Data
'Imports MySql.Data.MySqlClient
Public Class bajaUsuario
    '*****************codigo para la segunda entrega del proyecto****************** 
    'Dim conexion As New MySqlConnection
    'Dim datos As DataSet
    'Dim adaptador As New MySqlDataAdapter
    'Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtCi.Text = "" And txtNom.Text = "" Then
            MsgBox("Ingrese nombre y codigo de usuario")

        ElseIf txtCi.Text = "" Then
            MsgBox("Ingrese el Codigo de usuario")
        ElseIf txtNom.Text = "" Then
            MsgBox("Ingrese nombre de usuario")

        Else

            '*****************codigo para la segunda entrega del proyecto******************
            'Try

            'conexion.ConnectionString = "Server=localhost;user=root;password=;database=gigante"
            'conexion.Open()
            'Dim consulta As String
            ''agrego en la tabla d la base
            'consulta = "delete  from usuarios  where usu= '" + txtNom.Text + "' ;"
            'adaptador = New MySqlDataAdapter(consulta, conexion)
            'datos = New DataSet
            'adaptador.Fill(datos, "usuarios")


            MsgBox("Se elimino el usuario")
            txtNom.Text = " "
            txtCi.Text = " "
            '*****************codigo para la segunda entrega del proyecto******************
            'conexion.Close()
            'Catch ex As Exception
            'MsgBox(ex.Message)
            'conexion.Close()

            'End Try
        End If

    End Sub
    Private Sub bajaDeUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub bajaDeUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMax.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCi.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)
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

    Private Sub txtNom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
       
    End Sub
End Class