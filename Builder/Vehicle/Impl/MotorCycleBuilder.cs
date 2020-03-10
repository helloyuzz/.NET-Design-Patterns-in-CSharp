using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle.Impl
{
    // 摩托车
    class MotorCycleBuilder:TransportBuilder
    {
        public MotorCycleBuilder()
        {
            transport = new Transport("摩托车");
        }

        public override void BuildFrame()
        {
            transport["frame"] = "铝合金框架";
        }

        public override void BuildEngine()
        {
            transport["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            transport["wheels"] = "2只";
        }

        public override void BuildDoors()
        {
            transport["doors"] = "敞篷式";
        }
    }
}
