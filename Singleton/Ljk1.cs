using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Ljk1
    {
        private List<DbServer> _servers = new List<DbServer>();
        public Ljk1()
        {
            _servers = new List<DbServer>
                {
                 new DbServer{ Name = "Server-1", IP = "10.0.0.1" },
                 new DbServer{ Name = "Server-2", IP = "10.0.0.2" },
                 new DbServer{ Name = "Server-3", IP = "10.0.0.3" },
                 new DbServer{ Name = "Server-4", IP = "10.0.0.4" },
                 new DbServer{ Name = "Server-5", IP = "10.0.0.5" },
                };
        }
        private static readonly Ljk1 _instance = new Ljk1();
        public static Ljk1 GetInstance()
        {
            return _instance;
        }

        private Random _random = new Random();

        public DbServer NextDbServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
