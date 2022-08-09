using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    public class drawingobject
    {
        public virtual void Draw()
        {
            Console.WriteLine("I'm just a generic drawing object.");
        }
    }

    public class Line : drawingobject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Line.");
        }
    }

    public class circle : drawingobject
    {
        public override void Draw()
        {
            Console.WriteLine("I' in circle");
        }
    }

    public class square : drawingobject
    {
        public override void Draw()
        {
            Console.WriteLine("I' in square");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //first method

            //square obj = new square();
            //obj.Draw();
            //obj.Draw();

            //drawingobject obj1 = new drawingobject();
            //obj1.Draw();

            //circle obj2 = new circle();
            //obj2.Draw();

            //Line obj3 = new Line();
            //obj3.Draw();

            //second method

            drawingobject[] obj4 = new drawingobject[4];
            obj4[0] = new Line();
            obj4[1] = new circle();
            obj4[2] = new square();
            obj4[3] = new drawingobject();

            foreach (drawingobject drawobj in obj4)
            {
                drawobj.Draw();
            }

            Console.ReadLine();
        }
    }
}
