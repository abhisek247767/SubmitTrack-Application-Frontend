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
        lblStopwatch = New Label()
        btnPrevious = New Button()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtName = New TextBox()
        timerStopwatch = New Timer(components)
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnNext = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(339, 277)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 17
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.ButtonHighlight
        btnPrevious.Location = New Point(288, 331)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(94, 29)
        btnPrevious.TabIndex = 16
        btnPrevious.Text = "PREVIOUS "
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(329, 127)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter your Email"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(248, 27)
        txtEmail.TabIndex = 14
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(329, 171)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Enter your Contact Number"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(248, 27)
        txtPhone.TabIndex = 13
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(329, 220)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.PlaceholderText = "Enter your Github Repository Link"
        txtGitHub.ReadOnly = True
        txtGitHub.Size = New Size(248, 27)
        txtGitHub.TabIndex = 12
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(329, 82)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter your name"
        txtName.ReadOnly = True
        txtName.Size = New Size(248, 27)
        txtName.TabIndex = 11
        ' 
        ' timerStopwatch
        ' 
        timerStopwatch.Interval = 1000
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(224, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 21
        Label4.Text = "Contact No"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(227, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 20
        Label3.Text = "Github Link"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(224, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 19
        Label2.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 18
        Label1.Text = "Email"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ButtonHighlight
        btnNext.Location = New Point(453, 331)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 22
        btnNext.Text = "NEXT"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(384, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 20)
        Label5.TabIndex = 23
        Label5.Text = "VIEW SUBMISSIONS"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(btnNext)
        Controls.Add(lblStopwatch)
        Controls.Add(btnPrevious)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitHub)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents timerStopwatch As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Label5 As Label
End Class
