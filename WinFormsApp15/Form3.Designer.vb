<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label6 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Stopwatchbtn = New Button()
        Labelstopwatch = New Label()
        TextBox1 = New TextBox()
        TextBox6 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Submitbtn = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(57, 101)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 6
        Label6.Text = "NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(117, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(238, 20)
        Label1.TabIndex = 7
        Label1.Text = "Slidely Task 2 - Create Submissions"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 20)
        Label5.TabIndex = 8
        Label5.Text = "EMAIL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 9
        Label4.Text = "PHONE NO."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 10
        Label3.Text = "GIT HUB LINK"
        ' 
        ' Stopwatchbtn
        ' 
        Stopwatchbtn.BackColor = SystemColors.Info
        Stopwatchbtn.Location = New Point(57, 316)
        Stopwatchbtn.Name = "Stopwatchbtn"
        Stopwatchbtn.Size = New Size(117, 50)
        Stopwatchbtn.TabIndex = 15
        Stopwatchbtn.Text = "STOPWATCH (CTRL+T)"
        Stopwatchbtn.UseVisualStyleBackColor = False
        ' 
        ' Labelstopwatch
        ' 
        Labelstopwatch.AutoSize = True
        Labelstopwatch.Location = New Point(237, 331)
        Labelstopwatch.Name = "Labelstopwatch"
        Labelstopwatch.Size = New Size(53, 20)
        Labelstopwatch.TabIndex = 16
        Labelstopwatch.Text = "Label2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(166, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 27)
        TextBox1.TabIndex = 17
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(166, 156)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(206, 27)
        TextBox6.TabIndex = 18
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(166, 212)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(206, 27)
        TextBox2.TabIndex = 19
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(166, 268)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(206, 27)
        TextBox3.TabIndex = 20
        ' 
        ' Submitbtn
        ' 
        Submitbtn.BackColor = SystemColors.InactiveCaption
        Submitbtn.Location = New Point(166, 380)
        Submitbtn.Name = "Submitbtn"
        Submitbtn.Size = New Size(153, 48)
        Submitbtn.TabIndex = 21
        Submitbtn.Text = "SUBMIT (CTRL+S)"
        Submitbtn.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(462, 450)
        Controls.Add(Submitbtn)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox6)
        Controls.Add(TextBox1)
        Controls.Add(Labelstopwatch)
        Controls.Add(Stopwatchbtn)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Name = "Form3"
        Text = "Create Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Stopwatchbtn As Button
    Friend WithEvents Labelstopwatch As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Submitbtn As Button
    Friend WithEvents Timer1 As Timer
End Class
