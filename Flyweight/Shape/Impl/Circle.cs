using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Shape.Impl
{
    class Circle : IShape
    {
        private String color;
        private int radius = 100;
        public Circle(String color)
        {
            this.color = color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }        
        public void Draw()
        {
            Console.WriteLine("Circle Color:{0},-radius:{1}", color, radius);
        }
    }
}
