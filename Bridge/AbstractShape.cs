using Bridge.Draw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge {
    abstract class AbstractShape {
        protected Draw.IDraw api;
        protected AbstractShape(Draw.IDraw api) {
            this.api = api;
        }

        public abstract void Draw();
    }
}