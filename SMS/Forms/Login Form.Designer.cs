namespace SMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.OperationGroupBox = new System.Windows.Forms.GroupBox();
            this.OperationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OperationListComboBox = new System.Windows.Forms.ComboBox();
            this.AboutStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AboutStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoginGroupBox.SuspendLayout();
            this.OperationGroupBox.SuspendLayout();
            this.AboutStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.UsernameTextBox);
            this.LoginGroupBox.Location = new System.Drawing.Point(12, 13);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(260, 108);
            this.LoginGroupBox.TabIndex = 3;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Admin Login";
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Location = new System.Drawing.Point(6, 78);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(7, 50);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(247, 22);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(7, 22);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(247, 22);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.Text = "Admin";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // OperationGroupBox
            // 
            this.OperationGroupBox.Controls.Add(this.OperationButton);
            this.OperationGroupBox.Controls.Add(this.label1);
            this.OperationGroupBox.Controls.Add(this.OperationListComboBox);
            this.OperationGroupBox.Enabled = false;
            this.OperationGroupBox.Location = new System.Drawing.Point(12, 127);
            this.OperationGroupBox.Name = "OperationGroupBox";
            this.OperationGroupBox.Size = new System.Drawing.Size(260, 93);
            this.OperationGroupBox.TabIndex = 4;
            this.OperationGroupBox.TabStop = false;
            this.OperationGroupBox.Text = "Operation";
            // 
            // OperationButton
            // 
            this.OperationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperationButton.Location = new System.Drawing.Point(6, 61);
            this.OperationButton.Name = "OperationButton";
            this.OperationButton.Size = new System.Drawing.Size(75, 23);
            this.OperationButton.TabIndex = 6;
            this.OperationButton.TabStop = false;
            this.OperationButton.Text = "Open";
            this.OperationButton.UseVisualStyleBackColor = true;
            this.OperationButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Operation:";
            // 
            // OperationListComboBox
            // 
            this.OperationListComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperationListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationListComboBox.FormattingEnabled = true;
            this.OperationListComboBox.Items.AddRange(new object[] {
            "Employee Registration",
            "Project Registration",
            "Project Allocation",
            "Training Assessment",
            "Database (Read Only)"});
            this.OperationListComboBox.Location = new System.Drawing.Point(7, 34);
            this.OperationListComboBox.Name = "OperationListComboBox";
            this.OperationListComboBox.Size = new System.Drawing.Size(247, 21);
            this.OperationListComboBox.TabIndex = 3;
            this.OperationListComboBox.TabStop = false;
            // 
            // AboutStatusStrip
            // 
            this.AboutStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.AboutStatusStripLabel});
            this.AboutStatusStrip.Location = new System.Drawing.Point(0, 128);
            this.AboutStatusStrip.Name = "AboutStatusStrip";
            this.AboutStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.AboutStatusStrip.SizingGrip = false;
            this.AboutStatusStrip.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabel1.Text = "CSE - VB Project (2014-18)";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // AboutStatusStripLabel
            // 
            this.AboutStatusStripLabel.IsLink = true;
            this.AboutStatusStripLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AboutStatusStripLabel.Name = "AboutStatusStripLabel";
            this.AboutStatusStripLabel.Size = new System.Drawing.Size(40, 17);
            this.AboutStatusStripLabel.Text = "About";
            this.AboutStatusStripLabel.Click += new System.EventHandler(this.AboutStatusStripLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.AboutStatusStrip);
            this.Controls.Add(this.OperationGroupBox);
            this.Controls.Add(this.LoginGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Skill Management System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.OperationGroupBox.ResumeLayout(false);
            this.OperationGroupBox.PerformLayout();
            this.AboutStatusStrip.ResumeLayout(false);
            this.AboutStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.GroupBox OperationGroupBox;
        private System.Windows.Forms.Button OperationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OperationListComboBox;
        private System.Windows.Forms.StatusStrip AboutStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel AboutStatusStripLabel;
    }
}

