using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace go_to_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 0;
        start1:

            Console.WriteLine("\t\t Welcome To Coffee Shop...\n");
        Console.WriteLine("Please Select Below Options For Order");

        Console.WriteLine("1-Small \n 2-Medium \n 3-Large \n 4-Special\n");

        int order = int.Parse(Console.ReadLine());

            switch(order)
            {
                case 1:
            price += 50;
            break;

                case 2:
            price += 70;
            break;
                case 3:
            price += 100;
            break;
                case 4:
            price += 150;
            break;
                default:

            Console.WriteLine("Your Enter Choice {0} is invalid",order);

            goto start1;

            }

        start2:

            Console.WriteLine("Do You Want To Buy Another Cofee ?? YES \n NO");

        string order2 = Console.ReadLine();

            switch(order2.ToUpper())
            {
                case "YES":
                    goto start1;

                case "NO":
                    break;

                default:
                    Console.WriteLine("Your Choice {0} invalid. Please try again....", order2);
                    goto start2;

            }

            Console.WriteLine("Thank U!! for shopping with us.......");
            Console.WriteLine("Bill Amount = {0}", price);
            Console.ReadLine();
        }
    }
}
