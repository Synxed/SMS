<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectRegistration))
        Me.SwiftCheckBox = New System.Windows.Forms.CheckBox()
        Me.JavaCheckBox = New System.Windows.Forms.CheckBox()
        Me.PythonCheckBox = New System.Windows.Forms.CheckBox()
        Me.CPPCheckBox = New System.Windows.Forms.CheckBox()
        Me.PHPCheckBox = New System.Windows.Forms.CheckBox()
        Me.SkillsetGroupBox = New System.Windows.Forms.GroupBox()
        Me.CSharpCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.AllocatedTimeNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.label4 = New System.Windows.Forms.Label()
        Me.EmployeeRequiredNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ProjectDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ProjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SkillsetGroupBox.SuspendLayout
        CType(Me.AllocatedTimeNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EmployeeRequiredNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SwiftCheckBox
        '
        Me.SwiftCheckBox.AutoSize = true
        Me.SwiftCheckBox.Location = New System.Drawing.Point(7, 45)
        Me.SwiftCheckBox.Name = "SwiftCheckBox"
        Me.SwiftCheckBox.Size = New System.Drawing.Size(52, 17)
        Me.SwiftCheckBox.TabIndex = 7
        Me.SwiftCheckBox.Tag = "6"
        Me.SwiftCheckBox.Text = "Swift"
        Me.SwiftCheckBox.UseVisualStyleBackColor = true
        '
        'JavaCheckBox
        '
        Me.JavaCheckBox.AutoSize = true
        Me.JavaCheckBox.Location = New System.Drawing.Point(229, 21)
        Me.JavaCheckBox.Name = "JavaCheckBox"
        Me.JavaCheckBox.Size = New System.Drawing.Size(47, 17)
        Me.JavaCheckBox.TabIndex = 6
        Me.JavaCheckBox.Tag = "5"
        Me.JavaCheckBox.Text = "Java"
        Me.JavaCheckBox.UseVisualStyleBackColor = true
        '
        'PythonCheckBox
        '
        Me.PythonCheckBox.AutoSize = true
        Me.PythonCheckBox.Location = New System.Drawing.Point(161, 21)
        Me.PythonCheckBox.Name = "PythonCheckBox"
        Me.PythonCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.PythonCheckBox.TabIndex = 5
        Me.PythonCheckBox.Tag = "3"
        Me.PythonCheckBox.Text = "Python"
        Me.PythonCheckBox.UseVisualStyleBackColor = true
        '
        'CPPCheckBox
        '
        Me.CPPCheckBox.AutoSize = true
        Me.CPPCheckBox.Location = New System.Drawing.Point(106, 22)
        Me.CPPCheckBox.Name = "CPPCheckBox"
        Me.CPPCheckBox.Size = New System.Drawing.Size(49, 17)
        Me.CPPCheckBox.TabIndex = 4
        Me.CPPCheckBox.Tag = "2"
        Me.CPPCheckBox.Text = "C++"
        Me.CPPCheckBox.UseVisualStyleBackColor = true
        '
        'PHPCheckBox
        '
        Me.PHPCheckBox.AutoSize = true
        Me.PHPCheckBox.Location = New System.Drawing.Point(7, 22)
        Me.PHPCheckBox.Name = "PHPCheckBox"
        Me.PHPCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.PHPCheckBox.TabIndex = 2
        Me.PHPCheckBox.Tag = "0"
        Me.PHPCheckBox.Text = "PHP"
        Me.PHPCheckBox.UseVisualStyleBackColor = true
        '
        'SkillsetGroupBox
        '
        Me.SkillsetGroupBox.Controls.Add(Me.SwiftCheckBox)
        Me.SkillsetGroupBox.Controls.Add(Me.JavaCheckBox)
        Me.SkillsetGroupBox.Controls.Add(Me.PythonCheckBox)
        Me.SkillsetGroupBox.Controls.Add(Me.CPPCheckBox)
        Me.SkillsetGroupBox.Controls.Add(Me.CSharpCheckBox)
        Me.SkillsetGroupBox.Controls.Add(Me.PHPCheckBox)
        Me.SkillsetGroupBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SkillsetGroupBox.Location = New System.Drawing.Point(13, 143)
        Me.SkillsetGroupBox.Name = "SkillsetGroupBox"
        Me.SkillsetGroupBox.Size = New System.Drawing.Size(308, 72)
        Me.SkillsetGroupBox.TabIndex = 29
        Me.SkillsetGroupBox.TabStop = false
        Me.SkillsetGroupBox.Text = "Skill Set"
        '
        'CSharpCheckBox
        '
        Me.CSharpCheckBox.AutoSize = true
        Me.CSharpCheckBox.Location = New System.Drawing.Point(60, 22)
        Me.CSharpCheckBox.Name = "CSharpCheckBox"
        Me.CSharpCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.CSharpCheckBox.TabIndex = 3
        Me.CSharpCheckBox.Tag = "1"
        Me.CSharpCheckBox.Text = "C#"
        Me.CSharpCheckBox.UseVisualStyleBackColor = true
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Location = New System.Drawing.Point(244, 270)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 26
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'RegisterButton
        '
        Me.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterButton.Location = New System.Drawing.Point(13, 270)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 25
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = true
        '
        'AllocatedTimeNumericBox
        '
        Me.AllocatedTimeNumericBox.Location = New System.Drawing.Point(128, 242)
        Me.AllocatedTimeNumericBox.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.AllocatedTimeNumericBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AllocatedTimeNumericBox.Name = "AllocatedTimeNumericBox"
        Me.AllocatedTimeNumericBox.Size = New System.Drawing.Size(74, 22)
        Me.AllocatedTimeNumericBox.TabIndex = 24
        Me.AllocatedTimeNumericBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(125, 226)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(169, 13)
        Me.label4.TabIndex = 28
        Me.label4.Text = "Maximum Allocated Time (Days):"
        '
        'EmployeeRequiredNumericBox
        '
        Me.EmployeeRequiredNumericBox.Location = New System.Drawing.Point(13, 242)
        Me.EmployeeRequiredNumericBox.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.EmployeeRequiredNumericBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.EmployeeRequiredNumericBox.Name = "EmployeeRequiredNumericBox"
        Me.EmployeeRequiredNumericBox.Size = New System.Drawing.Size(74, 22)
        Me.EmployeeRequiredNumericBox.TabIndex = 23
        Me.EmployeeRequiredNumericBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(10, 226)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(109, 13)
        Me.label3.TabIndex = 27
        Me.label3.Text = "Employee Required:"
        '
        'ProjectDescriptionTextBox
        '
        Me.ProjectDescriptionTextBox.Location = New System.Drawing.Point(13, 59)
        Me.ProjectDescriptionTextBox.Multiline = true
        Me.ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox"
        Me.ProjectDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ProjectDescriptionTextBox.Size = New System.Drawing.Size(306, 78)
        Me.ProjectDescriptionTextBox.TabIndex = 21
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(10, 43)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(107, 13)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Project Description:"
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.Location = New System.Drawing.Point(93, 12)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(226, 22)
        Me.ProjectNameTextBox.TabIndex = 19
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(10, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 13)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Project Name:"
        '
        'ProjectRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 304)
        Me.Controls.Add(Me.SkillsetGroupBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.AllocatedTimeNumericBox)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.EmployeeRequiredNumericBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.ProjectDescriptionTextBox)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ProjectNameTextBox)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "ProjectRegistration"
        Me.Text = "Project Registration"
        Me.SkillsetGroupBox.ResumeLayout(false)
        Me.SkillsetGroupBox.PerformLayout
        CType(Me.AllocatedTimeNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EmployeeRequiredNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents SwiftCheckBox As CheckBox
    Private WithEvents JavaCheckBox As CheckBox
    Private WithEvents PythonCheckBox As CheckBox
    Private WithEvents CPPCheckBox As CheckBox
    Private WithEvents PHPCheckBox As CheckBox
    Private WithEvents SkillsetGroupBox As GroupBox
    Private WithEvents CSharpCheckBox As CheckBox
    Private WithEvents ResetButton As Button
    Private WithEvents RegisterButton As Button
    Private WithEvents AllocatedTimeNumericBox As NumericUpDown
    Private WithEvents label4 As Label
    Private WithEvents EmployeeRequiredNumericBox As NumericUpDown
    Private WithEvents label3 As Label
    Private WithEvents ProjectDescriptionTextBox As TextBox
    Private WithEvents label2 As Label
    Private WithEvents ProjectNameTextBox As TextBox
    Private WithEvents label1 As Label
End Class
