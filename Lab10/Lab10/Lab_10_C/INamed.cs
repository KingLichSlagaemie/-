using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_C
{
    internal interface INamed
    {
        string Name { get; set; }
    }
    public class Book: INamed
    {
        public string Name { get; set; }
    }
}
