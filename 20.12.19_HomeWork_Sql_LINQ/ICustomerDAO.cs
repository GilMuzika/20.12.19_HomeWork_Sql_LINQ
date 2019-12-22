using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._12._19_HomeWork_Sql_LINQ
{
    interface ICustomerDAO
    {
        List<Customer> GetAllCustomersAndGetCustomersBy(string[] identifiers, string rowIdentifyer);
        //Customer GetCustomerByID(int id);
        void AddCustomer(Customer customer);
        void UpdateOrDEleteCustomer(Customer customer, Modify modifier);
        //void DeleteCustomer(int id);
        //List<Customer> GetCustomersLivingInCity(string city);
        List<Customer> GrtCustomersBetweenAges(int minAge, int maxAge);
        //Customer GetCustomerByPhoneNumber(string phoneNumber);
        void RemoveAllCustomers();

        int GetNUmberOfCustomers();
    }
}
