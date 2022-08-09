using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda_exp
{
    class Class1
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void abc()
        {
            List<Class1> person = new List<Class1>(){
                new Class1 {Name="Daniyal",Age =4},
                new Class1 {Name="Talha",Age =5},
                new Class1 {Name="Sara",Age =3}
            };
            var names = person.Select(x => x.Name);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            var ages = person.Select(x => x.Age);
            foreach(var i in ages)
            {
                Console.WriteLine(i);

            }

            Console.ReadLine();
        }
    }
}
