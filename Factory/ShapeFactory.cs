using AbstractFactory;
using Factory.Shape;
using Factory.Shape.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ShapeFactory
    {
        public IShape GetShape(String shapeType) {
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
