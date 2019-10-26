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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearchAvaibleRooms = new System.Windows.Forms.Button();
            this.cBoxNumberOfPeople = new System.Windows.Forms.ComboBox();
            this.cBoxNumberOfNights = new System.Windows.Forms.ComboBox();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnSearchAvaibleRooms
            // 
            this.btnSearchAvaibleRooms.Location = new System.Drawing.Point(389, 83);
            this.btnSearchAvaibleRooms.Name = "btnSearchAvaibleRooms";
            this.btnSearchAvaibleRooms.Size = new System.Drawing.Size(198, 23);
            this.btnSearchAvaibleRooms.TabIndex = 1;
            this.btnSearchAvaibleRooms.Text = "Search For Avaible Rooms";
            this.btnSearchAvaibleRooms.UseVisualStyleBackColor = true;
            // 
            // cBoxNumberOfPeople
            // 
            this.cBoxNumberOfPeople.FormattingEnabled = true;
            this.cBoxNumberOfPeople.Location = new System.Drawing.Point(175, 27);
            this.cBoxNumberOfPeople.Name = "cBoxNumberOfPeople";
            this.cBoxNumberOfPeople.Size = new System.Drawing.Size(121, 24);
            this.cBoxNumberOfPeople.TabIndex = 2;
            // 
            // cBoxNumberOfNights
            // 
            this.cBoxNumberOfNights.FormattingEnabled = true;
            this.cBoxNumberOfNights.Location = new System.Drawing.Point(466, 27);
            this.cBoxNumberOfNights.Name = "cBoxNumberOfNights";
            this.cBoxNumberOfNights.Size = new System.Drawing.Size(121, 24);
            this.cBoxNumberOfNights.TabIndex = 3;
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Location = new System.Drawing.Point(12, 32);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(125, 17);
            this.labelNumberOfPeople.TabIndex = 4;
            this.labelNumberOfPeople.Text = "How many People:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Nights:";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(82, 87);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(42, 17);
            this.LabelDate.TabIndex = 6;
            this.LabelDate.Text = "Date:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(130, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 228);
            this.listBox1.TabIndex = 7;
            // 
            // BookARoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumberOfPeople);
            this.Controls.Add(this.cBoxNumberOfNights);
            this.Controls.Add(this.cBoxNumberOfPeople);
            this.Controls.Add(this.btnSearchAvaibleRooms);
            this.Controls.Add(this.textBox1);
            this.Name = "BookARoomForm";
            this.Text = "BookARoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearchAvaibleRooms;
        private System.Windows.Forms.ComboBox cBoxNumberOfPeople;
        private System.Windows.Forms.ComboBox cBoxNumberOfNights;
        private System.Windows.Forms.Label labelNumberOfPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.ListBox listBox1;
    }
}