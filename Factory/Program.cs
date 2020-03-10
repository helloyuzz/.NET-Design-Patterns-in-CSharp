using Factory.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //获取 Circle 的对象，并调用Circle的 draw 方法
            IShape shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.Draw();

            //获取 Rectangle 的对象，并调用Rectangle的 draw 方法
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.Draw();

            //获取 Square 的对象，并调用Square的 draw 方法
            IShape shape3 = shapeFactory.GetShape("SQUARE");
            shape3.Draw();

            Console.ReadLine();
        }
    }
}
