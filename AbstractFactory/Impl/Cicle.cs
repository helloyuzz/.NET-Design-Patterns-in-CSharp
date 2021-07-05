using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Impl {
    public class Cicle : IShape {
        public void DrawShape() {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
