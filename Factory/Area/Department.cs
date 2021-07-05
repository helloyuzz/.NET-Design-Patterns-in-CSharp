using Factory.Area.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Area {
    public class Department : IAction {
        public string GetName() {
            Console.WriteLine(this.GetType().Name);
            return this.GetType().Name;
        }
    }
}
