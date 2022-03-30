using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConstructorDemo
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Constructor is called");
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();
            Program program1 = new Program();
            Program program2 = new Program();
            Console.ReadLine();
        }
    }
}
