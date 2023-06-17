using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_encapsulation
{
    internal class Rectangle
    {
        /*
        Question 2# Design a class called Rectangle with the following private properties:
        length(double)
        width(double)
        Include public methods to calculate the area and perimeter of the rectangle based on its length and width.

        */

        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        public void PrintRectangleDetails()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Perimeter: " + CalculatePerimeter());
        }
    }
}
