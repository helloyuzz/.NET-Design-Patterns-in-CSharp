using Factory.Shape;
using System;

/*
 * 工厂模式，就是一个接口，多个实现
 * 再根据不同的参数，去实例化不同的接口实现类
 */
namespace Factory {
    class Program {
        static void Main(string[] args) {
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
