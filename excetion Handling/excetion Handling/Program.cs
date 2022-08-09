using System;

class div
{
    int result = 0;

    public void divide(int num1 , int num2)
    {

        try
        {
            result = num1 / num2;
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Exception caught : {0}",e);
        }

        finally
        {
            Console.WriteLine("Result : {0}",result);
            Console.WriteLine("VALUE1");

        }

    }
}


    class Program
    {
        static void Main(string[] args)
        {
            div obj = new div();

            obj.divide(10,0);

            Console.ReadLine();

        }
    }

