Public Partial Class LoginForm
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OperationListComboBox.SelectedIndex = 0
    End Sub

    Private Sub UsernameTextBox_Enter(sender As Object, e As EventArgs) Handles UsernameTextBox.Enter
        If UsernameTextBox.Text = "Username" Then
            UsernameTextBox.Clear()
        End If
    End Sub

    Private Sub UsernameTextBox_Leave(sender As Object, e As EventArgs) Handles UsernameTextBox.Leave
        If UsernameTextBox.Text = String.Empty Then
            UsernameTextBox.Text = "Username"
        End If
    End Sub

    Private Sub PasswordTextBox_Enter(sender As Object, e As EventArgs) Handles PasswordTextBox.Enter
        If PasswordTextBox.Text = "Password" Then
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If PasswordTextBox.Text = String.Empty Then
            PasswordTextBox.Text = "Password"
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTextBox.Text = "Admin" AndAlso PasswordTextBox.Text = "Password" Then
            LoginGroupBox.Enabled = False
            OperationGroupBox.Enabled = True
            Me.Size = New Size(300, 282)
        Else
            MessageBox.Show("Username & Password combination is incorrect.", "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub OperationButton_Click(sender As Object, e As EventArgs) Handles OperationButton.Click
        Select Case OperationListComboBox.SelectedIndex
            Case 0
                EmployeeRegistration.Show()
                Exit Select

            Case 1
                ProjectRegistration.Show()
                Exit Select

            Case 2
                ProjectAllocation.Show()
                Exit Select

            Case 3
                TrainingAssessment.Show()
                Exit Select

            Case 4
                DatabaseForm.Show()
                Exit Select
        End Select
    End Sub

    Private Sub AboutStatusStripLabel_Click(sender As Object, e As EventArgs) Handles AboutStatusStripLabel.Click
        About.Show()
    End Sub
End Class