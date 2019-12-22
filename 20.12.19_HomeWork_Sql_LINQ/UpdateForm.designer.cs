namespace _20._12._19_HomeWork_Sql_LINQ
{
    partial class UpdateForm
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
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btmDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(15, 198);
            this.numAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(86, 20);
            this.numAge.TabIndex = 20;
            this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(15, 121);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 19;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 18;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 222);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.lblPhoneNumber.TabIndex = 17;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 182);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Age:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 107);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update the customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(15, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 24;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(15, 158);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 26;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(12, 144);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 25;
            this.lblStreet.Text = "Street:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(15, 239);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 27;
            // 
            // btmDelete
            // 
            this.btmDelete.Location = new System.Drawing.Point(15, 295);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(112, 23);
            this.btmDelete.TabIndex = 28;
            this.btmDelete.Text = "Delete the customer";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 337);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnUpdate);
            this.Name = "UpdateForm";
            this.Text = "UpdateEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btmDelete;
    }
}