<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consultas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TxtBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(39, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 474)
        Me.Panel1.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.reportDocument1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1253, 474)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'TxtBoxBusqueda
        '
        Me.TxtBoxBusqueda.Location = New System.Drawing.Point(326, 97)
        Me.TxtBoxBusqueda.Name = "TxtBoxBusqueda"
        Me.TxtBoxBusqueda.Size = New System.Drawing.Size(569, 20)
        Me.TxtBoxBusqueda.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(929, 93)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://C:\Users\an0nim3.us3r\Documents\Visual Studio 2015\Projects\ArchivoMunic" &
    "ipal\ArchivoMunicipal\CRRegistroByAdmin\CRConsultasPublicas.rpt"
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 693)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBoxBusqueda)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TxtBoxBusqueda As TextBox
    Friend WithEvents BtnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CRConsultasPublicas1 As CRConsultasPublicas
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
