using Flyweight.Shape.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class ShapeFactory
    {
        private static readonly Dictionary<String, IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape GetCircle(String color)
        {
            IShape circle = null;
            if (circleMap.TryGetValue(color, out circle) == false)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);

                Console.WriteLine("-------------------新增Circle:" + color);
            }
            return circle;
        }
    }
}
