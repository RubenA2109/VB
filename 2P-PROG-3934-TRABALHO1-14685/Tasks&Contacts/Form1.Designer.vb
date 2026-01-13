<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeContatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeTarefaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarefasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplicaçãoToolStripMenuItem, Me.ContactosToolStripMenuItem, Me.TarefasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(817, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AplicaçãoToolStripMenuItem
        '
        Me.AplicaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.AplicaçãoToolStripMenuItem.Name = "AplicaçãoToolStripMenuItem"
        Me.AplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AplicaçãoToolStripMenuItem.Text = "Aplicação"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem.Text = "Sair do Programa"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposDeContatoToolStripMenuItem, Me.ContatosToolStripMenuItem})
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'TiposDeContatoToolStripMenuItem
        '
        Me.TiposDeContatoToolStripMenuItem.Name = "TiposDeContatoToolStripMenuItem"
        Me.TiposDeContatoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TiposDeContatoToolStripMenuItem.Text = "Tipos de contato"
        '
        'ContatosToolStripMenuItem
        '
        Me.ContatosToolStripMenuItem.Name = "ContatosToolStripMenuItem"
        Me.ContatosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContatosToolStripMenuItem.Text = "Contatos"
        '
        'TarefasToolStripMenuItem
        '
        Me.TarefasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposDeTarefaToolStripMenuItem, Me.TarefasToolStripMenuItem1})
        Me.TarefasToolStripMenuItem.Name = "TarefasToolStripMenuItem"
        Me.TarefasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.TarefasToolStripMenuItem.Text = "Tarefas"
        '
        'TiposDeTarefaToolStripMenuItem
        '
        Me.TiposDeTarefaToolStripMenuItem.Name = "TiposDeTarefaToolStripMenuItem"
        Me.TiposDeTarefaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TiposDeTarefaToolStripMenuItem.Text = "Tipos de Tarefa"
        '
        'TarefasToolStripMenuItem1
        '
        Me.TarefasToolStripMenuItem1.Name = "TarefasToolStripMenuItem1"
        Me.TarefasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.TarefasToolStripMenuItem1.Text = "Tarefas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AplicaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeContatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarefasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeTarefaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarefasToolStripMenuItem1 As ToolStripMenuItem
End Class
