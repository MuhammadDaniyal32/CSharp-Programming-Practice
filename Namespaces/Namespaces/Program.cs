using System;

    using A = ProjectA.TeamA;
    using B = ProjectA.TeamB;
    class Program
    {
        static void Main(string[] args)
        {
            //ProjectA.TeamA.ClassA.Print();
            //ProjectA.TeamB.ClassA.Print();

            A.ClassA.Print();
            B.ClassA.Print();

            Console.ReadLine();
        }
    }

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print method");
            }
        }
    }
}