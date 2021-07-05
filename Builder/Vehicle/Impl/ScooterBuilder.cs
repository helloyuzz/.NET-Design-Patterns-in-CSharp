using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle.Impl
{
    class ScooterBuilder:AbstractBuilder
    {
        public ScooterBuilder()
        {
            result = new Result("滑板车");
        }

        public override void BuildFrame()
        {
            result["frame"] = "木质框架";
        }

        public override void BuildEngine()
        {
            result["engine"] = "一碗米饭";
        }

        public override void BuildWheels()
        {
            result["wheels"] = "4只滑轮";
        }

        public override void BuildDoors()
        {
            result["doors"] = "敞篷式";
        }
    }
}
