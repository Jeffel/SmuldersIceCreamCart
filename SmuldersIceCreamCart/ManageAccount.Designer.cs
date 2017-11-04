namespace SmuldersIceCreamCart
{
    partial class ManageAccount
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
            this.PswdChangeButton = new System.Windows.Forms.Button();
            this.DeleteActButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PswdChangeButton
            // 
            this.PswdChangeButton.Location = new System.Drawing.Point(78, 63);
            this.PswdChangeButton.Name = "PswdChangeButton";
            this.PswdChangeButton.Size = new System.Drawing.Size(125, 23);
            this.PswdChangeButton.TabIndex = 0;
            this.PswdChangeButton.Text = "Change Password";
            this.PswdChangeButton.UseVisualStyleBackColor = true;
            this.PswdChangeButton.Click += new System.EventHandler(this.PswdChangeButton_Click);
            // 
            // DeleteActButton
            // 
            this.DeleteActButton.Location = new System.Drawing.Point(78, 167);
            this.DeleteActButton.Name = "DeleteActButton";
            this.DeleteActButton.Size = new System.Drawing.Size(125, 23);
            this.DeleteActButton.TabIndex = 1;
            this.DeleteActButton.Text = "Delete Account";
            this.DeleteActButton.UseVisualStyleBackColor = true;
            this.DeleteActButton.Click += new System.EventHandler(this.DeleteActButton_Click);
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteActButton);
            this.Controls.Add(this.PswdChangeButton);
            this.Name = "ManageAccount";
            this.Text = "ManageAccount";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PswdChangeButton;
        private System.Windows.Forms.Button DeleteActButton;
    }
}