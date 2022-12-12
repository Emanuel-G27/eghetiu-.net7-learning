using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Ex2
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

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPrice(float price)
        {
             Price = price;            
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }   

}
