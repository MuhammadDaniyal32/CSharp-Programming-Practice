using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String st = File.ReadAllText("C:\\Users\\asp.APTECHNK\\Desktop\\json_daniyal\\file2.json");
                Console.WriteLine(st);

            }
            catch(Exception ex)
            {
                Console.WriteLine("File Not Found!!!");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
