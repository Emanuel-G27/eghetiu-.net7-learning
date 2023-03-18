using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareAll
{
    public class OOP
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public void Share()
        {
            Console.WriteLine($"Author {Author} wrote a book named {Title} of {Pages} pages.");
        }

        public OOP(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Study { get; set; }
        public decimal Grade { get; set; }

        public Student(string name, string study, decimal grade)
        {
            Name = name;
            Study = study;
            Grade = grade;
        }

        public static void Calculator()
        {

            Console.WriteLine("CALCULATOR FUNCTION");
            int number1 = 0;
            int number2 = 0;
            int result = 0;

            Console.Write("enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");

            switch (Console.ReadLine())
            {
                case "+":
                     result = number1 + number2;
                    Console.WriteLine($"Your result: {number1}+ {number2} = {result}" );
                    break;
                case "-":
                     result = number1 - number2;
                    Console.WriteLine($"Your result: {number1}- {number2} = {result}");
                    break;
                case "*":
                     result = number1 * number2;
                    Console.WriteLine($"Your result: {number1}* {number2} = {result}");
                    break;
                case "/":
                     result = number1 / number2;
                    Console.WriteLine($"Your result: {number1}/ {number2} = {result}");
                    break;
                default:
                    Console.WriteLine("Not valid option");
                    break;
            }

            


        }
    }
}
