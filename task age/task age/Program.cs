using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_age
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age :");
            int age = int.Parse(Console.ReadLine());

            if (age<=5)
            {
                Console.WriteLine("Infant");
            }

            else if (age<=15)
            {
            Console.WriteLine("Childern");
            }

            else if (age <= 40)
            {
                Console.WriteLine("Adults");
            }

            else if (age <= 70)
            {
                Console.WriteLine("Senior citizen");
            }

            else
            {
                Console.WriteLine("Your not applicable");
            }


            double total;

            Console.WriteLine("Enter total Units");
            double unit = double.Parse(Console.ReadLine());

            if (unit <= 100)
            {
                total = unit * 4;
            }

            else if(unit>100 &&  unit <= 300)
            {
                total = unit * 4.5;
            }

            else if (unit > 300 && unit <= 500)
            {
                total = unit * 4.75;
            }

            else
            {
                total = unit * 5;
            }

            Console.WriteLine("Total : {0}", total);

            Console.ReadLine();
        }
    }
}
