<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim NrLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim Nr_TipoLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EquipamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDataSet = New BD_Ex8.BDDataSet()
        Me.TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NrTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox()
        Me.Nr_TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EquipamentosTableAdapter = New BD_Ex8.BDDataSetTableAdapters.EquipamentosTableAdapter()
        Me.TableAdapterManager = New BD_Ex8.BDDataSetTableAdapters.TableAdapterManager()
        Me.TiposTableAdapter = New BD_Ex8.BDDataSetTableAdapters.TiposTableAdapter()
        Me.EquipamentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EquipamentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_novo = New System.Windows.Forms.Button()
        Me.btn_remover = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_seguinte = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        NrLabel = New System.Windows.Forms.Label()
        DescriçãoLabel = New System.Windows.Forms.Label()
        Nr_TipoLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EquipamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquipamentosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NrLabel
        '
        NrLabel.AutoSize = True
        NrLabel.Location = New System.Drawing.Point(33, 49)
        NrLabel.Name = "NrLabel"
        NrLabel.Size = New System.Drawing.Size(21, 13)
        NrLabel.TabIndex = 0
        NrLabel.Text = "Nr:"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Location = New System.Drawing.Point(33, 75)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(58, 13)
        DescriçãoLabel.TabIndex = 2
        DescriçãoLabel.Text = "Descrição:"
        '
        'Nr_TipoLabel
        '
        Nr_TipoLabel.AutoSize = True
        Nr_TipoLabel.Location = New System.Drawing.Point(33, 101)
        Nr_TipoLabel.Name = "Nr_TipoLabel"
        Nr_TipoLabel.Size = New System.Drawing.Size(45, 13)
        Nr_TipoLabel.TabIndex = 4
        Nr_TipoLabel.Text = "Nr Tipo:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(33, 128)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 6
        DataLabel.Text = "Data:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EquipamentosBindingSource, "Nr Tipo", True))
        Me.ComboBox1.DataSource = Me.TiposBindingSource
        Me.ComboBox1.DisplayMember = "Nome Tipo"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(589, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Nr Tipo"
        '
        'EquipamentosBindingSource
        '
        Me.EquipamentosBindingSource.DataMember = "Equipamentos"
        Me.EquipamentosBindingSource.DataSource = Me.BDDataSet
        '
        'BDDataSet
        '
        Me.BDDataSet.DataSetName = "BDDataSet"
        Me.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposBindingSource
        '
        Me.TiposBindingSource.DataMember = "Tipos"
        Me.TiposBindingSource.DataSource = Me.BDDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Beige
        Me.GroupBox1.Controls.Add(NrLabel)
        Me.GroupBox1.Controls.Add(Me.NrTextBox)
        Me.GroupBox1.Controls.Add(DescriçãoLabel)
        Me.GroupBox1.Controls.Add(Me.DescriçãoTextBox)
        Me.GroupBox1.Controls.Add(Nr_TipoLabel)
        Me.GroupBox1.Controls.Add(Me.Nr_TipoTextBox)
        Me.GroupBox1.Controls.Add(DataLabel)
        Me.GroupBox1.Controls.Add(Me.DataDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 195)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'NrTextBox
        '
        Me.NrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Nr", True))
        Me.NrTextBox.Location = New System.Drawing.Point(97, 46)
        Me.NrTextBox.Name = "NrTextBox"
        Me.NrTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NrTextBox.TabIndex = 1
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Descrição", True))
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(97, 72)
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriçãoTextBox.TabIndex = 3
        '
        'Nr_TipoTextBox
        '
        Me.Nr_TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquipamentosBindingSource, "Nr Tipo", True))
        Me.Nr_TipoTextBox.Location = New System.Drawing.Point(97, 98)
        Me.Nr_TipoTextBox.Name = "Nr_TipoTextBox"
        Me.Nr_TipoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nr_TipoTextBox.TabIndex = 5
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquipamentosBindingSource, "Data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(97, 124)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 7
        '
        'EquipamentosTableAdapter
        '
        Me.EquipamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EquipamentosTableAdapter = Me.EquipamentosTableAdapter
        Me.TableAdapterManager.TiposTableAdapter = Me.TiposTableAdapter
        Me.TableAdapterManager.UpdateOrder = BD_Ex8.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TiposTableAdapter
        '
        Me.TiposTableAdapter.ClearBeforeFill = True
        '
        'EquipamentosBindingNavigator
        '
        Me.EquipamentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EquipamentosBindingNavigator.BindingSource = Me.EquipamentosBindingSource
        Me.EquipamentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EquipamentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EquipamentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EquipamentosBindingNavigatorSaveItem})
        Me.EquipamentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EquipamentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EquipamentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EquipamentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EquipamentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EquipamentosBindingNavigator.Name = "EquipamentosBindingNavigator"
        Me.EquipamentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EquipamentosBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EquipamentosBindingNavigator.TabIndex = 2
        Me.EquipamentosBindingNavigator.Text = "BindingNavigator1"
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
        'EquipamentosBindingNavigatorSaveItem
        '
        Me.EquipamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EquipamentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EquipamentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EquipamentosBindingNavigatorSaveItem.Name = "EquipamentosBindingNavigatorSaveItem"
        Me.EquipamentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EquipamentosBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(691, 353)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(96, 36)
        Me.btn_sair.TabIndex = 20
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_fechar
        '
        Me.btn_fechar.Location = New System.Drawing.Point(579, 353)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(96, 36)
        Me.btn_fechar.TabIndex = 19
        Me.btn_fechar.Text = "Fechar"
        Me.btn_fechar.UseVisualStyleBackColor = True
        '
        'btn_novo
        '
        Me.btn_novo.Location = New System.Drawing.Point(232, 353)
        Me.btn_novo.Name = "btn_novo"
        Me.btn_novo.Size = New System.Drawing.Size(96, 36)
        Me.btn_novo.TabIndex = 18
        Me.btn_novo.Text = "Novo"
        Me.btn_novo.UseVisualStyleBackColor = True
        '
        'btn_remover
        '
        Me.btn_remover.Location = New System.Drawing.Point(463, 353)
        Me.btn_remover.Name = "btn_remover"
        Me.btn_remover.Size = New System.Drawing.Size(96, 36)
        Me.btn_remover.TabIndex = 17
        Me.btn_remover.Text = "Remover"
        Me.btn_remover.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.Cyan
        Me.btn_gravar.Location = New System.Drawing.Point(345, 353)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(96, 36)
        Me.btn_gravar.TabIndex = 16
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'btn_seguinte
        '
        Me.btn_seguinte.Location = New System.Drawing.Point(118, 353)
        Me.btn_seguinte.Name = "btn_seguinte"
        Me.btn_seguinte.Size = New System.Drawing.Size(96, 36)
        Me.btn_seguinte.TabIndex = 15
        Me.btn_seguinte.Text = "Seguinte"
        Me.btn_seguinte.UseVisualStyleBackColor = True
        '
        'btn_anterior
        '
        Me.btn_anterior.Location = New System.Drawing.Point(7, 353)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(96, 36)
        Me.btn_anterior.TabIndex = 14
        Me.btn_anterior.Text = "Anterior"
        Me.btn_anterior.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.btn_novo)
        Me.Controls.Add(Me.btn_remover)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.btn_seguinte)
        Me.Controls.Add(Me.btn_anterior)
        Me.Controls.Add(Me.EquipamentosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EquipamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquipamentosBindingNavigator.ResumeLayout(False)
        Me.EquipamentosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BDDataSet As BDDataSet
    Friend WithEvents EquipamentosBindingSource As BindingSource
    Friend WithEvents EquipamentosTableAdapter As BDDataSetTableAdapters.EquipamentosTableAdapter
    Friend WithEvents TableAdapterManager As BDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquipamentosBindingNavigator As BindingNavigator
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
    Friend WithEvents EquipamentosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NrTextBox As TextBox
    Friend WithEvents DescriçãoTextBox As TextBox
    Friend WithEvents Nr_TipoTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents TiposTableAdapter As BDDataSetTableAdapters.TiposTableAdapter
    Friend WithEvents TiposBindingSource As BindingSource
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_fechar As Button
    Friend WithEvents btn_novo As Button
    Friend WithEvents btn_remover As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_seguinte As Button
    Friend WithEvents btn_anterior As Button
End Class
