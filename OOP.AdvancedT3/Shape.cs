using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AdvancedT3
{
    public abstract class Shape
    {

        private double area ;
        private string color;
        public string Color { get; set; }
        public double Area { get; set; }

        public abstract double CalculateArea();
        public abstract double GetPerimeter();
    }  
}
