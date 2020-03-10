using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Ljk
    {
        private static Ljk _instance;
        private List<DbServer> _servers = new List<DbServer>();
        public Ljk()
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


        private static object syncLock = new object();
        public static Ljk GetInstance() {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Ljk();
                    }
                }
            }

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
