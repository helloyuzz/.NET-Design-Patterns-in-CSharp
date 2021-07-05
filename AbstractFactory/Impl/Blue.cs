using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Impl {
    public class Blue : IColor {
        public void WhatColor() {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
