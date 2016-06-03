<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectAllocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectAllocation))
        Me.ExportReportButton = New System.Windows.Forms.Button()
        Me.ReportTextBox = New System.Windows.Forms.TextBox()
        Me.AllocateButton = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ProjectListComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout
        '
        'ExportReportButton
        '
        Me.ExportReportButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExportReportButton.Location = New System.Drawing.Point(420, 28)
        Me.ExportReportButton.Name = "ExportReportButton"
        Me.ExportReportButton.Size = New System.Drawing.Size(106, 23)
        Me.ExportReportButton.TabIndex = 7
        Me.ExportReportButton.TabStop = false
        Me.ExportReportButton.Text = "Export Report"
        Me.ExportReportButton.UseVisualStyleBackColor = true
        '
        'ReportTextBox
        '
        Me.ReportTextBox.Location = New System.Drawing.Point(13, 55)
        Me.ReportTextBox.Multiline = true
        Me.ReportTextBox.Name = "ReportTextBox"
        Me.ReportTextBox.ReadOnly = true
        Me.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ReportTextBox.Size = New System.Drawing.Size(513, 335)
        Me.ReportTextBox.TabIndex = 8
        Me.ReportTextBox.TabStop = false
        '
        'AllocateButton
        '
        Me.AllocateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AllocateButton.Location = New System.Drawing.Point(339, 28)
        Me.AllocateButton.Name = "AllocateButton"
        Me.AllocateButton.Size = New System.Drawing.Size(75, 23)
        Me.AllocateButton.TabIndex = 5
        Me.AllocateButton.TabStop = false
        Me.AllocateButton.Text = "Allocate"
        Me.AllocateButton.UseVisualStyleBackColor = true
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(13, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Select Project:"
        '
        'ProjectListComboBox
        '
        Me.ProjectListComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProjectListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProjectListComboBox.FormattingEnabled = true
        Me.ProjectListComboBox.Location = New System.Drawing.Point(13, 28)
        Me.ProjectListComboBox.Name = "ProjectListComboBox"
        Me.ProjectListComboBox.Size = New System.Drawing.Size(320, 21)
        Me.ProjectListComboBox.TabIndex = 4
        Me.ProjectListComboBox.TabStop = false
        '
        'ProjectAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 403)
        Me.Controls.Add(Me.ExportReportButton)
        Me.Controls.Add(Me.ReportTextBox)
        Me.Controls.Add(Me.AllocateButton)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ProjectListComboBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "ProjectAllocation"
        Me.Text = "Project Allocation"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents ExportReportButton As Button
    Private WithEvents ReportTextBox As TextBox
    Private WithEvents AllocateButton As Button
    Private WithEvents label1 As Label
    Private WithEvents ProjectListComboBox As ComboBox
End Class
