using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._12._19_HomeWork_Sql_LINQ
{
    public enum Modify
    {
        Get = 0,
        Update = 1,
        Delete = 2,        
    }
    
    class CustomerDAO : ICustomerDAO
    {
        private SQLiteConnection _connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["companyDb_local"].ConnectionString.Replace(@"=\", $"={Directory.GetCurrentDirectory()}\\"));
        private SQLiteCommand _command = new SQLiteCommand();
        //private SQLiteConnection _connection = new SQLiteConnection($"Data source ={Directory.GetCurrentDirectory()}\\_database\\_20._12._19_HomeWork_Sql_LINQ_Company.db; Version = 3;");

        private SQLiteConnection NewConnection()
        {
            SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["companyDb_local"].ConnectionString.Replace(@"=\", $"={Directory.GetCurrentDirectory()}\\"));
            con.Open();
            return con;
        }

        public CustomerDAO()
        {
            _command.CommandType = System.Data.CommandType.Text;
            _command.Connection = _connection;
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                _connection.Open();
                        _command.CommandText = $"INSERT INTO Customers(FIRST_NAME, LAST_NAME, AGE, ADDRESS_CITY, ADDRESS_STREET_, PH_NUMBER) VALUES('{customer.FIRST_NAME}', '{customer.LAST_NAME}', {customer.AGE}, '{customer.ADDRESS_CITY}', '{customer.ADDRESS_STREET_}', '{customer.PH_NUMBER}')";
                        _command.ExecuteNonQuery();
                _connection.Close();

            }
            catch(Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }

        public void DeleteCustomer(int id)
        {
            //throw new NotImplementedException();
        }


        public List<Customer> GetAllCustomersAndGetCustomersBy(string[] rowModifiers, string rowIdentifier)
        {
            List<Customer> list = new List<Customer>();
            try
            {
                int iterationsNumber;
                if (rowModifiers.Length == 0) iterationsNumber = 1;
                else iterationsNumber = rowModifiers.Length;

                _connection.Open();
                for (int j = 0; j < iterationsNumber; j++)
                {
                    if (rowModifiers.Length == 0) _command.CommandText = $"SELECT * FROM Customers";
                    else
                    {
                        bool isModifierString = Int32.TryParse(rowModifiers[j], out int modifierNumber);
                        if (!isModifierString) rowModifiers[j] = $"'{rowModifiers[j]}'";

                        _command.CommandText = $"SELECT * FROM Customers WHERE {rowIdentifier} = {rowModifiers[j]}";
                    }
                    /*
                    using (SQLiteDataReader reader = _command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer c = new Customer();
                            var propCollection = typeof(Customer).GetProperties();
                            int i;
                            for (i = 0; i < propCollection.Length; i++)
                            {
                                propCollection[i].SetValue(c, reader[propCollection[i].Name]);
                            }                            
                            list.Add(c);
                        }
                    }
                    */


                    list = readDBAndCreateList<Customer>();
                }

                
                _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }


            return list;
        }

        private List<T> readDBAndCreateList<T>() where T : new()
        {
            List<T> list = new List<T>();
            using (SQLiteDataReader reader = _command.ExecuteReader())
            {
                while (reader.Read())
                {
                    T c = new T();
                    var propCollection = typeof(T).GetProperties();
                    int i;
                    for (i = 0; i < propCollection.Length; i++)
                    {
                        propCollection[i].SetValue(c, reader[propCollection[i].Name]);
                    }
                    list.Add(c);
                }
            }
            return list;
        }
        public List<Customer> GetAllCustomersAndGetCustomersBy_LINQ(string[] rowModifiers, string rowIdentifier)
        {
            List<Customer> list = new List<Customer>();
            try
            {
                _connection.Open();
                _command.CommandText = "SELECT * FROM Customers";
                if (rowModifiers.Length != 0)
                {
                    for (int i = 0; i < rowModifiers.Length; i++)
                    {
                        IEnumerable<Customer> result = null;
                        if (Int32.TryParse(rowModifiers[i], out int rowModifierNUmber))  result = from s in readDBAndCreateList<Customer>() where (int)s.GetType().GetProperty(rowIdentifier).GetValue(s) == rowModifierNUmber select s;
                        else result = from s in readDBAndCreateList<Customer>() where (string)s.GetType().GetProperty(rowIdentifier).GetValue(s) == rowModifiers[i] select s;
                        list.AddRange(result.ToArray());
                    }
                }
                else
                {
                    var result = from s in readDBAndCreateList<Customer>() select s;
                    list.AddRange(result.ToArray());
                }

                





               _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            return list;
        }


        /*
        public Customer GetCustomerByPhoneNumber(string phoneNumber)
        {
            // throw new NotImplementedException();
            return null;
        }*/

        /*public List<Customer> GetCustomersLivingInCity(string city)
        {
            //throw new NotImplementedException();
            return null;
        }*/

        public List<Customer> GrtCustomersBetweenAges(int minAge, int maxAge)
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                _connection.Open();
                _command.CommandText = $"SELECT * FROM Customers WHERE AGE > {minAge} AND AGE < {maxAge}";

                customers = readDBAndCreateList<Customer>();

                _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            return customers;
        }
        public List<Customer> GrtCustomersBetweenAges_LINQ(int minAge, int maxAge)
        {            
            List<Customer> resList = new List<Customer>();
            try
            {
                _connection.Open();                
                _command.CommandText = $"SELECT * FROM Customers";
                var result = from s in readDBAndCreateList<Customer>() where (int)s.AGE > minAge && (int)s.AGE < maxAge select s;
                _connection.Close();
                resList.AddRange(result.ToArray());
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            return resList;
        }

        public void RemoveAllCustomers()
        {
            try
            {
                _connection.Open();
                _command.CommandText = "DELETE FROM Customers";
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }

        public void UpdateOrDEleteCustomer(Customer customer, Modify modifier)
        {
            try
            {
                _connection.Open();
                switch(modifier)
                {
                    case Modify.Update:
                        for (int i = 1; i < customer.GetType().GetProperties().Length; i++)
                        {
                            _command.CommandText = $"UPDATE Customers  SET {customer.GetType().GetProperties()[i].Name} = '{customer.GetType().GetProperties()[i].GetValue(customer)}' WHERE {customer.GetType().GetProperties()[0].Name} = {customer.GetType().GetProperties()[0].GetValue(customer)}";
                            _command.ExecuteNonQuery();
                        }
                        break;
                    case Modify.Delete:
                        _command.CommandText = $"DELETE FROM Customers WHERE {customer.GetType().GetProperties()[0].Name} = {customer.GetType().GetProperties()[0].GetValue(customer)}";
                        _command.ExecuteNonQuery();
                        break;

                }


                _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }

        public int GetNUmberOfCustomers()
        {
            int numberOfCustomers = -2;
            try
            {
                _connection.Open();
                _command.CommandText = $"SELECT COUNT(ID) FROM Customers";
                numberOfCustomers = Convert.ToInt32(_command.ExecuteScalar());
                _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            return numberOfCustomers;
        }

        public void CreateTableIfDontExists()
        {
            try
            {
                _connection.Open();
                _command.CommandText = File.ReadAllText("_allegedly_stored_procedure.txt");
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }
    }


}
