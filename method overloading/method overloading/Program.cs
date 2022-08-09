using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class classA
    {

        public int Sum(int A,int B)
        {
            return A + B;
        }

        public float Sum(int A, float B)
        {
            return A + B;
        }

        public float Sum(float A, float B)
        {
            return A + B;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            classA obj = new classA();

            Console.WriteLine("The sum of given number is :"+obj.Sum(10,20));
            Console.WriteLine("The sum of given number is :" + obj.Sum(40, 20.23f));
            Console.WriteLine("The sum of given number is :" + obj.Sum(10.5f,13.345f));

            Console.ReadLine();
        }
    }
}
