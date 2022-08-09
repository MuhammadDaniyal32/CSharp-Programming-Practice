using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i <= 1;)
            {
                
                Console.Write(" ");
                i += 2;
                Console.Write(i);
                for (i= i; i<=120;)
                {
                    
                    Console.Write(" ");
                    i += 2;
                    int a = i;

                    Console.Write(i);

                    Console.Write(" ");
                    i += 2;
                    Console.Write(i);

                    Console.Write(" ");
                    Console.Write(a += a + 2);

                    i = a;
                }
            }

            
            Console.ReadLine();
        }
    }
}
