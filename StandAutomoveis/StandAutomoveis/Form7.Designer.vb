<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuViaturas1
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
        RichTextBox = New RichTextBox()
        SuspendLayout()
        ' 
        ' RichTextBox
        ' 
        RichTextBox.Dock = DockStyle.Fill
        RichTextBox.Location = New Point(0, 0)
        RichTextBox.Name = "RichTextBox"
        RichTextBox.ReadOnly = True
        RichTextBox.Size = New Size(800, 450)
        RichTextBox.TabIndex = 0
        RichTextBox.Text = "As viaturas são as seguintes :" & vbLf & vbLf & "AA" & vbLf & "SS" & vbLf & "DD" & vbLf & "FF" & vbLf & "GG" & vbLf & "HH" & vbLf & "JJ" & vbLf & "KK" & vbLf
        ' 
        ' MenuViaturas1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox)
        Name = "MenuViaturas1"
        Text = "Viaturas"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox As RichTextBox
End Class
