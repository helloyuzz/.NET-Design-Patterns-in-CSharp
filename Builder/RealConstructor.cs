using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle
{
    class RealConstructor
    {
        public void Construct(TransportBuilder transportBuilder)
        {
            transportBuilder.BuildFrame();
            transportBuilder.BuildEngine();
            transportBuilder.BuildWheels();
            transportBuilder.BuildDoors();
        }
    }
}
