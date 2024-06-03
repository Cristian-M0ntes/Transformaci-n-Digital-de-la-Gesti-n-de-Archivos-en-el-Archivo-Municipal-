Imports System.Data.SqlClient
Imports System.Data
Imports ArchivoMunicipal.MenuAdministrativo
Imports System.Windows.Forms

Public Class Login

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        '        Dim conexion As New SqlConnection("Data Source=DESKTOP-DJ2R74K; Initial Catalog=ArchivoMunicipal; Integrated Security=True")
        '        Dim command As New SqlCommand("SELECT * FROM RegEmpleados INNER JOIN Roles ON RegEmpleados.Rol_ID = Roles.Id_rol WHERE RegEmpleados.NumeroDeEmpleado=@NumeroDeEmpleado AND RegEmpleados.Contraseña=@Contraseña", conexion)
        '        command.Parameters.AddWithValue("@NumeroDeEmpleado", TxtNumeroDeEmpleado.Text)
        '        command.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text)
        '        conexion.Open()
        '        Dim reader As SqlDataReader = command.ExecuteReader()
        '        If reader.HasRows Then
        '            While reader.Read()
        '                Dim rol As Integer = reader("Id_rol")
        '                If rol = 1 Then
        '                    MenuAdministrativo.Show()
        '                ElseIf rol = 2 Then
        '                    MenuSecundario.Show()
        '                End If
        '            End While
        '        Else
        '            MessageBox.Show("Usuario o contraseña incorrectos.")
        '        End If
        '        reader.Close()
        ' ''       conexion.Close()

        '_________________________________OTRO CODIGO _____________________________------------

        '        If String.IsNullOrEmpty(TxtNumeroDeEmpleado.Text) OrElse
        '           String.IsNullOrEmpty(TxtContraseña.Text) Then
        '            ' Mostrar una alerta si uno o más campos están vacíos
        '            MessageBox.Show("Es necesario no dejar ningun campo vacio")
        '        Else
        '            'Response.Redirect("Menu.aspx")
        '            Dim conexion As New SqlConnection("Data Source=DESKTOP-3U2TNE3;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
        '            Dim comando As New SqlCommand("select NumeroDeEmpleado, Contraseña, Rol_ID from RegEmpleados where NumeroDeEmpleado=@NumeroDeEmpleado and Contraseña=@Contraseña", conexion)
        '            Dim comprobacion As New SqlCommand("select * from RegEmpleados qhere NumeroDeEmpleado=@NumeroDeEmpledo and Contraseña=@Contraseña", conexion)
        '            comando.CommandType = CommandType.Text
        '            comando.Parameters.Add(New SqlParameter("@NumeroDeEmpleado", TxtNumeroDeEmpleado.Text))
        '            comando.Parameters.Add(New SqlParameter("@Contraseña", TxtContraseña.Text))
        '            conexion.Open()
        '            Dim leer As SqlDataReader = comando.ExecuteReader()
        '            If leer.Read = True Then
        '                'El valor ya existe en la base de dato, maneja el error aqui
        '                If leer("Rol_ID").ToString() = 1 Then
        '                    'Se redirecciona a MenuAdministrativo
        '                    MenuAdministrativo.Show()
        '                    Me.Hide()
        '                End If
        '                If leer("Rol_ID").ToString() = 0 Then
        '                    MenuSecundario.Show()
        '                    Me.Hide()
        '
        '                End If
        '            End If
        '        End If
        '
        '    End Sub





        If String.IsNullOrEmpty(TxtNumeroDeEmpleado.Text) OrElse
              String.IsNullOrEmpty(TxtContraseña.Text) Then

            ' Mostrar una alerta si uno o más campos están vacíos
            MessageBox.Show("Es necesario no dejar ningun campo vacio")
        Else
            Dim conexion As New SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
            Dim comando As New SqlCommand("SELECT * FROM RegEmpleados WHERE NumeroDeEmpleado=@NumeroDeEmpleado AND Contraseña=@Contraseña", conexion)
            comando.Parameters.Add(New SqlParameter("@NumeroDeEmpleado", TxtNumeroDeEmpleado.Text))
            comando.Parameters.Add(New SqlParameter("@Contraseña", TxtContraseña.Text))
            conexion.Open()
            Dim leer As SqlDataReader = comando.ExecuteReader()
            If leer.HasRows Then
                leer.Read()
                ' El número de empleado y la contraseña coinciden en la base de datos, permite el acceso
                If leer("Rol_ID").ToString() = 1 Then
                    ' Se redirecciona a MenuAdministrativo
                    MenuAdministrativo.Show()
                    Me.Hide()
                ElseIf leer("Rol_ID").ToString() = 0 Then
                    MenuSecundario.Show()
                    Me.Hide()
                End If
            Else
                ' El número de empleado y la contraseña no coinciden en la base de datos, muestra un mensaje de error
                MessageBox.Show("La contraseña ingresada no coincide con el número de usuario.")
                leer.Close()
                conexion.Close()
            End If
        End If



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim RegEmpleados As New RegEmpleados()
        RegEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim MenuPrincipal As New MenuPrincipal()
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Si el formulario se está cerrando debido a una acción del usuario (no porque la aplicación está cerrándose), entonces terminamos la sesión
        ' Verificar si la razón de cierre fue causada por el usuario
        ' Verificar si la razón de cierre fue causada por el usuario
        ' Establecer la variable de sesión como falsa
        '        Program.IsSessionActive = False
        ' Mostrar el formulario de inicio de sesión y ocultar el formulario actual
        Dim loginForm As New MenuPrincipal()
        loginForm.Show()
        TxtNumeroDeEmpleado.Text = ""
        TxtContraseña.Text = ""
        TxtNumeroDeEmpleado.Focus()
        Me.Hide()
        ' Cancelar el cierre del formulario principal para evitar que la aplicación se cierre completamente

    End Sub





    '    Public Class FrmPrincipal
    '        ' Evento que se dispara cuando el formulario está a punto de cerrarse
    '        Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Button1.Click
    '            ' Si el formulario se está cerrando debido a una acción del usuario (por ejemplo, al hacer clic en el botón de cierre del formulario), entonces terminamos la sesión
    '            If e.CloseReason = CloseReason.UserClosing Then
    '                ' Establecer la variable de sesión como falsa
    '                Program.IsSessionActive = False
    '                ' Mostrar el formulario de inicio de sesión y ocultar el formulario actual
    '                Dim loginForm As New Login()
    '                loginForm.Show()
    '                Me.Hide()
    '                ' Cancelar el cierre del formulario principal para evitar que la aplicación se cierre completamente
    '                e.Cancel = True
    '            End If
    '        End Sub

    '    Private Sub Hide()
    '            Throw New NotImplementedException()
    '        End Sub
    '    End Class


End Class


