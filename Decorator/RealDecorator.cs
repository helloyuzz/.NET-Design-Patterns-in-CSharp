using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class RealDecorator : Decorator
    {
        protected List<string> _list = new List<string>();

        public RealDecorator(Library libraryItem) : base(libraryItem)
        {
        }

        public void Borrow(string name, int numCopies)
        {
            _list.Add(name);
            libraryItem.NumCopies -= numCopies;
        }
        public void Return(string name, int numCopies)
        {
            _list.Remove(name);
            libraryItem.NumCopies += numCopies;
        }
        public override void Display()
        {
            base.Display();

            foreach (string borrower in _list)
            {
                Console.WriteLine("借阅者:" + borrower);
            }
        }
    }
}
