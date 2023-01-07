using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced.Homework6
{
    public class Circle : IShape, IColor
    {      
        public double Area { get; set; }
        private double radius;
        public double CalculateArea()
        {            
            return this.Area = Math.PI * Math.Pow(radius, 2);
        }
        public string Color { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
            this.Color = "Black";
        }
        public Circle(double radius, string color)
        {
            this.Color = color;
            this.radius = radius;
        } 
        
        public string CalculateArea(string unitOfMeasurement)
        {
            return $"Area: {Area} {unitOfMeasurement}";
        }
    

    }
}
