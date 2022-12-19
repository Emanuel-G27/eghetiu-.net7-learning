using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Ex5
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public double StudentId;
        public double GPA;
        

        public Student(string FirstName, string LastName, double StudentId, double GPA)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StudentId = StudentId;
            this. GPA = GPA;
        }

        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
        public bool HasHonors()
        {
            if (GPA >= 3.5)
                return true;
            else
                return false;
                                                              
        }

        
                                 
                    
        

      
            
        
    }
}
