using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    //declare the shape
    abstract class Shape
    {
        //delare the attributes
        //calculations depending on the object itself
        public abstract double area();

        //an abstract can contain methods of non-abstract class
 
        public void sayHi()
        {
            Console.WriteLine("Hello") ;
        }

        //everything inside an interface is an abstract method therefore 'abstract' is not required
        public interface ShapeItem
        {
            double area();
        }

        
        class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double num1, double num2)
            {
                length = num1;
                width = num2;
            }

            public override double area()
            {
                return length * width;
            }

            //operator overloading
            public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
            {
                double rectLength = rect1.length + rect2.length;
                double rectWidth = rect1.width + rect2.width;

                return new Rectangle(rectLength, rectWidth);
            }
        }

        class Triangle : Shape
        {
            private double theBase;
            private double height;

            public Triangle(double num1, double num2)
            {
                theBase = num1;
                height = num2;
            }

            public override double area()
            {
                return .5 * (theBase * height);
            }
        }
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);

            Console.WriteLine("Rect area " + rect.area());
            Console.WriteLine("Tri anrea " + tri.area());

            Rectangle combRect = (new Rectangle(5, 5) + new Rectangle(5, 5));

            Console.WriteLine("combRect area = " + combRect.area());
        }
    }


}
