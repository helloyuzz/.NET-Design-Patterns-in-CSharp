using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {
            //获取形状工厂
            AbstractFactory shapeFactory = MyFactory.CreateFactory("SHAPE");

            //获取形状为 Circle 的对象，并调用 Circle 的 draw 方法
            IShape shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.Draw();

            //获取形状为 Rectangle 的对象，并调用 Rectangle 的 draw 方法
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.Draw();

            //获取形状为 Square 的对象，并调用 Square 的 draw 方法
            IShape shape3 = shapeFactory.GetShape("SQUARE");
            shape3.Draw();




            //获取颜色工厂
            AbstractFactory colorFactory = MyFactory.CreateFactory("COLOR");

            //获取颜色为 Red 的对象，并调用 Red 的 fill 方法
            IColor color1 = colorFactory.GetColor("RED");
            color1.Fill();

            //获取颜色为 Green 的对象，并调用 Green 的 fill 方法
            IColor color2 = colorFactory.GetColor("Green");
            color2.Fill();

            //获取颜色为 Blue 的对象，并调用 Blue 的 fill 方法
            IColor color3 = colorFactory.GetColor("BLUE");
            color3.Fill();

            Console.ReadLine();
        }
    }
}