using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Video : Library
    {
        private string _title;
        private string _director;
        public Video(string _title, string _director, int numCopies) {
            this._director = _director;
            this._title = _title;
            this.NumCopies = numCopies;
        }
        public override void Display()
        {
            Console.WriteLine("Video Title:{0},Director:{1},NumCopies:{2}",_title,_director,NumCopies);
        }
    }
}
