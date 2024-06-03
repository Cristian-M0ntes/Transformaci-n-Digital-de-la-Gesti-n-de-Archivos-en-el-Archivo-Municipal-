<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegDocumentos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LblError1 = New System.Windows.Forms.Label()
        Me.LblError2 = New System.Windows.Forms.Label()
        Me.LblError3 = New System.Windows.Forms.Label()
        Me.LblError4 = New System.Windows.Forms.Label()
        Me.LblError5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.TxtDocumentacion = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtUbicacionFisica = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(510, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(510, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Documentacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Año"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ubicacion Fisica"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(510, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Serie"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(727, 467)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(595, 467)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 11
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(618, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 43)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "REGRESAR AL MENU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(618, 43)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(177, 40)
        Me.LabelX1.TabIndex = 45
        Me.LabelX1.Text = "REGISTRO DE DOCUMENTOS"
        '
        'LblError1
        '
        Me.LblError1.AutoSize = True
        Me.LblError1.ForeColor = System.Drawing.Color.Red
        Me.LblError1.Location = New System.Drawing.Point(869, 173)
        Me.LblError1.Name = "LblError1"
        Me.LblError1.Size = New System.Drawing.Size(11, 13)
        Me.LblError1.TabIndex = 46
        Me.LblError1.Text = "*"
        Me.LblError1.Visible = False
        '
        'LblError2
        '
        Me.LblError2.AutoSize = True
        Me.LblError2.ForeColor = System.Drawing.Color.Red
        Me.LblError2.Location = New System.Drawing.Point(869, 211)
        Me.LblError2.Name = "LblError2"
        Me.LblError2.Size = New System.Drawing.Size(11, 13)
        Me.LblError2.TabIndex = 47
        Me.LblError2.Text = "*"
        Me.LblError2.Visible = False
        '
        'LblError3
        '
        Me.LblError3.AutoSize = True
        Me.LblError3.ForeColor = System.Drawing.Color.Red
        Me.LblError3.Location = New System.Drawing.Point(869, 254)
        Me.LblError3.Name = "LblError3"
        Me.LblError3.Size = New System.Drawing.Size(11, 13)
        Me.LblError3.TabIndex = 48
        Me.LblError3.Text = "*"
        Me.LblError3.Visible = False
        '
        'LblError4
        '
        Me.LblError4.AutoSize = True
        Me.LblError4.ForeColor = System.Drawing.Color.Red
        Me.LblError4.Location = New System.Drawing.Point(869, 301)
        Me.LblError4.Name = "LblError4"
        Me.LblError4.Size = New System.Drawing.Size(11, 13)
        Me.LblError4.TabIndex = 49
        Me.LblError4.Text = "*"
        Me.LblError4.Visible = False
        '
        'LblError5
        '
        Me.LblError5.AutoSize = True
        Me.LblError5.ForeColor = System.Drawing.Color.Red
        Me.LblError5.Location = New System.Drawing.Point(869, 139)
        Me.LblError5.Name = "LblError5"
        Me.LblError5.Size = New System.Drawing.Size(11, 13)
        Me.LblError5.TabIndex = 50
        Me.LblError5.Text = "*"
        Me.LblError5.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-32, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(469, 529)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(611, 132)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(239, 20)
        Me.TxtSerie.TabIndex = 69
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(611, 174)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(239, 20)
        Me.TxtDepartamento.TabIndex = 70
        '
        'TxtDocumentacion
        '
        Me.TxtDocumentacion.Location = New System.Drawing.Point(611, 211)
        Me.TxtDocumentacion.Name = "TxtDocumentacion"
        Me.TxtDocumentacion.Size = New System.Drawing.Size(239, 20)
        Me.TxtDocumentacion.TabIndex = 71
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(611, 247)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(239, 20)
        Me.DateTimePicker1.TabIndex = 72
        '
        'TxtUbicacionFisica
        '
        Me.TxtUbicacionFisica.Location = New System.Drawing.Point(611, 293)
        Me.TxtUbicacionFisica.Name = "TxtUbicacionFisica"
        Me.TxtUbicacionFisica.Size = New System.Drawing.Size(239, 20)
        Me.TxtUbicacionFisica.TabIndex = 73
        '
        'RegDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1275, 582)
        Me.Controls.Add(Me.TxtUbicacionFisica)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtDocumentacion)
        Me.Controls.Add(Me.TxtDepartamento)
        Me.Controls.Add(Me.TxtSerie)
        Me.Controls.Add(Me.LblError5)
        Me.Controls.Add(Me.LblError4)
        Me.Controls.Add(Me.LblError3)
        Me.Controls.Add(Me.LblError2)
        Me.Controls.Add(Me.LblError1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Documentos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LblError1 As Label
    Friend WithEvents LblError2 As Label
    Friend WithEvents LblError3 As Label
    Friend WithEvents LblError4 As Label
    Friend WithEvents LblError5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents TxtDocumentacion As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtUbicacionFisica As TextBox
End Class
