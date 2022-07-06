using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    internal class Circle
    {
        //properties
        private double Radius;
        public Circle(double _radius)
        {
           Radius = _radius;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateFormattedCircumference()
        {
            return FormatNumber(2 * Math.PI * Radius);
        }
        public double CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        private double FormatNumber(double x)
        {
            return Math.Round(x, 2);
        }
    }
}
