using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    class Rectangle:Shape {
        public Rectangle(string id) : base(id) {
            type = "矩形";
        }
        public override void Print() {
            Console.WriteLine("SHAPE ID:" + Id + ",这是：" + type);
        }
    }
}