using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week1.Ex6
{
    public class Profesor
    {
        public string name;
        public string faculty;
        public string specialization;
        public List<string> studentsWhosGiveTheirDegree;


        public Profesor(string name, string faculty, string specialization)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
        }

        public Profesor(string name, string faculty, string specialization, List<string> studentsWhosGiveTheirDegree)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
            this.studentsWhosGiveTheirDegree = studentsWhosGiveTheirDegree;
        }
        
    }
}
