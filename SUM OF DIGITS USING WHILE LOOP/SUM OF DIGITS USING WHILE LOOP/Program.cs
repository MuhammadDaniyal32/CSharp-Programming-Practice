using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM_OF_DIGITS_USING_WHILE_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {


            int n, j,sum =0;
            Console.Write("Enter the No :=");

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            

            while (n > 0)
            {
                j = n % 10;
                sum += j;
                n /= 10;
            }

            Console.WriteLine("The Sum Of Digits is = {0}", sum);
            Console.ReadLine();

        }
    }
}
