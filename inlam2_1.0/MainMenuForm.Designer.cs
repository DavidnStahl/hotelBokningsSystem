namespace inlam2_1._0
{
    partial class MainMenuForm
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
            this.tBoxSearchCustomers = new System.Windows.Forms.TextBox();
            this.btnSearchCustomers = new System.Windows.Forms.Button();
            this.listBoxSearchedCustomers = new System.Windows.Forms.ListBox();
            this.btnShowCustomerInformation = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnBookARoom = new System.Windows.Forms.Button();
            this.btnCheckPayments = new System.Windows.Forms.Button();
            this.btnHandleCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxSearchCustomers
            // 
            this.tBoxSearchCustomers.Location = new System.Drawing.Point(395, 24);
            this.tBoxSearchCustomers.Name = "tBoxSearchCustomers";
            this.tBoxSearchCustomers.Size = new System.Drawing.Size(186, 22);
            this.tBoxSearchCustomers.TabIndex = 0;
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.Location = new System.Drawing.Point(598, 24);
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.Size = new System.Drawing.Size(136, 29);
            this.btnSearchCustomers.TabIndex = 1;
            this.btnSearchCustomers.Text = "Search Customers";
            this.btnSearchCustomers.UseVisualStyleBackColor = true;
            this.btnSearchCustomers.Click += new System.EventHandler(this.btnSearchCustomers_Click);
            // 
            // listBoxSearchedCustomers
            // 
            this.listBoxSearchedCustomers.FormattingEnabled = true;
            this.listBoxSearchedCustomers.ItemHeight = 16;
            this.listBoxSearchedCustomers.Location = new System.Drawing.Point(395, 66);
            this.listBoxSearchedCustomers.Name = "listBoxSearchedCustomers";
            this.listBoxSearchedCustomers.Size = new System.Drawing.Size(339, 244);
            this.listBoxSearchedCustomers.TabIndex = 2;
            // 
            // btnShowCustomerInformation
            // 
            this.btnShowCustomerInformation.Location = new System.Drawing.Point(395, 329);
            this.btnShowCustomerInformation.Name = "btnShowCustomerInformation";
            this.btnShowCustomerInformation.Size = new System.Drawing.Size(157, 27);
            this.btnShowCustomerInformation.TabIndex = 3;
            this.btnShowCustomerInformation.Text = "Show Customer info";
            this.btnShowCustomerInformation.UseVisualStyleBackColor = true;
            this.btnShowCustomerInformation.Click += new System.EventHandler(this.btnShowCustomerInformation_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 24);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(160, 36);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnBookARoom
            // 
            this.btnBookARoom.Location = new System.Drawing.Point(190, 24);
            this.btnBookARoom.Name = "btnBookARoom";
            this.btnBookARoom.Size = new System.Drawing.Size(143, 36);
            this.btnBookARoom.TabIndex = 5;
            this.btnBookARoom.Text = "Book a room";
            this.btnBookARoom.UseVisualStyleBackColor = true;
            this.btnBookARoom.Click += new System.EventHandler(this.btnBookARoom_Click);
            // 
            // btnCheckPayments
            // 
            this.btnCheckPayments.Location = new System.Drawing.Point(12, 81);
            this.btnCheckPayments.Name = "btnCheckPayments";
            this.btnCheckPayments.Size = new System.Drawing.Size(160, 37);
            this.btnCheckPayments.TabIndex = 6;
            this.btnCheckPayments.Text = "Check Payments";
            this.btnCheckPayments.UseVisualStyleBackColor = true;
            // 
            // btnHandleCustomers
            // 
            this.btnHandleCustomers.Location = new System.Drawing.Point(190, 81);
            this.btnHandleCustomers.Name = "btnHandleCustomers";
            this.btnHandleCustomers.Size = new System.Drawing.Size(143, 37);
            this.btnHandleCustomers.TabIndex = 7;
            this.btnHandleCustomers.Text = "Handle Customers";
            this.btnHandleCustomers.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHandleCustomers);
            this.Controls.Add(this.btnCheckPayments);
            this.Controls.Add(this.btnBookARoom);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnShowCustomerInformation);
            this.Controls.Add(this.listBoxSearchedCustomers);
            this.Controls.Add(this.btnSearchCustomers);
            this.Controls.Add(this.tBoxSearchCustomers);
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxSearchCustomers;
        private System.Windows.Forms.Button btnSearchCustomers;
        private System.Windows.Forms.ListBox listBoxSearchedCustomers;
        private System.Windows.Forms.Button btnShowCustomerInformation;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnBookARoom;
        private System.Windows.Forms.Button btnCheckPayments;
        private System.Windows.Forms.Button btnHandleCustomers;
    }
}

