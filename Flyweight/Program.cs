using Flyweight.Shape.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Red:");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle("circle");
                circle.SetColor("Red");
                circle.Draw();
            }

            Console.WriteLine("\r\nGreen:");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle("circle");
                circle.SetColor("Green");
                circle.Draw();
            }

            Console.WriteLine("\r\nBlue:");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle("circle");
                circle.SetColor("Green");
                circle.Draw();
            }

            Console.WriteLine("\r\nOrange:");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle("circle");
                circle.SetColor("Orange");
                circle.Draw();
            }

            Console.WriteLine("\r\nBlack:");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle("circle");
                circle.SetColor("Black");
                circle.Draw();
            }

            Console.ReadKey();
        }
    }
}
