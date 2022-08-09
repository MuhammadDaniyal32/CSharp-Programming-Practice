using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Book = new string[5];

            Book[0] = "C#";
            Book[1] = "Java";
            Book[2] = "RDBMS";
            Book[3] = "PHP";
            Book[4] = "C";

            Console.WriteLine("All the element of book array are : \n\n");

            Console.Write("\t1\t2\t3\t4\t5\n\n\t");

            for (int i = 0 ; i<5 ;i++)
            {

                Console.Write("{0}\t", Book[i]);

            }
            Console.ReadLine();

        }
    }
}
