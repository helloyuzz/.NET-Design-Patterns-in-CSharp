using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    abstract class Shape : ICloneable {
        private string _id;
        protected string type;
        public abstract void Print();

        public Shape() {
        }

        // Constructor
        public Shape(string id) {
            this._id = id;
        }

        // Gets id
        public string Id {
            get {
                return _id;
            }
        }
        public object Clone() {
            Object clone = base.MemberwiseClone();
            return clone;
        }
    }
}