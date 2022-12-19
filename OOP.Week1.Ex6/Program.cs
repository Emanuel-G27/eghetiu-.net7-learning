


using OOP.Week1.Ex6;

College college = new College();
college.name = "Cuza";

Student student = new Student("Edi",DateTime.Now.AddYears(-10),DateTime.Now.AddYears(-5), college , DateTime.Now.AddYears(-30) );

student.Print();
Console.WriteLine(student.IsStillStudent());




