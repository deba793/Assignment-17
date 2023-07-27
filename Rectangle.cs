using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17
{
    public class Rectangle : Space
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height)
        {
            ShapeType = "Rectangle";
            Width = width;
            Height = height;
        }

        public override double Area
        {
            get { return Width * Height; }
        }

        public override double Perimeter
        {
            get { return 2 * (Width + Height); }
        }
    }
}
