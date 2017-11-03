namespace SmuldersIceCreamCart
{
    partial class Login
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(90, 174);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(139, 20);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(90, 200);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(139, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(169, 228);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to Smulder\'s Ice Cream Cart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmuldersIceCreamCart.Properties.Resources.done;
            this.pictureBox1.Location = new System.Drawing.Point(54, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}