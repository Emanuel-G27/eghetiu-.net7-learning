



using System.Collections.Generic;
using System.ComponentModel;
using Exceptions;


//Write a program that reads a list of strings from 


//    the user and checks if they are all valid emails. If
//    any of the strings are not valid emails, throw a custom 
//    exception called InvalidEmailException.



List<int> list1 = new List<int>();
for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Insert the list of numbers!");
    int input = int.Parse(Console.ReadLine());
    list1.Add(input);
}

foreach(int item in list1)
{
    if ( item < 0 )
    {
        throw new NegativeNumberException("Invalid number");
    }           
    else
    {
        Console.WriteLine("All numbers are valid");
    }
}
    

public class NegativeNumberException: Exception
{
    public NegativeNumberException(string? message) : base(message)
    { }
}