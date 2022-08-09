using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_3d
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] list = { 34, 72, 13, 44, 25, 30, 10 };

            Console.Write("Original Array:");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(list);
            Console.Write("Reversed Array: ");

            foreach(int i in list)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

            Array.Sort(list);
            Console.Write("Ascending order: ");

            foreach(int i in list)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
