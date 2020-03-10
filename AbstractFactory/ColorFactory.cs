using AbstractFactory.Color.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{    
    class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            IColor color = null;
            switch (colorType.ToUpper()) {
                case "RED":
                    color = new Red();
                    break;
                case "GREEN":
                    color = new Green();
                    break;
                case "BLUE":
                    color = new Blue();
                    break;
            }
            return color;
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
