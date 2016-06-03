namespace SMS
{
    partial class ProjectAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectAllocation));
            this.ProjectListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AllocateButton = new System.Windows.Forms.Button();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.ExportReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectListComboBox
            // 
            this.ProjectListComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectListComboBox.FormattingEnabled = true;
            this.ProjectListComboBox.Location = new System.Drawing.Point(12, 29);
            this.ProjectListComboBox.Name = "ProjectListComboBox";
            this.ProjectListComboBox.Size = new System.Drawing.Size(320, 21);
            this.ProjectListComboBox.TabIndex = 0;
            this.ProjectListComboBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Project:";
            // 
            // AllocateButton
            // 
            this.AllocateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllocateButton.Location = new System.Drawing.Point(338, 29);
            this.AllocateButton.Name = "AllocateButton";
            this.AllocateButton.Size = new System.Drawing.Size(75, 23);
            this.AllocateButton.TabIndex = 1;
            this.AllocateButton.TabStop = false;
            this.AllocateButton.Text = "Allocate";
            this.AllocateButton.UseVisualStyleBackColor = true;
            this.AllocateButton.Click += new System.EventHandler(this.AllocateButton_Click);
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Location = new System.Drawing.Point(12, 56);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ReadOnly = true;
            this.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReportTextBox.Size = new System.Drawing.Size(513, 335);
            this.ReportTextBox.TabIndex = 3;
            this.ReportTextBox.TabStop = false;
            // 
            // ExportReportButton
            // 
            this.ExportReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportReportButton.Location = new System.Drawing.Point(419, 29);
            this.ExportReportButton.Name = "ExportReportButton";
            this.ExportReportButton.Size = new System.Drawing.Size(106, 23);
            this.ExportReportButton.TabIndex = 2;
            this.ExportReportButton.TabStop = false;
            this.ExportReportButton.Text = "Export Report";
            this.ExportReportButton.UseVisualStyleBackColor = true;
            this.ExportReportButton.Click += new System.EventHandler(this.ExportReportButton_Click);
            // 
            // ProjectAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 403);
            this.Controls.Add(this.ExportReportButton);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.AllocateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectListComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectAllocation";
            this.Text = "Project Allocation";
            this.Load += new System.EventHandler(this.ProjectAllocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProjectListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AllocateButton;
        private System.Windows.Forms.TextBox ReportTextBox;
        private System.Windows.Forms.Button ExportReportButton;
    }
}