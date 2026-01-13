Public Class FrmTarefas
    Private Sub TarefasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TarefasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TarefasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TasksContactsDataSet)

    End Sub

    Private Sub FrmTarefas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.Tarefas'. Você pode movê-la ou removê-la conforme necessário.
        Me.TarefasTableAdapter.Fill(Me.TasksContactsDataSet.Tarefas)

        MessageBox.Show(
            "Para adicionar, remover ou gurdar registos use os botões no topo do formulário.",
            "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

    Private Sub TarefasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TarefasDataGridView.CellContentClick

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        MessageBox.Show("Edite diretamente na tabela e grave.")
    End Sub
End Class