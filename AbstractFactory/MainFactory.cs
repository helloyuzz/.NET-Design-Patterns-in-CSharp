using AbstractFactory.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    public  class MainFactory {
        public static AbscractFactory GetFactory(string type) {
            AbscractFactory abscractFactory = null;
            switch (type) {
                case "shape":
                    abscractFactory = new ShapeFactory();
                    break;
                case "color":
                    abscractFactory = new ColorFactory();
                    break;
            }
            return abscractFactory;
        }
    }
}
