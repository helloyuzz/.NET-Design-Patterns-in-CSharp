using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ShapeDefine.Impl {
    class Square:Shape {
        public Square(string id) : base(id) {
            type = "正方形";
        }
        public override void Print() {
            Console.WriteLine("这是：" + type + "Shape ID:" + Id);
        }
    }
}