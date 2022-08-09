using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_method
{
    class customer
    {
        string firstname;
        string lastname;
        float id;
        string DOB;

        public void details (string firstname,string lastname,float id,string DOB)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.id = id;
            this.DOB = DOB;
        
        }

        public void print()
        {
            Console.WriteLine("Id: {2}\nFull Name : {0}{1}\nDOB : {3}", firstname, lastname, id, DOB);
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            customer obj = new customer();
            obj.details("Daniyal", "Noor", 10.23f, "12  5  2006");
            obj.print();
            obj.details("Arsalan", "Istiqe", 11.20f, "12  5  2006");
            obj.print();

            Console.ReadLine();
        }
    }
}
