using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string[,] book = new string[3, 3];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\nEnter Book For {0}.Row and {1}.Column:\t", i + 1, j + 1);
                    book[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("\n\n==================");
            Console.WriteLine("All the element of books array is :\n\n");

            Console.WriteLine("\t1\t2\t3\n\n");

            for (i = 0; i < 3; i++)
            {
                Console.Write("{0}.\t", i + 1);
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", book[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n===============");
            Console.ReadLine();
        }
    }

}
