using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle {
    class RealBuilder {
        public void Do(AbstractBuilder aBuilder) {
            aBuilder.BuildFrame();
            aBuilder.BuildEngine();
            aBuilder.BuildWheels();
            aBuilder.BuildDoors();
        }
    }
}