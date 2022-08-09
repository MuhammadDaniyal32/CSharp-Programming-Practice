using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_array
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[4];

            arr[0] = 12;
            arr[1] = "object string";
            arr[2] = 23.23;
            arr[3] = 54.23423f;
 
            foreach(object abc in arr)
            {
                Console.WriteLine("Values of array are : {0}", abc);

            }
            Console.ReadLine();

        }
    }
}
