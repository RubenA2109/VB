<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAppMarcas
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
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 0)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(800, 450)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = "As marcas são as seguintes:" & vbLf & vbLf & "AA" & vbLf & "SS" & vbLf & "D" & vbLf & "ASD" & vbLf & "AS" & vbLf & "DA" & vbLf & "SD" & vbLf & "ASF" & vbLf & "ASF" & vbLf & "AS" & vbLf & "FSA" & vbLf & "DF" & vbLf & "AEW" & vbLf & "F" & vbLf & "DF" & vbLf & "ADS" & vbLf & "G" & vbLf & "DSF" & vbLf & "AD" & vbLf & "FGA" & vbLf & "DG" & vbLf & vbLf & "GA" & vbLf & "FG" & vbLf & "ED" & vbLf & "G" & vbLf & "EDGDG" & vbLf & vbLf & "P" & vbLf & "JUY" & vbLf & "~HIOL" & vbLf & "UGL" & vbLf
        ' 
        ' MenuAppMarcas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Name = "MenuAppMarcas"
        Text = "Marcas"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
End Class
