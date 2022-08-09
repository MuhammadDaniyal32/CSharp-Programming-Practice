using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_program
{
    class Program
    {
        static void Main(string[] args)
        {

            int Sum = 4 + 3;
            Console.WriteLine("SUM IS :" + Sum);

            int sum1 = 3;
            int sum2 = 4;
            int result = sum1 + sum2;
            Console.WriteLine("SUM is :" + result);

            string a = "\" STRING A \"";
            Console.WriteLine("Escape Sequence with double quotes{0}:\n" + a);

            string b = "one\nTwo\nThree";
            Console.WriteLine("new line escape sequence:\n" + b);

            string c = "z:\\daniyal\\myfolder\\xyz.txt";
            Console.WriteLine(c);


            Console.WriteLine("\n");
            string c2 = @"z:\\daniyal\\myfolder\\xyz.txt";
            Console.WriteLine(c2);
            Console.WriteLine("\n");

            Console.WriteLine("min size of int is :{0}\n", int.MinValue);
            Console.WriteLine("max size of int is :{0}\n", int.MaxValue);

            Console.WriteLine("min size of byte is :{0}\n", byte.MinValue);
            Console.WriteLine("max size of byte is :{0}\n", byte.MaxValue);

            Console.WriteLine("min size of float is :{0}\n", float.MinValue);
            Console.WriteLine("max size of float is :{0}\n", float.MaxValue);

            Console.WriteLine("min size of double is :{0}\n", double.MinValue);
            Console.WriteLine("max size of double is :{0}\n", double.MaxValue);

            Console.WriteLine("min size of decimal is :{0}\n", decimal.MinValue);
            Console.WriteLine("max size of decimal is :{0}\n", decimal.MaxValue);

            Console.WriteLine("max size of sbyte is :{0}\n", sbyte.MinValue);
            Console.WriteLine("min size of sbyte is :{0}\n", sbyte.MaxValue);

            Console.WriteLine("min size of uint is :{0}\n", uint.MinValue);
            Console.WriteLine("max size of uint is :{0}\n", uint.MaxValue);

            Console.WriteLine("min size of long is :{0}\n", long.MinValue);
            Console.WriteLine("max size of long is :{0}\n", long.MaxValue);

            Console.WriteLine("min size of ulong is :{0}\n", ulong.MinValue);
            Console.WriteLine("max size of ulong is :{0}\n", ulong.MaxValue);

            Console.WriteLine("min size of short is :{0}\n", short.MinValue);
            Console.WriteLine("max size of short is :{0}\n", short.MaxValue);

            Console.WriteLine("min size of ushort is :{0}\n", ushort.MinValue);
            Console.WriteLine("max size of ushort is :{0}\n", ushort.MaxValue);

            Console.WriteLine("min size of char is :{0}\n", char.MinValue);
            Console.WriteLine("max size of char is :{0}\n", char.MaxValue);


            //typecasting : IMPLICIT

            int add = 2,add1=4;
            float result1 = (float)add / add1;

            Console.WriteLine("ADD OF TWO INTEGER NUMBERS AND ANS IS IN FLOAT : \n" + result1);

            decimal d =1.234512312412341234344m;
            Console.WriteLine("Decimal value is" + d);

            int ab = 1231;
            float f = ab;

            Console.WriteLine("Float value with implicit conversion" + f);

            float q = 1232.233f;

            int w = (int)q;
            Console.WriteLine("Float value with Explicit conversion with cast() operator\n" + w);

            int o = Convert.ToInt32(q);
            Console.WriteLine("Float value with Explicit conversion with convert class \n" + o);

            string str = "100";

            int str1 = int.Parse(str);

            Console.WriteLine("Explicit Conversion Of String value to int \n" + str1);

            Console.ReadLine();
        }
    }
}
