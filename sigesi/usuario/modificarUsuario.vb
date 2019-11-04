Imports MySql.Data.MySqlClient

Public Class modificarUsuario

    Shared Property rol As Object
    Private ci As Integer

    Private Sub dgvModificarUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGrid()
    End Sub

    Sub loadGrid()
        'Establece la conexón con el orgien de los datos
        Dim connection As New MySqlConnection
        'Representa un conjunto de comandos SQL y una conexión al origen de datos para rellenar el objeto DataSet y actualizar los datos
        Dim dataAdapter As New MySqlDataAdapter
        'Contiene los datos resultantes de ejecutar el comando SQL.
        Dim dataSet As New DataSet
        'Recupera datos del proceedor(SELECT * FROM ...)
        Dim command As String

        If rol = 2 Or rol = 3 Then
            Try
                connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                command = "SELECT ci, primer_nombre, segundo_nombre,apellido, direccion, email, telefono, pass, nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol "
                command += "WHERE estado = '1'"
                command += " AND rol.nombre_rol ='Alumno/a';"
                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "usuario")
                dgvModificarUsu.DataSource = dataSet
                dgvModificarUsu.DataMember = "usuario"

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Try
                connection.ConnectionString = "server = localhost;database= sigesi; user id=root; password=root;"
                command = "SELECT ci, primer_nombre, segundo_nombre,apellido, direccion, email, telefono, pass, nombre_rol FROM usuario INNER JOIN rol ON usuario.id_rol = rol.id_rol "
                command += "WHERE estado = '1'"
                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "usuario")
                dgvModificarUsu.DataSource = dataSet
                dgvModificarUsu.DataMember = "usuario"

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub h_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgvModificarUsu_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvModificarUsu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModificarUsu.CellClick
        Dim i As Integer
        i = dgvModificarUsu.CurrentRow.Index
        ci = dgvModificarUsu.Item(0, i).Value()
        txtApe.Text = dgvModificarUsu.Item(3, i).Value()
        txtNom.Text = dgvModificarUsu.Item(1, i).Value()
        txtNom1.Text = dgvModificarUsu.Item(2, i).Value()
        txtDir.Text = dgvModificarUsu.Item(4, i).Value()
        txtEmail.Text = dgvModificarUsu.Item(5, i).Value()
        txtTel.Text = dgvModificarUsu.Item(6, i).Value()
        txtPwd.Text = dgvModificarUsu.Item(7, i).Value()
        cboRoll.Text = dgvModificarUsu.Item(8, i).Value()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtApe.Text = "" Or txtDir.Text = "" Or txtEmail.Text = "" Or txtNom.Text = "" Or txtPwd.Text = "" Or txtTel.Text = "" Or txtNom1.Text = "" Or cboRoll.Text = "" Then
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
                command = "UPDATE usuario SET "
                command += "ci='" + ci
                command += "', primer_nombre='" + txtNom.Text
                command += "', segundo_nombre='" + txtNom1.Text
                command += "', apellido='" + txtApe.Text
                command += "', direccion='" + txtDir.Text
                command += "', email='" + txtEmail.Text
                command += "', telefono='" + txtTel.Text
                command += "', pass='" + txtPwd.Text
                command += "', id_rol='" + rol
                command += "' WHERE ci='" + ci + "';"

                dataAdapter = New MySqlDataAdapter(command, connection)
                'Abrir la conexión
                connection.Open()
                'Llenamos el dataSet con el método Fill() del objeto dataAdapter
                dataAdapter.Fill(dataSet, "usuario")
                MsgBox("Usuario modificado correctamente")
                Call LimpiarForm(Me)

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Call LimpiarForm(Me)
            loadGrid()
            listarUsuarios.gridLoad()
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub dgvModificarUsu_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvModificarUsu.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)
    End Sub

    Private Sub txtCi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub lbl9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPwd.Click

    End Sub

    Private Sub txtCi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtApe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe.TextChanged

    End Sub

    Private Sub txtNom2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom1.TextChanged

    End Sub

    Private Sub lbl7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRoll.Click

    End Sub

    Private Sub cboRoll_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoll.SelectedIndexChanged

    End Sub

    Private Sub lbl5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTel.Click

    End Sub

    Private Sub lbl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNom.Click

    End Sub

    Private Sub lbl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblApe.Click

    End Sub

    Private Sub txtPwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub txtNom1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged

    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub lbl4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub txtDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDir.TextChanged

    End Sub

    Private Sub lbl6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDir.Click

    End Sub

    Private Sub txtTel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTel.TextChanged

    End Sub

    Private Sub lblTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub lblAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAyuda.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNom1.Click

    End Sub
End Class