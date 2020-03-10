using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle.Impl
{
    class ScooterBuilder:TransportBuilder
    {
        public ScooterBuilder()
        {
            transport = new Transport("滑板车");
        }

        public override void BuildFrame()
        {
            transport["frame"] = "木质框架";
        }

        public override void BuildEngine()
        {
            transport["engine"] = "一碗米饭";
        }

        public override void BuildWheels()
        {
            transport["wheels"] = "4只滑轮";
        }

        public override void BuildDoors()
        {
            transport["doors"] = "敞篷式";
        }
    }
}
