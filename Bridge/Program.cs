using Bridge.Draw.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new LjkCircle(100, 100, 10, new RedCircle());
            Shape greenCircle = new LjkCircle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();

            Console.ReadLine();
        }
    }
}
