using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda_exp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evennumber = list.FindAll(x => (x % 2) == 0);

            foreach(var num in evennumber)
            {
                Console.Write("{0}", num);

            }
            Console.WriteLine();

            Class1 obj = new Class1();
            obj.abc();
            Console.ReadLine();
        }
    }
}
