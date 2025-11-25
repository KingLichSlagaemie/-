using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    public class Bird: ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Чирик!");
        }
    }
}
