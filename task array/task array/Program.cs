using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] name = new string[3];
            name[0] = "ALI";
            name[1] = "AHMED";
            name[2] = "OWAISE";

            string[][] array = new string[3][];

            array[0] = new string[3];
            array[1] = new string[1];
            array[2] = new string[2];

            array[0][0] = "Bachelor";
            array[0][1] = "Master";
            array[0][2] = "Doctorate";
            array[1][0] = "Bachelor";
            array[2][0] = "Bachelor";
            array[2][1] = "Master";

            for (int i = 0; i < array.Length;i++ )
            {
                Console.WriteLine(name[i]);
                Console.WriteLine("=========");

                string[] innerarray = array[i];

                for (int j = 0; j < innerarray.Length;j++ )
                {
                    Console.WriteLine(innerarray[j]);
                }
                Console.WriteLine();
            }

         Console.ReadLine();
        }
    }
}
