using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    internal interface IFlier
    {
        void Fly();
    }
    internal interface ISwimmmer
    {
        void Swim();
    }
    public class Duck : IFlier, ISwimmmer
    {
        public void Fly() => Console.WriteLine("Утка летит!");
        public void Swim() => Console.WriteLine("Утка плывет!");
    }
}
 
