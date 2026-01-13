Public Class Form1
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub TiposDeContatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeContatoToolStripMenuItem.Click

        Try
            Dim ftipocon As New FrmTipoContato()
            ftipocon.MdiParent = Me
            ftipocon.Show()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os tipos de contacto: " & ex.Message)
        End Try

    End Sub

    Private Sub ContatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContatosToolStripMenuItem.Click

        Try
            Dim fcon As New FrmContatos()
            fcon.MdiParent = Me
            fcon.Show()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar contactos: " & ex.Message)
        End Try

    End Sub

    Private Sub TiposDeTarefaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeTarefaToolStripMenuItem.Click
        Try
            Dim ftipotar As New FrmTiposTarefa()
            ftipotar.MdiParent = Me
            ftipotar.Show()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar os tipos de tarefa: " & ex.Message)
        End Try
    End Sub

    Private Sub TarefasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TarefasToolStripMenuItem1.Click
        Try
            Dim ftar As New FrmTarefas()
            ftar.MdiParent = Me
            ftar.Show()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar contactos: " & ex.Message)
        End Try
    End Sub

End Class
