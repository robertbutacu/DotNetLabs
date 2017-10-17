using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Data
{
    class Rectangle: Shape
    {
        public Guid Id { get; private set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width, String color, int transparency)
        {
            if (height <= 0 || width <= 0 || transparency < 0 || transparency > 100)
                throw new ArgumentException("Invalid arguments!");

            this.Id = Guid.NewGuid();
            this.Height = height;
            this.Width = width;
            this.Color = color;
            this.Transparency = transparency;
        }

        public override double ComputeArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle";
        }
    }
}
