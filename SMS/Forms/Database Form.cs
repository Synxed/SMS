using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SMS
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\""))
                {
                    connection.Open();
                    using (var row = new OleDbCommand("SELECT * FROM Employees", connection))
                    using (var red = row.ExecuteReader())
                    {
                        while (red != null && red.Read())
                        {
                            EmployeesDataGridView.Rows.Add(
                                EmployeesDataGridView.Rows.Count + 1,
                                red["EmployeeID"].ToString(),
                                red["FullName"].ToString(),
                                red["Sex"].ToString(),
                                red["Age"].ToString(),
                                red["Mobile"].ToString(),
                                Convert.ToBoolean(red["PHP"].ToString()),
                                Convert.ToBoolean(red["CSharp"].ToString()),
                                Convert.ToBoolean(red["CPP"].ToString()),
                                Convert.ToBoolean(red["Python"].ToString()),
                                Convert.ToBoolean(red["Java"].ToString()),
                                Convert.ToBoolean(red["Swift"].ToString()));
                        }
                    }

                    using (var row = new OleDbCommand("SELECT * FROM Projects", connection))
                    using (var red = row.ExecuteReader())
                    {
                        while (red != null && red.Read())
                        {
                            ProjectsDataGridView.Rows.Add(
                                ProjectsDataGridView.Rows.Count + 1,
                                red["ProjectName"].ToString(),
                                red["EmployeesRequired"].ToString(),
                                red["AllocatedTime"].ToString(),
                                Convert.ToBoolean(red["PHP"].ToString()),
                                Convert.ToBoolean(red["CSharp"].ToString()),
                                Convert.ToBoolean(red["CPP"].ToString()),
                                Convert.ToBoolean(red["Python"].ToString()),
                                Convert.ToBoolean(red["Java"].ToString()),
                                Convert.ToBoolean(red["Swift"].ToString()),
                                red["ProjectDescription"].ToString());
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
    }
}
