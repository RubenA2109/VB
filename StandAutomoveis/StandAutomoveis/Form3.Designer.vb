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
        RichTextBox1.Text = "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & vbLf & "a" & vbLf & "a" & vbLf & vbLf & "a" & vbLf & "aa" & vbLf & "a" & vbLf & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & "a" & vbLf & vbLf & "sdf" & vbLf & "sd" & vbLf & "sd" & vbLf & "fs" & vbLf & "df" & vbLf & "sdf" & vbLf & "sd" & vbLf & "fsd" & vbLf & "g" & vbLf & "drh" & vbLf & "rtu" & vbLf & "457" & vbLf & "45" & vbLf & "e" & vbLf & vbLf & "a"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Name = "Form3"
        Text = "Sobre"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
End Class
