namespace _20._12._19_HomeWork_Sql_LINQ
{
    partial class MainForm
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblPhNumber = new System.Windows.Forms.Label();
            this.cmbAllCustomers = new System.Windows.Forms.ComboBox();
            this.cmbWhat = new System.Windows.Forms.ComboBox();
            this.btnGetAllTheCustomers = new System.Windows.Forms.Button();
            this.cmbGetByWhat = new System.Windows.Forms.ComboBox();
            this.pnlAllCustomers = new _20._12._19_HomeWork_Sql_LINQ.ScrollablePanel();
            this.lblAllCustomers = new System.Windows.Forms.Label();
            this.pnlPhoneNumberCreator = new _20._12._19_HomeWork_Sql_LINQ.pnlPhoneNumberCreatorPanel();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnRemoveAllCustomers = new System.Windows.Forms.Button();
            this.btnSelectBetweenAges = new System.Windows.Forms.Button();
            this.numAgeMin = new System.Windows.Forms.NumericUpDown();
            this.numAgeMax = new System.Windows.Forms.NumericUpDown();
            this.lblAnd = new System.Windows.Forms.Label();
            this.chkLINQ_function = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.pnlAllCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeMax)).BeginInit();
            this.SuspendLayout();
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(12, 184);
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
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 145);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 18;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 168);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "Age:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 131);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 89);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 359);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(115, 23);
            this.btnAddCustomer.TabIndex = 13;
            this.btnAddCustomer.Text = "Add customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(12, 223);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 22;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(13, 209);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 23;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(13, 252);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 24;
            this.lblStreet.Text = "Street:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(12, 266);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 25;
            // 
            // lblPhNumber
            // 
            this.lblPhNumber.AutoSize = true;
            this.lblPhNumber.Location = new System.Drawing.Point(12, 296);
            this.lblPhNumber.Name = "lblPhNumber";
            this.lblPhNumber.Size = new System.Drawing.Size(79, 13);
            this.lblPhNumber.TabIndex = 17;
            this.lblPhNumber.Text = "Phone number:";
            // 
            // cmbAllCustomers
            // 
            this.cmbAllCustomers.FormattingEnabled = true;
            this.cmbAllCustomers.Location = new System.Drawing.Point(579, 13);
            this.cmbAllCustomers.Name = "cmbAllCustomers";
            this.cmbAllCustomers.Size = new System.Drawing.Size(209, 21);
            this.cmbAllCustomers.TabIndex = 29;
            this.cmbAllCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbAllCustomers_SelectedIndexChanged);
            // 
            // cmbWhat
            // 
            this.cmbWhat.FormattingEnabled = true;
            this.cmbWhat.Location = new System.Drawing.Point(452, 67);
            this.cmbWhat.Name = "cmbWhat";
            this.cmbWhat.Size = new System.Drawing.Size(121, 21);
            this.cmbWhat.TabIndex = 32;
            this.cmbWhat.SelectedIndexChanged += new System.EventHandler(this.cmbWhat_SelectedIndexChanged);
            // 
            // btnGetAllTheCustomers
            // 
            this.btnGetAllTheCustomers.Location = new System.Drawing.Point(452, 13);
            this.btnGetAllTheCustomers.Name = "btnGetAllTheCustomers";
            this.btnGetAllTheCustomers.Size = new System.Drawing.Size(119, 23);
            this.btnGetAllTheCustomers.TabIndex = 33;
            this.btnGetAllTheCustomers.Text = "Get All the customers";
            this.btnGetAllTheCustomers.UseVisualStyleBackColor = true;
            this.btnGetAllTheCustomers.Click += new System.EventHandler(this.btnGetAllTheCustomers_Click);
            // 
            // cmbGetByWhat
            // 
            this.cmbGetByWhat.FormattingEnabled = true;
            this.cmbGetByWhat.Location = new System.Drawing.Point(346, 67);
            this.cmbGetByWhat.Name = "cmbGetByWhat";
            this.cmbGetByWhat.Size = new System.Drawing.Size(100, 21);
            this.cmbGetByWhat.TabIndex = 34;
            this.cmbGetByWhat.SelectedIndexChanged += new System.EventHandler(this.cmbGetByWhat_SelectedIndexChanged);
            // 
            // pnlAllCustomers
            // 
            this.pnlAllCustomers.AutoScroll = true;
            this.pnlAllCustomers.AutoScrollHorizontalMaximum = 100;
            this.pnlAllCustomers.AutoScrollHorizontalMinimum = 0;
            this.pnlAllCustomers.AutoScrollHPos = 0;
            this.pnlAllCustomers.AutoScrollVerticalMaximum = 100;
            this.pnlAllCustomers.AutoScrollVerticalMinimum = 0;
            this.pnlAllCustomers.AutoScrollVPos = 0;
            this.pnlAllCustomers.Controls.Add(this.lblAllCustomers);
            this.pnlAllCustomers.EnableAutoScrollHorizontal = true;
            this.pnlAllCustomers.EnableAutoScrollVertical = true;
            this.pnlAllCustomers.Location = new System.Drawing.Point(579, 67);
            this.pnlAllCustomers.Name = "pnlAllCustomers";
            this.pnlAllCustomers.Size = new System.Drawing.Size(209, 412);
            this.pnlAllCustomers.TabIndex = 31;
            this.pnlAllCustomers.VisibleAutoScrollHorizontal = true;
            this.pnlAllCustomers.VisibleAutoScrollVertical = true;
            // 
            // lblAllCustomers
            // 
            this.lblAllCustomers.AutoSize = true;
            this.lblAllCustomers.Location = new System.Drawing.Point(4, 4);
            this.lblAllCustomers.Name = "lblAllCustomers";
            this.lblAllCustomers.Size = new System.Drawing.Size(35, 13);
            this.lblAllCustomers.TabIndex = 0;
            this.lblAllCustomers.Text = "label1";
            // 
            // pnlPhoneNumberCreator
            // 
            this.pnlPhoneNumberCreator.Location = new System.Drawing.Point(12, 312);
            this.pnlPhoneNumberCreator.Name = "pnlPhoneNumberCreator";
            this.pnlPhoneNumberCreator.NumberOfCombos = 8;
            this.pnlPhoneNumberCreator.RandomInitialValue = true;
            this.pnlPhoneNumberCreator.Size = new System.Drawing.Size(247, 21);
            this.pnlPhoneNumberCreator.SplitToSections = true;
            this.pnlPhoneNumberCreator.TabIndex = 28;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(579, 41);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteCustomer.TabIndex = 35;
            this.btnDeleteCustomer.Text = "Delete the customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnRemoveAllCustomers
            // 
            this.btnRemoveAllCustomers.Location = new System.Drawing.Point(6, 456);
            this.btnRemoveAllCustomers.Name = "btnRemoveAllCustomers";
            this.btnRemoveAllCustomers.Size = new System.Drawing.Size(121, 23);
            this.btnRemoveAllCustomers.TabIndex = 36;
            this.btnRemoveAllCustomers.Text = "Remove all customers";
            this.btnRemoveAllCustomers.UseVisualStyleBackColor = true;
            this.btnRemoveAllCustomers.Click += new System.EventHandler(this.btnRemoveAllCustomers_Click);
            // 
            // btnSelectBetweenAges
            // 
            this.btnSelectBetweenAges.Location = new System.Drawing.Point(346, 121);
            this.btnSelectBetweenAges.Name = "btnSelectBetweenAges";
            this.btnSelectBetweenAges.Size = new System.Drawing.Size(115, 23);
            this.btnSelectBetweenAges.TabIndex = 37;
            this.btnSelectBetweenAges.Text = "Select between ages";
            this.btnSelectBetweenAges.UseVisualStyleBackColor = true;
            this.btnSelectBetweenAges.Click += new System.EventHandler(this.btnSelectBetweenAges_Click);
            // 
            // numAgeMin
            // 
            this.numAgeMin.Location = new System.Drawing.Point(467, 122);
            this.numAgeMin.Name = "numAgeMin";
            this.numAgeMin.Size = new System.Drawing.Size(40, 20);
            this.numAgeMin.TabIndex = 38;
            // 
            // numAgeMax
            // 
            this.numAgeMax.Location = new System.Drawing.Point(531, 122);
            this.numAgeMax.Name = "numAgeMax";
            this.numAgeMax.Size = new System.Drawing.Size(42, 20);
            this.numAgeMax.TabIndex = 39;
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(513, 124);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(12, 13);
            this.lblAnd.TabIndex = 40;
            this.lblAnd.Text = "\\&";
            // 
            // chkLINQ_function
            // 
            this.chkLINQ_function.AutoSize = true;
            this.chkLINQ_function.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLINQ_function.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLINQ_function.Location = new System.Drawing.Point(459, 184);
            this.chkLINQ_function.Name = "chkLINQ_function";
            this.chkLINQ_function.Size = new System.Drawing.Size(114, 17);
            this.chkLINQ_function.TabIndex = 41;
            this.chkLINQ_function.Text = "with LINQ function";
            this.chkLINQ_function.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLINQ_function.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.chkLINQ_function);
            this.Controls.Add(this.lblAnd);
            this.Controls.Add(this.numAgeMax);
            this.Controls.Add(this.numAgeMin);
            this.Controls.Add(this.btnSelectBetweenAges);
            this.Controls.Add(this.btnRemoveAllCustomers);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.cmbGetByWhat);
            this.Controls.Add(this.btnGetAllTheCustomers);
            this.Controls.Add(this.cmbWhat);
            this.Controls.Add(this.pnlAllCustomers);
            this.Controls.Add(this.cmbAllCustomers);
            this.Controls.Add(this.pnlPhoneNumberCreator);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhNumber);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.pnlAllCustomers.ResumeLayout(false);
            this.pnlAllCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblPhNumber;
        private pnlPhoneNumberCreatorPanel pnlPhoneNumberCreator;
        private System.Windows.Forms.ComboBox cmbAllCustomers;
        private ScrollablePanel pnlAllCustomers;
        private System.Windows.Forms.Label lblAllCustomers;
        private System.Windows.Forms.ComboBox cmbWhat;
        private System.Windows.Forms.Button btnGetAllTheCustomers;
        private System.Windows.Forms.ComboBox cmbGetByWhat;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnRemoveAllCustomers;
        private System.Windows.Forms.Button btnSelectBetweenAges;
        private System.Windows.Forms.NumericUpDown numAgeMin;
        private System.Windows.Forms.NumericUpDown numAgeMax;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.CheckBox chkLINQ_function;
    }
}

