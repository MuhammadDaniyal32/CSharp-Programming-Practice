using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList la = new ArrayList();
            la.Add("C++");
            la.Add(344);
            la.Add(55);
            la.Add(25.23);
            la.Add("c.sharp");

            foreach(object ar in la)
            {
                Console.WriteLine(ar);
            }

            Console.WriteLine("\n");

            la.Remove(344);
            la.Remove(3);

            foreach (object ar in la)
                Console.WriteLine(ar);

            Console.ReadLine();
        }
    }
}
