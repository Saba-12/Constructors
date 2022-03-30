using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    internal class Program
    {
        int x;
        public Program(int i)
        {
            x = i;
            Console.WriteLine("Paramterized constructor is called with value = "+i);
        }

        public void Display()
        {
            Console.WriteLine("Value of x = " + x);
        }
        static void Main(string[] args)
        {
            Program p = new Program(10);
            Program p1 = new Program(20);

            p.Display();
            p1.Display();
            Console.ReadLine();
        }
    }
}
