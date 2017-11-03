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
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1754, 50);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usernameLabel.Location = new System.Drawing.Point(6, 0);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(141, 35);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "USERNAME";
            // 
            // manageAccountLabel
            // 
            this.manageAccountLabel.AutoSize = true;
            this.manageAccountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.manageAccountLabel.Location = new System.Drawing.Point(159, 0);
            this.manageAccountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manageAccountLabel.Name = "manageAccountLabel";
            this.manageAccountLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.manageAccountLabel.Size = new System.Drawing.Size(174, 35);
            this.manageAccountLabel.TabIndex = 3;
            this.manageAccountLabel.TabStop = true;
            this.manageAccountLabel.Text = "Manage Account";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoutLabel.Location = new System.Drawing.Point(345, 0);
            this.logoutLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.logoutLabel.Size = new System.Drawing.Size(78, 35);
            this.logoutLabel.TabIndex = 1;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "YOU ARE AN EMPLOYEE! Congrats. Do work.";
            // 
            // EmployeeMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 1079);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EmployeeMainView";
            this.Text = "EmployeeMainView";
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
    }
}