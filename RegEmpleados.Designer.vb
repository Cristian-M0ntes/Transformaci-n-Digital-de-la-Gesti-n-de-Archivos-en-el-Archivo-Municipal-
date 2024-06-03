<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegEmpleados))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNumeroDeEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtSectorDeTrabajo = New System.Windows.Forms.TextBox()
        Me.TxtNombreDeEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnRegresarLogin = New System.Windows.Forms.Button()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Lblerror1 = New System.Windows.Forms.Label()
        Me.LblError2 = New System.Windows.Forms.Label()
        Me.LblError3 = New System.Windows.Forms.Label()
        Me.LblError4 = New System.Windows.Forms.Label()
        Me.LblError5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBRolID = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnConsultarEmpleados = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(489, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID de Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(489, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sector de Trabajo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre De Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña "
        '
        'TxtNumeroDeEmpleado
        '
        Me.TxtNumeroDeEmpleado.Location = New System.Drawing.Point(625, 201)
        Me.TxtNumeroDeEmpleado.MaxLength = 8
        Me.TxtNumeroDeEmpleado.Name = "TxtNumeroDeEmpleado"
        Me.TxtNumeroDeEmpleado.Size = New System.Drawing.Size(239, 20)
        Me.TxtNumeroDeEmpleado.TabIndex = 4
        Me.TxtNumeroDeEmpleado.Tag = ""
        '
        'TxtSectorDeTrabajo
        '
        Me.TxtSectorDeTrabajo.Location = New System.Drawing.Point(625, 248)
        Me.TxtSectorDeTrabajo.Name = "TxtSectorDeTrabajo"
        Me.TxtSectorDeTrabajo.Size = New System.Drawing.Size(239, 20)
        Me.TxtSectorDeTrabajo.TabIndex = 5
        '
        'TxtNombreDeEmpleado
        '
        Me.TxtNombreDeEmpleado.Location = New System.Drawing.Point(625, 286)
        Me.TxtNombreDeEmpleado.Name = "TxtNombreDeEmpleado"
        Me.TxtNombreDeEmpleado.Size = New System.Drawing.Size(239, 20)
        Me.TxtNombreDeEmpleado.TabIndex = 6
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(625, 330)
        Me.TxtContraseña.MaxLength = 10
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(239, 20)
        Me.TxtContraseña.TabIndex = 7
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(553, 449)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(76, 23)
        Me.BtnRegistrar.TabIndex = 9
        Me.BtnRegistrar.Text = "Registrarse"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(464, 449)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(76, 23)
        Me.BtnLimpiar.TabIndex = 10
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnRegresarLogin
        '
        Me.BtnRegresarLogin.Location = New System.Drawing.Point(831, 449)
        Me.BtnRegresarLogin.Name = "BtnRegresarLogin"
        Me.BtnRegresarLogin.Size = New System.Drawing.Size(76, 23)
        Me.BtnRegresarLogin.TabIndex = 14
        Me.BtnRegresarLogin.Text = "Salir"
        Me.BtnRegresarLogin.UseVisualStyleBackColor = True
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(633, 58)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(180, 40)
        Me.LabelX1.TabIndex = 64
        Me.LabelX1.Text = "REALIZAR UN REGISTRO"
        '
        'Lblerror1
        '
        Me.Lblerror1.AutoSize = True
        Me.Lblerror1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblerror1.ForeColor = System.Drawing.Color.Red
        Me.Lblerror1.Location = New System.Drawing.Point(895, 207)
        Me.Lblerror1.Name = "Lblerror1"
        Me.Lblerror1.Size = New System.Drawing.Size(12, 13)
        Me.Lblerror1.TabIndex = 67
        Me.Lblerror1.Text = "*"
        Me.Lblerror1.Visible = False
        '
        'LblError2
        '
        Me.LblError2.AutoSize = True
        Me.LblError2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError2.ForeColor = System.Drawing.Color.Red
        Me.LblError2.Location = New System.Drawing.Point(895, 254)
        Me.LblError2.Name = "LblError2"
        Me.LblError2.Size = New System.Drawing.Size(12, 13)
        Me.LblError2.TabIndex = 68
        Me.LblError2.Text = "*"
        Me.LblError2.Visible = False
        '
        'LblError3
        '
        Me.LblError3.AutoSize = True
        Me.LblError3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError3.ForeColor = System.Drawing.Color.Red
        Me.LblError3.Location = New System.Drawing.Point(895, 293)
        Me.LblError3.Name = "LblError3"
        Me.LblError3.Size = New System.Drawing.Size(12, 13)
        Me.LblError3.TabIndex = 69
        Me.LblError3.Text = "*"
        Me.LblError3.Visible = False
        '
        'LblError4
        '
        Me.LblError4.AutoSize = True
        Me.LblError4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError4.ForeColor = System.Drawing.Color.Red
        Me.LblError4.Location = New System.Drawing.Point(895, 336)
        Me.LblError4.Name = "LblError4"
        Me.LblError4.Size = New System.Drawing.Size(12, 13)
        Me.LblError4.TabIndex = 70
        Me.LblError4.Text = "*"
        Me.LblError4.Visible = False
        '
        'LblError5
        '
        Me.LblError5.AutoSize = True
        Me.LblError5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError5.ForeColor = System.Drawing.Color.Red
        Me.LblError5.Location = New System.Drawing.Point(895, 374)
        Me.LblError5.Name = "LblError5"
        Me.LblError5.Size = New System.Drawing.Size(12, 13)
        Me.LblError5.TabIndex = 73
        Me.LblError5.Text = "*"
        Me.LblError5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(488, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Rol que Desempeña"
        '
        'CBRolID
        '
        Me.CBRolID.FormattingEnabled = True
        Me.CBRolID.Items.AddRange(New Object() {"Administrativo", "Usuario"})
        Me.CBRolID.Location = New System.Drawing.Point(625, 372)
        Me.CBRolID.Name = "CBRolID"
        Me.CBRolID.Size = New System.Drawing.Size(239, 21)
        Me.CBRolID.TabIndex = 74
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-31, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(470, 533)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(644, 568)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 43)
        Me.Button2.TabIndex = 75
        Me.Button2.Text = "MENU ADMINISTRATIVO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnConsultarEmpleados
        '
        Me.BtnConsultarEmpleados.Location = New System.Drawing.Point(647, 449)
        Me.BtnConsultarEmpleados.Name = "BtnConsultarEmpleados"
        Me.BtnConsultarEmpleados.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultarEmpleados.TabIndex = 76
        Me.BtnConsultarEmpleados.Text = "Consultar"
        Me.BtnConsultarEmpleados.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(738, 449)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 77
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(488, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Numero  de Registrados"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(625, 406)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(11, 13)
        Me.LblTotal.TabIndex = 79
        Me.LblTotal.Text = "*"
        Me.LblTotal.Visible = False
        '
        'RegEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 623)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnConsultarEmpleados)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CBRolID)
        Me.Controls.Add(Me.LblError5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblError4)
        Me.Controls.Add(Me.LblError3)
        Me.Controls.Add(Me.LblError2)
        Me.Controls.Add(Me.Lblerror1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.BtnRegresarLogin)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtNombreDeEmpleado)
        Me.Controls.Add(Me.TxtSectorDeTrabajo)
        Me.Controls.Add(Me.TxtNumeroDeEmpleado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegEmpleados"
        Me.Text = "Registro"
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
    Friend WithEvents TxtNumeroDeEmpleado As TextBox
    Friend WithEvents TxtSectorDeTrabajo As TextBox
    Friend WithEvents TxtNombreDeEmpleado As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnRegresarLogin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lblerror1 As Label
    Friend WithEvents LblError2 As Label
    Friend WithEvents LblError3 As Label
    Friend WithEvents LblError4 As Label
    Friend WithEvents LblError5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBRolID As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnConsultarEmpleados As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LblTotal As Label
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
