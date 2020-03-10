using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle
{
    abstract class TransportBuilder
    {
        protected Transport transport;

        // Gets Transport instance
        public Transport Transport
        {
            get { return transport; }
        }

        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
