using System;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class ProjectAllocation : Form
    {
        public ProjectAllocation()
        {
            InitializeComponent();
        }

        private void ProjectAllocation_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    using (var fetchProjectNames = new OleDbCommand("SELECT * FROM Projects", connection))
                    using (var reader = fetchProjectNames.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                            ProjectListComboBox.Items.Add(reader["ProjectName"].ToString());
                    }
                }

                if (ProjectListComboBox.Items.Count == 0)
                {
                    ProjectListComboBox.Items.Add("No Projects Found");
                    ProjectListComboBox.SelectedIndex = 0;
                    ProjectListComboBox.Enabled = false;
                    AllocateButton.Enabled = false;
                    ExportReportButton.Enabled = false;
                }
                else
                {
                    ProjectListComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine,
                    exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AllocateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var projectName = ProjectListComboBox.SelectedItem.ToString();

                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    using (var row = new OleDbCommand("SELECT * FROM Projects WHERE ProjectName = '" + projectName + "'", connection))
                    using (var reader = row.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                        {
                            ReportTextBox.Text = CreateReport(reader);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine,
                    exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt) | *.txt";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, ReportTextBox.Text);

                        MessageBox.Show($"Report successfully exported to {saveFileDialog.FileName}",
                            "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                   
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine,
                    exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CreateReport(OleDbDataReader reader)
        {
            var report = new StringBuilder();
            var skillsetRequired = GetSkillsInBoolean(reader);
            var employeesRequired = int.Parse(reader["EmployeesRequired"].ToString());

            report.AppendLine(reader["ProjectName"].ToString());
            report.AppendLine(new string('=', reader["ProjectName"].ToString().Length + 1));
            report.AppendLine(Environment.NewLine + "Dated: " + DateTime.Today.ToString("MMMM dd, yyyy"));
            report.AppendLine(Environment.NewLine + "Project Description:");
            report.AppendLine(reader["ProjectDescription"] + Environment.NewLine + "");
            report.AppendLine($"Required Skills: {GetSkillsInString(reader)}");
            report.AppendLine($"Required Employee: {employeesRequired}");
            report.AppendLine($"Maximum Allocated Time: {reader["AllocatedTime"]} Days" + Environment.NewLine);
            report.AppendLine("Eligible Employees: ");

            using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
            {
                connection.Open();
                using (var row = new OleDbCommand("SELECT * FROM Employees", connection))
                using (var red = row.ExecuteReader())
                {
                    while (red != null && red.Read())
                    {
                        if (IsEligible(skillsetRequired, GetSkillsInBoolean(red)))
                        {
                            report.AppendLine($"{red["EmployeeID"]} - {red["FullName"]} ({red["Sex"]})  Age: {red["Age"]}  Salary: {int.Parse(red["Salary"].ToString()):C2}  Mobile: {red["Mobile"]}");
                            employeesRequired--;
                        }
                    }
                    
                    if(employeesRequired > 0)
                        report.AppendLine(Environment.NewLine + $"{employeesRequired} employees are still required but none of the other existing employees are eligible for the project.");
                }

                return report.ToString();
            }
        }

        private static bool[] GetSkillsInBoolean(OleDbDataReader reader)
        {
            return new[]
            {
                Convert.ToBoolean(reader["PHP"]),
                Convert.ToBoolean(reader["CSharp"]),
                Convert.ToBoolean(reader["CPP"]),
                Convert.ToBoolean(reader["Python"]),
                Convert.ToBoolean(reader["Java"]),
                Convert.ToBoolean(reader["Swift"])
            };
        }

        private static string GetSkillsInString(OleDbDataReader reader)
        {
            var skills = new StringBuilder();

            skills.Append((Convert.ToBoolean(reader["PHP"]) ? "PHP, " : string.Empty).ToCharArray());
            skills.Append((Convert.ToBoolean(reader["CSharp"]) ? "CSharp, " : string.Empty).ToCharArray());
            skills.Append((Convert.ToBoolean(reader["CPP"]) ? "CPP, " : string.Empty).ToCharArray());
            skills.Append((Convert.ToBoolean(reader["Python"]) ? "Python, " : string.Empty).ToCharArray());
            skills.Append((Convert.ToBoolean(reader["Java"]) ? "Java, " : string.Empty).ToCharArray());
            skills.Append((Convert.ToBoolean(reader["Swift"]) ? "Swift, " : string.Empty).ToCharArray());

            skills.Remove(skills.Length - 2, 2);
            return skills.ToString();
        }

        private static bool IsEligible(bool[] requiredSkills, bool[] avalaibleSkills)
        {
            return !requiredSkills.Where((t, i) => t && avalaibleSkills[i] == false).Any();
        }
    }
}
