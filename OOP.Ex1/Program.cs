


using OOP.Ex1;

Book book = new Book("War and Peace", "Leo Tolstoy", 1869);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());

book.SetTitle("Anna Karenina");
book.SetAuthor("Leo Tolstoy");
book.SetYear(1877);

Console.WriteLine();

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());