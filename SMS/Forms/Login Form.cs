using System;
using System.Drawing;
using System.Windows.Forms;
using SMS.Forms;

namespace SMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            OperationListComboBox.SelectedIndex = 0;
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "Username")
                UsernameTextBox.Clear();
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == string.Empty)
                UsernameTextBox.Text = "Username";
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
                PasswordTextBox.Clear();
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == string.Empty)
                PasswordTextBox.Text = "Password";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Admin" && PasswordTextBox.Text == "Password")
            {
                LoginGroupBox.Enabled = false;
                OperationGroupBox.Enabled = true;
                this.Size = new Size(300, 286);
            }
            else
            {
                MessageBox.Show("Username & Password combination is incorrect.",
                    "Invalid Credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            switch (OperationListComboBox.SelectedIndex)
            {
                case 0:
                    new EmployeeRegistration().Show();
                    break;

                case 1:
                    new ProjectRegistration().Show();
                    break;

                case 2:
                    new ProjectAllocation().Show();
                    break;

                case 3:
                    new TrainingAssessment().Show();
                    break;

                case 4:
                    new DatabaseForm().Show();
                    break;
            }
        }

        private void AboutStatusStripLabel_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}