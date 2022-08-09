using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrl = new ArrayList();
            arrl.Add(300);
            //arrl.Add("rgsdgsdgfsdfgsdfs");
            arrl.Add(100);
            arrl.Add(500);
            arrl.Add(400);
            arrl.Add(200);

            Console.WriteLine("Original Order:");

            foreach (var item in arrl)
                Console.WriteLine(item);

            arrl.Reverse();
            Console.WriteLine("Reverse Order:");

            foreach (object item in arrl)
                Console.WriteLine(item);

            arrl.Sort();
            Console.WriteLine("Ascending Order:");

            foreach (object item in arrl)
                Console.WriteLine(item);

            Console.ReadLine();



        }
    }
}
