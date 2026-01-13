Public Class FrmTiposTarefa
    Private Sub TipoTarefaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TipoTarefaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TipoTarefaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TasksContactsDataSet)

    End Sub

    Private Sub FrmTiposTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.TarefaPessoa'. Você pode movê-la ou removê-la conforme necessário.
        Me.TarefaPessoaTableAdapter.Fill(Me.TasksContactsDataSet.TarefaPessoa)
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.TipoTarefa'. Você pode movê-la ou removê-la conforme necessário.
        Me.TipoTarefaTableAdapter.Fill(Me.TasksContactsDataSet.TipoTarefa)

        MessageBox.Show(
            "Para adicionar, remover ou gurdar registos use os botões no topo do formulário.",
            "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        MessageBox.Show("Edite diretamente na tabela e grave.")
    End Sub
End Class