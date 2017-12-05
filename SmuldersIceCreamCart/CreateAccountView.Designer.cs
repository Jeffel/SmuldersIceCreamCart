namespace SmuldersIceCreamCart
{
    partial class CreateAccountView
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
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.IsEmployeeCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(220, 67);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(276, 31);
            this.EmailBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-Mail: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password: ";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(220, 110);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(276, 31);
            this.PasswordBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name: ";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(220, 260);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(276, 31);
            this.FirstNameBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name: ";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(220, 304);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(276, 31);
            this.LastNameBox.TabIndex = 5;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(232, 398);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(132, 48);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // IsEmployeeCheck
            // 
            this.IsEmployeeCheck.AutoSize = true;
            this.IsEmployeeCheck.Location = new System.Drawing.Point(256, 193);
            this.IsEmployeeCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IsEmployeeCheck.Name = "IsEmployeeCheck";
            this.IsEmployeeCheck.Size = new System.Drawing.Size(173, 29);
            this.IsEmployeeCheck.TabIndex = 13;
            this.IsEmployeeCheck.Text = "Is Employee?";
            this.IsEmployeeCheck.UseVisualStyleBackColor = true;
            this.IsEmployeeCheck.Visible = false;
            // 
            // CreateAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 490);
            this.Controls.Add(this.IsEmployeeCheck);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAccountView";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.CheckBox IsEmployeeCheck;
    }
}