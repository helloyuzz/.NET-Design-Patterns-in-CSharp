﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Color.Impl
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("这是蓝色");
        }
    }
}
