using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();
            
            Console.WriteLine("1 + 1 = " + proxy.Add(1, 1));
            Console.WriteLine("2 - 1 = " + proxy.Sub(2, 1));
            Console.WriteLine("3 * 1 = " + proxy.Mul(3, 1));
            Console.WriteLine("4 / 1 = " + proxy.Div(4, 1));

            Console.ReadLine();
        }
    }
}
