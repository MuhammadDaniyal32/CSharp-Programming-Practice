using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

sealed class hide
{
    public void h1()
    {
        Console.WriteLine("This is sealed class method");
    }
    public void h2()
    {
        Console.WriteLine("This is another sealed class method");
    }
}

class hidden
{
    public void acc()
    {
        Console.WriteLine("This is normal class method");
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            hide obj1 = new hide();
            obj1.h1();
            obj1.h2();

            hidden obj2 = new hidden();
            obj2.acc();

            Console.ReadLine();
        }
    }

