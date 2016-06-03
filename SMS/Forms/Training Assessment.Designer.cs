namespace SMS
{
    partial class TrainingAssessment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingAssessment));
            this.SkillComboBox = new System.Windows.Forms.ComboBox();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.AssessmentDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SkillComboBox
            // 
            this.SkillComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkillComboBox.FormattingEnabled = true;
            this.SkillComboBox.Items.AddRange(new object[] {
            "PHP",
            "C#",
            "C++",
            "Python",
            "Java",
            "Swift"});
            this.SkillComboBox.Location = new System.Drawing.Point(13, 13);
            this.SkillComboBox.Name = "SkillComboBox";
            this.SkillComboBox.Size = new System.Drawing.Size(130, 21);
            this.SkillComboBox.TabIndex = 0;
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnalyzeButton.Location = new System.Drawing.Point(149, 13);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(75, 23);
            this.AnalyzeButton.TabIndex = 1;
            this.AnalyzeButton.Text = "Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // AssessmentDataGridView
            // 
            this.AssessmentDataGridView.AllowUserToAddRows = false;
            this.AssessmentDataGridView.AllowUserToDeleteRows = false;
            this.AssessmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EmployeeName,
            this.Sex,
            this.EmployeeAge,
            this.Salary});
            this.AssessmentDataGridView.Location = new System.Drawing.Point(12, 42);
            this.AssessmentDataGridView.Name = "AssessmentDataGridView";
            this.AssessmentDataGridView.RowHeadersVisible = false;
            this.AssessmentDataGridView.Size = new System.Drawing.Size(343, 193);
            this.AssessmentDataGridView.TabIndex = 3;
            this.AssessmentDataGridView.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 110;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 30;
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.HeaderText = "Age";
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.ReadOnly = true;
            this.EmployeeAge.Width = 45;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // ReportButton
            // 
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.Location = new System.Drawing.Point(230, 13);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(125, 23);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Export Full Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // TrainingAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 247);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.AssessmentDataGridView);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.SkillComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrainingAssessment";
            this.Text = "Training Assessment";
            this.Load += new System.EventHandler(this.TrainingAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SkillComboBox;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.DataGridView AssessmentDataGridView;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}