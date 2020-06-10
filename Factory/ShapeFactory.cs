using AbstractFactory;
using Factory.Shape;
using Factory.Shape.Impl;
using System;

namespace Factory {
    class ShapeFactory {
        public IShape GetShape(String shapeType) {
            IShape shape = null;
            switch(shapeType.ToUpper()) {
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
