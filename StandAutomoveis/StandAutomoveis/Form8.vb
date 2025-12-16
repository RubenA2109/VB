Public Class MenuAppMarcas
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub MenuAppMarcas_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim frm8 As New MenuAppMarcas()

        frm8.Show()
    End Sub
End Class