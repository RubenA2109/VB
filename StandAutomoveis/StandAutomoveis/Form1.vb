Public Class Form1

    Private Sub MenuAppSair_Click(sender As Object, e As EventArgs) Handles MenuAppSair.Click
        Me.Close()
        Application.Exit()
    End Sub


    Private Sub MenuAppSobre_Click(sender As Object, e As EventArgs) Handles MenuAppSobre.Click
        Dim frm3 As New Form3()

        frm3.Show()
    End Sub


    Private Sub MenuAppAjuda_Click(sender As Object, e As EventArgs) Handles MenuAppAjuda.Click
        Dim frm4 As New Form4()

        frm4.Show()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        Dim frm8 As New MenuAppMarcas()

        frm8.Show()
    End Sub


    Public Sub Mensagem(txt As String)
        MessageBox.Show(txt)
    End Sub

    Private Sub Mensagem()
        MessageBox.Show("Olá")
    End Sub

    'Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
    '    Me.Close()
    'End Sub

    'Private Sub AbrirFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirFormToolStripMenuItem.Click
    '    Dim formMassa As New MassaCorporal
    '    formMassa.MdiParent = Me
    '    formMassa.Show()
    'End Sub

    'Private Sub AbrirForm3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirForm3ToolStripMenuItem.Click
    '   Dim form3 As New Form3
    '    form3.MdiParent = Me
    '    form3.Show()
    'End Sub

End Class
