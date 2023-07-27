using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of different shapes
            Circle circle = new Circle(7);
            Rectangle rectangle = new Rectangle(5, 7);
            Triangle triangle = new Triangle(7, 8, 3);

            // Printing information about each shape
            Console.WriteLine("Circle Information:");
            circle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Information:");
            rectangle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Triangle Information:");
            triangle.PrintInfo();
        }
    }
}
