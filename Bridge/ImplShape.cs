using Bridge.Draw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge {
    class ImplShape : AbstractShape {
        private int x, y, radius;

        public ImplShape(int x, int y, int radius, Draw.IDraw api) : base(api) {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public override void Draw() {
            api.DrawCircle(radius, x, y);
        }
    }
}