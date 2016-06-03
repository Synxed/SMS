Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Partial Class ProjectAllocation

    Private Sub ProjectAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Using fetchProjectNames = New OleDbCommand("SELECT * FROM Projects", connection)
                    Using reader = fetchProjectNames.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            ProjectListComboBox.Items.Add(reader("ProjectName").ToString())
                        End While
                    End Using
                End Using
            End Using

            If ProjectListComboBox.Items.Count = 0 Then
                ProjectListComboBox.Items.Add("No Projects Found")
                ProjectListComboBox.SelectedIndex = 0
                ProjectListComboBox.Enabled = False
                AllocateButton.Enabled = False
                ExportReportButton.Enabled = False
            Else
                ProjectListComboBox.SelectedIndex = 0
            End If
        Catch exception As Exception
            MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub AllocateButton_Click(sender As Object, e As EventArgs) Handles AllocateButton.Click
        Try
            Dim projectName = ProjectListComboBox.SelectedItem.ToString()

            Using connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Using row = New OleDbCommand("SELECT * FROM Projects WHERE ProjectName = '" + projectName + "'", connection)
                    Using reader = row.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            ReportTextBox.Text = CreateReport(reader)
                        End While
                    End Using
                End Using
            End Using
        Catch exception As Exception
            MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ExportReportButton_Click(sender As Object, e As EventArgs) Handles ExportReportButton.Click
        Try
            Using saveFileDialog = New SaveFileDialog()
                saveFileDialog.Filter = "Text Files (*.txt) | *.txt"
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    File.WriteAllText(saveFileDialog.FileName, ReportTextBox.Text)
                    MessageBox.Show("Report successfully exported to {saveFileDialog.FileName}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
             End Using
        Catch exception As Exception
            MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Function CreateReport(reader As OleDbDataReader) As String
        Dim report = New StringBuilder()
        Dim skillsetRequired = GetSkillsInBoolean(reader)
        Dim employeesRequired = Integer.Parse(reader("EmployeesRequired").ToString())

        report.AppendLine(reader("ProjectName").ToString())
        report.AppendLine(New String("="C, reader("ProjectName").ToString().Length + 1))
        report.AppendLine(Environment.NewLine + "Dated: " + DateTime.Today.ToString("MMMM dd, yyyy"))
        report.AppendLine(Environment.NewLine + "Project Description:")
        report.AppendLine(reader("ProjectDescription") + Environment.NewLine + "")
        report.AppendLine("Required Skills: {GetSkillsInString(reader)}")
        report.AppendLine("Required Employee: {employeesRequired}")
        report.AppendLine("Maximum Allocated Time: {reader[")
        report.AppendLine("Eligible Employees: ")

        Using connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
            connection.Open()
            Using row = New OleDbCommand("SELECT * FROM Employees", connection)
                Using red = row.ExecuteReader()
                    While red IsNot Nothing AndAlso red.Read()
                        If IsEligible(skillsetRequired, GetSkillsInBoolean(red)) Then
                            report.AppendLine("{red[")
                            employeesRequired -= 1
                        End If
                    End While

                    If employeesRequired > 0 Then
                        report.AppendLine(Environment.NewLine + "{employeesRequired} employees are still required but none of the other existing employees are eligible for the project.")
                    End If
                End Using
            End Using

            Return report.ToString()
        End Using
    End Function

    Private Shared Function GetSkillsInBoolean(reader As OleDbDataReader) As Boolean()
        Dim boolArray = New List(Of Boolean)()

        boolArray.Add(Convert.ToBoolean(reader("PHP")))
        boolArray.Add(Convert.ToBoolean(reader("CSharp")))
        boolArray.Add(Convert.ToBoolean(reader("CPP")))
        boolArray.Add(Convert.ToBoolean(reader("Python")))
        boolArray.Add(Convert.ToBoolean(reader("Java")))
        boolArray.Add(Convert.ToBoolean(reader("Swift")))

        Return boolArray.ToArray()

     End Function

    Private Shared Function GetSkillsInString(reader As OleDbDataReader) As String
        Dim skills = New StringBuilder()

        skills.Append((If(Convert.ToBoolean(reader("PHP")), "PHP, ", String.Empty)).ToCharArray())
        skills.Append((If(Convert.ToBoolean(reader("CSharp")), "CSharp, ", String.Empty)).ToCharArray())
        skills.Append((If(Convert.ToBoolean(reader("CPP")), "CPP, ", String.Empty)).ToCharArray())
        skills.Append((If(Convert.ToBoolean(reader("Python")), "Python, ", String.Empty)).ToCharArray())
        skills.Append((If(Convert.ToBoolean(reader("Java")), "Java, ", String.Empty)).ToCharArray())
        skills.Append((If(Convert.ToBoolean(reader("Swift")), "Swift, ", String.Empty)).ToCharArray())

        skills.Remove(skills.Length - 2, 2)
        Return skills.ToString()
    End Function

    Private Shared Function IsEligible(requiredSkills As Boolean(), avalaibleSkills As Boolean()) As Boolean
        Return Not requiredSkills.Where(Function(t, i) t AndAlso avalaibleSkills(i) = False).Any()
    End Function
End Class