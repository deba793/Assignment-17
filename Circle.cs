using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17
{
    public class Circle : Space
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            ShapeType = "Circle";
            Radius = radius;
        }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * Radius; }
        }
    }
}
