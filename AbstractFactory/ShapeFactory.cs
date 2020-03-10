using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shapeType)
        {
            IShape shape = null;
            switch (shapeType.ToUpper())
            {
                case "CIRCLE":
                    shape = new Circle();
                    break;
                case "RECTANGLE":
                    shape = new Rectangle();
                    break;
                case "SQUARE":
                    shape = new Square();
                    break;                
            }
            return shape;
        }
    }
}
