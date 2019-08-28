Public Class modificarAlumno

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Call LimpiarForm(Me)
        dtpFecha.Text = "14/07/2019"
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtApe1.Text = "" Or txtApe2.Text = "" Or txtCI.Text = "" Or txtEmail.Text = "" Or txtNom1.Text = "" Or txtNom2.Text = "" Or txtTel.Text = "" Or cboTurno.Text = "" Or cboCurso.Text = "" Or cboGrado.Text = "" Or cboGrupo.Text = "" Then

            MsgBox("Complete todos los campos")
        ElseIf dtpFecha.Text = "14/07/2019" Then
            MsgBox("Ingrese la fecha de nacimiento")
        ElseIf MsgBox("Se ah modificado el alumno") Then
            Call LimpiarForm(Me)
        End If

    End Sub

    Private Sub txtBuscarCi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCI.TextChanged
       

       
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl5.Click

    End Sub

    Private Sub txtNom1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom1.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub txtNom2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNom2.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub txtApe1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe1.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub txtApe2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe2.TextChanged

    End Sub

    Private Sub txtApe2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe2.KeyPress
        ' valido letras (hay que ir al evento key press y dentro del :)
        If Char.IsLetter(e.KeyChar) Then
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

    Private Sub cboTurno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTurno.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedIndexChanged

    End Sub

    Private Sub cboCurso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCurso.KeyPress
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub cboGrupo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGrupo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboGrado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboGrado.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtCI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
        ' valido numeros (hay que ir al evento key press y dentro del :)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If

    End Sub

    Private Sub modificarAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class