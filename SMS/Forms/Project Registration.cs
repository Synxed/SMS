using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SMS
{
    public partial class ProjectRegistration : Form
    {
        public ProjectRegistration()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    var command = "INSERT INTO Projects (ProjectName, ProjectDescription, EmployeesRequired, AllocatedTime, PHP, CSharp, CPP, Python, Java, Swift)" +
                                  "Values (@Name, @Description, @EmployeesRequired, @Time, @PHP, @CSharp, @CPP, @Python, @Java, @Swift)";

                    using (var addQueryCommand = new OleDbCommand(command, connection))
                    {
                        addQueryCommand.Parameters.AddWithValue("@Name", ProjectNameTextBox.Text);
                        addQueryCommand.Parameters.AddWithValue("@Description", ProjectDescriptionTextBox.Text);
                        addQueryCommand.Parameters.AddWithValue("@EmployeesRequired", (int)EmployeeRequiredNumericBox.Value);
                        addQueryCommand.Parameters.AddWithValue("@Time", (int)AllocatedTimeNumericBox.Value);
                        addQueryCommand.Parameters.AddWithValue("@PHP", PHPCheckBox.Checked);
                        addQueryCommand.Parameters.AddWithValue("@CSharp", CSharpCheckBox.Checked);
                        addQueryCommand.Parameters.AddWithValue("@CPP", CPPCheckBox.Checked);
                        addQueryCommand.Parameters.AddWithValue("@Python", PythonCheckBox.Checked);
                        addQueryCommand.Parameters.AddWithValue("@Java", JavaCheckBox.Checked);
                        addQueryCommand.Parameters.AddWithValue("@Swift", SwiftCheckBox.Checked);

                        addQueryCommand.ExecuteNonQuery();
                    }    
                }

                MessageBox.Show("The project has been successfully registered.", "Registration Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine,
                    exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(TextBox))
                    {
                        ((TextBox)control).Clear();
                    }
                    else if (control.GetType() == typeof (NumericUpDown))
                    {
                        ((NumericUpDown) control).Value = ((NumericUpDown) control).Minimum;
                    }
                    else if (control.GetType() == typeof(GroupBox))
                    {
                        foreach (CheckBox checkBox in ((GroupBox)control).Controls)
                            checkBox.Checked = false;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("{0}{1}{1}Details: {2}", "An error occurred.", Environment.NewLine,
                    exception.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
