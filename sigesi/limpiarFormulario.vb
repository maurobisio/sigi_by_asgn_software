Module limpiarFormulario
    Public Sub LimpiarForm(ByVal formulario As Form)

        'Recorremos todos los controles del formulario que enviamos  
        For Each control As Control In formulario.Controls


            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto  
            End If
            If TypeOf control Is ComboBox Then
                control.Text = "" ' eliminar el texto  
            End If
        Next
        'para poder llamarlo dentro de cualquier form: 
        'Call LimpiarForm(Me)
    End Sub


End Module
