<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout
        Me.groupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 10)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(260, 157)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = false
        Me.groupBox1.Text = "About"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(6, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(248, 136)
        Me.label2.TabIndex = 0
        Me.label2.Text = resources.GetString("label2.Text")
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Location = New System.Drawing.Point(12, 173)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(260, 94)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = false
        Me.groupBox2.Text = "Developed By"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(6, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(248, 69)
        Me.label1.TabIndex = 0
        Me.label1.Text = "11500114111 - Suman Bhowmick"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114110 - Sujay Dey"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114109 - Sugata Bera"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114108 - Suchismita Mahato"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"11500114107 - Subir Kumar Hansda"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 276)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "About"
        Me.Text = "About"
        Me.groupBox1.ResumeLayout(false)
        Me.groupBox2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label2 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label1 As Label
End Class
