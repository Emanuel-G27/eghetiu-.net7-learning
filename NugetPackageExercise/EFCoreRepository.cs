

namespace NugetPackageExercise
{
    public class EFCoreRepository
    {
        public void Go()
        {
             using(var context = new DBPracticeContext())
             {
                int numberOfBooks = context.Books.Count();
                Console.WriteLine("Number of books = " + numberOfBooks);

                var books = context.Books.ToList();
                foreach(var book in books)
                {
                    Console.WriteLine($"{book.Id}, {book.Title}");
                }

                var firstBook = books.First();
                firstBook.Title = "Test123";
                context.Books.Update(firstBook);
                context.SaveChanges();

                var bookByTitle = context.Books.Where(b => b.Title == "Title5").First();
                Console.WriteLine(bookByTitle.Id);
                Console.WriteLine(bookByTitle.Title);
             }
        }
    }
}
