using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class ValueChecker
    {
        public void CheckType(object input)
        {

            if (input is ValueType)
            {
                Console.WriteLine($"Значение '{input}' является ЗНАЧИМЫМ типом");
            }
            else
            {
                Console.WriteLine($"Значение '{input}' является ССЫЛОЧНЫМ типом");
            }


            if (input is int)
            {
                int typedValue = (int)input;
                Console.WriteLine($"- Это целое число (int): {typedValue}");
            }

            if (input is string)
            {
                string typedValue = (string)input;
                Console.WriteLine($"- Это строка (string): {typedValue}");
            }

            if (input is double)
            {
                double typedValue = (double)input;
                Console.WriteLine($"- Это число с плавающей точкой (double): {typedValue}");
            }

            if (input is bool)
            {
                bool typedValue = (bool)input;
                Console.WriteLine($"- Это логическое значение (bool): {typedValue}");
            }

            if (input is decimal)
            {
                decimal typedValue = (decimal)input;
                Console.WriteLine($"- Это десятичное число (decimal): {typedValue}");
            }
        }
    }
}
