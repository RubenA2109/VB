Public Class Form1
    Private Sub TiposDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EquipamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipamentosToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
