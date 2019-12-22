using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._12._19_HomeWork_Sql_LINQ
{
    class ComboItem<T>
    {
        public T Value { get; set; } = default(T);

        public ComboItem(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.GetType().GetProperties()[1].GetValue(Value).ToString();
        }
    }
}
