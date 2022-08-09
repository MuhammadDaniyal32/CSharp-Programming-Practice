using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, a, n;

            int[] number = new int[30];

            Console.WriteLine("Enter the value of N\n");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number \n");

            for (i = 0; i < n;i++ )
            
                number[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (number[i] > number[j])
                    {
                        a = number[i];
                        number[i] = number[j];
                        number[j] = a;
                    }

                }
            }
            

            Console.WriteLine("The number arranged in ascending order are given below\n");
            for (i=0;i<n;i++)
            

                Console.WriteLine("{0}\n", number[i]);
            Console.ReadLine();

            
        }
    }
}
