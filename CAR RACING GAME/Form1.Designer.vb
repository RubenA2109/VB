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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        race3 = New PictureBox()
        race1 = New PictureBox()
        car = New PictureBox()
        race2 = New PictureBox()
        RoadMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        RaceMover1 = New Timer(components)
        RaceMover2 = New Timer(components)
        RaceMover3 = New Timer(components)
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(race3, ComponentModel.ISupportInitialize).BeginInit()
        CType(race1, ComponentModel.ISupportInitialize).BeginInit()
        CType(car, ComponentModel.ISupportInitialize).BeginInit()
        CType(race2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Location = New Point(94, -57)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(15, 128)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Location = New Point(211, 101)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(15, 128)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Location = New Point(211, -57)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(15, 128)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.Location = New Point(94, 101)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(15, 128)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.ButtonHighlight
        PictureBox5.Location = New Point(211, 252)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(15, 128)
        PictureBox5.TabIndex = 6
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.ButtonHighlight
        PictureBox6.Location = New Point(94, 252)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(15, 128)
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.ButtonHighlight
        PictureBox7.Location = New Point(211, 407)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(15, 128)
        PictureBox7.TabIndex = 8
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.ButtonHighlight
        PictureBox8.Location = New Point(94, 407)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(15, 128)
        PictureBox8.TabIndex = 7
        PictureBox8.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 25)
        Label1.TabIndex = 9
        Label1.Text = "SCORE 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(246, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 25)
        Label2.TabIndex = 10
        Label2.Text = "SPEED 0"
        ' 
        ' race3
        ' 
        race3.Image = My.Resources.Resources._3
        race3.Location = New Point(12, 211)
        race3.Name = "race3"
        race3.Size = New Size(49, 79)
        race3.SizeMode = PictureBoxSizeMode.Zoom
        race3.TabIndex = 11
        race3.TabStop = False
        ' 
        ' race1
        ' 
        race1.Image = My.Resources.Resources._4
        race1.Location = New Point(260, 211)
        race1.Name = "race1"
        race1.Size = New Size(52, 79)
        race1.SizeMode = PictureBoxSizeMode.Zoom
        race1.TabIndex = 12
        race1.TabStop = False
        ' 
        ' car
        ' 
        car.Image = My.Resources.Resources._1
        car.Location = New Point(130, 342)
        car.Name = "car"
        car.Size = New Size(54, 80)
        car.SizeMode = PictureBoxSizeMode.Zoom
        car.TabIndex = 13
        car.TabStop = False
        ' 
        ' race2
        ' 
        race2.Image = My.Resources.Resources._2
        race2.Location = New Point(143, 61)
        race2.Name = "race2"
        race2.Size = New Size(41, 95)
        race2.SizeMode = PictureBoxSizeMode.Zoom
        race2.TabIndex = 14
        race2.TabStop = False
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' RaceMover1
        ' 
        RaceMover1.Enabled = True
        RaceMover1.Interval = 10
        ' 
        ' RaceMover2
        ' 
        RaceMover2.Enabled = True
        RaceMover2.Interval = 10
        ' 
        ' RaceMover3
        ' 
        RaceMover3.Enabled = True
        RaceMover3.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Firebrick
        Label3.Location = New Point(67, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 59)
        Label3.TabIndex = 15
        Label3.Text = "GAMEOVER"
        Label3.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PeachPuff
        Button1.Font = New Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.WindowText
        Button1.Location = New Point(105, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 45)
        Button1.TabIndex = 16
        Button1.Text = "REPLAY"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(246, 414)
        Button2.Name = "Button2"
        Button2.Size = New Size(69, 35)
        Button2.TabIndex = 17
        Button2.Text = "START"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(334, 461)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(race2)
        Controls.Add(car)
        Controls.Add(race1)
        Controls.Add(race3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        MaximumSize = New Size(350, 500)
        MinimumSize = New Size(350, 500)
        Name = "Form1"
        Text = "CAR RACING GAME"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(race3, ComponentModel.ISupportInitialize).EndInit()
        CType(race1, ComponentModel.ISupportInitialize).EndInit()
        CType(car, ComponentModel.ISupportInitialize).EndInit()
        CType(race2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents race3 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents race2 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RaceMover1 As Timer
    Friend WithEvents RaceMover2 As Timer
    Friend WithEvents RaceMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
