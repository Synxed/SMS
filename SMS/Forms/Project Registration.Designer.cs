namespace SMS
{
    partial class ProjectRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeRequiredNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AllocatedTimeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SkillsetGroupBox = new System.Windows.Forms.GroupBox();
            this.SwiftCheckBox = new System.Windows.Forms.CheckBox();
            this.JavaCheckBox = new System.Windows.Forms.CheckBox();
            this.PythonCheckBox = new System.Windows.Forms.CheckBox();
            this.CPPCheckBox = new System.Windows.Forms.CheckBox();
            this.CSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.PHPCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeRequiredNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllocatedTimeNumericBox)).BeginInit();
            this.SkillsetGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name:";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(92, 12);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(226, 22);
            this.ProjectNameTextBox.TabIndex = 0;
            // 
            // ProjectDescriptionTextBox
            // 
            this.ProjectDescriptionTextBox.Location = new System.Drawing.Point(12, 59);
            this.ProjectDescriptionTextBox.Multiline = true;
            this.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            this.ProjectDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ProjectDescriptionTextBox.Size = new System.Drawing.Size(306, 78);
            this.ProjectDescriptionTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee Required:";
            // 
            // EmployeeRequiredNumericBox
            // 
            this.EmployeeRequiredNumericBox.Location = new System.Drawing.Point(12, 242);
            this.EmployeeRequiredNumericBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EmployeeRequiredNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EmployeeRequiredNumericBox.Name = "EmployeeRequiredNumericBox";
            this.EmployeeRequiredNumericBox.Size = new System.Drawing.Size(74, 22);
            this.EmployeeRequiredNumericBox.TabIndex = 8;
            this.EmployeeRequiredNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AllocatedTimeNumericBox
            // 
            this.AllocatedTimeNumericBox.Location = new System.Drawing.Point(127, 242);
            this.AllocatedTimeNumericBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.AllocatedTimeNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AllocatedTimeNumericBox.Name = "AllocatedTimeNumericBox";
            this.AllocatedTimeNumericBox.Size = new System.Drawing.Size(74, 22);
            this.AllocatedTimeNumericBox.TabIndex = 9;
            this.AllocatedTimeNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Maximum Allocated Time (Days):";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Location = new System.Drawing.Point(12, 270);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(243, 270);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
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
            this.SkillsetGroupBox.Location = new System.Drawing.Point(12, 143);
            this.SkillsetGroupBox.Name = "SkillsetGroupBox";
            this.SkillsetGroupBox.Size = new System.Drawing.Size(308, 72);
            this.SkillsetGroupBox.TabIndex = 18;
            this.SkillsetGroupBox.TabStop = false;
            this.SkillsetGroupBox.Text = "Skill Set";
            // 
            // SwiftCheckBox
            // 
            this.SwiftCheckBox.AutoSize = true;
            this.SwiftCheckBox.Location = new System.Drawing.Point(7, 45);
            this.SwiftCheckBox.Name = "SwiftCheckBox";
            this.SwiftCheckBox.Size = new System.Drawing.Size(52, 17);
            this.SwiftCheckBox.TabIndex = 7;
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
            this.JavaCheckBox.TabIndex = 6;
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
            this.PythonCheckBox.TabIndex = 5;
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
            this.CPPCheckBox.TabIndex = 4;
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
            this.CSharpCheckBox.TabIndex = 3;
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
            this.PHPCheckBox.TabIndex = 2;
            this.PHPCheckBox.Tag = "0";
            this.PHPCheckBox.Text = "PHP";
            this.PHPCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProjectRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 304);
            this.Controls.Add(this.SkillsetGroupBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.AllocatedTimeNumericBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeRequiredNumericBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectRegistration";
            this.Text = "Project Registration";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeRequiredNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllocatedTimeNumericBox)).EndInit();
            this.SkillsetGroupBox.ResumeLayout(false);
            this.SkillsetGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.TextBox ProjectDescriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown EmployeeRequiredNumericBox;
        private System.Windows.Forms.NumericUpDown AllocatedTimeNumericBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox SkillsetGroupBox;
        private System.Windows.Forms.CheckBox SwiftCheckBox;
        private System.Windows.Forms.CheckBox JavaCheckBox;
        private System.Windows.Forms.CheckBox PythonCheckBox;
        private System.Windows.Forms.CheckBox CPPCheckBox;
        private System.Windows.Forms.CheckBox CSharpCheckBox;
        private System.Windows.Forms.CheckBox PHPCheckBox;
    }
}