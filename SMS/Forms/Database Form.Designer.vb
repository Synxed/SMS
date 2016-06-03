<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseForm))
        Me.ProjectDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectJava = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProjectPython = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProjectCPP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProjectCSharp = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProjectPHP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProjectTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectEmployeesRequired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectSerial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProjectSwift = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.EmployeeSwift = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeJava = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeCPP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeCSharp = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeePHP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeeMobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeSerial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmployeePython = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        CType(Me.ProjectsDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage2.SuspendLayout
        CType(Me.EmployeesDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage1.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.SuspendLayout
        '
        'ProjectDescription
        '
        Me.ProjectDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProjectDescription.HeaderText = "Description"
        Me.ProjectDescription.Name = "ProjectDescription"
        Me.ProjectDescription.ReadOnly = true
        '
        'ProjectJava
        '
        Me.ProjectJava.HeaderText = "Java"
        Me.ProjectJava.Name = "ProjectJava"
        Me.ProjectJava.ReadOnly = true
        Me.ProjectJava.Width = 50
        '
        'ProjectPython
        '
        Me.ProjectPython.HeaderText = "Python"
        Me.ProjectPython.Name = "ProjectPython"
        Me.ProjectPython.ReadOnly = true
        Me.ProjectPython.Width = 50
        '
        'ProjectCPP
        '
        Me.ProjectCPP.HeaderText = "C++"
        Me.ProjectCPP.Name = "ProjectCPP"
        Me.ProjectCPP.ReadOnly = true
        Me.ProjectCPP.Width = 50
        '
        'ProjectCSharp
        '
        Me.ProjectCSharp.HeaderText = "C#"
        Me.ProjectCSharp.Name = "ProjectCSharp"
        Me.ProjectCSharp.ReadOnly = true
        Me.ProjectCSharp.Width = 50
        '
        'ProjectPHP
        '
        Me.ProjectPHP.HeaderText = "PHP"
        Me.ProjectPHP.Name = "ProjectPHP"
        Me.ProjectPHP.ReadOnly = true
        Me.ProjectPHP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProjectPHP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProjectPHP.Width = 50
        '
        'ProjectTime
        '
        Me.ProjectTime.HeaderText = "Allocated Time (Days)"
        Me.ProjectTime.Name = "ProjectTime"
        Me.ProjectTime.ReadOnly = true
        Me.ProjectTime.Width = 150
        '
        'ProjectEmployeesRequired
        '
        Me.ProjectEmployeesRequired.HeaderText = "Employees Required"
        Me.ProjectEmployeesRequired.Name = "ProjectEmployeesRequired"
        Me.ProjectEmployeesRequired.ReadOnly = true
        Me.ProjectEmployeesRequired.Width = 150
        '
        'ProjectName
        '
        Me.ProjectName.HeaderText = "Name"
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.ReadOnly = true
        Me.ProjectName.Width = 250
        '
        'ProjectSerial
        '
        Me.ProjectSerial.HeaderText = "Serial"
        Me.ProjectSerial.Name = "ProjectSerial"
        Me.ProjectSerial.ReadOnly = true
        Me.ProjectSerial.Width = 50
        '
        'ProjectsDataGridView
        '
        Me.ProjectsDataGridView.AllowUserToAddRows = false
        Me.ProjectsDataGridView.AllowUserToDeleteRows = false
        Me.ProjectsDataGridView.AllowUserToOrderColumns = true
        Me.ProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProjectsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProjectSerial, Me.ProjectName, Me.ProjectEmployeesRequired, Me.ProjectTime, Me.ProjectPHP, Me.ProjectCSharp, Me.ProjectCPP, Me.ProjectPython, Me.ProjectJava, Me.ProjectSwift, Me.ProjectDescription})
        Me.ProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjectsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ProjectsDataGridView.Name = "ProjectsDataGridView"
        Me.ProjectsDataGridView.RowHeadersVisible = false
        Me.ProjectsDataGridView.Size = New System.Drawing.Size(1108, 552)
        Me.ProjectsDataGridView.TabIndex = 0
        '
        'ProjectSwift
        '
        Me.ProjectSwift.HeaderText = "Swift"
        Me.ProjectSwift.Name = "ProjectSwift"
        Me.ProjectSwift.ReadOnly = true
        Me.ProjectSwift.Width = 50
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.ProjectsDataGridView)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(1114, 558)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Projects"
        Me.tabPage2.UseVisualStyleBackColor = true
        '
        'EmployeeSwift
        '
        Me.EmployeeSwift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeSwift.HeaderText = "Swift"
        Me.EmployeeSwift.Name = "EmployeeSwift"
        Me.EmployeeSwift.ReadOnly = true
        '
        'EmployeeJava
        '
        Me.EmployeeJava.HeaderText = "Java"
        Me.EmployeeJava.Name = "EmployeeJava"
        Me.EmployeeJava.ReadOnly = true
        Me.EmployeeJava.Width = 50
        '
        'EmployeeCPP
        '
        Me.EmployeeCPP.HeaderText = "C++"
        Me.EmployeeCPP.Name = "EmployeeCPP"
        Me.EmployeeCPP.ReadOnly = true
        Me.EmployeeCPP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeCPP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EmployeeCPP.Width = 50
        '
        'EmployeeCSharp
        '
        Me.EmployeeCSharp.HeaderText = "C#"
        Me.EmployeeCSharp.Name = "EmployeeCSharp"
        Me.EmployeeCSharp.ReadOnly = true
        Me.EmployeeCSharp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeCSharp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EmployeeCSharp.Width = 50
        '
        'EmployeePHP
        '
        Me.EmployeePHP.HeaderText = "PHP"
        Me.EmployeePHP.Name = "EmployeePHP"
        Me.EmployeePHP.ReadOnly = true
        Me.EmployeePHP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeePHP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EmployeePHP.Width = 50
        '
        'EmployeeMobile
        '
        Me.EmployeeMobile.HeaderText = "Mobile"
        Me.EmployeeMobile.Name = "EmployeeMobile"
        Me.EmployeeMobile.ReadOnly = true
        Me.EmployeeMobile.Width = 150
        '
        'EmployeeSalary
        '
        Me.EmployeeSalary.HeaderText = "Salary"
        Me.EmployeeSalary.Name = "EmployeeSalary"
        Me.EmployeeSalary.ReadOnly = true
        Me.EmployeeSalary.Width = 150
        '
        'EmployeeAge
        '
        Me.EmployeeAge.HeaderText = "Age"
        Me.EmployeeAge.Name = "EmployeeAge"
        Me.EmployeeAge.ReadOnly = true
        '
        'EmployeeSex
        '
        Me.EmployeeSex.HeaderText = "Sex"
        Me.EmployeeSex.Name = "EmployeeSex"
        Me.EmployeeSex.ReadOnly = true
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "Full Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = true
        Me.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeName.Width = 150
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "ID"
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = true
        '
        'EmployeeSerial
        '
        Me.EmployeeSerial.HeaderText = "Serial"
        Me.EmployeeSerial.Name = "EmployeeSerial"
        Me.EmployeeSerial.ReadOnly = true
        Me.EmployeeSerial.Width = 50
        '
        'EmployeesDataGridView
        '
        Me.EmployeesDataGridView.AllowUserToAddRows = false
        Me.EmployeesDataGridView.AllowUserToDeleteRows = false
        Me.EmployeesDataGridView.AllowUserToOrderColumns = true
        Me.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeSerial, Me.EmployeeID, Me.EmployeeName, Me.EmployeeSex, Me.EmployeeAge, Me.EmployeeSalary, Me.EmployeeMobile, Me.EmployeePHP, Me.EmployeeCSharp, Me.EmployeeCPP, Me.EmployeePython, Me.EmployeeJava, Me.EmployeeSwift})
        Me.EmployeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.EmployeesDataGridView.Name = "EmployeesDataGridView"
        Me.EmployeesDataGridView.RowHeadersVisible = false
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(1108, 552)
        Me.EmployeesDataGridView.TabIndex = 0
        '
        'EmployeePython
        '
        Me.EmployeePython.HeaderText = "Python"
        Me.EmployeePython.Name = "EmployeePython"
        Me.EmployeePython.ReadOnly = true
        Me.EmployeePython.Width = 50
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.EmployeesDataGridView)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1114, 558)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Employees"
        Me.tabPage1.UseVisualStyleBackColor = true
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1122, 584)
        Me.tabControl1.TabIndex = 1
        Me.tabControl1.TabStop = false
        '
        'DatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 584)
        Me.Controls.Add(Me.tabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "DatabaseForm"
        Me.Text = "Database (Read Only)"
        CType(Me.ProjectsDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage2.ResumeLayout(false)
        CType(Me.EmployeesDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage1.ResumeLayout(false)
        Me.tabControl1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Private WithEvents ProjectDescription As DataGridViewTextBoxColumn
    Private WithEvents ProjectJava As DataGridViewCheckBoxColumn
    Private WithEvents ProjectPython As DataGridViewCheckBoxColumn
    Private WithEvents ProjectCPP As DataGridViewCheckBoxColumn
    Private WithEvents ProjectCSharp As DataGridViewCheckBoxColumn
    Private WithEvents ProjectPHP As DataGridViewCheckBoxColumn
    Private WithEvents ProjectTime As DataGridViewTextBoxColumn
    Private WithEvents ProjectEmployeesRequired As DataGridViewTextBoxColumn
    Private WithEvents ProjectName As DataGridViewTextBoxColumn
    Private WithEvents ProjectSerial As DataGridViewTextBoxColumn
    Private WithEvents ProjectsDataGridView As DataGridView
    Private WithEvents ProjectSwift As DataGridViewCheckBoxColumn
    Private WithEvents tabPage2 As TabPage
    Private WithEvents EmployeeSwift As DataGridViewCheckBoxColumn
    Private WithEvents EmployeeJava As DataGridViewCheckBoxColumn
    Private WithEvents EmployeeCPP As DataGridViewCheckBoxColumn
    Private WithEvents EmployeeCSharp As DataGridViewCheckBoxColumn
    Private WithEvents EmployeePHP As DataGridViewCheckBoxColumn
    Private WithEvents EmployeeMobile As DataGridViewTextBoxColumn
    Private WithEvents EmployeeSalary As DataGridViewTextBoxColumn
    Private WithEvents EmployeeAge As DataGridViewTextBoxColumn
    Private WithEvents EmployeeSex As DataGridViewTextBoxColumn
    Private WithEvents EmployeeName As DataGridViewTextBoxColumn
    Private WithEvents EmployeeID As DataGridViewTextBoxColumn
    Private WithEvents EmployeeSerial As DataGridViewTextBoxColumn
    Private WithEvents EmployeesDataGridView As DataGridView
    Private WithEvents EmployeePython As DataGridViewCheckBoxColumn
    Private WithEvents tabPage1 As TabPage
    Private WithEvents tabControl1 As TabControl
End Class
