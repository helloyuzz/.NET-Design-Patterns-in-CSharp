using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Book : Library
    {
        private string _title;
        public Book(string title, int numCopies) {
            _title = title;
            this.NumCopies = numCopies;
        }
        public override void Display()
        {
            Console.WriteLine("Title:{0},NumCopies:{1}",_title,NumCopies);
        }
    }
}
