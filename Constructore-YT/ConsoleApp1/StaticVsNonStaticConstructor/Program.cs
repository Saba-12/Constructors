using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsNonStaticConstructor
{
    internal class Program
    {
        static int y;
        int x;
        static Program()
        {
            Console.WriteLine("Static Constructor is called");
        }

        public Program()
        {
            Console.WriteLine("Non-Static Constructor is called");
        }
        static void Main(string[] args)
        {
            Program program=new Program();
            Console.WriteLine("Main Method is called");
            Console.ReadLine();
        }
    }
}
