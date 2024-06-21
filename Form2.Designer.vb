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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.GitHubTextBox = New System.Windows.Forms.TextBox()
        Me.StopwatchTextBox = New System.Windows.Forms.TextBox()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(335, 51)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(335, 81)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 1
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(335, 111)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PhoneTextBox.TabIndex = 2
        '
        'GitHubTextBox
        '
        Me.GitHubTextBox.Location = New System.Drawing.Point(335, 141)
        Me.GitHubTextBox.Name = "GitHubTextBox"
        Me.GitHubTextBox.ReadOnly = True
        Me.GitHubTextBox.Size = New System.Drawing.Size(200, 22)
        Me.GitHubTextBox.TabIndex = 3
        '
        'StopwatchTextBox
        '
        Me.StopwatchTextBox.Location = New System.Drawing.Point(335, 171)
        Me.StopwatchTextBox.Name = "StopwatchTextBox"
        Me.StopwatchTextBox.ReadOnly = True
        Me.StopwatchTextBox.Size = New System.Drawing.Size(200, 22)
        Me.StopwatchTextBox.TabIndex = 4
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.LightBlue
        Me.PreviousButton.Location = New System.Drawing.Point(246, 214)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(160, 30)
        Me.PreviousButton.TabIndex = 5
        Me.PreviousButton.Text = "PREVIOUS (CTRL + P)"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.LightBlue
        Me.NextButton.Location = New System.Drawing.Point(435, 214)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(160, 30)
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "NEXT (CTRL + N)"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone Num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = " Github Link For Task 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Stopwatch Time"
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Coral
        Me.DeleteButton.Location = New System.Drawing.Point(246, 259)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(160, 34)
        Me.DeleteButton.TabIndex = 12
        Me.DeleteButton.Text = "DELETE (CTRL + D)"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.Coral
        Me.EditButton.Location = New System.Drawing.Point(435, 259)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(160, 34)
        Me.EditButton.TabIndex = 13
        Me.EditButton.Text = "EDIT (CTRL + E)"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(722, 407)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.StopwatchTextBox)
        Me.Controls.Add(Me.GitHubTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents GitHubTextBox As TextBox
    Friend WithEvents StopwatchTextBox As TextBox
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
End Class
