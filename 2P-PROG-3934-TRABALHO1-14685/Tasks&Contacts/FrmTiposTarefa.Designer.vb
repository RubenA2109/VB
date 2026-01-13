<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTiposTarefa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiposTarefa))
        Me.TasksContactsDataSet = New Tasks_Contacts.TasksContactsDataSet()
        Me.TipoTarefaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoTarefaTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.TipoTarefaTableAdapter()
        Me.TableAdapterManager = New Tasks_Contacts.TasksContactsDataSetTableAdapters.TableAdapterManager()
        Me.TipoTarefaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TipoTarefaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TipoTarefaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.TarefaPessoaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarefaPessoaTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.TarefaPessoaTableAdapter()
        CType(Me.TasksContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoTarefaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoTarefaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipoTarefaBindingNavigator.SuspendLayout()
        CType(Me.TipoTarefaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarefaPessoaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TasksContactsDataSet
        '
        Me.TasksContactsDataSet.DataSetName = "TasksContactsDataSet"
        Me.TasksContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoTarefaBindingSource
        '
        Me.TipoTarefaBindingSource.DataMember = "TipoTarefa"
        Me.TipoTarefaBindingSource.DataSource = Me.TasksContactsDataSet
        '
        'TipoTarefaTableAdapter
        '
        Me.TipoTarefaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContatoDetalheTableAdapter = Nothing
        Me.TableAdapterManager.ContatoTableAdapter = Nothing
        Me.TableAdapterManager.PessoaContatoTableAdapter = Nothing
        Me.TableAdapterManager.PessoasTableAdapter = Nothing
        Me.TableAdapterManager.TarefaPessoaTableAdapter = Nothing
        Me.TableAdapterManager.TarefasTableAdapter = Nothing
        Me.TableAdapterManager.TipoContatoTableAdapter = Nothing
        Me.TableAdapterManager.TipoTarefaTableAdapter = Me.TipoTarefaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tasks_Contacts.TasksContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TipoTarefaBindingNavigator
        '
        Me.TipoTarefaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TipoTarefaBindingNavigator.BindingSource = Me.TipoTarefaBindingSource
        Me.TipoTarefaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TipoTarefaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TipoTarefaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TipoTarefaBindingNavigatorSaveItem})
        Me.TipoTarefaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TipoTarefaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TipoTarefaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TipoTarefaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TipoTarefaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TipoTarefaBindingNavigator.Name = "TipoTarefaBindingNavigator"
        Me.TipoTarefaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TipoTarefaBindingNavigator.Size = New System.Drawing.Size(794, 25)
        Me.TipoTarefaBindingNavigator.TabIndex = 0
        Me.TipoTarefaBindingNavigator.Text = "BindingNavigator1"
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
        'TipoTarefaBindingNavigatorSaveItem
        '
        Me.TipoTarefaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TipoTarefaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TipoTarefaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TipoTarefaBindingNavigatorSaveItem.Name = "TipoTarefaBindingNavigatorSaveItem"
        Me.TipoTarefaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TipoTarefaBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'TipoTarefaDataGridView
        '
        Me.TipoTarefaDataGridView.AutoGenerateColumns = False
        Me.TipoTarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipoTarefaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TipoTarefaDataGridView.DataSource = Me.TipoTarefaBindingSource
        Me.TipoTarefaDataGridView.Location = New System.Drawing.Point(41, 88)
        Me.TipoTarefaDataGridView.Name = "TipoTarefaDataGridView"
        Me.TipoTarefaDataGridView.Size = New System.Drawing.Size(246, 122)
        Me.TipoTarefaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idTipoTarefa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idTipoTarefa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descricao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descricao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(487, 183)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(119, 43)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(487, 88)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(119, 43)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
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
        'FrmTiposTarefa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 460)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.TipoTarefaDataGridView)
        Me.Controls.Add(Me.TipoTarefaBindingNavigator)
        Me.Name = "FrmTiposTarefa"
        Me.Text = "FrmTiposTarefa"
        CType(Me.TasksContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoTarefaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoTarefaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipoTarefaBindingNavigator.ResumeLayout(False)
        Me.TipoTarefaBindingNavigator.PerformLayout()
        CType(Me.TipoTarefaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarefaPessoaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TasksContactsDataSet As TasksContactsDataSet
    Friend WithEvents TipoTarefaBindingSource As BindingSource
    Friend WithEvents TipoTarefaTableAdapter As TasksContactsDataSetTableAdapters.TipoTarefaTableAdapter
    Friend WithEvents TableAdapterManager As TasksContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TipoTarefaBindingNavigator As BindingNavigator
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
    Friend WithEvents TipoTarefaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TipoTarefaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnSair As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents TarefaPessoaBindingSource As BindingSource
    Friend WithEvents TarefaPessoaTableAdapter As TasksContactsDataSetTableAdapters.TarefaPessoaTableAdapter
End Class
