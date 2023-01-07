using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced.Homework6
{
    public class Rectangle : IShape, IColor
    {
        private double width;
        private double height;       
        public double Area { get; set; }

        public string Color { get; set; }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            this.Color = "Black";
        }
        public Rectangle(double width, double height, string color)
        {
            this.width = width;
            this.height = height;
            this.Color = color;

        }
        public double CalculateArea()
        {
            return this.Area = width * height;
        }
        public string CalculateArea(string unitOfMeasurement)
        {
            return $"Area: {Area} {unitOfMeasurement}";
        }
           
           
    }
}