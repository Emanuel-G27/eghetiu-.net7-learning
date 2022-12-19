using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Ex5
{
    public class Faculty
    {
        public string firstName;
        public string lastName;
        public double employeeId;
        public List<string> subjectsTaught;

        public Faculty(string firstName, string lastName, double employeeId, List<string> subjectsTaught)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.subjectsTaught = subjectsTaught;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public List<string> GetSubjectsTaught()
        {           
            return subjectsTaught;
        }
    }
}
