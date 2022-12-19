using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Ex5
{
    public class University 
    {
        public string name;
        public List<Student> students { get; set; }
        public List<Faculty> faculties { get; set; }

        public University(string name)
        {
            this.name = name;
            students = new List<Student>();
            faculties = new List<Faculty>();
        }

        

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
        public int GetStudentCount()
        {
            return students.Count;
        }
        public int GetFacultyCount()
        {
            return faculties.Count;
        }

      



    }
}
