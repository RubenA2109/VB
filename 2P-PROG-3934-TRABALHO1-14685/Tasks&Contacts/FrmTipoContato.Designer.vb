<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTipoContato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoContato))
        Me.TasksContactsDataSet = New Tasks_Contacts.TasksContactsDataSet()
        Me.TipoContatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoContatoTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.TipoContatoTableAdapter()
        Me.TableAdapterManager = New Tasks_Contacts.TasksContactsDataSetTableAdapters.TableAdapterManager()
        Me.TipoContatoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TipoContatoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TipoContatoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PessoaContatoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PessoaContatoTableAdapter = New Tasks_Contacts.TasksContactsDataSetTableAdapters.PessoaContatoTableAdapter()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.TasksContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoContatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoContatoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipoContatoBindingNavigator.SuspendLayout()
        CType(Me.TipoContatoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PessoaContatoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TasksContactsDataSet
        '
        Me.TasksContactsDataSet.DataSetName = "TasksContactsDataSet"
        Me.TasksContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoContatoBindingSource
        '
        Me.TipoContatoBindingSource.DataMember = "TipoContato"
        Me.TipoContatoBindingSource.DataSource = Me.TasksContactsDataSet
        '
        'TipoContatoTableAdapter
        '
        Me.TipoContatoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TipoContatoTableAdapter = Me.TipoContatoTableAdapter
        Me.TableAdapterManager.TipoTarefaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tasks_Contacts.TasksContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TipoContatoBindingNavigator
        '
        Me.TipoContatoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TipoContatoBindingNavigator.BindingSource = Me.TipoContatoBindingSource
        Me.TipoContatoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TipoContatoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TipoContatoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TipoContatoBindingNavigatorSaveItem})
        Me.TipoContatoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TipoContatoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TipoContatoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TipoContatoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TipoContatoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TipoContatoBindingNavigator.Name = "TipoContatoBindingNavigator"
        Me.TipoContatoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TipoContatoBindingNavigator.Size = New System.Drawing.Size(686, 25)
        Me.TipoContatoBindingNavigator.TabIndex = 0
        Me.TipoContatoBindingNavigator.Text = "BindingNavigator1"
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
        'TipoContatoBindingNavigatorSaveItem
        '
        Me.TipoContatoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TipoContatoBindingNavigatorSaveItem.Image = CType(resources.GetObject("TipoContatoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TipoContatoBindingNavigatorSaveItem.Name = "TipoContatoBindingNavigatorSaveItem"
        Me.TipoContatoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TipoContatoBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'TipoContatoDataGridView
        '
        Me.TipoContatoDataGridView.AutoGenerateColumns = False
        Me.TipoContatoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipoContatoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TipoContatoDataGridView.DataSource = Me.TipoContatoBindingSource
        Me.TipoContatoDataGridView.Location = New System.Drawing.Point(42, 28)
        Me.TipoContatoDataGridView.Name = "TipoContatoDataGridView"
        Me.TipoContatoDataGridView.Size = New System.Drawing.Size(300, 142)
        Me.TipoContatoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idTipoContato"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idTipoContato"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descricao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descricao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
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
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(394, 118)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(119, 43)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(394, 56)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(119, 43)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'FrmTipoContato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 393)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.TipoContatoDataGridView)
        Me.Controls.Add(Me.TipoContatoBindingNavigator)
        Me.Name = "FrmTipoContato"
        CType(Me.TasksContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoContatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoContatoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipoContatoBindingNavigator.ResumeLayout(False)
        Me.TipoContatoBindingNavigator.PerformLayout()
        CType(Me.TipoContatoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PessoaContatoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TasksContactsDataSet As TasksContactsDataSet
    Friend WithEvents TipoContatoBindingSource As BindingSource
    Friend WithEvents TipoContatoTableAdapter As TasksContactsDataSetTableAdapters.TipoContatoTableAdapter
    Friend WithEvents TableAdapterManager As TasksContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TipoContatoBindingNavigator As BindingNavigator
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
    Friend WithEvents TipoContatoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TipoContatoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PessoaContatoBindingSource As BindingSource
    Friend WithEvents PessoaContatoTableAdapter As TasksContactsDataSetTableAdapters.PessoaContatoTableAdapter
    Friend WithEvents btnSair As Button
    Friend WithEvents btnEditar As Button
End Class
