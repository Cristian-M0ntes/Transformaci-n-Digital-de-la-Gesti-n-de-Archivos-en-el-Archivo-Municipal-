Imports System.Data.SqlClient
Imports System.Globalization

Public Class RegDocumentosConfidenciales
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim showme As New MenuAdministrativo()
        MenuAdministrativo.Show()
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
            LblError2.Visible = True
            TxtDepartamento.Focus()
            Return
        Else
            Lblerror1.Visible = False
        End If
        '1

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

        If String.IsNullOrEmpty(TxtUbicacionFisica.Text) Then
            LblError4.Visible = True
            TxtUbicacionFisica.Focus()
            Return
        Else
            LblError4.Visible = False
        End If
        '''''''============================================================================= SEGUNDO CODIGO ===================''''''''''
        '        Dim conexion As New SqlClient SqlConnection("Data Source=DESKTOP-3U2TNE3;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
        '        Dim comando As New SqlCommand("Select * from RegNuevoDocumento where NombreDelPDF = @NombreDelPDF", conexion)
        '        comando Parameters Add(New( SqlParameter("@NombreDelPDF", TxtNombreDelPDF.Text))
        '        conexion.Open()
        '        Dim reader As SqlDataReader = comando.ExecuteReader()
        '        If reader HasRows Then 
        '            'Checar si el valor ya existe en la base de datos 
        '            MessageBox Show("El Nombre del pdf ya esta en la base de datos")
        '                reader.Close()
        '            Return
        '        Else
        '            reader.Close()
        '            comando.CommandText = "RgistroDeNuevosDocumentos"
        '            comando.Parameters.Clear()
        '            comando.Parameters.Add(New SqlParameter("@Fecha", TxtFechaRegDocumento.Text))
        '            comando.Parameters.Add(New SqlParameter("@QuienEnvia", TxtQuienEnvia.Text))
        '            comando.Parameters.Add(New SqlParameter("@QuienRecibe", TxtQuienRecive.Text))
        '            comando.Parameters.Add(New SqlParameter("@UbicacionFisica", TxtUbicacionFisica.Text))
        '            comando.Parameters.Add(New SqlParameter("@NombreDelPDF", TxtNombreDelPDF.Text))
        '        End If


        Dim nombrePDF As String = TxtDocumentacion.Text

        Using conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
            conexion.Open()

            ' Verificar si el nombre del PDF ya existe en la base de datos
            Dim consultaExistenciaPDF As New SqlCommand("IF EXISTS (SELECT 1 FROM RegNuevoDocumentoConfidencial WHERE Documentacion = @Documentacion) SELECT 1 ELSE SELECT 0", conexion)
            consultaExistenciaPDF.Parameters.AddWithValue("@Documentacion", nombrePDF)
            Dim resultado As Integer = consultaExistenciaPDF.ExecuteScalar()

            If resultado = 1 Then
                ' El valor ya existe en la base de datos, manejar el error aquí
                MessageBox.Show("El nombre del PDF ya existe en la base de datos.")
                Return
            Else
                ' Validar y convertir la fecha del documento
                Dim fechaDocumento As DateTime
                If DateTime.TryParseExact(DateTimePicker1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, fechaDocumento) Then
                    ' Convertir la fecha al formato "yyyy/MM/dd"
                    Dim fechaFormateada As String = fechaDocumento.ToString("yyyy/MM/dd")

                    ' Registrar nuevos documentos en la base de datos
                    Dim comando As New SqlCommand("RegistroDeNuevosDocumentosConfidenciales", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Add(New SqlParameter("@Serie", TxtSerie.Text))
                    comando.Parameters.Add(New SqlParameter("@Departamento", TxtDepartamento.Text))
                    comando.Parameters.Add(New SqlParameter("@Documentacion", TxtDocumentacion.Text))
                    comando.Parameters.Add(New SqlParameter("@Fecha", fechaFormateada))
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
                Else
                    ' La fecha del documento no es válida, manejar el error aquí
                    MessageBox.Show("La fecha del documento no es válida.")
                    Return
                End If
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Try
            Dim conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
            Dim comandoConsultar As New SqlCommand("SELECT * FROM RegNuevoDocumento WHERE Serie LIKE @Serie", conexion)
            ' Añadir el carácter % al inicio y al final del texto de búsqueda para buscar cualquier registro que contenga la letra P
            comandoConsultar.Parameters.Add(New SqlParameter("@Serie", "%" & TxtSerie.Text & "%"))

            conexion.Open()
            Dim leer As SqlDataReader = comandoConsultar.ExecuteReader()

            ' Crear un DataTable para almacenar los resultados de la consulta
            Dim dt As New DataTable()
            dt.Load(leer)

            ' Cargar el DataTable en el Crystal Report
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            rpt.Load("C:\Users\an0nim3.us3r\documents\visual studio 2015\Projects\ArchivoMunicipal\ArchivoMunicipal\CRRegistroByAdmin\CRRegistroConfidencialComoAdministrador.rpt") ' Asegúrate de proporcionar la ruta correcta a tu archivo .rpt
            rpt.SetDataSource(dt)

            ' Mostrar el reporte en el CrystalReportViewer
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()

            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos en el reporte: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
        Dim comandoConsultar As New SqlCommand("EliminarDocumentosConfidenciales", conexion)
        comandoConsultar.CommandType = CommandType.StoredProcedure
        comandoConsultar.Parameters.Add(New SqlParameter("@NombreDelPDF", TxtDocumentacion.Text))
        conexion.Open()
        comandoConsultar.ExecuteNonQuery()
        conexion.Close()
        TxtSerie.Text = ""
        TxtDepartamento.Text = ""
        TxtDocumentacion.Text = ""
        DateTimePicker1.Text = ""
        TxtUbicacionFisica.Text = ""
        TxtSerie.Focus()

        'contarEmpleados()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub RegDocumentosConfidenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSerie.Text = ""
        TxtDepartamento.Text = ""
        TxtDocumentacion.Text = ""
        DateTimePicker1.Text = ""
        TxtUbicacionFisica.Text = ""
        TxtSerie.Focus()
    End Sub
End Class