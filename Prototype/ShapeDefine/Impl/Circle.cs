using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ShapeDefine.Impl
{
    class Circle : Shape
    {
        public Circle(string id) : base(id)
        {
            type = "圆形";
        }
        public override void Print()
        {
            Console.WriteLine("ID:" + Id + ",这是：" + type);
        }
    }
}
