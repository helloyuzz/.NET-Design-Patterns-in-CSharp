using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    public abstract class AbscractFactory {
        public abstract IColor GetColor(string type);
        public abstract IShape GetShape(string type);
    }
}
