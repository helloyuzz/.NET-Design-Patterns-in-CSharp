using AbstractFactory.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    public class ShapeFactory : AbscractFactory {
        public override IColor GetColor(string type) {
            return null;
        }

        public override IShape GetShape(string type) {
            IShape _shape = null;
            switch (type.ToUpper()) {
                case "CICLE":
                    _shape = new Cicle();
                    break;
                case "SQUARE":
                    _shape = new Square();
                    break;
                default:
                    throw new Exception("未知类型");
            }
            return _shape;
        }
    }
}
