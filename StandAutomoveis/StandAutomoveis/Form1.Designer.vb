<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MenuAppAplicação = New ToolStripMenuItem()
        MenuAppSobre = New ToolStripMenuItem()
        MenuAppSair = New ToolStripMenuItem()
        MenuAppViaturas = New ToolStripMenuItem()
        MarcasToolStripMenuItem = New ToolStripMenuItem()
        ModelosToolStripMenuItem = New ToolStripMenuItem()
        ViaturasToolStripMenuItem1 = New ToolStripMenuItem()
        MenuAppAjuda = New ToolStripMenuItem()
        AbrirFormToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        AbrirForm3ToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuAppAplicação, MenuAppViaturas, MenuAppAjuda, AbrirFormToolStripMenuItem, SairToolStripMenuItem, AbrirForm3ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuAppAplicação
        ' 
        MenuAppAplicação.DropDownItems.AddRange(New ToolStripItem() {MenuAppSobre, MenuAppSair})
        MenuAppAplicação.Name = "MenuAppAplicação"
        MenuAppAplicação.Size = New Size(71, 20)
        MenuAppAplicação.Text = "Aplicação"
        ' 
        ' MenuAppSobre
        ' 
        MenuAppSobre.Name = "MenuAppSobre"
        MenuAppSobre.Size = New Size(180, 22)
        MenuAppSobre.Text = "Sobre"
        ' 
        ' MenuAppSair
        ' 
        MenuAppSair.Name = "MenuAppSair"
        MenuAppSair.Size = New Size(180, 22)
        MenuAppSair.Text = "Sair"
        ' 
        ' MenuAppViaturas
        ' 
        MenuAppViaturas.DropDownItems.AddRange(New ToolStripItem() {MarcasToolStripMenuItem, ModelosToolStripMenuItem, ViaturasToolStripMenuItem1})
        MenuAppViaturas.Name = "MenuAppViaturas"
        MenuAppViaturas.Size = New Size(61, 20)
        MenuAppViaturas.Text = "Viaturas"
        ' 
        ' MarcasToolStripMenuItem
        ' 
        MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        MarcasToolStripMenuItem.Size = New Size(180, 22)
        MarcasToolStripMenuItem.Text = "Marcas"
        ' 
        ' ModelosToolStripMenuItem
        ' 
        ModelosToolStripMenuItem.Name = "ModelosToolStripMenuItem"
        ModelosToolStripMenuItem.Size = New Size(180, 22)
        ModelosToolStripMenuItem.Text = "Modelos"
        ' 
        ' ViaturasToolStripMenuItem1
        ' 
        ViaturasToolStripMenuItem1.Name = "ViaturasToolStripMenuItem1"
        ViaturasToolStripMenuItem1.Size = New Size(180, 22)
        ViaturasToolStripMenuItem1.Text = "Viaturas"
        ' 
        ' MenuAppAjuda
        ' 
        MenuAppAjuda.Name = "MenuAppAjuda"
        MenuAppAjuda.Size = New Size(50, 20)
        MenuAppAjuda.Text = "Ajuda"
        ' 
        ' AbrirFormToolStripMenuItem
        ' 
        AbrirFormToolStripMenuItem.Name = "AbrirFormToolStripMenuItem"
        AbrirFormToolStripMenuItem.Size = New Size(76, 20)
        AbrirFormToolStripMenuItem.Text = "Abrir Form"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(38, 20)
        SairToolStripMenuItem.Text = "Sair"
        ' 
        ' AbrirForm3ToolStripMenuItem
        ' 
        AbrirForm3ToolStripMenuItem.Name = "AbrirForm3ToolStripMenuItem"
        AbrirForm3ToolStripMenuItem.Size = New Size(82, 20)
        AbrirForm3ToolStripMenuItem.Text = "Abrir Form3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Stand de Automóveis"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirForm3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAppAplicação As ToolStripMenuItem
    Friend WithEvents MenuAppSobre As ToolStripMenuItem
    Friend WithEvents MenuAppSair As ToolStripMenuItem
    Friend WithEvents MenuAppViaturas As ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModelosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViaturasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuAppAjuda As ToolStripMenuItem

End Class
