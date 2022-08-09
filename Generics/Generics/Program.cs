using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class test<F>
{
    F value;
    
    public test(F t)
    {
        value = t;
    }
    public void write()
    {
        Console.WriteLine("Value is :" + value);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            test<int> test1 = new test<int>(5);
            test1.write();

            test<string> test2 = new test<string>("daniyal");
            test2.write();

            test<float> test3 = new test<float>(5.23f);
            test3.write();

            Console.ReadLine();
        }
    }

