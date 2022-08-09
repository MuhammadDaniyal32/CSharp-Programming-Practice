using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k<=10; k++)
            {
            Console.WriteLine("Batch code :1808C1");
            }
            int[] number = new int[4];
            number[0] = 100;
            number[1] = 101;
            number[2] = 102;
            number[3] = 103;

            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine(number[j]);
            }
            int i = 0;
            while (i < number.Length)
            {
                Console.WriteLine(number[i]);
                i++;
            }
            foreach (int k in number)
            {
                Console.WriteLine(k);
            }
            for (int j = 0; j <= 20; j++)
            {
                Console.WriteLine(j);
                if (j == 10)
                    break;
            }
            for (int f = 0; f <= 30; f++)
            {
                if (f % 3 == 0)
                    continue;
                Console.WriteLine(f);
            }









                Console.ReadLine();
        }
    }
}
