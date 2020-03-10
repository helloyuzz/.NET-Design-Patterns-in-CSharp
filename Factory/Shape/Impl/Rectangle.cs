using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Shape.Impl
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("绘制矩形");
        }
    }
}
