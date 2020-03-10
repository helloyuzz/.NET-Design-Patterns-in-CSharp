using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MyFactory
    {
        public static AbstractFactory CreateFactory(string choice)
        {
            AbstractFactory abstractFactory = null;
            switch (choice.ToUpper())
            {
                case "COLOR":
                    abstractFactory = new ColorFactory();
                    break;
                case "SHAPE":
                    abstractFactory = new ShapeFactory();
                    break;
            }
            return abstractFactory;
        }
    }
}
