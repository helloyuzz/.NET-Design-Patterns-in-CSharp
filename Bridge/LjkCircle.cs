using Bridge.Draw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class LjkCircle : Shape
    {
        private int x, y, radius;

        public LjkCircle(int x, int y, int radius, DrawCircleAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public override void Draw()
        {
            drawAPI.DrawCircle(radius, x, y);
        }
    }
}