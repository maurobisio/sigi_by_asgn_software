Public Class menuAdministrativo

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tmrOcultarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOcultarMenu.Tick
        'hago 2 timer para que agrande o achique el panel izquierdo
        'sin el panel izquiero tiene un ancho menor q 60 
        If pnlIzquierda.Width <= 60 Then
            'deshabilito el timer q achica el panel izquierdo a 60 d ancho
            Me.tmrOcultarMenu.Enabled = False
        Else
            ' y le digo oa q velocidad d tiene q achicar
            Me.pnlIzquierda.Width = pnlIzquierda.Width - 160

        End If
    End Sub
    Public Sub abrirFormPanel(ByVal formHijo As Object)
        'creo metodo para abrir formularios dentro d el panel central
        ' valido q si tiene objetos dentro, q los remueva
        If Me.pnlCentral.Controls.Count > 0 Then
            Me.pnlCentral.Controls.RemoveAt(0)
        End If
        'creo variable de tipo Form, y este va a ser el parametro d entrada
        Dim formH As Form = TryCast(formHijo, Form)
        'cambio de nivel al formulario recibido para especificar q no es d nivel superior
        formH.TopLevel = False
        ' quito el estilo de borde al formulario
        formH.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'acoplo el fromulario al  tamaño del panel
        formH.Dock = DockStyle.Fill
        'agrego los controles del formulario al panel central
        Me.pnlCentral.Controls.Add(formH)
        ' le digo q el panel central va a tener los datos del formulario
        Me.pnlCentral.Tag = formH
        'muestro el formulario
        formH.Show()

    End Sub

    Private Sub tmrMostrarMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMostrarMenu.Tick
        'codifico el timer para controlar el panel izquierdo al apretar el boton de menu dentro del panel
        'aca hago al revez del timer anterior para q vuelva a su posicion
        If pnlIzquierda.Width >= 214 Then
            Me.tmrMostrarMenu.Enabled = False
        Else
            Me.pnlIzquierda.Width = pnlIzquierda.Width + 160

        End If
    End Sub

    Private Sub PctMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PctMenu.Click
        'codifico el boton: activo los timers y les pongo condicion dentro d if  con los valores del ancho del panel q pase en los timers
        If pnlIzquierda.Width = 214 Then
            tmrOcultarMenu.Enabled = True
        End If

        tmrMostrarMenu.Enabled = True
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

   
    Private Sub PnlCentral_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlCentral.Paint

    End Sub

    Private Sub menuAdministrativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        abrirFormPanel(New homeAdministrativo)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumno.Click
        abrirFormPanel(New listarAlumno)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncidencias.Click
        abrirFormPanel(New IncidenciasDocente)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncio.Click
        abrirFormPanel(New homeAdministrativo)
    End Sub
End Class