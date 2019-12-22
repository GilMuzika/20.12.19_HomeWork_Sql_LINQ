using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._12._19_HomeWork_Sql_LINQ
{
    public partial class MainForm : Form
    {
        private CustomerDAO _currentCustomerDAO = new CustomerDAO();
        private List<Customer> allCustomers = new List<Customer>();
        private UpdateForm _currentUpdateForm;
        private Random _rnd = new Random();
        private string[] namesToUsing;
        private string[] citiesToUsing;
        private ToolTip toolTip1 = new ToolTip();


        public MainForm()
        {
            InitializeComponent();
            GetAllCustomers();
            ReadFromFile();
            InitializeCriteria();
            InitializeCustomerDefaults();
            _currentCustomerDAO.CreateTableIfDontExists();
        }
        private void InitializeCriteria()
        {            
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(cmbWhat, "Please select the criterion from the ajacent ComboBox leftward.");


            //cmbCities.Items.AddRange(allCustomers.Select(x => x.ADDRESS_CITY).ToArray());
            cmbWhat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGetByWhat.Items.AddRange(typeof(Customer).GetProperties().Select(x => x.Name).ToArray());

            lblAnd.Text = @"&";
            numAgeMax.Maximum = numAgeMin.Maximum = numAge.Maximum;
            numAgeMax.Minimum = numAgeMin.Minimum = numAge.Minimum;
            numAgeMax.Value = numAgeMax.Maximum;

            //cmbAllCustomers.SelectedIndex = 0;
            cmbAllCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            btnRemoveAllCustomers.BackColor = Color.Red;
            btnRemoveAllCustomers.ForeColor = Color.White;
            btnRemoveAllCustomers.drawBorder(1, Color.DarkBlue);
        }

        private void GetAllCustomers()
        {
            
            allCustomers = _currentCustomerDAO.GetAllCustomersAndGetCustomersBy(new string[] {  }, "");
            DisplayAllTheCustomers();

        }
        private void DisplayAllTheCustomers()
        {
            lblAllCustomers.Text = string.Empty;
            cmbAllCustomers.Items.Clear();
            cmbAllCustomers.Items.AddRange(allCustomers.Select(x => new ComboItem<Customer>(x)).ToArray());
            lblAllCustomers.Text = string.Empty;
            allCustomers.ForEach(x => lblAllCustomers.Text += x + Environment.NewLine);
        }
        private void ReadFromFile()
        {
            string names = string.Empty;
            string cities = string.Empty;
            try
            {
                names = File.ReadAllText("_names.txt");
                cities = File.ReadAllText("_cities.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \n\nSo the program will use the defult names");
                names = " Alfred Benny Connnor Daniel Eran ";
                cities = " New-York Los-Angeles San-Francisco Chicago ";
            }
            namesToUsing = names.Split(new char[] { ' ', '\t', '\n' }).Where(x => !String.IsNullOrEmpty(x)).ToArray();
            citiesToUsing = cities.Split('\n').Where(x => !String.IsNullOrEmpty(x)).Select(x => x.Substring(0, x.IndexOf(","))).ToArray();
        }
        private void InitializeCustomerDefaults()
        {
            txtFirstName.Text = namesToUsing[_rnd.Next(0, namesToUsing.Length - 1)];
            txtLastName.Text = txtFirstName.Text + "son";
            numAge.Value = _rnd.Next((int)numAge.Minimum, (int)numAge.Maximum);
            txtCity.Text = citiesToUsing[_rnd.Next(0, citiesToUsing.Length - 1)];
            txtStreet.Text = $"{Statics.GetUniqueKeyOriginal_BIASED(8)} st.";            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _currentCustomerDAO.AddCustomer(new Customer(txtFirstName.Text, txtLastName.Text, (int)numAge.Value, txtCity.Text, txtStreet.Text, pnlPhoneNumberCreator.Number));

            InitializeCustomerDefaults();
            pnlPhoneNumberCreator.RandomNumber();
            try
            {
                Customer theLastCustomer = _currentCustomerDAO.GetAllCustomersAndGetCustomersBy(new string[] {  }, "").Last();
                cmbAllCustomers.Items.Add(new ComboItem<Customer>(theLastCustomer));
                lblAllCustomers.Text += theLastCustomer;
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }

        }

        private void cmbWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chkLINQ_function.Checked) allCustomers = _currentCustomerDAO.GetAllCustomersAndGetCustomersBy_LINQ(new string[] { (sender as ComboBox).SelectedItem.ToString() }, cmbGetByWhat.SelectedItem as string);
            else allCustomers = _currentCustomerDAO.GetAllCustomersAndGetCustomersBy(new string[] { (sender as ComboBox).SelectedItem.ToString() }, cmbGetByWhat.SelectedItem as string);            
            DisplayAllTheCustomers();
        }

        private void btnGetAllTheCustomers_Click(object sender, EventArgs e)
        {
            allCustomers = _currentCustomerDAO.GetAllCustomersAndGetCustomersBy(new string[] {  }, "");
            DisplayAllTheCustomers();
        }

        private void cmbGetByWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cmbWhat, $"Get the customer by {(sender as ComboBox).SelectedItem.ToString()}");
            cmbWhat.Items.Clear();
            allCustomers = _currentCustomerDAO.GetAllCustomersAndGetCustomersBy(new string[] { }, "");
            cmbWhat.Items.AddRange(allCustomers.Select(x =>   x.GetType().GetProperty((sender as ComboBox).SelectedItem as string).GetValue(x)    ).ToArray());
        }

        private void cmbAllCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentUpdateForm = new UpdateForm(((sender as ComboBox).SelectedItem as ComboItem<Customer>).Value);
            _currentUpdateForm.AutoSize = true;
            _currentUpdateForm.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width - 20, Screen.PrimaryScreen.WorkingArea.Height - 20);
            _currentUpdateForm.BackgroundImageChanged += (object sender2, EventArgs e2) => { GetAllCustomers(); };
            _currentUpdateForm.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(cmbAllCustomers.SelectedIndex == -1) 
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show("Plsease select a name from the combo box");
            }
            else _currentCustomerDAO.UpdateOrDEleteCustomer((cmbAllCustomers.SelectedItem as ComboItem<Customer>).Value as Customer, Modify.Delete);

            GetAllCustomers();
        }

        private void btnRemoveAllCustomers_Click(object sender, EventArgs e)
        {
            _currentCustomerDAO.RemoveAllCustomers();
            GetAllCustomers();

        }

        private void btnSelectBetweenAges_Click(object sender, EventArgs e)
        {
            if(chkLINQ_function.Checked) allCustomers = _currentCustomerDAO.GrtCustomersBetweenAges_LINQ((int)numAgeMin.Value, (int)numAgeMax.Value);
            else allCustomers = _currentCustomerDAO.GrtCustomersBetweenAges((int)numAgeMin.Value, (int)numAgeMax.Value);
            DisplayAllTheCustomers();
        }
    }
}
