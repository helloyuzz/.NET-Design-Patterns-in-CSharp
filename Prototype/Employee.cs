using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Employee
    {
        public Employee() {
            Console.WriteLine("-------------------------------------");
        }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
