using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Department : Company
    {
        List<Company> _subList = new List<Company>();

        public Department(string name) : base(name)
        {

        }
        public override void Add(Company department)
        {
            _subList.Add(department);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " " + name);

            // 递归遍历显示
            foreach (Company department in _subList)
            {
                department.Display(depth + 2);
            }
        }

        public override void Remove(Company department)
        {
            _subList.Remove(department);
        }
    }
}
