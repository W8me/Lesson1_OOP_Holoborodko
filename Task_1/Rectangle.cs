using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Rectangle
    {
        private readonly double side1, side2;

        public Rectangle(double x, double y)
        {
            this.side1 = x;
            this.side2 = y;
        }

       public double AreaCalculator()
        {
            double s = side1 * side2;
            return s;
        }

        public double PerimeterCalculator()
        {
            double p = (side1 + side2) * 2;
            return p;
        }

    }
}
