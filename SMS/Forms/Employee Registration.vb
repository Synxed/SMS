Imports System.Data.OleDb

Public Partial Class EmployeeRegistration
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Dim command As Object = "INSERT INTO Employees (EmployeeID, FullName, Sex, Age, Salary, Mobile, PHP, CSharp, CPP, Python, Java, Swift)" + "Values (@EmployeeID, @Name, @Sex, @Age, @Salary, @Mobile, @PHP, @CSharp, @CPP, @Python, @Java, @Swift)"

                Using addQueryCommand As New OleDbCommand(command, connection)
                    addQueryCommand.Parameters.AddWithValue("@EmployeeID", EmployeeIDTextBox.Text)
                    addQueryCommand.Parameters.AddWithValue("@Name", NameTextBox.Text)
                    addQueryCommand.Parameters.AddWithValue("@Sex", SexTextBox.Text)
                    addQueryCommand.Parameters.AddWithValue("@Age", Integer.Parse(AgeTextBox.Text))
                    addQueryCommand.Parameters.AddWithValue("@Salary", Decimal.Parse(SalaryTextBox.Text))
                    addQueryCommand.Parameters.AddWithValue("@Mobile", MobileTextBox.Text)
                    addQueryCommand.Parameters.AddWithValue("@PHP", PHPCheckBox.Checked)
                    addQueryCommand.Parameters.AddWithValue("@CSharp", CSharpCheckBox.Checked)
                    addQueryCommand.Parameters.AddWithValue("@CPP", CPPCheckBox.Checked)
                    addQueryCommand.Parameters.AddWithValue("@Python", PythonCheckBox.Checked)
                    addQueryCommand.Parameters.AddWithValue("@Java", JavaCheckBox.Checked)
                    addQueryCommand.Parameters.AddWithValue("@Swift", SwiftCheckBox.Checked)

                    addQueryCommand.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("The employee has been successfully registered.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exception As Exception
            MessageBox.Show([String].Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Try
            For Each control As Control In Me.Controls
                If control.[GetType]() = GetType(TextBox) Then
                    CType(control, TextBox).Clear()
                ElseIf control.[GetType]() = GetType(GroupBox) Then
                    For Each checkBox As CheckBox In (CType(control, GroupBox)).Controls
                        checkBox.Checked = False
                    Next
                End If
            Next
        Catch exception As Exception
            MessageBox.Show([String].Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class