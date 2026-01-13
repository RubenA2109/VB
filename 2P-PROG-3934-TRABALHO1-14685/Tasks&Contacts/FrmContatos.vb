Public Class FrmContatos
    Private Sub PessoasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PessoasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PessoasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TasksContactsDataSet)

    End Sub

    Private Sub FrmContatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.TarefaPessoa'. Você pode movê-la ou removê-la conforme necessário.
        Me.TarefaPessoaTableAdapter.Fill(Me.TasksContactsDataSet.TarefaPessoa)
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.ContatoDetalhe'. Você pode movê-la ou removê-la conforme necessário.
        Me.ContatoDetalheTableAdapter.Fill(Me.TasksContactsDataSet.ContatoDetalhe)
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.PessoaContato'. Você pode movê-la ou removê-la conforme necessário.
        Me.PessoaContatoTableAdapter.Fill(Me.TasksContactsDataSet.PessoaContato)
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.Pessoas'. Você pode movê-la ou removê-la conforme necessário.
        Me.PessoasTableAdapter.Fill(Me.TasksContactsDataSet.Pessoas)

        MessageBox.Show(
            "Para adicionar, remover ou gurdar registos use os botões no topo do formulário.",
            "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        MessageBox.Show("Edite diretamente na tabela e grave.")
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class