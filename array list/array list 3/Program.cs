using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();
            langs.Add("JAVA");
            langs.Add("C#");
            langs.Add("C++");
            langs.Add("RUBY");
            langs.Add("JAVASCRIPT");
            langs.Add("PYTHON");
            
            foreach(string lang in langs)
            {
                Console.WriteLine(lang);
            }
            Console.WriteLine("\n\n");

            langs.Remove("C#");
            langs.Remove("C++");

            langs.Insert(4,"RDMS");

            langs.Sort();

            foreach(string lang in langs)
            {
                Console.WriteLine(lang);
            }

            Console.ReadLine();
        }
    }
}
