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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainView));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.manageAccountLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.VertSplitLabel = new System.Windows.Forms.Label();
            this.HistFromLabel = new System.Windows.Forms.Label();
            this.HistToLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UpdateInfoButton = new System.Windows.Forms.Button();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // logoutLabel
            // 
            resources.ApplyResources(this.logoutLabel, "logoutLabel");
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.TabStop = true;
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.usernameLabel);
            this.flowLayoutPanel1.Controls.Add(this.manageAccountLabel);
            this.flowLayoutPanel1.Controls.Add(this.logoutLabel);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // manageAccountLabel
            // 
            resources.ApplyResources(this.manageAccountLabel, "manageAccountLabel");
            this.manageAccountLabel.Name = "manageAccountLabel";
            this.manageAccountLabel.TabStop = true;
            this.manageAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageAccountLabel_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // VertSplitLabel
            // 
            this.VertSplitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.VertSplitLabel, "VertSplitLabel");
            this.VertSplitLabel.Name = "VertSplitLabel";
            // 
            // HistFromLabel
            // 
            resources.ApplyResources(this.HistFromLabel, "HistFromLabel");
            this.HistFromLabel.Name = "HistFromLabel";
            // 
            // HistToLabel
            // 
            resources.ApplyResources(this.HistToLabel, "HistToLabel");
            this.HistToLabel.Name = "HistToLabel";
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            // 
            // PlaceOrderButton
            // 
            resources.ApplyResources(this.PlaceOrderButton, "PlaceOrderButton");
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // UpdateInfoButton
            // 
            resources.ApplyResources(this.UpdateInfoButton, "UpdateInfoButton");
            this.UpdateInfoButton.Name = "UpdateInfoButton";
            this.UpdateInfoButton.UseVisualStyleBackColor = true;
            this.UpdateInfoButton.Click += new System.EventHandler(this.UpdateInfoButton_Click);
            // 
            // NameTextbox
            // 
            resources.ApplyResources(this.NameTextbox, "NameTextbox");
            this.NameTextbox.Name = "NameTextbox";
            // 
            // CustomerMainView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.UpdateInfoButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.HistToLabel);
            this.Controls.Add(this.HistFromLabel);
            this.Controls.Add(this.VertSplitLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerMainView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel manageAccountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VertSplitLabel;
        private System.Windows.Forms.Label HistFromLabel;
        private System.Windows.Forms.Label HistToLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button UpdateInfoButton;
        private System.Windows.Forms.TextBox NameTextbox;
    }
}