using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class TrainingAssessment : Form
    {
        public TrainingAssessment()
        {
            InitializeComponent();
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            AssessmentDataGridView.Rows.Clear();
            AssessmentDataGridView.Refresh();

            var selectedSkill = GetSkillName(SkillComboBox.SelectedItem.ToString());

            foreach (var employee in GetEmployeesForTraining(selectedSkill))
                AssessmentDataGridView.Rows.Add(employee);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var report = new StringBuilder();
                report.AppendLine("Training Assessment Report");
                report.AppendLine(new string('=', "Training Assessment Report".Length));
                report.AppendLine(Environment.NewLine + "Dated: " + DateTime.Today.ToString("MMMM dd, yyyy"));

                foreach (var item in SkillComboBox.Items)
                {
                    report.AppendLine(Environment.NewLine + item);
                    report.AppendLine(new string('-', item.ToString().Length) + Environment.NewLine);

                    var employees = GetEmployeesForTraining(item.ToString());

                    if (employees.Any())
                    {
                        foreach (var employee in employees)
                        {
                            report.AppendLine($"{employee[0]} - {employee[1]}  " +
                                              $"Sex: {employee[2]}  " +
                                              $"Age: {employee[3]}  " +
                                              $"Salary: {employee[4]}");
                        }          
                    }
                    else
                    {
                        report.AppendLine($"No employees require {item} training." + Environment.NewLine);
                    }
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt) | *.txt";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        File.WriteAllText(saveFileDialog.FileName, report.ToString());

                    MessageBox.Show($"Report successfully exported to {saveFileDialog.FileName}",
                        "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine,
                    exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<object[]> GetEmployeesForTraining(string selectedSkill)
        {
            try
            {
                List<object[]> employeeList = new List<object[]>();
                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    using (var row = new OleDbCommand("SELECT * FROM Employees", connection))
                    using (var red = row.ExecuteReader())
                    {
                        while (red != null && red.Read())
                        {
                            if (!Convert.ToBoolean(red[GetSkillName(selectedSkill)]))
                            {
                                employeeList.Add(new object[]
                                {
                                    red["EmployeeID"].ToString(),
                                    red["FullName"].ToString(),
                                    red["Sex"].ToString(),
                                    red["Age"].ToString(),
                                    $"{int.Parse(red["Salary"].ToString()):C2}"
                                });
                            }
                        }
                        return employeeList;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine,
                    exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string GetSkillName(string selectedSkill)
        {
            switch (selectedSkill)
            {
                case "C#":
                    return "CSharp";
                case "C++":
                    return "CPP";
                default:
                    return selectedSkill;
            }
        }

        private void TrainingAssessment_Load(object sender, EventArgs e)
        {
            SkillComboBox.SelectedIndex = 0;
        }
    }
}
