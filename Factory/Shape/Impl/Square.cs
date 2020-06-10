using Factory.Shape;
using System;

namespace AbstractFactory {
    class Square:IShape {
        public void Draw() {
            Console.WriteLine("绘制正方形");
        }
    }
}