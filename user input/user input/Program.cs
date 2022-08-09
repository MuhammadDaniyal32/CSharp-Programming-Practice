using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Firstname:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Please Enter Lastname:");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Please Enter Your Rollno:");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Firstname is : {0}\n\n Your Lastname is : {1}\n\n Your Rollno is : {2}\n\n", Firstname, Lastname, rollno);

            Console.WriteLine("\t For Further Addition Program.......\n");

            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You entered {0}\n", num1);
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You entered {0}\n", num2);
            Console.WriteLine("\t Below is the sum of these two Answer is : {0}\n");
            int ans = num1 + num2;

            Console.WriteLine("Your Answer is : {0}", ans);

            int multi = num1 * num2;

            Console.WriteLine("your product is {0}: ", multi);

            int sub = num1 - num2;

            Console.WriteLine("sub is {0} : ", sub);

            float div = (float)num1 / num2;

            Console.WriteLine("Div is {0}:", div);


            Console.WriteLine("Take Float value input");
            float fa = float.Parse(Console.ReadLine());
            Console.WriteLine("you have enter:",+fa);

            Console.WriteLine("for double value input");

            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("the double value is : " + value);

            Console.WriteLine("Enter Decimal value");
            decimal dc = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Decimal Value is : " + dc);

            Console.WriteLine("Enter NUMBER TO CHECK!!");

            int num4 = Convert.ToInt16(Console.ReadLine());

            string abc = num4 % 2 == 0 ? "even" : "odd";
            Console.WriteLine("Your number is :" + abc);




            Console.ReadLine();

        }
    }
}
