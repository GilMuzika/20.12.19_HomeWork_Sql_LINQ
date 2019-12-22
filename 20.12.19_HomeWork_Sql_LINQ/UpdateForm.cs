using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._12._19_HomeWork_Sql_LINQ
{    
    internal partial class UpdateForm : Form
    {
        private Customer _customer;
        public Customer Customer { get => _customer; set => _customer = value; }

        public UpdateForm(Customer cust)
        {

            _customer = cust;
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
            this.FormClosed += (object semder, FormClosedEventArgs e) => { this.Dispose(); };

            initializeEmployee();

        }
        private void initializeEmployee()
        {
            this.lblID.Text = "ID: " + _customer.ID; 
            
            this.txtFirstName.Text = (string)_customer.FIRST_NAME;
            this.txtLastName.Text = (string)_customer.LAST_NAME;
            this.txtCity.Text = (string)_customer.ADDRESS_CITY;
            this.txtStreet.Text = (string)_customer.ADDRESS_STREET_;            
            this.numAge.Value = Convert.ToDecimal(_customer.AGE);
            this.txtPhoneNumber.Text = (string)_customer.PH_NUMBER;
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                
                new CustomerDAO().UpdateOrDEleteCustomer(new Customer((int)_customer.ID, this.txtFirstName.Text, this.txtLastName.Text, (int)this.numAge.Value, this.txtCity.Text, this.txtStreet.Text, this.txtPhoneNumber.Text), Modify.Update);
                System.Windows.Forms.Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (object sender2, EventArgs e2) => { this.BackgroundImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height); (sender2 as Timer).Stop(); (sender2 as Timer).Dispose(); this.Close(); };
                timer.Start();

                
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            /*
            InitializeEmployeeDefaults();
            InitializeCombo();
            GetListOfEmployees();
            */
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            new CustomerDAO().UpdateOrDEleteCustomer(new Customer((int)_customer.ID, this.txtFirstName.Text, this.txtLastName.Text, (int)this.numAge.Value, this.txtCity.Text, this.txtStreet.Text, this.txtPhoneNumber.Text), Modify.Delete);
            this.BackgroundImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            this.Close();
        }
    }
}
