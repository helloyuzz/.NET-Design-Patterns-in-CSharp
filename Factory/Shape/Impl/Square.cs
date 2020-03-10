using Factory.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("绘制正方形");
        }
    }
}
