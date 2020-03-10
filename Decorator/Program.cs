using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C#基础教程", 10);
            book.Display();

            Video video = new Video("星际争霸", "张艺谋", 100);
            video.Display();


            RealDecorator realDecorator = new RealDecorator(book);
            realDecorator.Borrow("成龙",3);
            realDecorator.Display();


            RealDecorator videoDecorator = new RealDecorator(video);
            videoDecorator.Borrow("李连杰",10);
            videoDecorator.Display();

            Console.ReadLine();
        }
    }
}
