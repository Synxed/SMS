Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Partial Class TrainingAssessment
    Private Sub AnalyzeButton_Click(sender As Object, e As EventArgs) Handles AnalyzeButton.Click
        AssessmentDataGridView.Rows.Clear()
        AssessmentDataGridView.Refresh()

        Dim selectedSkill = GetSkillName(SkillComboBox.SelectedItem.ToString())

        For Each employee As Object() In GetEmployeesForTraining(selectedSkill)
            AssessmentDataGridView.Rows.Add(employee)
        Next
    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        Try
            Dim report = New StringBuilder()
            report.AppendLine("Training Assessment Report")
            report.AppendLine(New String("="C, "Training Assessment Report".Length))
            report.AppendLine(Environment.NewLine + "Dated: " + DateTime.Today.ToString("MMMM dd, yyyy"))

            For Each item As Object In SkillComboBox.Items
                report.AppendLine(Environment.NewLine + item)
                report.AppendLine(New String("-"C, item.ToString().Length) + Environment.NewLine)

                Dim employees = GetEmployeesForTraining(item.ToString())

                If employees.Any() Then
                    For Each employee In employees
                        report.AppendLine(String.Format("{0} - {1}  Sex: {2}  Age: {3}  Salary: {4}", employee(0),employee(1),employee(2), employee(3), employee(4)))
                    Next
                Else
                    report.AppendLine(String.Format("No employees require {0}  training.{1}", item.ToString(),  Environment.NewLine))
                End If
            Next

            Using saveFileDialog = New SaveFileDialog()
                saveFileDialog.Filter = "Text Files (*.txt) | *.txt"
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    File.WriteAllText(saveFileDialog.FileName, report.ToString())
                        MessageBox.Show("Report successfully exported to " + saveFileDialog.FileName, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)        
                End If

            End Using
        Catch exception As Exception
            MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Function GetEmployeesForTraining(selectedSkill As String) As List(Of Object())
        Try
            Dim employeeList As New List(Of Object())()
            Using connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Using row = New OleDbCommand("SELECT * FROM Employees", connection)
                    Using red = row.ExecuteReader()
                        While red IsNot Nothing AndAlso red.Read()
                            If Not Convert.ToBoolean(red(GetSkillName(selectedSkill))) Then
                                employeeList.Add(New Object() {red("EmployeeID").ToString(), red("FullName").ToString(), 
                                                 red("Sex").ToString(), red("Age").ToString(), 
                                                 String.Format("{0:C2}", Integer.Parse(red("Salary").ToString()))})
                            End If
                        End While
                        Return employeeList
                    End Using
                End Using
            End Using
        Catch exception As Exception
            MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return Nothing
        End Try
    End Function

    Private Function GetSkillName(selectedSkill As String) As String
        Select Case selectedSkill
            Case "C#"
                Return "CSharp"
            Case "C++"
                Return "CPP"
            Case Else
                Return selectedSkill
        End Select
    End Function

    Private Sub TrainingAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkillComboBox.SelectedIndex = 0
    End Sub
End Class