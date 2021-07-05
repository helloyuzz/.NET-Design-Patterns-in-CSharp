using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle.Impl
{
    // 摩托车
    class MotorCycleBuilder:AbstractBuilder
    {
        public MotorCycleBuilder()
        {
            result = new Result("摩托车");
        }

        public override void BuildFrame()
        {
            result["frame"] = "铝合金框架";
        }

        public override void BuildEngine()
        {
            result["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            result["wheels"] = "2只";
        }

        public override void BuildDoors()
        {
            result["doors"] = "敞篷式";
        }
    }
}
