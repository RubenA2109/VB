<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMarcas
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
        RichTextBox2 = New RichTextBox()
        SuspendLayout()
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Dock = DockStyle.Fill
        RichTextBox2.Location = New Point(0, 0)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.Size = New Size(800, 450)
        RichTextBox2.TabIndex = 0
        RichTextBox2.Text = "As marcas são as seguintes :" & vbLf & vbLf & "AA" & vbLf & "SS" & vbLf & "DD" & vbLf & "FF" & vbLf & "GG" & vbLf & "HH" & vbLf & "JJ" & vbLf & "KK" & vbLf
        ' 
        ' MenuMarcas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox2)
        Name = "MenuMarcas"
        Text = "Marcas"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox2 As RichTextBox
End Class
