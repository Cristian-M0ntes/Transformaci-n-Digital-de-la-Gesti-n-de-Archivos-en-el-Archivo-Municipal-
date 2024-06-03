<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumeroDeEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LblError1 = New System.Windows.Forms.Label()
        Me.LblError2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(505, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id de Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'TxtNumeroDeEmpleado
        '
        Me.TxtNumeroDeEmpleado.Location = New System.Drawing.Point(595, 268)
        Me.TxtNumeroDeEmpleado.MaxLength = 8
        Me.TxtNumeroDeEmpleado.Name = "TxtNumeroDeEmpleado"
        Me.TxtNumeroDeEmpleado.Size = New System.Drawing.Size(239, 20)
        Me.TxtNumeroDeEmpleado.TabIndex = 2
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(595, 333)
        Me.TxtContraseña.MaxLength = 10
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(239, 20)
        Me.TxtContraseña.TabIndex = 3
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Location = New System.Drawing.Point(750, 385)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEntrar.TabIndex = 4
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-31, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(470, 532)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(630, 58)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(180, 40)
        Me.LabelX1.TabIndex = 63
        Me.LabelX1.Text = "INGRESAR COMO EMPLEADO"
        '
        'LblError1
        '
        Me.LblError1.AutoSize = True
        Me.LblError1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError1.ForeColor = System.Drawing.Color.Red
        Me.LblError1.Location = New System.Drawing.Point(840, 274)
        Me.LblError1.Name = "LblError1"
        Me.LblError1.Size = New System.Drawing.Size(12, 13)
        Me.LblError1.TabIndex = 64
        Me.LblError1.Text = "*"
        Me.LblError1.Visible = False
        '
        'LblError2
        '
        Me.LblError2.AutoSize = True
        Me.LblError2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError2.ForeColor = System.Drawing.Color.Red
        Me.LblError2.Location = New System.Drawing.Point(840, 340)
        Me.LblError2.Name = "LblError2"
        Me.LblError2.Size = New System.Drawing.Size(12, 13)
        Me.LblError2.TabIndex = 65
        Me.LblError2.Text = "*"
        Me.LblError2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(636, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 43)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Menu Principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 573)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblError2)
        Me.Controls.Add(Me.LblError1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtNumeroDeEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumeroDeEmpleado As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblError1 As Label
    Friend WithEvents LblError2 As Label
    Friend WithEvents Button1 As Button
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
