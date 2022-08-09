using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_inharitance
{
    public class employee
    {

        public string firstname;
        public string lastname;

        public void get(string a, string b)
        {
            firstname = a;
            lastname = b;
        }

        public void print()
        {
            Console.WriteLine("firstname is : {0}", firstname);
            Console.WriteLine("lastname is : {0}", lastname);
        }
    }

    public class employee1 : employee
    {
        public float yearlsalary;

        public void fa()
        {

            Console.WriteLine(base.firstname + "base class variable");
            Console.WriteLine(base.lastname + "base class variable");

        }

    }

    public class employee2 : employee1
    {

        public void emp2()
        {
            Console.WriteLine("This is employee2 class method");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            employee2 obj = new employee2();
            obj.emp2();
            obj.firstname = "afsf";
            obj.lastname = "asdfasdf";
            obj.yearlsalary=12.34f;
            obj.fa();
            obj.print();
            Console.ReadLine();
        }
    }
}
