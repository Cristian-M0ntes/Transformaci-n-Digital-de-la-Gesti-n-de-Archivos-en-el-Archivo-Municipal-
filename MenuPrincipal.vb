Imports ArchivoMunicipal.MenuAdministrativo

Public Class MenuPrincipal
    '    Public Property TxtNumeroDeEmpleado As Object
    '    Public Property TxtContraseña As Object
    '
    '    'Variable global para acceder al valor de la session
    '    Public Class Program
    '        Public Shared IsSessionActive As Boolean = True
    '    End Class
    '
    '    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        If Not Program.IsSessionActive Then
    '            ' La sesión no está activa, redirige al usuario al formulario de inicio de sesión
    '            Dim loginForm As New Login()
    '            loginForm.Show()
    '            Me.Hide()
    '        End If
    '    End Sub
    '
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SalirToLogin.Click
        Dim SalirfromApp As DialogResult
        SalirfromApp = MessageBox.Show("SEGURO QUE DESEAS SALIR ?", "Confirmacion", MessageBoxButtons.YesNo)
        If SalirfromApp = DialogResult.Yes Then
            End
        Else
            MessageBox.Show("Has seleccionado No")
        End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿En este apartado podras registrarte para solicitar archivos?", "Confirmación", MessageBoxButtons.YesNo)

        If resultado = DialogResult.Yes Then
            Using Form2 As New RegVisitantes()
            End Using

            RegVisitantes.Show()
            Me.Hide()
        Else
            MessageBox.Show("Has seleccionado No")
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Seras dirigido al inicio de sesión de empleado?", "Confirmación", MessageBoxButtons.YesNo)

        If resultado = DialogResult.Yes Then
            Dim loginForm As New Login()

            If loginForm IsNot Nothing AndAlso Not String.IsNullOrEmpty(loginForm.TxtNumeroDeEmpleado.Text) AndAlso Not String.IsNullOrEmpty(loginForm.TxtContraseña.Text) Then
                loginForm.TxtNumeroDeEmpleado.Text = ""
                loginForm.TxtContraseña.Text = ""
                loginForm.TxtNumeroDeEmpleado.Focus()
            End If

            loginForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Has seleccionado No")
        End If
    End Sub




    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Dim Res As DialogResult
        Res = MessageBox.Show("¿Quieres hacer una consulta en los archivos municipales?", "Confirmacion", MessageBoxButtons.YesNo)
        If Res = DialogResult.Yes Then
            Dim irConsultas As New Consultas
            irConsultas.Show()
            Me.Hide()
        Else
            MessageBox.Show("Has seleccionado no Gracias ")

        End If


    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim Res As DialogResult
        Res = MessageBox.Show("¿Quieres hacer una consulta en Internet?", "Confirmacion", MessageBoxButtons.YesNo)
        If Res = DialogResult.Yes Then
            Dim Form2 As New ConsultasOnline
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Has seleccionado no Gracias ")

        End If

    End Sub
End Class