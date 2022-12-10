using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemeOOP_Week1
{
    public class Product
    {
        public string Name;
        public float Price;
        public int Quantity;

        public Product(string name, float price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string GetName()
        {
            return this.Name;
        }
        public float GetPrice()
        {
            return this.Price;
        }
        public int GetQuantity()
        {
            return this.Quantity;
        }

        public string SetName(string n)
        {
            return Name = n;
            Console.WriteLine(n);
        }
        public float SetPrice(float p)
        {
            return Price = p;
            Console.WriteLine(p);
        }
        public int SetQuantity(int q)
        {
            return Quantity = q;
            Console.WriteLine(q);
        }
    }
}
