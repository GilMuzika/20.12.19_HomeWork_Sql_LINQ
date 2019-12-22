using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._12._19_HomeWork_Sql_LINQ
{
    class Customer
    {
        private int _id;
        public object ID { get => _id; set => _id = Convert.ToInt32(value); }
        private string _first_name;
        public object FIRST_NAME { get => _first_name; set => _first_name = Convert.ToString(value); }
        private string _last_name;
        public object LAST_NAME { get => _last_name; set => _last_name = Convert.ToString(value); }
        private int _age;
        public object AGE { get => _age; set => _age = Convert.ToInt32(value); }
        private string _address_city;
        public object ADDRESS_CITY { get => _address_city; set => _address_city = Convert.ToString(value); }
        private string _address_street;
        public object ADDRESS_STREET_ { get => _address_street; set => _address_street = Convert.ToString(value); }
        private string _ph_number;
        public object PH_NUMBER { get => _ph_number; set => _ph_number = Convert.ToString(value); }

        public Customer(string fIRST_NAME, string lAST_NAME, int aGE, string aDDRESS_CITY, string aDDRESS_STREET, string pH_NUMBER)
        {
            FIRST_NAME = fIRST_NAME;
            LAST_NAME = lAST_NAME;
            AGE = aGE;
            ADDRESS_CITY = aDDRESS_CITY;
            ADDRESS_STREET_ = aDDRESS_STREET;
            PH_NUMBER = pH_NUMBER;
        }

        public Customer(int iD, string fIRST_NAME, string lAST_NAME, int aGE, string aDDRESS_CITY, string aDDRESS_STREET, string pH_NUMBER)
        {
            ID = iD;
            FIRST_NAME = fIRST_NAME;
            LAST_NAME = lAST_NAME;
            AGE = aGE;
            ADDRESS_CITY = aDDRESS_CITY;
            ADDRESS_STREET_ = aDDRESS_STREET;
            PH_NUMBER = pH_NUMBER;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            string str = string.Empty;
            this.GetType().GetProperties().ToList().ForEach(x => str += $"{x.Name}: {x.GetValue(this)}\n");
            str += "--------------------\n";

            return str;
        }
    }
}
