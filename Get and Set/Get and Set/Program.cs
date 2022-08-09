using System;

public class student
{
    private int ID;
    private string Name;
    public int PassMarks = 35;
    
    public void SetId(int a)
    {
        if (a <= 0)
        {
            throw new Exception("Student id cannot be negative");

        }
        this.ID = a;
    }

    public int Getid()
    {
        return this.ID;
    }

    public void SetName(string Names)
    {
        if (string.IsNullOrEmpty(Names))
        {
            throw new Exception("Name cannot be empty");
        }
        this.Name = Names;
    }

    public string GetName()
    {
        return this.Name;
    }

    public int GetPassMarks()
    {
        return this.PassMarks;
    }
     
}

    class Program
    {
        static void Main(string[] args)
        {
            student obj2 = new student();
            obj2.PassMarks = 23;
            
            student obj = new student();

            obj.SetId(45);
            obj.SetName("daniyal");
            
            
            Console.WriteLine(obj.Getid());
            Console.WriteLine(obj.GetName());
            Console.WriteLine(obj.GetPassMarks());

            Console.ReadLine();
        }
    }

