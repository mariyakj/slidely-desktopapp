<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.GitHubTextBox = New System.Windows.Forms.TextBox()
        Me.StopwatchTextBox = New System.Windows.Forms.TextBox()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelStopwatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(314, 42)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(314, 72)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 1
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(314, 102)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PhoneTextBox.TabIndex = 2
        '
        'GitHubTextBox
        '
        Me.GitHubTextBox.Location = New System.Drawing.Point(314, 132)
        Me.GitHubTextBox.Name = "GitHubTextBox"
        Me.GitHubTextBox.Size = New System.Drawing.Size(200, 22)
        Me.GitHubTextBox.TabIndex = 3
        '
        'StopwatchTextBox
        '
        Me.StopwatchTextBox.Location = New System.Drawing.Point(314, 178)
        Me.StopwatchTextBox.Name = "StopwatchTextBox"
        Me.StopwatchTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StopwatchTextBox.TabIndex = 4
        '
        'StartStopButton
        '
        Me.StartStopButton.BackColor = System.Drawing.Color.LightYellow
        Me.StartStopButton.Location = New System.Drawing.Point(50, 174)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(235, 30)
        Me.StartStopButton.TabIndex = 5
        Me.StartStopButton.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.StartStopButton.UseVisualStyleBackColor = False
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.LightBlue
        Me.SubmitButton.Location = New System.Drawing.Point(50, 223)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(472, 61)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "SUBMIT (CTRL + S)"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone Num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Github Link For Task2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LabelStopwatch
        '
        Me.LabelStopwatch.AutoSize = True
        Me.LabelStopwatch.Location = New System.Drawing.Point(338, 181)
        Me.LabelStopwatch.Name = "LabelStopwatch"
        Me.LabelStopwatch.Size = New System.Drawing.Size(55, 16)
        Me.LabelStopwatch.TabIndex = 11
        Me.LabelStopwatch.Text = "00:00:00"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelStopwatch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.StartStopButton)
        Me.Controls.Add(Me.StopwatchTextBox)
        Me.Controls.Add(Me.GitHubTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents GitHubTextBox As TextBox
    Friend WithEvents StopwatchTextBox As TextBox
    Friend WithEvents StartStopButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelStopwatch As Label
End Class
