using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    internal class Student: Person
    {
        public string? University { get; set; }
        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine($"Я учусь в {University}.");
        }
    }
}
