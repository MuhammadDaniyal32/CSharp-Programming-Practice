using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   class a
   {
       public void oddnumber()
       {
           int i = 1;
           while (i<=20)
           {
               Console.WriteLine(i);
               i += 2;
           }
       }
}
    class Program
    {
        //this is instance method
        public void evennumber()
        {
            int start = 0;

            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;

            }

        }

        //this is static method

        public static void evennumber2()
        {
            int start = 0;

            while (start <= 20)
            {
                Console.WriteLine(start);
                start = start + 2;

            }

        }

        public int add(int a , int b)
        {
            return a + b;

        }



        static void Main(string[] args)
        {

            a obj = new a();
            obj.oddnumber();

            Program p = new Program();
            p.evennumber();
            Console.WriteLine("\n");


            Program.evennumber2();

            int sum = p.add(4, 6);
            Console.WriteLine("\n sum is : {0}",sum);

            int sum2 = p.add(10, 5);
            Console.WriteLine("\n {0}",sum2);

            Console.ReadLine();
        }
    }
}
