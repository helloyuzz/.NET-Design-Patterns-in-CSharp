using Factory.Shape;
using System;

namespace AbstractFactory {
    class Circle:IShape {
        public void Draw() {
            Console.WriteLine("绘制圆形");
        }
    }
}
