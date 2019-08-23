'*********************************** codigo para la segunda entrega del proyecto ******************************************************Imports MySql.Data
'Imports MySql.Data.MySqlClient
Public Class modificarUsuario
    ' Dim conexion As New MySqlConnection
    ' Dim datos As DataSet
    'Dim adaptador As New MySqlDataAdapter
   

    

    Private Sub dgvModificarUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '*********************************** codigo para la segunda entrega del proyecto ******************************************************
        ' Try

        'conexion.ConnectionString = "Server=localhost;user=root;password=;database=isgesi"
        'conexion.Open()
        'Dim consulta As String
        'consulta = "select * from usuarios"
        'adaptador = New MySqlDataAdapter(consulta, conexion)
        'datos = New DataSet
        'adaptador.Fill(datos, "usuarios")
        'dgvModificarUsu.DataSource = datos
        'dgvModificarUsu.DataMember = "usuarios"


        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub h_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
   
    End Sub

    Private Sub dgvModificarUsu_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvModificarUsu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModificarUsu.CellClick
        Dim i As Integer
        i = dgvModificarUsu.CurrentRow.Index
        txtCi.Text = dgvModificarUsu.Item(0, i).Value()
        txtApe.Text = dgvModificarUsu.Item(2, i).Value()
        txtNom.Text = dgvModificarUsu.Item(1, i).Value()
        txtDir.Text = dgvModificarUsu.Item(5, i).Value()
        txtEmail.Text = dgvModificarUsu.Item(3, i).Value()
        txtTel.Text = dgvModificarUsu.Item(4, i).Value()
        txtPwd.Text = dgvModificarUsu.Item(8, i).Value()
        txtUsu.Text = dgvModificarUsu.Item(7, i).Value()
        cboRoll.Text = dgvModificarUsu.Item(6, i).Value()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtApe.Text = "" Or txtCi.Text = "" Or txtDir.Text = "" Or txtEmail.Text = "" Or txtNom.Text = "" Or txtPwd.Text = "" Or txtTel.Text = "" Or txtUsu.Text = "" Or cboRoll.Text = "" Then
            MsgBox("Complete todos los campos")
        ElseIf MsgBox("Usuario modificado") Then
            Call LimpiarForm(Me)

        End If





        '*********************************** codigo para la segunda entrega del proyecto ****************************************************** Try

        'conexion.ConnectionString = "Server=localhost;user=root;password=;database=sigesi"
        ' conexion.Open()
        ' Dim consulta As String
        'agrego en la tabla d la base
        'consulta = "update  usuarios set Usu= '" & txtUsu.Text & "' where Usuario= '" & txtUsu.Text & "' and CI='" & txtCi.Text & "' "
        'adaptador = New MySqlDataAdapter(consulta, conexion)
        'datos = New DataSet
        'adaptador.Fill(datos, "usuarios")


        ' MsgBox("Usuario actualizado")

        'Catch ex As Exception
        'MsgBox(ex.Message)
        'conexion.Close()

        ' End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub dgvModificarUsu_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModificarUsu.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
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

    Private Sub cboRoll_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRoll.KeyPress
        e.Handled = True
    End Sub
End Class