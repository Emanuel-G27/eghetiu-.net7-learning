using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced.Homework6
{
    public interface IShape
    {
        public double CalculateArea();
    }
    public interface IColor
    {
         string Color { get; set; }
    }
}
