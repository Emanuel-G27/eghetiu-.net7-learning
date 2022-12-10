

using TemeOOP_Week1;

Book book = new Book("War and Peace", "Leo Tolstoi", 1869);

Console.WriteLine(book.GetTitle()); 
Console.WriteLine(book.GetAuthor()); 
Console.WriteLine(book.GetYear());

Console.WriteLine();

book.SetTitle("Anna Karenina"); 
book.SetAuthor("Leo Toltoi");
book.SetYear(1877);

Console.WriteLine();

Console.WriteLine(book.GetTitle()); 
Console.WriteLine(book.GetAuthor()); 
Console.WriteLine(book.GetYear()); 