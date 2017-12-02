namespace SmuldersIceCreamCart
{
    partial class OrderHistoryView
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
            this.label1 = new System.Windows.Forms.Label();
            this.manageAccountLabel_LinkClicked = new System.Windows.Forms.LinkLabel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.order_id = new System.Windows.Forms.Label();
            this.totalItems = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HomeButtonClicked = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TimePlacedTextBox = new System.Windows.Forms.TextBox();
            this.OrderStatusTextBox = new System.Windows.Forms.TextBox();
            this.TimeFulfilledTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.manageAccountLabel_LinkClicked);
            this.flowLayoutPanel1.Controls.Add(this.logoutLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(665, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            // 
            // manageAccountLabel_LinkClicked
            // 
            this.manageAccountLabel_LinkClicked.AutoSize = true;
            this.manageAccountLabel_LinkClicked.Location = new System.Drawing.Point(104, 0);
            this.manageAccountLabel_LinkClicked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manageAccountLabel_LinkClicked.Name = "manageAccountLabel_LinkClicked";
            this.manageAccountLabel_LinkClicked.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.manageAccountLabel_LinkClicked.Size = new System.Drawing.Size(77, 23);
            this.manageAccountLabel_LinkClicked.TabIndex = 2;
            this.manageAccountLabel_LinkClicked.TabStop = true;
            this.manageAccountLabel_LinkClicked.Text = "MyAccount";
            this.manageAccountLabel_LinkClicked.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManageAccountLink_Clicked);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(189, 0);
            this.logoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.logoutLabel.Size = new System.Drawing.Size(52, 23);
            this.logoutLabel.TabIndex = 3;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_Clicked);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(150, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 244);
            this.listBox1.TabIndex = 1;
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Location = new System.Drawing.Point(156, 51);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(66, 17);
            this.order_id.TabIndex = 2;
            this.order_id.Text = "Order ID:";
            // 
            // totalItems
            // 
            this.totalItems.AutoSize = true;
            this.totalItems.Location = new System.Drawing.Point(195, 347);
            this.totalItems.Name = "totalItems";
            this.totalItems.Size = new System.Drawing.Size(161, 17);
            this.totalItems.TabIndex = 3;
            this.totalItems.Text = "Number of item in order:";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(471, 347);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(80, 17);
            this.totalCost.TabIndex = 4;
            this.totalCost.Text = "Total Cost: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time Placed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time Fulfilled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Status";
            // 
            // HomeButtonClicked
            // 
            this.HomeButtonClicked.Location = new System.Drawing.Point(33, 319);
            this.HomeButtonClicked.Name = "HomeButtonClicked";
            this.HomeButtonClicked.Size = new System.Drawing.Size(100, 45);
            this.HomeButtonClicked.TabIndex = 8;
            this.HomeButtonClicked.Text = "Home";
            this.HomeButtonClicked.UseVisualStyleBackColor = true;
            this.HomeButtonClicked.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.TotalItemBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.TotalCostBox_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.OrderIDBox_TextChanged);
            // 
            // TimePlacedTextBox
            // 
            this.TimePlacedTextBox.Location = new System.Drawing.Point(33, 91);
            this.TimePlacedTextBox.Name = "TimePlacedTextBox";
            this.TimePlacedTextBox.ReadOnly = true;
            this.TimePlacedTextBox.Size = new System.Drawing.Size(100, 22);
            this.TimePlacedTextBox.TabIndex = 12;
            this.TimePlacedTextBox.TextChanged += new System.EventHandler(this.TimePlacedBox_TextChanged);
            // 
            // OrderStatusTextBox
            // 
            this.OrderStatusTextBox.Location = new System.Drawing.Point(33, 264);
            this.OrderStatusTextBox.Name = "OrderStatusTextBox";
            this.OrderStatusTextBox.ReadOnly = true;
            this.OrderStatusTextBox.Size = new System.Drawing.Size(100, 22);
            this.OrderStatusTextBox.TabIndex = 13;
            this.OrderStatusTextBox.TextChanged += new System.EventHandler(this.OrderStatusBox_TextChanged);
            // 
            // TimeFulfilledTextBox
            // 
            this.TimeFulfilledTextBox.Location = new System.Drawing.Point(33, 180);
            this.TimeFulfilledTextBox.Name = "TimeFulfilledTextBox";
            this.TimeFulfilledTextBox.ReadOnly = true;
            this.TimeFulfilledTextBox.Size = new System.Drawing.Size(100, 22);
            this.TimeFulfilledTextBox.TabIndex = 14;
            this.TimeFulfilledTextBox.TextChanged += new System.EventHandler(this.TimeFulfilledBox_TextChanged);
            // 
            // OrderHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 391);
            this.Controls.Add(this.TimeFulfilledTextBox);
            this.Controls.Add(this.OrderStatusTextBox);
            this.Controls.Add(this.TimePlacedTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HomeButtonClicked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.totalItems);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OrderHistoryView";
            this.Text = " Smulder\'s Ice Cream Cart Service - Order History";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel manageAccountLabel_LinkClicked;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.Label totalItems;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HomeButtonClicked;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TimePlacedTextBox;
        private System.Windows.Forms.TextBox OrderStatusTextBox;
        private System.Windows.Forms.TextBox TimeFulfilledTextBox;
    }
}