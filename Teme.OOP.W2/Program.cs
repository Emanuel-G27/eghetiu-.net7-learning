



using System;
using Teme.OOP.W2;

Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

Console.WriteLine(book.GetTitle()); 
Console.WriteLine(book.GetAuthor()); 
Console.WriteLine(book.GetPageCount()); 
Console.WriteLine(book.GetCurrentPage());

book.NextPage();
Console.WriteLine(book.GetCurrentPage()); 

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage()); 

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage()); 

book.Title = "The Great Gatsby (Revised Edition)";
Console.WriteLine(book.GetTitle()); 

book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
Console.WriteLine(book.GetAuthor()); 