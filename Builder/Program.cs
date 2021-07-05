using Builder.Vehicle;
using Builder.Vehicle.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            AbstractBuilder abBuilder;                          // Create Builder，相当于中间件

            RealBuilder builder = new RealBuilder();    // 实际的执行者，又称Director

            abBuilder = new ScooterBuilder();                    // 建造滑板车
            builder.Do(abBuilder);
            abBuilder.Result.Show();

            abBuilder = new MotorCycleBuilder();                 // 建造摩托车
            builder.Do(abBuilder);
            abBuilder.Result.Show();

            abBuilder = new CarBuilder();                        // 建造汽车
            builder.Do(abBuilder);
            abBuilder.Result.Show();

            Console.ReadLine();
        }
    }
}
