'*******************************CODIGO PARA LA SEGUNDA ENTREGA DEL PROYECTO****************************************************
'Imports MySql.Data
'Imports MySql.Data.MySqlClient
Public Class altaAlumno


    '*******************************CODIGO PARA LA SEGUNDA ENTREGA DEL PROYECTO****************************************************

    ' Dim conexion As New MySqlConnection
    ' Dim datos As DataSet
    'Dim adaptador As New MySqlDataAdapter
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCI.TextChanged


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom1.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe1.KeyPress, txtApe2.KeyPress, txtNom2.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTurno.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedIndexChanged

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        '*******************************CODIGO PARA LA SEGUNDA ENTREGA DEL PROYECTO****************************************************
        'Try

        'conexion.ConnectionString = "Server=localhost;user=root;password=;database=sigesi"
        ' conexion.Open()
        ' Dim consulta As String
        'agrego en la tabla d la base
        'consulta = "insert into  alumnos (CI,Primer_nombre,Segundo_nombre,Primer_apellido,Segundo_apellido,Turno,Curso,Grado,telefono,Email,Grupo) values ('" + txtCI.Text + "','" + txtNom1.Text + "', '" + txtNom2.Text + "','" + txtApe1.Text + "','" + txtApe2.Text + "','" + cboTurno.Text + "','" + cboCurso.Text + "','" + cboGrado.Text + "','" + txtTel.Text + "','" + txtEmail.Text + "','" + cboGrupo.Text + "');"
        ' adaptador = New MySqlDataAdapter(consulta, conexion)
        'datos = New DataSet
        'adaptador.Fill(datos, "alumnos")


        'MsgBox("Alumno ingresado correctamente")
        'Catch ex As Exception
        'MsgBox(ex.Message)
        ' conexion.Close()

        'End Try
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is System.Windows.Forms.TextBox Then x.Text = ""
            If TypeOf x Is System.Windows.Forms.ComboBox Then x.Text = ""
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LimpiarForm(Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call LimpiarForm(Me)
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If txtCI.Text = "" Or txtApe1.Text = "" Or txtApe2.Text = "" Or txtEmail.Text = "" Or txtTel.Text = "" Or txtNom1.Text = "" Or txtNom2.Text = "" Or cboTurno.Text = "" Or cboCurso.Text = "" Or cboGrado.Text = "" Or cboGrupo.Text = "" Then
            MsgBox("Complete todos los campos")
        ElseIf MsgBox("Alumno ingresado") Then
            Call LimpiarForm(Me)
        End If
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is System.Windows.Forms.TextBox Then x.Text = ""
            If TypeOf x Is System.Windows.Forms.ComboBox Then x.Text = ""
        Next
    End Sub

    Private Sub txtNom1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom1.TextChanged

    End Sub

    Private Sub altaAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub cboTurno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTurno.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboCurso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCurso.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrupo.SelectedIndexChanged

    End Sub

    Private Sub cboGrado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGrado.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboGrupo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGrupo.KeyPress
        e.Handled = True
    End Sub
End Class