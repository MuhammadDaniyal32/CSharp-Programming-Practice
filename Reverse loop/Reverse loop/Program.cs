using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, j;
            Console.Write("Enter the No :=");

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Resverse of the number is......");

            while(n>0)
            {
                j = n % 10;
                Console.Write(j);
                n /= 10;
            }
            Console.ReadLine();

        }
    }
}
