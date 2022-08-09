using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            int a = Convert.ToInt16(Console.ReadLine());

            if (a==10)
            {
                Console.WriteLine("It is is a matching value!!!");

            }

            else if(a==20)
            {
                Console.WriteLine("It is is a matching value!!");

            }
            
            else if(a==30)
            {
                Console.WriteLine("It is is a matching value!!");

            }

            else if (a<20)
            {
                Console.WriteLine("a is less than 20");
            }

            else
            {
                Console.WriteLine("None of the value is matching");
            }

            Console.WriteLine("value of a is :{0}",a);
            Console.ReadLine();
        }
    }
}
