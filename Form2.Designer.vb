<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NameTextBox.Location = New System.Drawing.Point(362, 69)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(250, 30)
        Me.NameTextBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EmailTextBox.Location = New System.Drawing.Point(362, 118)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(250, 30)
        Me.EmailTextBox.TabIndex = 1
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(362, 168)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(250, 30)
        Me.PhoneTextBox.TabIndex = 2
        '
        'GitHubTextBox
        '
        Me.GitHubTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GitHubTextBox.Location = New System.Drawing.Point(362, 218)
        Me.GitHubTextBox.Name = "GitHubTextBox"
        Me.GitHubTextBox.ReadOnly = True
        Me.GitHubTextBox.Size = New System.Drawing.Size(250, 30)
        Me.GitHubTextBox.TabIndex = 3
        '
        'StopwatchTextBox
        '
        Me.StopwatchTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.StopwatchTextBox.Location = New System.Drawing.Point(362, 267)
        Me.StopwatchTextBox.Name = "StopwatchTextBox"
        Me.StopwatchTextBox.ReadOnly = True
        Me.StopwatchTextBox.Size = New System.Drawing.Size(250, 30)
        Me.StopwatchTextBox.TabIndex = 4
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.Color.LightBlue
        Me.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PreviousButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PreviousButton.ForeColor = System.Drawing.Color.Black
        Me.PreviousButton.Location = New System.Drawing.Point(167, 321)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(220, 40)
        Me.PreviousButton.TabIndex = 5
        Me.PreviousButton.Text = "PREVIOUS (CTRL + P)"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.LightBlue
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NextButton.ForeColor = System.Drawing.Color.Black
        Me.NextButton.Location = New System.Drawing.Point(412, 321)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(226, 40)
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "NEXT (CTRL + N)"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(238, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label2.Location = New System.Drawing.Point(238, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label3.Location = New System.Drawing.Point(183, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone Num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label4.Location = New System.Drawing.Point(81, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 28)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "GitHub Link For Task 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label5.Location = New System.Drawing.Point(141, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Stopwatch Time"
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FloralWhite
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeleteButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteButton.Location = New System.Drawing.Point(167, 377)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(220, 40)
        Me.DeleteButton.TabIndex = 12
        Me.DeleteButton.Text = "DELETE (CTRL + D)"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FloralWhite
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EditButton.ForeColor = System.Drawing.Color.Black
        Me.EditButton.Location = New System.Drawing.Point(412, 377)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(226, 40)
        Me.EditButton.TabIndex = 13
        Me.EditButton.Text = "EDIT (CTRL + E)"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label6.Location = New System.Drawing.Point(182, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(470, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Mariya KJ, Slidely Task2 - Slidely Form App"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Click here"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
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
        Me.ForeColor = System.Drawing.Color.DarkMagenta
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
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip

End Class
