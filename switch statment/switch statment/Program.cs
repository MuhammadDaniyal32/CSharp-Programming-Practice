using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number");
            int a = int.Parse(Console.ReadLine());

            switch(a)
            {
            
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("you enter one");
                    break;
                case 6:
                    Console.WriteLine("you enter two");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            Console.ReadLine();



            }

        }
    }

