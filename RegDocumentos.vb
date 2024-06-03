Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO



Public Class RegDocumentos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New MenuSecundario()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        TxtSerie.Text = ""
        TxtDepartamento.Text = ""
        TxtDocumentacion.Text = ""
        DateTimePicker1.Text = ""
        TxtUbicacionFisica.Text = ""
        TxtSerie.Focus()
    End Sub




    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If String.IsNullOrEmpty(TxtSerie.Text) Then
            LblError5.Visible = True
            TxtDepartamento.Focus()
            Return
        Else
            LblError5.Visible = False
        End If
        '1

        '2
        If String.IsNullOrEmpty(TxtSerie.Text) Then
            LblError1.Visible = True
            TxtSerie.Focus()
            Return
        Else
            LblError1.Visible = False
        End If
        '2

        '3
        If String.IsNullOrEmpty(TxtDepartamento.Text) Then
            LblError2.Visible = True
            TxtDepartamento.Focus()
            Return
        Else
            LblError2.Visible = False

        End If

        If String.IsNullOrEmpty(TxtDocumentacion.Text) Then
            LblError3.Visible = True
            TxtDocumentacion.Focus()
            Return
        Else
            LblError3.Visible = False
        End If
        '6
        '7
        If String.IsNullOrEmpty(DateTimePicker1.Text) Then
            LblError4.Visible = True
            DateTimePicker1.Focus()
            Return
        Else
            LblError4.Visible = False
        End If





        Dim nombrePDF As String = TxtDocumentacion.Text

        Using conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
            conexion.Open()

            ' Verificar si el nombre del PDF ya existe en la base de datos
            Dim consultaExistenciaPDF As New SqlCommand("IF EXISTS (SELECT  1 FROM RegNuevoDocumento WHERE Documentacion = @Documentacion) SELECT  1 ELSE SELECT  0", conexion)
            consultaExistenciaPDF.Parameters.AddWithValue("@Documentacion", nombrePDF)
            Dim resultado As Integer = consultaExistenciaPDF.ExecuteScalar()

            If resultado = 1 Then
                ' El valor ya existe en la base de datos, manejar el error aquí
                MessageBox.Show("El nombre de este documento ya existe en la base de datos.")
                Return
            Else
                ' Obtener la fecha del documento directamente desde DateTimePicker1
#Disable Warning S1481 ' Unused local variables should be removed
                Dim fechaDocumento As DateTime = DateTimePicker1.Value
#Enable Warning S1481 ' Unused local variables should be removed

                ' Registrar nuevos documentos en la base de datos
                Dim comando As New SqlCommand("RegistroDeNuevosDocumentos", conexion)
                comando.Parameters.Add(New SqlParameter("@Serie", TxtSerie.Text))
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add(New SqlParameter("@Documentacion", TxtDocumentacion.Text))
                comando.Parameters.Add(New SqlParameter("@Departamento", TxtDepartamento.Text))

                '               'Agregar el objeto DateTime directamente
                comando.Parameters.Add(New SqlParameter("@Año", DateTimePicker1.Value))
                comando.Parameters.Add(New SqlParameter("@UbicacionFisica", TxtUbicacionFisica.Text))
                ' Resto del código para agregar parámetros al comando y ejecutarlo
                comando.ExecuteNonQuery()
                conexion.Close()
                TxtSerie.Text = ""
                TxtDepartamento.Text = ""
                TxtDocumentacion.Text = ""
                DateTimePicker1.Text = ""
                TxtUbicacionFisica.Text = ""
                TxtSerie.Focus()
            End If
        End Using

    End Sub

    Private Sub RegDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSerie.Text = ""
        TxtDepartamento.Text = ""
        TxtDocumentacion.Text = ""
        DateTimePicker1.Text = ""
        TxtUbicacionFisica.Text = ""
        TxtSerie.Focus()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub


    '        Using conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-3U2TNE3;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
    '            conexion.Open()
    '
    '            ' Verificar si el nombre del PDF ya existe en la base de datos
    '            Dim consultaExistenciaPDF As New SqlCommand("SELECT * FROM RegNuevoDocumento WHERE NombreDelPDF = @NombreDelPDF", conexion)
    '            consultaExistenciaPDF.Parameters.AddWithValue("@NombreDelPDF", nombrePDF)
    '            Dim reader As SqlDataReader = consultaExistenciaPDF.ExecuteReader()
    '            If reader.HasRows Then
    '                ' El valor ya existe en la base de datos, manejar el error aquí
    '                MessageBox.Show("El nombre del PDF ya existe en la base de datos.")
    '                reader.Close()
    '                Return
    '            End If
    '            reader.Close()
    '
    '            ' Registrar nuevos documentos en la base de datos
    '            Dim comando As New SqlCommand("RegistroDeNuevosDocumentos", conexion)
    '            comando.CommandType = CommandType.StoredProcedure
    '
    '            Dim fechaRegistro As DateTime
    '            If DateTime.TryParse(TxtFechaRegDocumento.Text, fechaRegistro) Then
    '                comando.Parameters.AddWithValue("@FechaRegistroDocumento", fechaRegistro)
    '            Else
    '                MessageBox.Show("La fecha de registro no está en el formato correcto.")
    '                Return
    '            End If
    '
    '            comando.Parameters.AddWithValue("@NombreDelPDF", TxtNombreDelPDF.Text)
    '            comando.Parameters.AddWithValue("@QuienEnvia", TxtQuienEnvia.Text)
    '            comando.Parameters.AddWithValue("@QuienRevice", TxtQuienRecive.Text)
    '            comando.Parameters.AddWithValue("@UbicacionFisica", TxtUbicacionFisica.Text)
    '            comando.Parameters.AddWithValue("@Fecha", DateTime.Now) ' Puedes cambiar DateTime.Now por el valor de fecha que desees
    '
    '            comando.ExecuteNonQuery()
    '
    '            TxtNombreDelPDF.Text = ""
    '            TxtFechaRegDocumento.Text = ""
    '            TxtQuienEnvia.Text = ""
    '            TxtQuienRecive.Text = ""
    '            TxtUbicacionFisica.Text = ""
    '            TxtNombreDelPDF.Focus()
    '        End Using
    '        '    Private Sub RegDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        '        Dim path As String = "C:\Users\an0nim3.us3r\Downloads\Guia de Elaboración de Tesina  2023 ING  MJRL.pdf"
    '        '        Dim byteArray() As Byte = File.ReadAllBytes(path)
    '        '
    '        '        Using conn As New SqlConnection("Data Source=DESKTOP-3U2TNE3;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
    '        '            Using cmd As New SqlCommand("RegistroDeNuevosDocumentos", conn)
    '        '                cmd.Parameters.Add("@PDF", SqlDbType.VarBinary, -1).Value = byteArray
    '        '                conn.Open()
    '        '                cmd.ExecuteNonQuery()
    '        '            End Using
    '        '        End Using
End Class