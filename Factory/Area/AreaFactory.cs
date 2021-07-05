using Factory.Area.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Area {
    public class AreaFactory {
        public IAction GetAction(string type) {
            IAction _action = null;
            switch (type) {
                case "Department":
                    _action = new Department();
                    break;
                case "Employee":
                    _action = new Employee();
                    break;
                default:
                    throw new Exception("未知类型");
            }
            return _action;
        }
    }
}
