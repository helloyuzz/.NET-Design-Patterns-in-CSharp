using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle.Impl
{
    // 汽车
    class CarBuilder:TransportBuilder
    {
        public CarBuilder()
        {
            transport = new Transport("汽车");
        }

        public override void BuildFrame()
        {
            transport["frame"] = "钛合金框架";
        }

        public override void BuildEngine()
        {
            transport["engine"] = "3.0T";
        }

        public override void BuildWheels()
        {
            transport["wheels"] = "4轮";
        }

        public override void BuildDoors()
        {
            transport["doors"] = "4门";
        }
    }
}
