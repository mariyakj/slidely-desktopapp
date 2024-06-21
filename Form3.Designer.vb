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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NameTextBox.Location = New System.Drawing.Point(400, 110)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(250, 30)
        Me.NameTextBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EmailTextBox.Location = New System.Drawing.Point(400, 150)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(250, 30)
        Me.EmailTextBox.TabIndex = 1
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhoneTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(400, 190)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(250, 30)
        Me.PhoneTextBox.TabIndex = 2
        '
        'GitHubTextBox
        '
        Me.GitHubTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GitHubTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GitHubTextBox.Location = New System.Drawing.Point(400, 230)
        Me.GitHubTextBox.Name = "GitHubTextBox"
        Me.GitHubTextBox.Size = New System.Drawing.Size(250, 30)
        Me.GitHubTextBox.TabIndex = 3
        '
        'StopwatchTextBox
        '
        Me.StopwatchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StopwatchTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StopwatchTextBox.Location = New System.Drawing.Point(400, 270)
        Me.StopwatchTextBox.Name = "StopwatchTextBox"
        Me.StopwatchTextBox.Size = New System.Drawing.Size(250, 30)
        Me.StopwatchTextBox.TabIndex = 4
        '
        'StartStopButton
        '
        Me.StartStopButton.BackColor = System.Drawing.Color.LightYellow
        Me.StartStopButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartStopButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StartStopButton.Location = New System.Drawing.Point(62, 265)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(294, 35)
        Me.StartStopButton.TabIndex = 5
        Me.StartStopButton.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.StartStopButton.UseVisualStyleBackColor = False
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.LightBlue
        Me.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SubmitButton.Location = New System.Drawing.Point(134, 330)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(472, 61)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "SUBMIT (CTRL + S)"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(300, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(300, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(249, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone Num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(185, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Github Link For Task2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label6.Location = New System.Drawing.Point(200, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(407, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Mariya KJ, Slidely Task2 - Slidely Form App"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
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
    Friend WithEvents Label6 As Label
End Class
