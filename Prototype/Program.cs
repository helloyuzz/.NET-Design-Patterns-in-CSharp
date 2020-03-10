using Prototype.ShapeDefine.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle
            Circle circle = new Circle("1");            
            circle.Print();

            Circle cloned_Circle1 = circle.Clone() as Circle;            
            cloned_Circle1.Print();

            // Square
            Square square = new Square("2");
            square.Print();

            Square cloned_Square1 = square.Clone() as Square;
            cloned_Square1.Print();


            // Rectangle
            Rectangle rectangle = new Rectangle("3");
            rectangle.Print();

            Rectangle cloned_Rectangle1 = rectangle.Clone() as Rectangle;
            cloned_Rectangle1.Print();

            Console.WriteLine();

            // CacheManager
            //ShapeManager shapeManager = new ShapeManager();

            //Circle c_circle = new Circle("a1");
            //Square c_square = new Square("a2");
            //Rectangle c_rectangle = new Rectangle("a3");

            //shapeManager["Circle"] = c_circle;
            //shapeManager["Square"] = c_square;
            //shapeManager["Rectangle"] = c_rectangle;

            //Circle cloned_c_circle = shapeManager["Circle"].Clone() as Circle;
            //Square cloned_c_square = shapeManager["Square"].Clone() as Square;
            //Rectangle cloned_c_rectangle = shapeManager["Rectangle"].Clone() as Rectangle;

            //c_circle.Print();
            //cloned_c_circle.Print();

            //c_square.Print();
            //cloned_c_square.Print();

            //c_rectangle.Print();
            //cloned_c_rectangle.Print();

            Console.ReadLine();
        }
    }
}
