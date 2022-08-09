using System;

class A
{
    private string name;
    protected int rollno;
    public string address;

}
class B:A
{
    public void method()
    {
        rollno = 56;
        address = "sdfsdf";
        Console.WriteLine(rollno);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.address= "address";
            obj.method();

            Console.ReadLine();
        }
    }

