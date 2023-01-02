using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced.T4
{
    public abstract class Employee
    {
        private string email;
        private double phone;
        public double Phone
        {
            get { return phone = 3768453627; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email = "john d."; }
            set { email = value; }
        }
                     
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }


        public abstract double CalculateBonus();
        public virtual string GetContactInfo()
        {
            return this.email + this.phone;
        }                                                 
    }
    public enum Department
    {
        HR,
        IT,
        Sales,
        Marketing
    }
}
