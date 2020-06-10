using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    // 定义抽象工厂类
    public abstract class AbstractFactory {
        public abstract IColor GetColor(string color);
        public abstract IShape GetShape(string shape);
    }
}