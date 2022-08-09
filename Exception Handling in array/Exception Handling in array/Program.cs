using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int [] array = new int [3];
                array [0] = 1;
                array [1] = 2;
                array [2] = 3;
                //array [3] = 4;

                foreach (int a in array)
                {
                    Console.WriteLine(a);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("ARRAY LENGHT OUT OF BOND" + e);

            }
            finally
            {
                Console.WriteLine("\n\n Array Elements Not Printed!!");
            }

            Console.ReadLine();
        }
    }

