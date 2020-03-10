using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Employee : Company
    {
        public Employee(string name) : base(name)
        {
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " " + name);
        }
        public override void Add(Company c)
        {
            // 无须实现
        }
        public override void Remove(Company c)
        {
            // 无须实现
        }
    }
}