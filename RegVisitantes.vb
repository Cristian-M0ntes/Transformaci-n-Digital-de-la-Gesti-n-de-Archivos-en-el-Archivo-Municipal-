Imports System.Data.SqlClient

Public Class RegVisitantes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New MenuPrincipal()
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtClaveReceptor.Text = ""
        TxtCURP.Text = ""
        TxtNombre.Text = ""
        TxtApellidoPaterno.Text = ""
        TxtApellidoMaterno.Text = ""
        TxtCodigoPostalSeccional.Text = ""
        TxtCalle.Text = ""
        TxtColonia.Text = ""
        TxtNumeroCasa.Text = ""
        TxtCorreoElectronico.Text = ""
        TxtNumeroCelular.Text = ""
        TxtFechaRegistro.Text = ""
        TxtMotivoVisita.Text = ""
        TxtClaveReceptor.Focus()
    End Sub
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        '1
        If String.IsNullOrEmpty(TxtClaveReceptor.Text) Then
            LblError1.Visible = True
            TxtClaveReceptor.Focus()
            Return
        Else
            LblError1.Visible = False
        End If
        '1

        '2
        If String.IsNullOrEmpty(TxtCURP.Text) Then
            LblError2.Visible = True
            TxtCURP.Focus()
            Return
        Else
            LblError2.Visible = False
        End If
        '2

        '3
        If String.IsNullOrEmpty(TxtNombre.Text) Then
            LblError3.Visible = True
            TxtNombre.Focus()
            Return
        Else
            LblError3.Visible = False
        End If
        '3

        '4
        If String.IsNullOrEmpty(TxtApellidoPaterno.Text) Then
            LblError4.Visible = True
            TxtApellidoPaterno.Focus()
            Return
        Else
            LblError4.Visible = False
        End If
        '4
        '5
        If String.IsNullOrEmpty(TxtApellidoMaterno.Text) Then
            LblError5.Visible = True
            TxtApellidoMaterno.Focus()
            Return
        Else
            LblError5.Visible = False
        End If
        '5
        '6
        If String.IsNullOrEmpty(TxtCodigoPostalSeccional.Text) Then
            LblError6.Visible = True
            TxtCodigoPostalSeccional.Focus()
            Return
        Else
            LblError6.Visible = False
        End If
        '6
        '7
        If String.IsNullOrEmpty(TxtCalle.Text) Then
            LblError7.Visible = True
            TxtCalle.Focus()
            Return
        Else
            LblError7.Visible = False
        End If
        '7
        '8
        If String.IsNullOrEmpty(TxtColonia.Text) Then
            LblError8.Visible = True
            TxtColonia.Focus()
            Return
        Else
            LblError8.Visible = False
        End If
        '8
        '9
        If String.IsNullOrEmpty(TxtNumeroCasa.Text) Then
            LblError9.Visible = True
            TxtNumeroCasa.Focus()
            Return
        Else
            LblError9.Visible = False
        End If
        '9

        '10
        If String.IsNullOrEmpty(TxtCorreoElectronico.Text) Then
            LblError10.Visible = True
            TxtCorreoElectronico.Focus()
            Return
        Else
            LblError10.Visible = False
        End If
        '10

        '11
        If String.IsNullOrEmpty(TxtNumeroCelular.Text) Then
            LblError11.Visible = True
            TxtNumeroCelular.Focus()
            Return
        Else
            LblError11.Visible = False
        End If
        '11

        '12
        If String.IsNullOrEmpty(TxtFechaRegistro.Text) Then
            LblError12.Visible = True
            TxtFechaRegistro.Focus()
            Return
        Else
            LblError12.Visible = False
        End If
        '12

        '13
        If String.IsNullOrEmpty(TxtMotivoVisita.Text) Then
            LblError13.Visible = True
            TxtMotivoVisita.Focus()
            Return
        Else
            LblError13.Visible = False
        End If
        '13

        ' Verifica si el CURP ya existe en la base de datos
        Dim conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
        Dim comando As New SqlCommand("SELECT * FROM RegVisitantes WHERE CURP = @CURP", conexion)
        comando.Parameters.Add(New SqlParameter("@CURP", TxtCURP.Text))
        conexion.Open()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        If reader.HasRows Then
            ' El valor ya existe en la base de datos, maneja el error aquí
            MessageBox.Show("El CURP ya existe en la base de datos.")
            reader.Close()
            conexion.Close()
            Return
        End If
        reader.Close()
        ' Verifica si el Correo Electrónico ya existe en la base de datos
        comando.CommandText = "SELECT * FROM RegVisitantes WHERE CorreoElectronico = @CorreoElectronico"
        comando.Parameters.Clear()
        comando.Parameters.Add(New SqlParameter("@CorreoElectronico", TxtCorreoElectronico.Text))
        reader = comando.ExecuteReader()
        If reader.HasRows Then
            ' El valor ya existe en la base de datos, maneja el error aquí
            MessageBox.Show("El Correo Electrónico ya existe en la base de datos.")
            reader.Close()
            conexion.Close()
            Return
        End If
        reader.Close()
        conexion = New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
        comando = New SqlCommand("RegistroDeVisitantes", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New SqlParameter("@ClaveReceptor", TxtClaveReceptor.Text))
        comando.Parameters.Add(New SqlParameter("@CURP", TxtCURP.Text))
        comando.Parameters.Add(New SqlParameter("@Nombre", TxtNombre.Text))
        comando.Parameters.Add(New SqlParameter("@ApellidoPaterno", TxtApellidoPaterno.Text))
        comando.Parameters.Add(New SqlParameter("@ApellidoMaterno", TxtApellidoMaterno.Text))
        comando.Parameters.Add(New SqlParameter("@CodigoPostalSeccional", TxtCodigoPostalSeccional.Text))
        comando.Parameters.Add(New SqlParameter("@Calle", TxtCalle.Text))
        comando.Parameters.Add(New SqlParameter("@Colonia", TxtColonia.Text))
        comando.Parameters.Add(New SqlParameter("@NumeroCasa", TxtNumeroCasa.Text))
        comando.Parameters.Add(New SqlParameter("@CorreoElectronico", TxtCorreoElectronico.Text))
        comando.Parameters.Add(New SqlParameter("@NumeroCelular", TxtNumeroCelular.Text))
        Dim FechaRegistro As DateTime
        If DateTime.TryParse(TxtFechaRegistro.Text, FechaRegistro) Then
            comando.Parameters.Add(New SqlParameter("@FechaRegistro", FechaRegistro))
        Else
            MessageBox.Show("La fecha de registro no está en el formato correcto.")
            Return
        End If
        comando.Parameters.Add(New SqlParameter("@MotivoVisita", TxtMotivoVisita.Text))
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
        TxtClaveReceptor.Text = ""
        TxtCURP.Text = ""
        TxtNombre.Text = ""
        TxtApellidoPaterno.Text = ""
        TxtApellidoMaterno.Text = ""
        TxtCodigoPostalSeccional.Text = ""
        TxtCalle.Text = ""
        TxtColonia.Text = ""
        TxtNumeroCasa.Text = ""
        TxtCorreoElectronico.Text = ""
        TxtNumeroCelular.Text = ""
        TxtFechaRegistro.Text = ""
        TxtMotivoVisita.Text = ""
        TxtClaveReceptor.Focus()
        contarVisitantes()
    End Sub
    Public Sub contarVisitantes()
        Dim conexion As New SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
        Dim comando As New SqlCommand("Select count (*) from RegVisitantes ", conexion)
        comando.CommandType = CommandType.Text
        conexion.Open()
        Dim leer As SqlDataReader = comando.ExecuteReader
        If leer.Read Then
            LblTotal.Text = leer.Item(0).ToString
        End If
        conexion.Close()
    End Sub

    Private Sub RegVisitantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtClaveReceptor.Text = ""
        TxtCURP.Text = ""
        TxtNombre.Text = ""
        TxtApellidoPaterno.Text = ""
        TxtApellidoMaterno.Text = ""
        TxtCodigoPostalSeccional.Text = ""
        TxtCalle.Text = ""
        TxtColonia.Text = ""
        TxtNumeroCasa.Text = ""
        TxtCorreoElectronico.Text = ""
        TxtNumeroCelular.Text = ""
        TxtFechaRegistro.Text = ""
        TxtMotivoVisita.Text = ""
        TxtClaveReceptor.Focus()
    End Sub
End Class
