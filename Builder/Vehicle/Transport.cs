using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicle
{
    // 交通工具
    class Transport
    {
        private string _transportType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Transport(string transportType)
        {
            this._transportType = transportType;
        }
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void ShowResult()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(" #类型: {0}", _transportType);
            Console.WriteLine(" #框架: {0}", _parts["frame"]);
            Console.WriteLine(" #排量: {0}", _parts["engine"]);
            Console.WriteLine(" #轮胎: {0}", _parts["wheels"]);
            Console.WriteLine(" #门数: {0}", _parts["doors"]);
        }
    }
}
