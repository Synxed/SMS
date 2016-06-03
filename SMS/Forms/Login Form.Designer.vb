<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LoginGroupBox = New System.Windows.Forms.GroupBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.OperationGroupBox = New System.Windows.Forms.GroupBox()
        Me.OperationButton = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OperationListComboBox = New System.Windows.Forms.ComboBox()
        Me.AboutStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AboutStatusStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LoginGroupBox.SuspendLayout
        Me.OperationGroupBox.SuspendLayout
        Me.AboutStatusStrip.SuspendLayout
        Me.SuspendLayout
        '
        'LoginGroupBox
        '
        Me.LoginGroupBox.Controls.Add(Me.LoginButton)
        Me.LoginGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.LoginGroupBox.Controls.Add(Me.UsernameTextBox)
        Me.LoginGroupBox.Location = New System.Drawing.Point(12, 7)
        Me.LoginGroupBox.Name = "LoginGroupBox"
        Me.LoginGroupBox.Size = New System.Drawing.Size(260, 108)
        Me.LoginGroupBox.TabIndex = 6
        Me.LoginGroupBox.TabStop = false
        Me.LoginGroupBox.Text = "Admin Login"
        '
        'LoginButton
        '
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.Location = New System.Drawing.Point(6, 78)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = true
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(7, 50)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(247, 22)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.Text = "Password"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(7, 22)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(247, 22)
        Me.UsernameTextBox.TabIndex = 0
        Me.UsernameTextBox.Text = "Admin"
        '
        'OperationGroupBox
        '
        Me.OperationGroupBox.Controls.Add(Me.OperationButton)
        Me.OperationGroupBox.Controls.Add(Me.label1)
        Me.OperationGroupBox.Controls.Add(Me.OperationListComboBox)
        Me.OperationGroupBox.Enabled = false
        Me.OperationGroupBox.Location = New System.Drawing.Point(12, 121)
        Me.OperationGroupBox.Name = "OperationGroupBox"
        Me.OperationGroupBox.Size = New System.Drawing.Size(260, 93)
        Me.OperationGroupBox.TabIndex = 7
        Me.OperationGroupBox.TabStop = false
        Me.OperationGroupBox.Text = "Operation"
        '
        'OperationButton
        '
        Me.OperationButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OperationButton.Location = New System.Drawing.Point(6, 61)
        Me.OperationButton.Name = "OperationButton"
        Me.OperationButton.Size = New System.Drawing.Size(75, 23)
        Me.OperationButton.TabIndex = 6
        Me.OperationButton.TabStop = false
        Me.OperationButton.Text = "Open"
        Me.OperationButton.UseVisualStyleBackColor = true
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(6, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(96, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Select Operation:"
        '
        'OperationListComboBox
        '
        Me.OperationListComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OperationListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OperationListComboBox.FormattingEnabled = true
        Me.OperationListComboBox.Items.AddRange(New Object() {"Employee Registration", "Project Registration", "Project Allocation", "Training Assessment", "Database (Read Only)"})
        Me.OperationListComboBox.Location = New System.Drawing.Point(7, 34)
        Me.OperationListComboBox.Name = "OperationListComboBox"
        Me.OperationListComboBox.Size = New System.Drawing.Size(247, 21)
        Me.OperationListComboBox.TabIndex = 3
        Me.OperationListComboBox.TabStop = false
        '
        'AboutStatusStrip
        '
        Me.AboutStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.AboutStatusStripLabel})
        Me.AboutStatusStrip.Location = New System.Drawing.Point(0, 123)
        Me.AboutStatusStrip.Name = "AboutStatusStrip"
        Me.AboutStatusStrip.Size = New System.Drawing.Size(284, 22)
        Me.AboutStatusStrip.SizingGrip = false
        Me.AboutStatusStrip.TabIndex = 9
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.toolStripStatusLabel1.Text = "CSE - VB Project (2014-18)"
        '
        'toolStripStatusLabel2
        '
        Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
        Me.toolStripStatusLabel2.Size = New System.Drawing.Size(85, 17)
        Me.toolStripStatusLabel2.Spring = true
        '
        'AboutStatusStripLabel
        '
        Me.AboutStatusStripLabel.IsLink = true
        Me.AboutStatusStripLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AboutStatusStripLabel.Name = "AboutStatusStripLabel"
        Me.AboutStatusStripLabel.Size = New System.Drawing.Size(40, 17)
        Me.AboutStatusStripLabel.Text = "About"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 145)
        Me.Controls.Add(Me.AboutStatusStrip)
        Me.Controls.Add(Me.LoginGroupBox)
        Me.Controls.Add(Me.OperationGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "LoginForm"
        Me.Text = "Skill Management System"
        Me.LoginGroupBox.ResumeLayout(false)
        Me.LoginGroupBox.PerformLayout
        Me.OperationGroupBox.ResumeLayout(false)
        Me.OperationGroupBox.PerformLayout
        Me.AboutStatusStrip.ResumeLayout(false)
        Me.AboutStatusStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents LoginGroupBox As GroupBox
    Private WithEvents LoginButton As Button
    Private WithEvents PasswordTextBox As TextBox
    Private WithEvents UsernameTextBox As TextBox
    Private WithEvents OperationGroupBox As GroupBox
    Private WithEvents OperationButton As Button
    Private WithEvents label1 As Label
    Private WithEvents OperationListComboBox As ComboBox
    Private WithEvents AboutStatusStrip As StatusStrip
    Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Private WithEvents toolStripStatusLabel2 As ToolStripStatusLabel
    Private WithEvents AboutStatusStripLabel As ToolStripStatusLabel
End Class
