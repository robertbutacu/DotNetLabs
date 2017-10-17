using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Data
{
    abstract class Shape
    {
        public string Color { get; set; }
        public int Transparency { get; set; }

        abstract public double ComputeArea();
        public virtual Boolean IsVisible()
        {
            return Transparency >= 50;
        }
        public virtual String Draw() {
            return "Drawing " + this;
        }

    }
}
