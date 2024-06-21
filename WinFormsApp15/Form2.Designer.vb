<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label4 = New Label()
        Label6 = New Label()
        previousbtn = New Button()
        nextbtn = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 307)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 12
        Label4.Text = "GIT HUB LINK"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(132, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(220, 20)
        Label6.TabIndex = 14
        Label6.Text = "Slidely task 2 - View Submission"
        ' 
        ' previousbtn
        ' 
        previousbtn.BackColor = SystemColors.Info
        previousbtn.Location = New Point(12, 360)
        previousbtn.Name = "previousbtn"
        previousbtn.Size = New Size(236, 56)
        previousbtn.TabIndex = 15
        previousbtn.Text = "PREVIOUS (CTRL+P)"
        previousbtn.UseVisualStyleBackColor = False
        ' 
        ' nextbtn
        ' 
        nextbtn.BackColor = SystemColors.InactiveCaption
        nextbtn.Location = New Point(257, 360)
        nextbtn.Name = "nextbtn"
        nextbtn.Size = New Size(236, 56)
        nextbtn.TabIndex = 16
        nextbtn.Text = "Next (CTRL+N)"
        nextbtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 20)
        Label5.TabIndex = 17
        Label5.Text = "STOP WATCH TIME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 18
        Label3.Text = "PHONE NO."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 19
        Label2.Text = "EMAIL"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 20
        Label1.Text = "NAME"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(505, 450)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(nextbtn)
        Controls.Add(previousbtn)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Name = "Form2"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents previousbtn As Button
    Friend WithEvents nextbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
