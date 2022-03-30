using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    internal class Program
    {
        static Program()
        {
            Console.WriteLine("Static constructor is called ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main method is called");
        }
    }
}
