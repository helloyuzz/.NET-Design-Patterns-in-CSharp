﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Draw.Impl {
    class RedCircle : IDraw {
        public void DrawCircle(int radius, int x, int y) {
            Console.WriteLine(string.Format("Color:Red,radius:{0},x:{1},y{2}", radius, x, y));
        }
    }
}