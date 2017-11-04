namespace SmuldersIceCreamCart
{
    partial class EmployeeMainView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.manageAccountLabel = new System.Windows.Forms.LinkLabel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccountsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.usernameLabel);
            this.flowLayoutPanel1.Controls.Add(this.manageAccountLabel);
            this.flowLayoutPanel1.Controls.Add(this.logoutLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(877, 26);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(73, 18);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "USERNAME";
            // 
            // manageAccountLabel
            // 
            this.manageAccountLabel.AutoSize = true;
            this.manageAccountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.manageAccountLabel.Location = new System.Drawing.Point(82, 0);
            this.manageAccountLabel.Name = "manageAccountLabel";
            this.manageAccountLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.manageAccountLabel.Size = new System.Drawing.Size(89, 18);
            this.manageAccountLabel.TabIndex = 3;
            this.manageAccountLabel.TabStop = true;
            this.manageAccountLabel.Text = "Manage Account";
            this.manageAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageAccountLabel_LinkClicked);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoutLabel.Location = new System.Drawing.Point(177, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.logoutLabel.Size = new System.Drawing.Size(40, 18);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "YOU ARE AN EMPLOYEE! Congrats. Do work.";
            // 
            // CreateAccountsButton
            // 
            this.CreateAccountsButton.Location = new System.Drawing.Point(19, 79);
            this.CreateAccountsButton.Name = "CreateAccountsButton";
            this.CreateAccountsButton.Size = new System.Drawing.Size(121, 23);
            this.CreateAccountsButton.TabIndex = 5;
            this.CreateAccountsButton.Text = "Create Accounts";
            this.CreateAccountsButton.UseVisualStyleBackColor = true;
            this.CreateAccountsButton.Click += new System.EventHandler(this.CreateAccountsButton_Click);
            // 
            // EmployeeMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 552);
            this.Controls.Add(this.CreateAccountsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeMainView";
            this.Text = "Employee Dashboard";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel manageAccountLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateAccountsButton;
    }
}