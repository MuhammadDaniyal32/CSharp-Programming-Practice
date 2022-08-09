using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARTHMETIC Operator

            int valueone = 10;
            int valuetwo = 2;
            int add = valueone + valuetwo;
            int sub = valueone - valuetwo;
            int div = valueone / valuetwo;
            int multi = valueone * valuetwo;
            int rem = valueone % valuetwo;

            Console.WriteLine("ADD" + add);
            Console.WriteLine("SUB" + sub);
            Console.WriteLine("div" + div);
            Console.WriteLine("multi" + multi);
            Console.WriteLine("rem" + rem);

            //Relational Operators

            int a = 20, b = 30;

            Console.WriteLine("value of a is :" + a);
            Console.WriteLine("value of b is :" + b);
            Console.WriteLine("\n");

            Console.WriteLine("Equal to operator "+(a==b));
            Console.WriteLine("not equal to operator" +(a != b));
            Console.WriteLine("Less than to operator" + (a < b));
            Console.WriteLine("greater than to operator" + (a > b));
            Console.WriteLine("Less than equal to operator" + (a <= b));
            Console.WriteLine("Greater than equal to operator" + (a >= b));

            //Assignment Operators

            int one = 5;
            Console.WriteLine("Value1 = " + one);
            one += 4;
            Console.WriteLine("Value1 +=4 " + one);
            one -= 8;
            Console.WriteLine("Value1 -=8 " + one);
            one *= 7;
            Console.WriteLine("Value1 *=7= " + one);
            one /= 2;
            Console.WriteLine("Value1 /=2= " + one);

            Console.WriteLine("\n\n\n");

            int a1 = 4;

            string abc = a1 % 2 == 0 ? "even" : "odd";
            Console.WriteLine("number 4 is :" + abc);

            string name1 = "daniyal",name2 = "arsalan";

            string namelessthanfive = name2.Length < 5 ? name1 : name2;
            Console.WriteLine(namelessthanfive);

            Console.ReadLine();
        }
    }
}
