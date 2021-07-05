using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    class ShapeManager {
        private Dictionary<string, Shape> _colors = new Dictionary<string, Shape>();

        // Indexer
        public Shape this[string key] {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}