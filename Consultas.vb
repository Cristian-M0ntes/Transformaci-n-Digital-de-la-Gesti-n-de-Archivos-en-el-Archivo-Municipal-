Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Globalization

Public Class Consultas
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-3U2TNE3;Initial Catalog=ArchivoMunicipal;Integrated Security=True")
            Dim comandoConsultar As New SqlCommand("SELECT * FROM RegNuevoDocumento WHERE Serie LIKE @Serie", conexion)
            ' Añadir el carácter % al inicio y al final del texto de búsqueda para buscar cualquier registro que contenga la letra P
            comandoConsultar.Parameters.Add(New SqlParameter("@Serie", String.Format("%{0}%", TxtBoxBusqueda.Text)))

            conexion.Open()
            Dim leer As SqlDataReader = comandoConsultar.ExecuteReader()

            ' Crear un DataTable para almacenar los resultados de la consulta
            Dim dt As New DataTable()
            dt.Load(leer)

            ' Cargar el DataTable en el Crystal Report
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            rpt.Load("C:\Users\an0nim3.us3r\Documents\Visual Studio 2015\Projects\ArchivoMunicipal\ArchivoMunicipal\CRRegistroByAdmin\CRConsultasPublicas.rpt") ' Asegúrate de proporcionar la ruta correcta a tu archivo .rpt
            rpt.SetDataSource(dt)

            ' Mostrar el reporte en el CrystalReportViewer
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()

            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos en el reporte: " & ex.Message)
        End Try
    End Sub

End Class