using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemeOOP2
{
    public class Animal
    {
        public string Name;
        public string Species;
        public string Breed;
        public int Age;
        public string Color;
        public double Weight;
        public bool isSpayedOrNeutered;
       

        public Animal(string name, string species, string breed, int age, string color, double weight, bool isSpayedOrNeutered)
        {
            this.Name = name;
            this.Species = species;
            this.Breed = breed;
            this.Age = age;
            this.Color = color;
            this.Weight = weight;
            this.isSpayedOrNeutered = isSpayedOrNeutered;
                
        }

        public string GetName() 
        {
            return this.Name;
        }
        public string GetSpecies()
        {
            return this.Species;
        } 

        public string GetBreed() 
        {
            return this.Breed;
        }
        public int GetAge()
        {
            return this.Age;
        }                   
        public string GetColor()
        {
            return this.Color;
        }
        public double GetWeight()
        {
            return this.Weight;
        }
        public bool IsSpayedOrNeutered()
        {
            return this.isSpayedOrNeutered;
        }
        public void SetName(string name)
        {
             Name = name;          
        }
        public void SetSpecies(string species)
        {
            Species = species;          
        }
        public void SetBreed(string breed)
        {
            Breed = breed;          
        }
        public void SetAge(int age)
        {
            Age = age;          
        }
        public void SetColor(string color) 
        { 
            Color = color;           
        }
        public void SetWeight(double weight)
        {
             Weight = weight;           
        }
        public void SetIsSpayedOrNeutered(bool isSpayedOrNeutered)
        {
            this.isSpayedOrNeutered = isSpayedOrNeutered;         
        }

    }
}
