using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    class Person
    {
        public string? Name { get; set; }
        public virtual void SayHello()
        {
            Console.WriteLine($"Привет, меня зовут {Name}!");
        }
    }
}
