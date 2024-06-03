Public Class MenuAdministrativo
    Private Sub MenuAdministrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim RegEmpleados As New RegEmpleados()
        RegEmpleados.Show()
        Me.Hide()
    End Sub



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim Documentos As New RegDocumentos()
        RegDocumentosAdmnistrativos.Show()
        Me.Hide()
    End Sub


    '   Public Class Program
    '       Public Shared IsSessionActive As Boolean = True
    '   End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Documentos As New RegDocumentos()
        MenuPrincipal.Show()

        '       Program.IsSessionActive = False
        '       Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' La sesión no está activa, redirige al usuario al formulario de inicio de sesión
        Dim Login As New Login()
            Login.Show()
            Me.Hide()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim Documentos As New RegDocumentosConfidenciales()
        Documentos.Show()
        Me.Hide()
    End Sub
End Class


