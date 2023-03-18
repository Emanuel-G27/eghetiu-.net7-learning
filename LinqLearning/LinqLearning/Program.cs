using System.Linq;
using LinqLearning;


var myBooks = new List<Book>
{
    new Book(){Title = "Advanced C#", Price = 10.23},
    new Book(){Title = "OOP in C#", Price = 9.99},
    new Book(){Title = "Linq", Price = 7.99},
    new Book(){Title = "Entity Framework Core ", Price = 34.99}
};

var mynewbook = myBooks.Where(book => book.Title.Contains("C#")).OrderBy(b => b.Price);
foreach(var item in mynewbook)
{
    Console.WriteLine(item.Title);
}

int[,] array = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 23, 45, 67, 21 } };
foreach(var item in array)
{
    if(item % 2 == 0)
    {
        Console.WriteLine(item);
    }
}