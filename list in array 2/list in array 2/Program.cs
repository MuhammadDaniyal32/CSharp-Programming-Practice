using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_in_array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arl = new ArrayList();

            arl.Add(100);
            arl.Add(200);

            ArrayList arl2 = new ArrayList();
            arl2.Add(10);
            arl2.Add(20);
            arl2.Add(30);

            arl2.InsertRange(2, arl);

            foreach (var item in arl2)
                Console.WriteLine(item);
            Console.WriteLine();

            ArrayList arl3 = new ArrayList();
            arl3.Add(100);
            arl3.Add(200);
            arl3.Add(300);

            arl3.RemoveRange(0, 2);

            foreach (var item in arl3)
                Console.WriteLine(item);
            Console.WriteLine();

            ArrayList myarray = new ArrayList();
            myarray.Add(1);
            myarray.Add("TWO");
            myarray.Add(3);
            myarray.Add(4.5);

            myarray.Insert(1, "Second Item");
            myarray.Insert(2,100);

            foreach (var val in myarray)
                Console.WriteLine(val);

            Console.ReadLine();

        }
    }
}
