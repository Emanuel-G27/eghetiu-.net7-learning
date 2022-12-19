

using OOP.Ex5;


University myUniversity = new University("My University");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, new List<string>() {"Math", "Physics" });
Faculty bob = new Faculty("Bob", "Smith", 222222, new List<string>() {"English", "History" });

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); 
Console.WriteLine(myUniversity.GetFacultyCount()); 
