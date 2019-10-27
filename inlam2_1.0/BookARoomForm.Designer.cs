namespace inlam2_1._0
{
    partial class BookARoomForm
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
            this.btnSearchAvaibleRooms = new System.Windows.Forms.Button();
            this.cBoxNumberOfPeople = new System.Windows.Forms.ComboBox();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            this.LabelCheckInDate = new System.Windows.Forms.Label();
            this.lstAvaibleRooms = new System.Windows.Forms.ListBox();
            this.CheckInStartDate = new System.Windows.Forms.DateTimePicker();
            this.checkOutEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.btnBookTheRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchAvaibleRooms
            // 
            this.btnSearchAvaibleRooms.Location = new System.Drawing.Point(299, 120);
            this.btnSearchAvaibleRooms.Name = "btnSearchAvaibleRooms";
            this.btnSearchAvaibleRooms.Size = new System.Drawing.Size(198, 23);
            this.btnSearchAvaibleRooms.TabIndex = 1;
            this.btnSearchAvaibleRooms.Text = "Search For Avaible Rooms";
            this.btnSearchAvaibleRooms.UseVisualStyleBackColor = true;
            this.btnSearchAvaibleRooms.Click += new System.EventHandler(this.btnSearchAvaibleRooms_Click);
            // 
            // cBoxNumberOfPeople
            // 
            this.cBoxNumberOfPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxNumberOfPeople.FormattingEnabled = true;
            this.cBoxNumberOfPeople.Location = new System.Drawing.Point(143, 116);
            this.cBoxNumberOfPeople.Name = "cBoxNumberOfPeople";
            this.cBoxNumberOfPeople.Size = new System.Drawing.Size(121, 24);
            this.cBoxNumberOfPeople.TabIndex = 2;
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Location = new System.Drawing.Point(9, 123);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(125, 17);
            this.labelNumberOfPeople.TabIndex = 4;
            this.labelNumberOfPeople.Text = "How many People:";
            // 
            // LabelCheckInDate
            // 
            this.LabelCheckInDate.AutoSize = true;
            this.LabelCheckInDate.Location = new System.Drawing.Point(9, 9);
            this.LabelCheckInDate.Name = "LabelCheckInDate";
            this.LabelCheckInDate.Size = new System.Drawing.Size(96, 17);
            this.LabelCheckInDate.TabIndex = 6;
            this.LabelCheckInDate.Text = "Checkin Date:";
            // 
            // lstAvaibleRooms
            // 
            this.lstAvaibleRooms.FormattingEnabled = true;
            this.lstAvaibleRooms.ItemHeight = 16;
            this.lstAvaibleRooms.Location = new System.Drawing.Point(12, 161);
            this.lstAvaibleRooms.Name = "lstAvaibleRooms";
            this.lstAvaibleRooms.Size = new System.Drawing.Size(485, 180);
            this.lstAvaibleRooms.TabIndex = 7;
            // 
            // CheckInStartDate
            // 
            this.CheckInStartDate.CustomFormat = "yyyy-MM-dd";
            this.CheckInStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckInStartDate.Location = new System.Drawing.Point(123, 4);
            this.CheckInStartDate.Name = "CheckInStartDate";
            this.CheckInStartDate.Size = new System.Drawing.Size(111, 22);
            this.CheckInStartDate.TabIndex = 8;
            // 
            // checkOutEndDate
            // 
            this.checkOutEndDate.CustomFormat = "yyyy-MM-dd";
            this.checkOutEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkOutEndDate.Location = new System.Drawing.Point(123, 60);
            this.checkOutEndDate.Name = "checkOutEndDate";
            this.checkOutEndDate.Size = new System.Drawing.Size(111, 22);
            this.checkOutEndDate.TabIndex = 9;
            // 
            // labelCheckOutDate
            // 
            this.labelCheckOutDate.AutoSize = true;
            this.labelCheckOutDate.Location = new System.Drawing.Point(9, 60);
            this.labelCheckOutDate.Name = "labelCheckOutDate";
            this.labelCheckOutDate.Size = new System.Drawing.Size(105, 17);
            this.labelCheckOutDate.TabIndex = 10;
            this.labelCheckOutDate.Text = "Checkout Date:";
            // 
            // btnBookTheRoom
            // 
            this.btnBookTheRoom.Location = new System.Drawing.Point(12, 369);
            this.btnBookTheRoom.Name = "btnBookTheRoom";
            this.btnBookTheRoom.Size = new System.Drawing.Size(163, 30);
            this.btnBookTheRoom.TabIndex = 11;
            this.btnBookTheRoom.Text = "Book selected room";
            this.btnBookTheRoom.UseVisualStyleBackColor = true;
            this.btnBookTheRoom.Click += new System.EventHandler(this.btnBookTheRoom_Click);
            // 
            // BookARoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.btnBookTheRoom);
            this.Controls.Add(this.labelCheckOutDate);
            this.Controls.Add(this.checkOutEndDate);
            this.Controls.Add(this.CheckInStartDate);
            this.Controls.Add(this.lstAvaibleRooms);
            this.Controls.Add(this.LabelCheckInDate);
            this.Controls.Add(this.labelNumberOfPeople);
            this.Controls.Add(this.cBoxNumberOfPeople);
            this.Controls.Add(this.btnSearchAvaibleRooms);
            this.Name = "BookARoomForm";
            this.Text = "BookARoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchAvaibleRooms;
        private System.Windows.Forms.ComboBox cBoxNumberOfPeople;
        private System.Windows.Forms.Label labelNumberOfPeople;
        private System.Windows.Forms.Label LabelCheckInDate;
        private System.Windows.Forms.ListBox lstAvaibleRooms;
        private System.Windows.Forms.DateTimePicker CheckInStartDate;
        private System.Windows.Forms.DateTimePicker checkOutEndDate;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.Button btnBookTheRoom;
    }
}