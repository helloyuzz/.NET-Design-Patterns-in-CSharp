using Builder.Vehicle;
using Builder.Vehicle.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {            
            TransportBuilder transportBuilder;                          // Create Builder，相当于中间件

            RealConstructor realConstructer = new RealConstructor();    // 实际的执行者，又称Director
            
            transportBuilder = new ScooterBuilder();                    // 建造滑板车
            realConstructer.Construct(transportBuilder);                
            transportBuilder.Transport.ShowResult();

            transportBuilder = new MotorCycleBuilder();                 // 建造摩托车
            realConstructer.Construct(transportBuilder); 
            transportBuilder.Transport.ShowResult();

            transportBuilder = new CarBuilder();                        // 建造汽车
            realConstructer.Construct(transportBuilder);
            transportBuilder.Transport.ShowResult();

            Console.ReadLine();
        }
    }
}
