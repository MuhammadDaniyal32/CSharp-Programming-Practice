using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construct_overloading
{
    class abc
    {
        public abc ()
        {
            Console.WriteLine("this is default constructor");
        }

        public abc (int a)
        {
            Console.WriteLine("this is parameterized constructor1");
        }

        public abc (string a, string b)
        {
            Console.WriteLine("this is parameterized constructor2");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            abc obj = new abc();
            abc obj1 = new abc(234345);
            abc obj2 = new abc("daniyal","xyz");
            abc obj3 = new abc(435346);

            Console.ReadLine();
        }
    }
}
