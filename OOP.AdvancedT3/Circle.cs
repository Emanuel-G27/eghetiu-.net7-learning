using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AdvancedT3
{
    public class Circle: Shape
    {
        private double radius;              
        public Circle(string color, double radius)
        {
            this.Color = color;
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            double pi = 3.14159265;
            return Area = pi * Math.Pow(radius, 2);
        }
        public override double GetPerimeter()
        {
            double pi = 3.14159265;
            double circumference;
            return circumference = 2 * radius * pi;
        }
        public string GetPerimeter(int feet)
        {
            return "Circumference:" + feet;
        }
    }
}
