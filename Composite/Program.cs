using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Department root = new Department("劳吉克");
            root.Add(new Employee("aa"));
            root.Add(new Employee("bb"));

            Department zjb = new Department("总经办");
            zjb.Add(new Employee("叶梦兰"));
            zjb.Add(new Employee("谭晓丽"));

            root.Add(zjb);    

            root.Display(1);
            Console.ReadLine();
        }
    }
}
