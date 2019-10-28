namespace inlam2_1._0
{
    partial class HandleCustomerForm
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
            this.btnChangeReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.tBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.tBoxRoomDescription = new System.Windows.Forms.TextBox();
            this.tBoxDates = new System.Windows.Forms.TextBox();
            this.tBoxAmountToPay = new System.Windows.Forms.TextBox();
            this.tBoxHaveCustomerPayed = new System.Windows.Forms.TextBox();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.labelRoomDescription = new System.Windows.Forms.Label();
            this.labelstartDateendDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeReservation
            // 
            this.btnChangeReservation.Location = new System.Drawing.Point(224, 291);
            this.btnChangeReservation.Name = "btnChangeReservation";
            this.btnChangeReservation.Size = new System.Drawing.Size(155, 53);
            this.btnChangeReservation.TabIndex = 0;
            this.btnChangeReservation.Text = "Change Reservation";
            this.btnChangeReservation.UseVisualStyleBackColor = true;
            this.btnChangeReservation.Click += new System.EventHandler(this.btnChangeReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(420, 291);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(151, 53);
            this.btnDeleteReservation.TabIndex = 1;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // tBoxRoomNumber
            // 
            this.tBoxRoomNumber.Location = new System.Drawing.Point(224, 29);
            this.tBoxRoomNumber.Name = "tBoxRoomNumber";
            this.tBoxRoomNumber.Size = new System.Drawing.Size(347, 22);
            this.tBoxRoomNumber.TabIndex = 2;
            // 
            // tBoxRoomDescription
            // 
            this.tBoxRoomDescription.Location = new System.Drawing.Point(224, 76);
            this.tBoxRoomDescription.Name = "tBoxRoomDescription";
            this.tBoxRoomDescription.Size = new System.Drawing.Size(347, 22);
            this.tBoxRoomDescription.TabIndex = 3;
            // 
            // tBoxDates
            // 
            this.tBoxDates.Location = new System.Drawing.Point(224, 127);
            this.tBoxDates.Name = "tBoxDates";
            this.tBoxDates.Size = new System.Drawing.Size(347, 22);
            this.tBoxDates.TabIndex = 4;
            // 
            // tBoxAmountToPay
            // 
            this.tBoxAmountToPay.Location = new System.Drawing.Point(224, 182);
            this.tBoxAmountToPay.Name = "tBoxAmountToPay";
            this.tBoxAmountToPay.Size = new System.Drawing.Size(347, 22);
            this.tBoxAmountToPay.TabIndex = 5;
            // 
            // tBoxHaveCustomerPayed
            // 
            this.tBoxHaveCustomerPayed.Location = new System.Drawing.Point(224, 230);
            this.tBoxHaveCustomerPayed.Name = "tBoxHaveCustomerPayed";
            this.tBoxHaveCustomerPayed.Size = new System.Drawing.Size(347, 22);
            this.tBoxHaveCustomerPayed.TabIndex = 6;
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Location = new System.Drawing.Point(95, 29);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(103, 17);
            this.labelRoomID.TabIndex = 7;
            this.labelRoomID.Text = "Room Number:";
            // 
            // labelRoomDescription
            // 
            this.labelRoomDescription.AutoSize = true;
            this.labelRoomDescription.Location = new System.Drawing.Point(74, 76);
            this.labelRoomDescription.Name = "labelRoomDescription";
            this.labelRoomDescription.Size = new System.Drawing.Size(124, 17);
            this.labelRoomDescription.TabIndex = 8;
            this.labelRoomDescription.Text = "Room Description:";
            // 
            // labelstartDateendDate
            // 
            this.labelstartDateendDate.AutoSize = true;
            this.labelstartDateendDate.Location = new System.Drawing.Point(149, 130);
            this.labelstartDateendDate.Name = "labelstartDateendDate";
            this.labelstartDateendDate.Size = new System.Drawing.Size(49, 17);
            this.labelstartDateendDate.TabIndex = 9;
            this.labelstartDateendDate.Text = "Dates:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount to pay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Have customer payed:";
            // 
            // HandleCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 368);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelstartDateendDate);
            this.Controls.Add(this.labelRoomDescription);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.tBoxHaveCustomerPayed);
            this.Controls.Add(this.tBoxAmountToPay);
            this.Controls.Add(this.tBoxDates);
            this.Controls.Add(this.tBoxRoomDescription);
            this.Controls.Add(this.tBoxRoomNumber);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnChangeReservation);
            this.Name = "HandleCustomerForm";
            this.Text = "HandleCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.TextBox tBoxRoomNumber;
        private System.Windows.Forms.TextBox tBoxRoomDescription;
        private System.Windows.Forms.TextBox tBoxDates;
        private System.Windows.Forms.TextBox tBoxAmountToPay;
        private System.Windows.Forms.TextBox tBoxHaveCustomerPayed;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.Label labelRoomDescription;
        private System.Windows.Forms.Label labelstartDateendDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}