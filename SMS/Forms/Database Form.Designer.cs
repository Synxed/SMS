namespace SMS
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePHP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeCSharp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeCPP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeePython = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeJava = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeSwift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectEmployeesRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPHP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectCSharp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectCPP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectPython = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectJava = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectSwift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 584);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EmployeesDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.AllowUserToAddRows = false;
            this.EmployeesDataGridView.AllowUserToDeleteRows = false;
            this.EmployeesDataGridView.AllowUserToOrderColumns = true;
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeSerial,
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeSex,
            this.EmployeeAge,
            this.EmployeeSalary,
            this.EmployeeMobile,
            this.EmployeePHP,
            this.EmployeeCSharp,
            this.EmployeeCPP,
            this.EmployeePython,
            this.EmployeeJava,
            this.EmployeeSwift});
            this.EmployeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.RowHeadersVisible = false;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(1108, 552);
            this.EmployeesDataGridView.TabIndex = 0;
            // 
            // EmployeeSerial
            // 
            this.EmployeeSerial.HeaderText = "Serial";
            this.EmployeeSerial.Name = "EmployeeSerial";
            this.EmployeeSerial.ReadOnly = true;
            this.EmployeeSerial.Width = 50;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Full Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeName.Width = 150;
            // 
            // EmployeeSex
            // 
            this.EmployeeSex.HeaderText = "Sex";
            this.EmployeeSex.Name = "EmployeeSex";
            this.EmployeeSex.ReadOnly = true;
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.HeaderText = "Age";
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.ReadOnly = true;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.HeaderText = "Salary";
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.ReadOnly = true;
            this.EmployeeSalary.Width = 150;
            // 
            // EmployeeMobile
            // 
            this.EmployeeMobile.HeaderText = "Mobile";
            this.EmployeeMobile.Name = "EmployeeMobile";
            this.EmployeeMobile.ReadOnly = true;
            this.EmployeeMobile.Width = 150;
            // 
            // EmployeePHP
            // 
            this.EmployeePHP.HeaderText = "PHP";
            this.EmployeePHP.Name = "EmployeePHP";
            this.EmployeePHP.ReadOnly = true;
            this.EmployeePHP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeePHP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeePHP.Width = 50;
            // 
            // EmployeeCSharp
            // 
            this.EmployeeCSharp.HeaderText = "C#";
            this.EmployeeCSharp.Name = "EmployeeCSharp";
            this.EmployeeCSharp.ReadOnly = true;
            this.EmployeeCSharp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeCSharp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeeCSharp.Width = 50;
            // 
            // EmployeeCPP
            // 
            this.EmployeeCPP.HeaderText = "C++";
            this.EmployeeCPP.Name = "EmployeeCPP";
            this.EmployeeCPP.ReadOnly = true;
            this.EmployeeCPP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeCPP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeeCPP.Width = 50;
            // 
            // EmployeePython
            // 
            this.EmployeePython.HeaderText = "Python";
            this.EmployeePython.Name = "EmployeePython";
            this.EmployeePython.ReadOnly = true;
            this.EmployeePython.Width = 50;
            // 
            // EmployeeJava
            // 
            this.EmployeeJava.HeaderText = "Java";
            this.EmployeeJava.Name = "EmployeeJava";
            this.EmployeeJava.ReadOnly = true;
            this.EmployeeJava.Width = 50;
            // 
            // EmployeeSwift
            // 
            this.EmployeeSwift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeSwift.HeaderText = "Swift";
            this.EmployeeSwift.Name = "EmployeeSwift";
            this.EmployeeSwift.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ProjectsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProjectsDataGridView
            // 
            this.ProjectsDataGridView.AllowUserToAddRows = false;
            this.ProjectsDataGridView.AllowUserToDeleteRows = false;
            this.ProjectsDataGridView.AllowUserToOrderColumns = true;
            this.ProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectSerial,
            this.ProjectName,
            this.ProjectEmployeesRequired,
            this.ProjectTime,
            this.ProjectPHP,
            this.ProjectCSharp,
            this.ProjectCPP,
            this.ProjectPython,
            this.ProjectJava,
            this.ProjectSwift,
            this.ProjectDescription});
            this.ProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ProjectsDataGridView.Name = "ProjectsDataGridView";
            this.ProjectsDataGridView.RowHeadersVisible = false;
            this.ProjectsDataGridView.Size = new System.Drawing.Size(1108, 552);
            this.ProjectsDataGridView.TabIndex = 0;
            // 
            // ProjectSerial
            // 
            this.ProjectSerial.HeaderText = "Serial";
            this.ProjectSerial.Name = "ProjectSerial";
            this.ProjectSerial.ReadOnly = true;
            this.ProjectSerial.Width = 50;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 250;
            // 
            // ProjectEmployeesRequired
            // 
            this.ProjectEmployeesRequired.HeaderText = "Employees Required";
            this.ProjectEmployeesRequired.Name = "ProjectEmployeesRequired";
            this.ProjectEmployeesRequired.ReadOnly = true;
            this.ProjectEmployeesRequired.Width = 150;
            // 
            // ProjectTime
            // 
            this.ProjectTime.HeaderText = "Allocated Time (Days)";
            this.ProjectTime.Name = "ProjectTime";
            this.ProjectTime.ReadOnly = true;
            this.ProjectTime.Width = 150;
            // 
            // ProjectPHP
            // 
            this.ProjectPHP.HeaderText = "PHP";
            this.ProjectPHP.Name = "ProjectPHP";
            this.ProjectPHP.ReadOnly = true;
            this.ProjectPHP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectPHP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProjectPHP.Width = 50;
            // 
            // ProjectCSharp
            // 
            this.ProjectCSharp.HeaderText = "C#";
            this.ProjectCSharp.Name = "ProjectCSharp";
            this.ProjectCSharp.ReadOnly = true;
            this.ProjectCSharp.Width = 50;
            // 
            // ProjectCPP
            // 
            this.ProjectCPP.HeaderText = "C++";
            this.ProjectCPP.Name = "ProjectCPP";
            this.ProjectCPP.ReadOnly = true;
            this.ProjectCPP.Width = 50;
            // 
            // ProjectPython
            // 
            this.ProjectPython.HeaderText = "Python";
            this.ProjectPython.Name = "ProjectPython";
            this.ProjectPython.ReadOnly = true;
            this.ProjectPython.Width = 50;
            // 
            // ProjectJava
            // 
            this.ProjectJava.HeaderText = "Java";
            this.ProjectJava.Name = "ProjectJava";
            this.ProjectJava.ReadOnly = true;
            this.ProjectJava.Width = 50;
            // 
            // ProjectSwift
            // 
            this.ProjectSwift.HeaderText = "Swift";
            this.ProjectSwift.Name = "ProjectSwift";
            this.ProjectSwift.ReadOnly = true;
            this.ProjectSwift.Width = 50;
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectDescription.HeaderText = "Description";
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.ReadOnly = true;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 584);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseForm";
            this.Text = "Database (Read Only)";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView EmployeesDataGridView;
        private System.Windows.Forms.DataGridView ProjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeMobile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmployeePHP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmployeeCSharp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmployeeCPP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmployeePython;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmployeeJava;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmployeeSwift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectEmployeesRequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProjectPHP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProjectCSharp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProjectCPP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProjectPython;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProjectJava;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProjectSwift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDescription;
    }
}