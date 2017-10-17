using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Data
{
    class Circle: Shape
    {
        public Guid Id { get; private set; }
        public double Radius { get; private set; }

        public Circle(double radius, string color, int transparency)
        {
            if (radius <= 0 || transparency < 0 || transparency > 100)
                throw new ArgumentException("Invalid radius!");

            this.Id = Guid.NewGuid();
            this.Radius = radius;
            this.Color = color;
            this.Transparency = transparency;
        }

        public override double ComputeArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Circle";
        }
    }
}
