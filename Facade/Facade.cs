using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        private SubSystemOne subSystemOne;
        private SubSystemTwo subSystemTwo;
        private SubSystemThree subSystemThree;
        private SubSystemFour subSystemFour;

        public Facade()
        {
            subSystemOne = new SubSystemOne();
            subSystemTwo = new SubSystemTwo();
            subSystemThree = new SubSystemThree();
            subSystemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            subSystemOne.MethodOne();
            subSystemTwo.MethodTwo();
            subSystemFour.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            subSystemTwo.MethodTwo();
            subSystemThree.MethodThree();
        }
    }
}
