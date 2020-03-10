using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Ljk singleton1 = Ljk.GetInstance();
            Ljk singleton2 = Ljk.GetInstance();
            Ljk singleton3 = Ljk.GetInstance();
            Ljk singleton4 = Ljk.GetInstance();           

            if (object.ReferenceEquals(singleton1, singleton2) && object.ReferenceEquals(singleton2, singleton3) && object.ReferenceEquals(singleton3, singleton4))
            {
                Console.WriteLine("相同\r\n");
            }

            if (singleton1 == singleton2 && singleton2 == singleton3 && singleton3 == singleton4)
            {
                Console.WriteLine("相同\r\n");
            }
            else {
                Console.WriteLine("不同\r\n");
            }

            Ljk singleton = Ljk.GetInstance();
            for (int i = 0; i < 15; i++)
            {
                DbServer dbServer = singleton.NextDbServer;

                Console.WriteLine("服务器名称：{0}，IP地址：-{1}: ", dbServer.Name, dbServer.IP);
            }


            /*
              另一种.NET解决方案，Singleton模式只使用一个私有构造函数和一个延迟初始化的静态readonly实例变量。
              其中，线程安全由编译器保证。
             

            Ljk1 singleton_1 = Ljk1.GetInstance();
            Ljk1 singleton_2 = Ljk1.GetInstance();
            Ljk1 singleton_3 = Ljk1.GetInstance();
            Ljk1 singleton_4 = Ljk1.GetInstance();

            if (singleton_1 == singleton_2 && singleton_2 == singleton_3 && singleton_3 == singleton_4)
            {
                Console.WriteLine("相同\r\n");
            }
            else
            {
                Console.WriteLine("不同\r\n");
            }
            for (int i = 0; i < 15; i++)
            {
                DbServer dbServer = singleton_1.NextDbServer;

                Console.WriteLine("服务器名称：{0}，IP地址：-{1}: ", dbServer.Name, dbServer.IP);
            }
            */

            Console.ReadLine();
        }
    }
}