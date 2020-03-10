using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // 矩形
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("绘制矩形");
        }
    }
}
