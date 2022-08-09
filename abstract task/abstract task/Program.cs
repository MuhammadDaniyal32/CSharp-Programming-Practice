using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_task
{
    abstract class bonus
    {
        public int bEmp1 = 4000;
        public int bEmp2 = 4000;
        public int bEmp3 = 4000;
        public int bEmp4 = 4000;

        public void Bonus()
        {
            Console.WriteLine("Employee 1 bonus is :" + bEmp1);
            Console.WriteLine("Employee 2 bonus is :" + bEmp2);
            Console.WriteLine("Employee 3 bonus is :" + bEmp3);
            Console.WriteLine("Employee 4 bonus is :" + bEmp4);

            int result = bEmp1 + bEmp2 + bEmp3 + bEmp4;
            Console.WriteLine("Total bonus given to Employees are :" + result);
        }
    }
   class salary : bonus
   {
       int total1, total2, total3, total4;

       public void sal()
       {
           int salaryEmp1 = 14000;
           int salaryEmp2 = 40000;
           int salaryEmp3 = 45000;
           int salaryEmp4 = 46000;

           Console.WriteLine("Employee 1 salary :" + salaryEmp1);
           Console.WriteLine("Employee 2 salary :" + salaryEmp2);
           Console.WriteLine("Employee 3 salary :" + salaryEmp3);
           Console.WriteLine("Employee 4 salary :" + salaryEmp4);

           int salarytotal = salaryEmp1 + salaryEmp2 + salaryEmp3 + salaryEmp4;

           Console.WriteLine("Total salary given to employee are :" + salarytotal);
           Console.WriteLine("Salary After adding 4000 bonus in each employee salary is ");

           total1 = salaryEmp1 + bEmp1;
           total2 = salaryEmp2 + bEmp2;
           total3 = salaryEmp3 + bEmp3;
           total4 = salaryEmp4 + bEmp4;

           Console.WriteLine("Grand total after adding bonus of employee 1 is:" + total1);
           Console.WriteLine("Grand total after adding bonus of employee 2 is:" + total2);
           Console.WriteLine("Grand total after adding bonus of employee 3 is:" + total3);
           Console.WriteLine("Grand total after adding bonus of employee 4 is:" + total4);

       }
   }
   class Program
        {
        static void Main(string[] args)
        {

            salary obj = new salary();
            obj.Bonus();
            obj.sal();
            Console.ReadLine();


        }
    }
}
