namespace SmuldersIceCreamCart
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPassBox = new System.Windows.Forms.TextBox();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.NewPassMatchBox = new System.Windows.Forms.TextBox();
            this.PassMatchCheckLabel = new System.Windows.Forms.Label();
            this.ConfirmChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat New Password: ";
            // 
            // OldPassBox
            // 
            this.OldPassBox.Location = new System.Drawing.Point(137, 23);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.Size = new System.Drawing.Size(163, 20);
            this.OldPassBox.TabIndex = 1;
            this.OldPassBox.UseSystemPasswordChar = true;
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(137, 49);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(163, 20);
            this.NewPassBox.TabIndex = 2;
            this.NewPassBox.UseSystemPasswordChar = true;
            // 
            // NewPassMatchBox
            // 
            this.NewPassMatchBox.Location = new System.Drawing.Point(137, 76);
            this.NewPassMatchBox.Name = "NewPassMatchBox";
            this.NewPassMatchBox.Size = new System.Drawing.Size(163, 20);
            this.NewPassMatchBox.TabIndex = 3;
            this.NewPassMatchBox.UseSystemPasswordChar = true;
            this.NewPassMatchBox.TextChanged += new System.EventHandler(this.NewPassMatchBox_TextChanged);
            // 
            // PassMatchCheckLabel
            // 
            this.PassMatchCheckLabel.AutoSize = true;
            this.PassMatchCheckLabel.Location = new System.Drawing.Point(306, 79);
            this.PassMatchCheckLabel.Name = "PassMatchCheckLabel";
            this.PassMatchCheckLabel.Size = new System.Drawing.Size(14, 13);
            this.PassMatchCheckLabel.TabIndex = 6;
            this.PassMatchCheckLabel.Text = "X";
            // 
            // ConfirmChangeButton
            // 
            this.ConfirmChangeButton.Enabled = false;
            this.ConfirmChangeButton.Location = new System.Drawing.Point(182, 102);
            this.ConfirmChangeButton.Name = "ConfirmChangeButton";
            this.ConfirmChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmChangeButton.TabIndex = 4;
            this.ConfirmChangeButton.Text = "Change";
            this.ConfirmChangeButton.UseVisualStyleBackColor = true;
            this.ConfirmChangeButton.Click += new System.EventHandler(this.ConfirmChangeButton_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 134);
            this.Controls.Add(this.ConfirmChangeButton);
            this.Controls.Add(this.PassMatchCheckLabel);
            this.Controls.Add(this.NewPassMatchBox);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.OldPassBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPassBox;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.TextBox NewPassMatchBox;
        private System.Windows.Forms.Label PassMatchCheckLabel;
        private System.Windows.Forms.Button ConfirmChangeButton;
    }
}