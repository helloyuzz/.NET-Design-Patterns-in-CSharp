using Prototype.ShapeDefine.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    class Program {
        static void Main(string[] args) {
            // Circle
            Circle shape1 = new Circle("1");
            shape1.Print();

            Circle shape1_copy = shape1.Clone() as Circle;
            shape1_copy.Print();

            // Square
            Square shape2 = new Square("2");
            shape2.Print();

            Square shape2_copy = shape2.Clone() as Square;
            shape2_copy.Print();


            // Rectangle
            Rectangle shape3 = new Rectangle("3");
            shape3.Print();

            Rectangle shape3_copy = shape3.Clone() as Rectangle;
            shape3_copy.Print();

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