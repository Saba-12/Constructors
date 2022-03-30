﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorNeedDemo
{
    internal class Program
    {
        class First
        {
            public int x = 100;
        }
 
        class Second {
            public int x;
            public Second(int x)
            {
                this.x = x;
            }
        }

        static void Main(string[] args)
        {
            First f1=new First();
            First f2=new First();
            First f3=new First();

            Console.WriteLine(f1.x+" "+f2.x+" "+f3.x);

            Second s1=new Second(100);
            Second s2 = new Second(200);
            Second s3 = new Second(300);
            Console.WriteLine(s1.x + " " + s2.x + " " + s3.x);
            Console.ReadLine();
        }
    }
}