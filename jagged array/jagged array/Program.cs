using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {

          int [] [] num = new int [3][];
          num[0] = new int[] { 11, 23, 34, 45 };
          num[1] = new int[] { 16,25 };
          num[2] = new int[] { 75,98,2};


            for (int x = 0; x<3;x++)
            {
                for (int y = 0; y < num[x].Length; y++)
                {
                    Console.Write(num[x][y] + " ");
                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
