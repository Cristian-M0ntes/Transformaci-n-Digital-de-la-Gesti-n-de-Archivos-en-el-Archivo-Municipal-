
Public Class ConsultasOnline

    Private Sub ConsultasOnline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carga Google al iniciar el formulario
        WebBrowser1.Navigate("https://bing.com")
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim regresar As New MenuPrincipal
        regresar.Show()
        Hide()
    End Sub
End Class
