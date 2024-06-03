<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegDocumentosConfidenciales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegDocumentosConfidenciales))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Lblerror1 = New System.Windows.Forms.Label()
        Me.LblError2 = New System.Windows.Forms.Label()
        Me.LblError3 = New System.Windows.Forms.Label()
        Me.LblError4 = New System.Windows.Forms.Label()
        Me.LblError5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtUbicacionFisica = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtDocumentacion = New System.Windows.Forms.TextBox()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRRegistroConfidencialComoAdministrador1 = New ArchivoMunicipal.CRRegistroConfidencialComoAdministrador()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(209, 555)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 43)
        Me.Button5.TabIndex = 104
        Me.Button5.Text = "Menu Administrativo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(386, 448)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 103
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(295, 449)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 102
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(201, 449)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 101
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(27, 449)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 24)
        Me.BtnLimpiar.TabIndex = 96
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(115, 449)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 24)
        Me.BtnGuardar.TabIndex = 95
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(470, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(381, 40)
        Me.LabelX1.TabIndex = 85
        Me.LabelX1.Text = "REALIZAR UN REGISTRO CONFIDENCIAL  COMO ADMINISTRADOR"
        '
        'Lblerror1
        '
        Me.Lblerror1.AutoSize = True
        Me.Lblerror1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblerror1.ForeColor = System.Drawing.Color.Red
        Me.Lblerror1.Location = New System.Drawing.Point(423, 194)
        Me.Lblerror1.Name = "Lblerror1"
        Me.Lblerror1.Size = New System.Drawing.Size(11, 13)
        Me.Lblerror1.TabIndex = 105
        Me.Lblerror1.Text = "*"
        Me.Lblerror1.Visible = False
        '
        'LblError2
        '
        Me.LblError2.AutoSize = True
        Me.LblError2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError2.ForeColor = System.Drawing.Color.Red
        Me.LblError2.Location = New System.Drawing.Point(423, 230)
        Me.LblError2.Name = "LblError2"
        Me.LblError2.Size = New System.Drawing.Size(11, 13)
        Me.LblError2.TabIndex = 106
        Me.LblError2.Text = "*"
        Me.LblError2.Visible = False
        '
        'LblError3
        '
        Me.LblError3.AutoSize = True
        Me.LblError3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError3.ForeColor = System.Drawing.Color.Red
        Me.LblError3.Location = New System.Drawing.Point(423, 268)
        Me.LblError3.Name = "LblError3"
        Me.LblError3.Size = New System.Drawing.Size(11, 13)
        Me.LblError3.TabIndex = 107
        Me.LblError3.Text = "*"
        Me.LblError3.Visible = False
        '
        'LblError4
        '
        Me.LblError4.AutoSize = True
        Me.LblError4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError4.ForeColor = System.Drawing.Color.Red
        Me.LblError4.Location = New System.Drawing.Point(423, 305)
        Me.LblError4.Name = "LblError4"
        Me.LblError4.Size = New System.Drawing.Size(11, 13)
        Me.LblError4.TabIndex = 108
        Me.LblError4.Text = "*"
        Me.LblError4.Visible = False
        '
        'LblError5
        '
        Me.LblError5.AutoSize = True
        Me.LblError5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError5.ForeColor = System.Drawing.Color.Red
        Me.LblError5.Location = New System.Drawing.Point(423, 352)
        Me.LblError5.Name = "LblError5"
        Me.LblError5.Size = New System.Drawing.Size(11, 13)
        Me.LblError5.TabIndex = 109
        Me.LblError5.Text = "*"
        Me.LblError5.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-31, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(470, 532)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'TxtUbicacionFisica
        '
        Me.TxtUbicacionFisica.Location = New System.Drawing.Point(162, 345)
        Me.TxtUbicacionFisica.Name = "TxtUbicacionFisica"
        Me.TxtUbicacionFisica.Size = New System.Drawing.Size(239, 20)
        Me.TxtUbicacionFisica.TabIndex = 119
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 299)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(239, 20)
        Me.DateTimePicker1.TabIndex = 118
        '
        'TxtDocumentacion
        '
        Me.TxtDocumentacion.Location = New System.Drawing.Point(162, 263)
        Me.TxtDocumentacion.Name = "TxtDocumentacion"
        Me.TxtDocumentacion.Size = New System.Drawing.Size(239, 20)
        Me.TxtDocumentacion.TabIndex = 117
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(162, 226)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(239, 20)
        Me.TxtDepartamento.TabIndex = 116
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(162, 184)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(239, 20)
        Me.TxtSerie.TabIndex = 115
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Ubicacion Fisica"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Documentacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Departamento"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(470, 63)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CRRegistroConfidencialComoAdministrador1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(844, 521)
        Me.CrystalReportViewer1.TabIndex = 120
        '
        'RegDocumentosConfidenciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 690)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.TxtUbicacionFisica)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtDocumentacion)
        Me.Controls.Add(Me.TxtDepartamento)
        Me.Controls.Add(Me.TxtSerie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblError5)
        Me.Controls.Add(Me.LblError4)
        Me.Controls.Add(Me.LblError3)
        Me.Controls.Add(Me.LblError2)
        Me.Controls.Add(Me.Lblerror1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LabelX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegDocumentosConfidenciales"
        Me.Text = "RegDocumentosConfidenciales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lblerror1 As Label
    Friend WithEvents LblError2 As Label
    Friend WithEvents LblError3 As Label
    Friend WithEvents LblError4 As Label
    Friend WithEvents LblError5 As Label
    Friend WithEvents TxtUbicacionFisica As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtDocumentacion As TextBox
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRRegistroConfidencialComoAdministrador1 As CRRegistroConfidencialComoAdministrador
End Class
