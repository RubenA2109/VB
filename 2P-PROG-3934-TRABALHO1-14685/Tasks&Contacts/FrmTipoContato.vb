Public Class FrmTipoContato
    Private Sub TipoContatoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TipoContatoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TipoContatoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TasksContactsDataSet)

    End Sub

    Private Sub FrmTipoContato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.PessoaContato'. Você pode movê-la ou removê-la conforme necessário.
        Me.PessoaContatoTableAdapter.Fill(Me.TasksContactsDataSet.PessoaContato)
        'TODO: esta linha de código carrega dados na tabela 'TasksContactsDataSet.TipoContato'. Você pode movê-la ou removê-la conforme necessário.
        Me.TipoContatoTableAdapter.Fill(Me.TasksContactsDataSet.TipoContato)

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