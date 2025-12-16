<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAppModelos
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
        RichTextBox1.Size = New Size(800, 450)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = "Os modelos são os seguintes:" & vbLf & "a<" & vbLf & "sa" & vbLf & "s" & vbLf & "as" & vbLf & "a" & vbLf & "sd" & vbLf & "asda" & vbLf & "sd" & vbLf & "as" & vbLf & "das" & vbLf & "d" & vbLf & "as" & vbLf & "f" & vbLf & "asd" & vbLf & "f" & vbLf & "aew" & vbLf & vbLf & "34" & vbLf & "t" & vbLf & "ead" & vbLf & "gasedg" & vbLf & "seda" & vbLf & "gf" & vbLf & "easdg" & vbLf & "eqr" & vbLf & "g" & vbLf & "erdsag" & vbLf & "324tg" & vbLf & "t4" & vbLf & "35tga" & vbLf & "d"
        ' 
        ' MenuAppModelos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Name = "MenuAppModelos"
        Text = "Modelos"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
End Class
