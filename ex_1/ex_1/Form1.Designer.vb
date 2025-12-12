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
        BotCalcular = New Button()
        Label1 = New Label()
        ValorAltura = New TextBox()
        ValorPeso = New TextBox()
        Label2 = New Label()
        Resultado = New TextBox()
        SuspendLayout()
        ' 
        ' BotCalcular
        ' 
        BotCalcular.Location = New Point(201, 251)
        BotCalcular.Name = "BotCalcular"
        BotCalcular.Size = New Size(122, 53)
        BotCalcular.TabIndex = 0
        BotCalcular.Text = "Calcular"
        BotCalcular.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(115, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Altura"
        ' 
        ' ValorAltura
        ' 
        ValorAltura.Location = New Point(202, 91)
        ValorAltura.Name = "ValorAltura"
        ValorAltura.Size = New Size(100, 23)
        ValorAltura.TabIndex = 2
        ' 
        ' ValorPeso
        ' 
        ValorPeso.Location = New Point(201, 147)
        ValorPeso.Name = "ValorPeso"
        ValorPeso.Size = New Size(100, 23)
        ValorPeso.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(115, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 4
        Label2.Text = "Peso"
        ' 
        ' Resultado
        ' 
        Resultado.Enabled = False
        Resultado.Location = New Point(201, 200)
        Resultado.Name = "Resultado"
        Resultado.Size = New Size(100, 23)
        Resultado.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(505, 409)
        Controls.Add(Resultado)
        Controls.Add(Label2)
        Controls.Add(ValorPeso)
        Controls.Add(ValorAltura)
        Controls.Add(Label1)
        Controls.Add(BotCalcular)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Projeto #1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BotCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ValorAltura As TextBox
    Friend WithEvents ValorPeso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Resultado As TextBox

End Class
