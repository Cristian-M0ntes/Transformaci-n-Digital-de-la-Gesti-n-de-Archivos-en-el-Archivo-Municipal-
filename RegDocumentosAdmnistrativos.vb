Imports System.Data.SqlClient
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Public Class RegDocumentosAdmnistrativos
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
            Dim consultaExistenciaPDF As New SqlCommand("IF EXISTS (SELECT  1 FROM RegNuevoDocumento WHERE Documentacion = @Documentacion) SELECT  1 ELSE SELECT  0", conexion)
            consultaExistenciaPDF.Parameters.AddWithValue("@Documentacion", nombrePDF)
            Dim resultado As Integer = consultaExistenciaPDF.ExecuteScalar()

            If resultado = 1 Then
                ' El valor ya existe en la base de datos, manejar el error aquí
                MessageBox.Show("El nombre de este documento ya existe en la base de datos.")
                Return
            Else
                ' Obtener la fecha del documento directamente desde DateTimePicker1
                Dim fechaDocumento As DateTime = DateTimePicker1.Value

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



    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
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
            rpt.Load("C:\CRRegistroByAdmin\CRRegistroComoAdminitrador.rpt") ' Asegúrate de proporcionar la ruta correcta a tu archivo .rpt
            rpt.SetDataSource(dt)

            ' Mostrar el reporte en el CrystalReportViewer
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()

            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos en el reporte: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim conexion As New SqlClient.SqlConnection("Data Source=MacBookPro;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
            conexion.Open()
            Dim comandoConsultar As New SqlCommand("EliminarDocumentos", conexion)
            comandoConsultar.CommandType = CommandType.StoredProcedure
            comandoConsultar.Parameters.Add(New SqlParameter("@Serie", TxtSerie.Text))
            comandoConsultar.Parameters.Add(New SqlParameter("@Documentacion", TxtDocumentacion.Text))
            comandoConsultar.ExecuteNonQuery()

        Catch ex As Exception
            ' Aquí puedes manejar la excepción, por ejemplo, mostrando un mensaje al usuario
            MessageBox.Show("Error al eliminar documentos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LimpiarCampos()


        'contarEmpleados()
    End Sub


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MenuAdmin As New MenuAdministrativo()
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub LimpiarCampos()
        TxtSerie.Text = ""
        TxtDepartamento.Text = ""
        TxtDocumentacion.Text = ""
        DateTimePicker1.Text = ""
        TxtUbicacionFisica.Text = ""
        TxtSerie.Focus()
    End Sub

    Private Sub RegDodumentosAdmnistrativos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarCampos()
    End Sub



End Class