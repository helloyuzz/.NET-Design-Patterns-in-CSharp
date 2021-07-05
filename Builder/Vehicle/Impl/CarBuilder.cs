using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle.Impl {
    // 汽车
    class CarBuilder : AbstractBuilder {
        public CarBuilder() {
            result = new Result("汽车");
        }

        public override void BuildFrame() {
            result["frame"] = "钛合金框架";
        }

        public override void BuildEngine() {
            result["engine"] = "3.0T";
        }

        public override void BuildWheels() {
            result["wheels"] = "4轮";
        }

        public override void BuildDoors() {
            result["doors"] = "4门";
        }
    }
}