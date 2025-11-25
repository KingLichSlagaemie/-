using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    internal interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

    }
    public class Student2: IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kaf { get; set; }
    }
    public class Teacher2: IPerson
    {
        public string Name { get; set; }
        public  int Age { get; set; }
        public string Kaf { get; set; }
    }
}
