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
            this.SuspendLayout();
            // 
            // btnChangeReservation
            // 
            this.btnChangeReservation.Location = new System.Drawing.Point(43, 94);
            this.btnChangeReservation.Name = "btnChangeReservation";
            this.btnChangeReservation.Size = new System.Drawing.Size(155, 53);
            this.btnChangeReservation.TabIndex = 0;
            this.btnChangeReservation.Text = "Change Reservation";
            this.btnChangeReservation.UseVisualStyleBackColor = true;
            this.btnChangeReservation.Click += new System.EventHandler(this.btnChangeReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(258, 94);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(151, 53);
            this.btnDeleteReservation.TabIndex = 1;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // HandleCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 266);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnChangeReservation);
            this.Name = "HandleCustomerForm";
            this.Text = "HandleCustomerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
    }
}