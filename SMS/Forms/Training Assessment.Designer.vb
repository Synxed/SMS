<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainingAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainingAssessment))
        Me.AssessmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnalyzeButton = New System.Windows.Forms.Button()
        Me.SkillComboBox = New System.Windows.Forms.ComboBox()
        Me.ReportButton = New System.Windows.Forms.Button()
        CType(Me.AssessmentDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'AssessmentDataGridView
        '
        Me.AssessmentDataGridView.AllowUserToAddRows = false
        Me.AssessmentDataGridView.AllowUserToDeleteRows = false
        Me.AssessmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AssessmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmployeeName, Me.Sex, Me.EmployeeAge, Me.Salary})
        Me.AssessmentDataGridView.Location = New System.Drawing.Point(12, 41)
        Me.AssessmentDataGridView.Name = "AssessmentDataGridView"
        Me.AssessmentDataGridView.RowHeadersVisible = false
        Me.AssessmentDataGridView.Size = New System.Drawing.Size(343, 193)
        Me.AssessmentDataGridView.TabIndex = 7
        Me.AssessmentDataGridView.TabStop = false
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = true
        Me.ID.Width = 60
        '
        'EmployeeName
        '
        Me.EmployeeName.HeaderText = "Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = true
        Me.EmployeeName.Width = 110
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = true
        Me.Sex.Width = 30
        '
        'EmployeeAge
        '
        Me.EmployeeAge.HeaderText = "Age"
        Me.EmployeeAge.Name = "EmployeeAge"
        Me.EmployeeAge.ReadOnly = true
        Me.EmployeeAge.Width = 45
        '
        'Salary
        '
        Me.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Salary.HeaderText = "Salary"
        Me.Salary.Name = "Salary"
        Me.Salary.ReadOnly = true
        '
        'AnalyzeButton
        '
        Me.AnalyzeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnalyzeButton.Location = New System.Drawing.Point(149, 12)
        Me.AnalyzeButton.Name = "AnalyzeButton"
        Me.AnalyzeButton.Size = New System.Drawing.Size(75, 23)
        Me.AnalyzeButton.TabIndex = 5
        Me.AnalyzeButton.Text = "Analyze"
        Me.AnalyzeButton.UseVisualStyleBackColor = true
        '
        'SkillComboBox
        '
        Me.SkillComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SkillComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SkillComboBox.FormattingEnabled = true
        Me.SkillComboBox.Items.AddRange(New Object() {"PHP", "C#", "C++", "Python", "Java", "Swift"})
        Me.SkillComboBox.Location = New System.Drawing.Point(13, 12)
        Me.SkillComboBox.Name = "SkillComboBox"
        Me.SkillComboBox.Size = New System.Drawing.Size(130, 21)
        Me.SkillComboBox.TabIndex = 4
        '
        'ReportButton
        '
        Me.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReportButton.Location = New System.Drawing.Point(230, 12)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(125, 23)
        Me.ReportButton.TabIndex = 6
        Me.ReportButton.Text = "Export Full Report"
        Me.ReportButton.UseVisualStyleBackColor = true
        '
        'TrainingAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 247)
        Me.Controls.Add(Me.AssessmentDataGridView)
        Me.Controls.Add(Me.AnalyzeButton)
        Me.Controls.Add(Me.SkillComboBox)
        Me.Controls.Add(Me.ReportButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "TrainingAssessment"
        Me.Text = "Training Assessment"
        CType(Me.AssessmentDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Private WithEvents AssessmentDataGridView As DataGridView
    Private WithEvents ID As DataGridViewTextBoxColumn
    Private WithEvents EmployeeName As DataGridViewTextBoxColumn
    Private WithEvents Sex As DataGridViewTextBoxColumn
    Private WithEvents EmployeeAge As DataGridViewTextBoxColumn
    Private WithEvents Salary As DataGridViewTextBoxColumn
    Private WithEvents AnalyzeButton As Button
    Private WithEvents SkillComboBox As ComboBox
    Private WithEvents ReportButton As Button
End Class
