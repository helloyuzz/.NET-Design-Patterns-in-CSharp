using System;

namespace AbstractFactory {
    class Program {
        static void Main(string[] args) {
            AbscractFactory abscractFactory1 = MainFactory.GetFactory("color");
            abscractFactory1.GetColor("red").WhatColor();
            abscractFactory1.GetColor("blue").WhatColor();


            AbscractFactory abscractFactory2 = MainFactory.GetFactory("shape");
            abscractFactory2.GetShape("cicle").DrawShape();
            abscractFactory2.GetShape("square").DrawShape();




            Console.ReadLine();
        }
    }
}