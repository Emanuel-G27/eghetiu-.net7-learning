using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced.T4
{
    public class Developer: Employee
    {
        private List<string> skills;
        private bool isJunior;

        public Developer(string name, int age, double salary,List<string> skills, bool isJunior)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.skills = skills;
            this.isJunior = isJunior;
        }

        public override double CalculateBonus()
        {
            double bonus;
            return bonus = Salary * 0.2;
        }
        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Skills: {skills}, Email: {Email}, Phone: {Phone}";
        }

    }
}
