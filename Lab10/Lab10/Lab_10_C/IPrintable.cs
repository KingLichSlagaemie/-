using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    internal interface IPrintable
    {
        string Name { get; set; }
        int Year { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Name} | Год выпуска: {Year}");
        }
        
    }
    public class Book1: IPrintable
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    public class Magazine1: IPrintable
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }

}
