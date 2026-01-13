<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContatos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContatos))
        Me.TasksContactsDataSet = New Tasks_Contacts.TasksContactsDataSet()
        Me.PessoasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PessoasTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.PessoasTableAdapter()
        Me.TableAdapterManager = New Tasks_Contacts.TasksContactsDataSetTableAdapters.TableAdapterManager()
        Me.PessoasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PessoasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PessoasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PessoaContatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PessoaContatoTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.PessoaContatoTableAdapter()
        Me.ContatoDetalheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContatoDetalheTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.ContatoDetalheTableAdapter()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.ContatoDetalheDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarefaPessoaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarefaPessoaTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.TarefaPessoaTableAdapter()
        CType(Me.TasksContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PessoasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PessoasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PessoasBindingNavigator.SuspendLayout()
        CType(Me.PessoasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PessoaContatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContatoDetalheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContatoDetalheDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarefaPessoaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TasksContactsDataSet
        '
        Me.TasksContactsDataSet.DataSetName = "TasksContactsDataSet"
        Me.TasksContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PessoasBindingSource
        '
        Me.PessoasBindingSource.DataMember = "Pessoas"
        Me.PessoasBindingSource.DataSource = Me.TasksContactsDataSet
        '
        'PessoasTableAdapter
        '
        Me.PessoasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContatoDetalheTableAdapter = Nothing
        Me.TableAdapterManager.ContatoTableAdapter = Nothing
        Me.TableAdapterManager.PessoaContatoTableAdapter = Nothing
        Me.TableAdapterManager.PessoasTableAdapter = Me.PessoasTableAdapter
        Me.TableAdapterManager.TarefaPessoaTableAdapter = Nothing
        Me.TableAdapterManager.TarefasTableAdapter = Nothing
        Me.TableAdapterManager.TipoContatoTableAdapter = Nothing
        Me.TableAdapterManager.TipoTarefaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tasks_Contacts.TasksContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PessoasBindingNavigator
        '
        Me.PessoasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PessoasBindingNavigator.BindingSource = Me.PessoasBindingSource
        Me.PessoasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PessoasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PessoasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PessoasBindingNavigatorSaveItem})
        Me.PessoasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PessoasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PessoasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PessoasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PessoasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PessoasBindingNavigator.Name = "PessoasBindingNavigator"
        Me.PessoasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PessoasBindingNavigator.Size = New System.Drawing.Size(980, 25)
        Me.PessoasBindingNavigator.TabIndex = 0
        Me.PessoasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover seguinte"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PessoasBindingNavigatorSaveItem
        '
        Me.PessoasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PessoasBindingNavigatorSaveItem.Image = CType(resources.GetObject("PessoasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PessoasBindingNavigatorSaveItem.Name = "PessoasBindingNavigatorSaveItem"
        Me.PessoasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PessoasBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'PessoasDataGridView
        '
        Me.PessoasDataGridView.AutoGenerateColumns = False
        Me.PessoasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PessoasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PessoasDataGridView.DataSource = Me.PessoasBindingSource
        Me.PessoasDataGridView.Location = New System.Drawing.Point(52, 40)
        Me.PessoasDataGridView.Name = "PessoasDataGridView"
        Me.PessoasDataGridView.Size = New System.Drawing.Size(444, 157)
        Me.PessoasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idPessoa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idPessoa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apelido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apelido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataNascimento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DataNascimento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'PessoaContatoBindingSource
        '
        Me.PessoaContatoBindingSource.DataMember = "PessoaContato"
        Me.PessoaContatoBindingSource.DataSource = Me.TasksContactsDataSet
        '
        'PessoaContatoTableAdapter
        '
        Me.PessoaContatoTableAdapter.ClearBeforeFill = True
        '
        'ContatoDetalheBindingSource
        '
        Me.ContatoDetalheBindingSource.DataMember = "ContatoDetalhe"
        Me.ContatoDetalheBindingSource.DataSource = Me.TasksContactsDataSet
        '
        'ContatoDetalheTableAdapter
        '
        Me.ContatoDetalheTableAdapter.ClearBeforeFill = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(560, 61)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(137, 54)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(560, 135)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(137, 56)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'ContatoDetalheDataGridView
        '
        Me.ContatoDetalheDataGridView.AutoGenerateColumns = False
        Me.ContatoDetalheDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContatoDetalheDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ContatoDetalheDataGridView.DataSource = Me.ContatoDetalheBindingSource
        Me.ContatoDetalheDataGridView.Location = New System.Drawing.Point(52, 220)
        Me.ContatoDetalheDataGridView.Name = "ContatoDetalheDataGridView"
        Me.ContatoDetalheDataGridView.Size = New System.Drawing.Size(444, 139)
        Me.ContatoDetalheDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idContatoDetalhe"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idContatoDetalhe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idContato"
        Me.DataGridViewTextBoxColumn10.HeaderText = "idContato"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "idTipoContato"
        Me.DataGridViewTextBoxColumn11.HeaderText = "idTipoContato"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn12.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'TarefaPessoaBindingSource
        '
        Me.TarefaPessoaBindingSource.DataMember = "TarefaPessoa"
        Me.TarefaPessoaBindingSource.DataSource = Me.TasksContactsDataSet
        '
        'TarefaPessoaTableAdapter
        '
        Me.TarefaPessoaTableAdapter.ClearBeforeFill = True
        '
        'FrmContatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 399)
        Me.Controls.Add(Me.ContatoDetalheDataGridView)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.PessoasDataGridView)
        Me.Controls.Add(Me.PessoasBindingNavigator)
        Me.Name = "FrmContatos"
        Me.Text = "FrmContatos"
        CType(Me.TasksContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PessoasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PessoasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PessoasBindingNavigator.ResumeLayout(False)
        Me.PessoasBindingNavigator.PerformLayout()
        CType(Me.PessoasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PessoaContatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContatoDetalheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContatoDetalheDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarefaPessoaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TasksContactsDataSet As TasksContactsDataSet
    Friend WithEvents PessoasBindingSource As BindingSource
    Friend WithEvents PessoasTableAdapter As TasksContactsDataSetTableAdapters.PessoasTableAdapter
    Friend WithEvents TableAdapterManager As TasksContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PessoasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PessoasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PessoasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PessoaContatoBindingSource As BindingSource
    Friend WithEvents PessoaContatoTableAdapter As TasksContactsDataSetTableAdapters.PessoaContatoTableAdapter
    Friend WithEvents ContatoDetalheBindingSource As BindingSource
    Friend WithEvents ContatoDetalheTableAdapter As TasksContactsDataSetTableAdapters.ContatoDetalheTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents ContatoDetalheDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents TarefaPessoaBindingSource As BindingSource
    Friend WithEvents TarefaPessoaTableAdapter As TasksContactsDataSetTableAdapters.TarefaPessoaTableAdapter
End Class
