namespace SMS
{
    partial class EmployeeRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRegistration));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.SkillsetGroupBox = new System.Windows.Forms.GroupBox();
            this.SwiftCheckBox = new System.Windows.Forms.CheckBox();
            this.JavaCheckBox = new System.Windows.Forms.CheckBox();
            this.PythonCheckBox = new System.Windows.Forms.CheckBox();
            this.CPPCheckBox = new System.Windows.Forms.CheckBox();
            this.CSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.PHPCheckBox = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.SkillsetGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(75, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(243, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sex:";
            // 
            // SexTextBox
            // 
            this.SexTextBox.Location = new System.Drawing.Point(75, 66);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(243, 22);
            this.SexTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(75, 92);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(243, 22);
            this.AgeTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salary:";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(75, 118);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(243, 22);
            this.SalaryTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mobile:";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(75, 144);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(243, 22);
            this.MobileTextBox.TabIndex = 5;
            // 
            // SkillsetGroupBox
            // 
            this.SkillsetGroupBox.Controls.Add(this.SwiftCheckBox);
            this.SkillsetGroupBox.Controls.Add(this.JavaCheckBox);
            this.SkillsetGroupBox.Controls.Add(this.PythonCheckBox);
            this.SkillsetGroupBox.Controls.Add(this.CPPCheckBox);
            this.SkillsetGroupBox.Controls.Add(this.CSharpCheckBox);
            this.SkillsetGroupBox.Controls.Add(this.PHPCheckBox);
            this.SkillsetGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkillsetGroupBox.Location = new System.Drawing.Point(10, 179);
            this.SkillsetGroupBox.Name = "SkillsetGroupBox";
            this.SkillsetGroupBox.Size = new System.Drawing.Size(308, 72);
            this.SkillsetGroupBox.TabIndex = 10;
            this.SkillsetGroupBox.TabStop = false;
            this.SkillsetGroupBox.Text = "Skill Set";
            // 
            // SwiftCheckBox
            // 
            this.SwiftCheckBox.AutoSize = true;
            this.SwiftCheckBox.Location = new System.Drawing.Point(7, 45);
            this.SwiftCheckBox.Name = "SwiftCheckBox";
            this.SwiftCheckBox.Size = new System.Drawing.Size(52, 17);
            this.SwiftCheckBox.TabIndex = 11;
            this.SwiftCheckBox.Tag = "6";
            this.SwiftCheckBox.Text = "Swift";
            this.SwiftCheckBox.UseVisualStyleBackColor = true;
            // 
            // JavaCheckBox
            // 
            this.JavaCheckBox.AutoSize = true;
            this.JavaCheckBox.Location = new System.Drawing.Point(229, 21);
            this.JavaCheckBox.Name = "JavaCheckBox";
            this.JavaCheckBox.Size = new System.Drawing.Size(47, 17);
            this.JavaCheckBox.TabIndex = 10;
            this.JavaCheckBox.Tag = "5";
            this.JavaCheckBox.Text = "Java";
            this.JavaCheckBox.UseVisualStyleBackColor = true;
            // 
            // PythonCheckBox
            // 
            this.PythonCheckBox.AutoSize = true;
            this.PythonCheckBox.Location = new System.Drawing.Point(161, 21);
            this.PythonCheckBox.Name = "PythonCheckBox";
            this.PythonCheckBox.Size = new System.Drawing.Size(62, 17);
            this.PythonCheckBox.TabIndex = 9;
            this.PythonCheckBox.Tag = "3";
            this.PythonCheckBox.Text = "Python";
            this.PythonCheckBox.UseVisualStyleBackColor = true;
            // 
            // CPPCheckBox
            // 
            this.CPPCheckBox.AutoSize = true;
            this.CPPCheckBox.Location = new System.Drawing.Point(106, 22);
            this.CPPCheckBox.Name = "CPPCheckBox";
            this.CPPCheckBox.Size = new System.Drawing.Size(49, 17);
            this.CPPCheckBox.TabIndex = 8;
            this.CPPCheckBox.Tag = "2";
            this.CPPCheckBox.Text = "C++";
            this.CPPCheckBox.UseVisualStyleBackColor = true;
            // 
            // CSharpCheckBox
            // 
            this.CSharpCheckBox.AutoSize = true;
            this.CSharpCheckBox.Location = new System.Drawing.Point(60, 22);
            this.CSharpCheckBox.Name = "CSharpCheckBox";
            this.CSharpCheckBox.Size = new System.Drawing.Size(40, 17);
            this.CSharpCheckBox.TabIndex = 7;
            this.CSharpCheckBox.Tag = "1";
            this.CSharpCheckBox.Text = "C#";
            this.CSharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // PHPCheckBox
            // 
            this.PHPCheckBox.AutoSize = true;
            this.PHPCheckBox.Location = new System.Drawing.Point(7, 22);
            this.PHPCheckBox.Name = "PHPCheckBox";
            this.PHPCheckBox.Size = new System.Drawing.Size(46, 17);
            this.PHPCheckBox.TabIndex = 6;
            this.PHPCheckBox.Tag = "0";
            this.PHPCheckBox.Text = "PHP";
            this.PHPCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Location = new System.Drawing.Point(10, 257);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(243, 257);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID:";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(75, 12);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(243, 22);
            this.EmployeeIDTextBox.TabIndex = 0;
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 291);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SkillsetGroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SexTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeeRegistration";
            this.Text = "Employee Registration";
            this.SkillsetGroupBox.ResumeLayout(false);
            this.SkillsetGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.GroupBox SkillsetGroupBox;
        private System.Windows.Forms.CheckBox SwiftCheckBox;
        private System.Windows.Forms.CheckBox JavaCheckBox;
        private System.Windows.Forms.CheckBox PythonCheckBox;
        private System.Windows.Forms.CheckBox CPPCheckBox;
        private System.Windows.Forms.CheckBox CSharpCheckBox;
        private System.Windows.Forms.CheckBox PHPCheckBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
    }
}