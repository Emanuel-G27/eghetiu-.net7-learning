using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareAll
{
    public class Car
    {
        public int NrOfWeels { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public string Describe()
        {
            return $"My car has {NrOfWeels} and {Color}";
        }
    }

    public class Audi: Car
    {
        public int YearOfFabrication { get; set; }

        public Audi(int nrOfWeels, string name, string color, double price,int yearOfFabrication)
        {
            this.NrOfWeels = nrOfWeels;
            this.Name = name;
            this.Color = color;
            this.Price = price;
            this.YearOfFabrication = yearOfFabrication;
        } 
        
    }

    public class Mercedes: Car
    {
        public int Price()
        {
            return 10 + 100;
        }
    }
}
