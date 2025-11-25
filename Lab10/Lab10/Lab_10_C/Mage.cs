using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    internal class Mage: IUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Mage(string name2)
        {
            Name = name2;
            Health = 75;
        }

        public void Attack(IUnit target)
        {
            Console.WriteLine($"{Name} кстует заклинание на {target.Name}!");
        }
    }
}
