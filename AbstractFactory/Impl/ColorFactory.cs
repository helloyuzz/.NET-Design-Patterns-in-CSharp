using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Impl {
    public class ColorFactory : AbscractFactory {
        public override IColor GetColor(string type) {
            IColor _color = null;
            switch (type.ToUpper()) {
                case "RED":
                    _color = new Red();
                    break;
                case "BLUE":
                    _color = new Blue();
                    break;
                default:
                    throw new Exception("未知类型");
            }
            return _color;
        }

        public override IShape GetShape(string type) {
            return null;
        }
    }
}
