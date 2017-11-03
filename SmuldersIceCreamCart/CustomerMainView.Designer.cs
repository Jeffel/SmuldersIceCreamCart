namespace SmuldersIceCreamCart
{
    partial class CustomerMainView
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(73, 23);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "USERNAME";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(177, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.linkLabel1.Size = new System.Drawing.Size(40, 23);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.usernameLabel);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel2);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(882, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(82, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.linkLabel2.Size = new System.Drawing.Size(89, 23);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Manage Account";
            // 
            // CustomerMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CustomerMainView";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Text = "CustomerMainView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}