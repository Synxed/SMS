Imports System.Data.OleDb

Public Partial Class DatabaseForm
    Private Sub DatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb""")
                connection.Open()
                Using row As New OleDbCommand("SELECT * FROM Employees", connection)
                    Using red As Object = row.ExecuteReader()
                        While red IsNot Nothing AndAlso red.Read()
                            EmployeesDataGridView.Rows.Add(EmployeesDataGridView.Rows.Count + 1, red("EmployeeID").ToString(), red("FullName").ToString(), red("Sex").ToString(), red("Age").ToString(), red("Mobile").ToString(), _
                                                           Convert.ToBoolean(red("PHP").ToString()), Convert.ToBoolean(red("CSharp").ToString()), Convert.ToBoolean(red("CPP").ToString()), Convert.ToBoolean(red("Python").ToString()), Convert.ToBoolean(red("Java").ToString()), Convert.ToBoolean(red("Swift").ToString()))
                        End While
                    End Using
                End Using

                Using row As New OleDbCommand("SELECT * FROM Projects", connection)
                    Using red As Object = row.ExecuteReader()
                        While red IsNot Nothing AndAlso red.Read()
                            ProjectsDataGridView.Rows.Add(ProjectsDataGridView.Rows.Count + 1, red("ProjectName").ToString(), red("EmployeesRequired").ToString(), red("AllocatedTime").ToString(), Convert.ToBoolean(red("PHP").ToString()), Convert.ToBoolean(red("CSharp").ToString()), _
                                                          Convert.ToBoolean(red("CPP").ToString()), Convert.ToBoolean(red("Python").ToString()), Convert.ToBoolean(red("Java").ToString()), Convert.ToBoolean(red("Swift").ToString()), red("ProjectDescription").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch exception As Exception
            MessageBox.Show([String].Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine, exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class