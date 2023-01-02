using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AdvancedT3
{
    public class Rectangle: Shape
    {
        private double width;
        private double height;

        public Rectangle(string color, double width, double height)
        {
            this.Color = color;
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return Area = this.width * this.height;
        }

        public override double GetPerimeter()
        {
            double perimeter;
            return perimeter = 2 * (this.width + this.height);
        }
        public string GetPerimeter(int meters)
        {
            return "Perimeter :" + meters;
        }
    }
}
