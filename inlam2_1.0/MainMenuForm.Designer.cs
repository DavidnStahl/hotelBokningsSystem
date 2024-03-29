﻿namespace inlam2_1._0
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
            this.btnHandleReservations = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxSearchCustomers
            // 
            this.tBoxSearchCustomers.Location = new System.Drawing.Point(84, 24);
            this.tBoxSearchCustomers.Name = "tBoxSearchCustomers";
            this.tBoxSearchCustomers.Size = new System.Drawing.Size(497, 22);
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
            this.listBoxSearchedCustomers.Location = new System.Drawing.Point(84, 66);
            this.listBoxSearchedCustomers.Name = "listBoxSearchedCustomers";
            this.listBoxSearchedCustomers.Size = new System.Drawing.Size(650, 212);
            this.listBoxSearchedCustomers.TabIndex = 2;
            // 
            // btnShowCustomerInformation
            // 
            this.btnShowCustomerInformation.Location = new System.Drawing.Point(84, 306);
            this.btnShowCustomerInformation.Name = "btnShowCustomerInformation";
            this.btnShowCustomerInformation.Size = new System.Drawing.Size(155, 36);
            this.btnShowCustomerInformation.TabIndex = 3;
            this.btnShowCustomerInformation.Text = "Show Customer info";
            this.btnShowCustomerInformation.UseVisualStyleBackColor = true;
            this.btnShowCustomerInformation.Click += new System.EventHandler(this.btnShowCustomerInformation_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(570, 306);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(164, 36);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnBookARoom
            // 
            this.btnBookARoom.Location = new System.Drawing.Point(407, 306);
            this.btnBookARoom.Name = "btnBookARoom";
            this.btnBookARoom.Size = new System.Drawing.Size(146, 36);
            this.btnBookARoom.TabIndex = 5;
            this.btnBookARoom.Text = "Book a room";
            this.btnBookARoom.UseVisualStyleBackColor = true;
            this.btnBookARoom.Click += new System.EventHandler(this.btnBookARoom_Click);
            // 
            // btnHandleReservations
            // 
            this.btnHandleReservations.Location = new System.Drawing.Point(84, 360);
            this.btnHandleReservations.Name = "btnHandleReservations";
            this.btnHandleReservations.Size = new System.Drawing.Size(155, 37);
            this.btnHandleReservations.TabIndex = 7;
            this.btnHandleReservations.Text = "Handle Reservations";
            this.btnHandleReservations.UseVisualStyleBackColor = true;
            this.btnHandleReservations.Click += new System.EventHandler(this.btnHandleReservations_Click_1);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(256, 306);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(134, 36);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Customer Payed";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(570, 359);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(164, 40);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(256, 360);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(134, 39);
            this.btnUpdateCustomer.TabIndex = 10;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnHandleReservations);
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
        private System.Windows.Forms.Button btnHandleReservations;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
    }
}

