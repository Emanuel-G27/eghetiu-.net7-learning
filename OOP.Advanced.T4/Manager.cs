using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced.T4
{
    public class Manager: Employee
    {
        private Department iT;
        public Department IT { get; set; }

        public Manager(string name, int age, double salary, Department IT)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.iT = IT;
        }

        public override double CalculateBonus()
        {
            double bonus;
            return bonus = Salary * 0.1;
        }
        public override string GetContactInfo()
        {
            return $"Name: {Name}, Age: {Age}, Department:{Department.IT}, Email: {Email}, Phone: {Phone}";     
        }

    }
}
