using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int age;
        public string gender;

        public Person(string FirstName, string LastName, int age, string gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.age = age;

            if (gender != "male" && gender != "female")
            {
                throw new Exception("Gender is not valid");
            }
                
            this.gender = gender;


        }

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is {0} {1} and I am {2},and I am a {3}", FirstName, LastName, age, gender);
        }


        
	

      

            
    }
}
