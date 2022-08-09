using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singal_inharitance
{
    public class employee
    {

        public string firstname;
        public string lastname;

        public void get (string a, string b)
        {
            firstname = a;
            lastname = b;
        }

        public void print ()
        {
            Console.WriteLine("firstname is : {0}", firstname);
            Console.WriteLine("lastname is : {0}", lastname);
        }
    }

    public class  employee1 : employee
    {
        public float yearlsalary;

        public void fa()
        {

            Console.WriteLine(base.firstname + "base class variable");
            Console.WriteLine(base.lastname + "base class variable");

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            employee1 obj = new employee1();
            obj.firstname="daniyal";
            obj.lastname = "noor";
            //obj.get("xyz", "asf");
            obj.print();


            Console.ReadLine();
        }
    }
}
