Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotCalcular.Click
        Dim altura = ValorAltura.Text
        Dim peso = ValorPeso.Text
        Dim calculo = peso / (altura * altura)
        Resultado.Text = calculo * 100
        'MessageBox.Show(calculo)
    End Sub

    Private Sub mostraMsg()
        MessageBox.Show("alrta")
    End Sub

    Private Sub ValorAltura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValorAltura.KeyPress
        ' MessageBox.Show(Asc(e.KeyChar))
        ' 0 - 48 / 9 - 57 / 8 - backspace / . - 46
        Dim codAscii = Asc(e.KeyChar)
        Dim codigosPermitidos As Int32() = {8, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57}

        If (codigosPermitidos.Contains(codAscii)) Then
            e.Handled = False
        Else
            e.KeyChar = ""
        End If

    End Sub
End Class
