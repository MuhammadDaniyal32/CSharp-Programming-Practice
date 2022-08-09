using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_if
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Value Of 'A'");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Value Of 'B'");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} is greater than {1}", a, b);

            }

            else if ( a < b)
            {
                Console.WriteLine("{0} is less than {1}", a, b);
            }

          

            Console.WriteLine("VALUE OF A IS : {0}", a);
            Console.WriteLine("VALUE OF B IS : {0}", b);
            Console.ReadLine();
        }
    }
}
