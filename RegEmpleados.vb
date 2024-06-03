Imports System.Data.SqlClient

Public Class RegEmpleados
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        TxtNumeroDeEmpleado.Text = ""
        TxtSectorDeTrabajo.Text = ""
        TxtNombreDeEmpleado.Text = ""
        TxtContraseña.Text = ""
        CBRolID.Text = ""
        TxtNumeroDeEmpleado.Focus()


    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If String.IsNullOrEmpty(TxtNumeroDeEmpleado.Text) Then
            Lblerror1.Visible = True
            TxtNumeroDeEmpleado.Focus()
            Return
        Else
            Lblerror1.Visible = False
        End If

        If String.IsNullOrEmpty(TxtSectorDeTrabajo.Text) Then
            LblError2.Visible = True
            TxtSectorDeTrabajo.Focus()
            Return
        Else
            LblError2.Visible = False
        End If

        If String.IsNullOrEmpty(TxtNombreDeEmpleado.Text) Then
            LblError3.Visible = True
            TxtNombreDeEmpleado.Focus()
            Return
        Else
            LblError3.Visible = False
        End If


        If String.IsNullOrEmpty(TxtContraseña.Text) Then
            LblError4.Visible = True
            TxtContraseña.Focus()
            Return
        Else
            LblError4.Visible = False
        End If


        If String.IsNullOrEmpty(CBRolID.Text) Then
            LblError5.Visible = True
            CBRolID.Focus()
            Return
        Else
            LblError5.Visible = False
        End If

        ' ... (validaciones de entrada) ...

        Dim conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
        Dim comando As New SqlCommand("SELECT * FROM RegEmpleados WHERE NumeroDeEmpleado = @NumeroDeEmpleado", conexion)
        comando.Parameters.Add(New SqlParameter("@NumeroDeEmpleado", TxtNumeroDeEmpleado.Text))
        conexion.Open()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        If reader.HasRows Then
            ' El valor ya existe en la base de datos, maneja el error aquí
            MessageBox.Show("Este Numero de empleado ya esta en uso")
            reader.Close()
            Return
        Else
            reader.Close()
            comando.CommandText = "RegistroDeEmpleados"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Clear()
            comando.Parameters.Add(New SqlParameter("@NombreDeEmpleado", TxtNombreDeEmpleado.Text))
            comando.Parameters.Add(New SqlParameter("@SectorDeTrabajo", TxtSectorDeTrabajo.Text))
            comando.Parameters.Add(New SqlParameter("@Contraseña", TxtContraseña.Text))
            comando.Parameters.Add(New SqlParameter("@CBRolID", CBRolID.Text))
            Dim rolID As Integer
            Select Case CBRolID.Text
                Case "Administrativo"
                    rolID = 1
                Case "Usuario"
                    rolID = 0
                Case Else
                    ' Manejar el caso en que no se seleccionó ninguna opción
            End Select

            comando.Parameters.Add(New SqlParameter("@Rol_ID", rolID))

            comando.ExecuteNonQuery()
        End If
        conexion.Close()

        ' ... (limpiar campos y enfocar el siguiente campo) ...
        TxtNumeroDeEmpleado.Text = ""
        TxtSectorDeTrabajo.Text = ""
        TxtNombreDeEmpleado.Text = ""
        TxtContraseña.Text = ""
        CBRolID.Text = ""
        TxtNumeroDeEmpleado.Focus()
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim MenuPrincipal As New MenuPrincipal()
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
    Private Sub BtnRegresarLogin_Click(sender As Object, e As EventArgs) Handles BtnRegresarLogin.Click
        Dim loginForm As New Login()
        loginForm.Show()
        TxtNumeroDeEmpleado.Text = ""
        TxtContraseña.Text = ""
        TxtNumeroDeEmpleado.Focus()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MenuAdministrativo As New MenuPrincipal()
        MenuAdministrativo.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnConsultarEmpleados.Click

    End Sub




    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Using conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
                Using comandoConsultar As New SqlCommand("EliminarEmpleados", conexion)
                    comandoConsultar.CommandType = CommandType.StoredProcedure
                    comandoConsultar.Parameters.Add(New SqlParameter("@NumeroDeEmpleado", TxtNumeroDeEmpleado.Text))
                    conexion.Open()
                    comandoConsultar.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Aquí puedes manejar la excepción, por ejemplo, mostrando un mensaje al usuario
            MessageBox.Show("Error al eliminar el empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Limpiar campos
        TxtNumeroDeEmpleado.Text = ""
        TxtSectorDeTrabajo.Text = ""
        TxtNombreDeEmpleado.Text = ""
        TxtContraseña.Text = ""
        CBRolID.Text = ""
        TxtNumeroDeEmpleado.Focus()
        'ContarEmpleados()
    End Sub



End Class