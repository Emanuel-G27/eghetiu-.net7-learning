
using OOP.Advanced.T4;
using System;

Manager manager = new Manager("John Doe", 35, 50000, Department.IT);
Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

Console.WriteLine(manager.CalculateBonus()); 
Console.WriteLine(developer.CalculateBonus()); 

Console.WriteLine(manager.GetContactInfo());