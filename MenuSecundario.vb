Public Class MenuSecundario
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        MessageBox.Show("Solo el administrador puede hacer registros de usuarios.")
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim RegDocumentos As New RegDocumentos()
        RegDocumentos.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RegDocumentos As New RegDocumentos()
        MenuPrincipal.Show()
        Me.Hide()
    End Sub
End Class