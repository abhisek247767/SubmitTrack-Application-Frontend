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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtGitHub = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        lblStopwatch = New Label()
        timerStopwatch = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(203, 72)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter your name"
        txtName.Size = New Size(248, 27)
        txtName.TabIndex = 0
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(203, 210)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.PlaceholderText = "Enter your Github Repository Link"
        txtGitHub.Size = New Size(248, 27)
        txtGitHub.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(203, 161)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Enter your Contact Number"
        txtPhone.Size = New Size(248, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(203, 117)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter your Email"
        txtEmail.Size = New Size(248, 27)
        txtEmail.TabIndex = 3
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(357, 267)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(94, 29)
        btnToggleStopwatch.TabIndex = 4
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(262, 330)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "SUBMIT "
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(213, 267)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(63, 20)
        lblStopwatch.TabIndex = 6
        lblStopwatch.Text = "00:00:00"
        ' 
        ' timerStopwatch
        ' 
        timerStopwatch.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 7
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 9
        Label3.Text = "Github Link"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(98, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 10
        Label4.Text = "Contact No"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(273, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 20)
        Label5.TabIndex = 11
        Label5.Text = "CREATE SUBMISSION"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitHub)
        Controls.Add(txtName)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents timerStopwatch As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
