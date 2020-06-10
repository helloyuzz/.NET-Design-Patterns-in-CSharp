using System;

namespace Factory.Shape.Impl {
    class Rectangle:IShape {
        public void Draw() {
            Console.WriteLine("绘制矩形");
        }
    }
}
