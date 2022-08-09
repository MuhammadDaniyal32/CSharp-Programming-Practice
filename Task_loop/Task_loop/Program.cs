using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Series of these numbers");
            int i, sum;
            for(i = 2;i<=122;i++)
            {
                i++;
                Console.Write("{0}", i);
            }

            Console.ReadLine();

        }
    }
}
