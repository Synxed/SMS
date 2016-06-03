<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeRegistration))
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.SwiftCheckBox = New System.Windows.Forms.CheckBox()
        Me.JavaCheckBox = New System.Windows.Forms.CheckBox()
        Me.PythonCheckBox = New System.Windows.Forms.CheckBox()
        Me.CPPCheckBox = New System.Windows.Forms.CheckBox()
        Me.CSharpCheckBox = New System.Windows.Forms.CheckBox()
        Me.PHPCheckBox = New System.Windows.Forms.CheckBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.SkillsetGroupBox = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.MobileTextBox = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SkillsetGroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(78, 11)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(243, 22)
        Me.EmployeeIDTextBox.TabIndex = 15
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Location = New System.Drawing.Point(246, 256)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 28
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'RegisterButton
        '
        Me.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterButton.Location = New System.Drawing.Point(13, 256)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 27
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = true
        '
        'SwiftCheckBox
        '
        Me.SwiftCheckBox.AutoSize = true
        Me.SwiftCheckBox.Location = New System.Drawing.Point(7, 45)
        Me.SwiftCheckBox.Name = "SwiftCheckBox"
        Me.SwiftCheckBox.Size = New System.Drawing.Size(52, 17)
        Me.SwiftCheckBox.TabIndex = 11
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
        Me.JavaCheckBox.TabIndex = 10
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
        Me.PythonCheckBox.TabIndex = 9
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
        Me.CPPCheckBox.TabIndex = 8
        Me.CPPCheckBox.Tag = "2"
        Me.CPPCheckBox.Text = "C++"
        Me.CPPCheckBox.UseVisualStyleBackColor = true
        '
        'CSharpCheckBox
        '
        Me.CSharpCheckBox.AutoSize = true
        Me.CSharpCheckBox.Location = New System.Drawing.Point(60, 22)
        Me.CSharpCheckBox.Name = "CSharpCheckBox"
        Me.CSharpCheckBox.Size = New System.Drawing.Size(40, 17)
        Me.CSharpCheckBox.TabIndex = 7
        Me.CSharpCheckBox.Tag = "1"
        Me.CSharpCheckBox.Text = "C#"
        Me.CSharpCheckBox.UseVisualStyleBackColor = true
        '
        'PHPCheckBox
        '
        Me.PHPCheckBox.AutoSize = true
        Me.PHPCheckBox.Location = New System.Drawing.Point(7, 22)
        Me.PHPCheckBox.Name = "PHPCheckBox"
        Me.PHPCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.PHPCheckBox.TabIndex = 6
        Me.PHPCheckBox.Tag = "0"
        Me.PHPCheckBox.Text = "PHP"
        Me.PHPCheckBox.UseVisualStyleBackColor = true
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(51, 14)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(21, 13)
        Me.label6.TabIndex = 29
        Me.label6.Text = "ID:"
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
        Me.SkillsetGroupBox.Location = New System.Drawing.Point(13, 178)
        Me.SkillsetGroupBox.Name = "SkillsetGroupBox"
        Me.SkillsetGroupBox.Size = New System.Drawing.Size(308, 72)
        Me.SkillsetGroupBox.TabIndex = 26
        Me.SkillsetGroupBox.TabStop = false
        Me.SkillsetGroupBox.Text = "Skill Set"
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(24, 146)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(46, 13)
        Me.label5.TabIndex = 25
        Me.label5.Text = "Mobile:"
        '
        'MobileTextBox
        '
        Me.MobileTextBox.Location = New System.Drawing.Point(78, 143)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(243, 22)
        Me.MobileTextBox.TabIndex = 22
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(30, 120)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 13)
        Me.label4.TabIndex = 24
        Me.label4.Text = "Salary:"
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.Location = New System.Drawing.Point(78, 117)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(243, 22)
        Me.SalaryTextBox.TabIndex = 21
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(41, 94)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(30, 13)
        Me.label3.TabIndex = 23
        Me.label3.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(78, 91)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(243, 22)
        Me.AgeTextBox.TabIndex = 19
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(43, 68)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(27, 13)
        Me.label2.TabIndex = 20
        Me.label2.Text = "Sex:"
        '
        'SexTextBox
        '
        Me.SexTextBox.Location = New System.Drawing.Point(78, 65)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(243, 22)
        Me.SexTextBox.TabIndex = 18
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(10, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Full Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(78, 39)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(243, 22)
        Me.NameTextBox.TabIndex = 17
        '
        'EmployeeRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 291)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.SkillsetGroupBox)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "EmployeeRegistration"
        Me.Text = "Employee Registration"
        Me.SkillsetGroupBox.ResumeLayout(false)
        Me.SkillsetGroupBox.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents EmployeeIDTextBox As TextBox
    Private WithEvents ResetButton As Button
    Private WithEvents RegisterButton As Button
    Private WithEvents SwiftCheckBox As CheckBox
    Private WithEvents JavaCheckBox As CheckBox
    Private WithEvents PythonCheckBox As CheckBox
    Private WithEvents CPPCheckBox As CheckBox
    Private WithEvents CSharpCheckBox As CheckBox
    Private WithEvents PHPCheckBox As CheckBox
    Private WithEvents label6 As Label
    Private WithEvents SkillsetGroupBox As GroupBox
    Private WithEvents label5 As Label
    Private WithEvents MobileTextBox As TextBox
    Private WithEvents label4 As Label
    Private WithEvents SalaryTextBox As TextBox
    Private WithEvents label3 As Label
    Private WithEvents AgeTextBox As TextBox
    Private WithEvents label2 As Label
    Private WithEvents SexTextBox As TextBox
    Private WithEvents label1 As Label
    Private WithEvents NameTextBox As TextBox
End Class
