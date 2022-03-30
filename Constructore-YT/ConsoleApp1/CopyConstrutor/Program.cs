using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstrutor
{
    internal class Program
    {
        int x;

        public Program(int i)                              //Paramterized Constructor
        {
            x = i;
        }

        public void Display()
        {
            Console.WriteLine("Value of x = "+x);
        }

        public Program(Program obj)                       //Copy constructore
        {
            x = obj.x;
        }
        static void Main(string[] args)
        {
            Program p = new Program(10);
            p.Display();

            Program p1 = new Program(p);
            p1.Display();

            Console.ReadLine();
        }
    }
}
