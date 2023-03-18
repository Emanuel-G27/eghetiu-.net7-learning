using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetPackageExercise
{
    public class AdoNetRepository
    {
       // public void Go()
        //{
            //var connectionString = "Server=localhost;Database=<YOUR_DB_NAME>;User Id=sa;Password=<YOUR_PASSWORD>;TrustServerCertificate=True";

            ////SqlConnection connection = new SqlConnection(connectionString);

            //// option1 - do not use
            ////connection.Open();
            ////// code block
            ////connection.Close();

            //// option2 - way better than 1
            ////try
            ////{
            ////    connection.Open();
            ////    //code block
            ////}
            ////catch(Exception ex)
            ////{
            ////    // code block
            ////}
            ////finally
            ////{
            ////    connection.Close();
            ////}

            //// option 3 - the best
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    SqlCommand readNumberOfBooks = new SqlCommand("SELECT COUNT(*) FROM books", connection);
            //    var numberOfBooks = readNumberOfBooks.ExecuteScalar();

            //    Console.WriteLine("number of books:" + numberOfBooks);

            //    SqlCommand updateBooksTitle = new SqlCommand("UPDATE books SET title = 'None' WHERE id=1", connection);
            //    var numberOfUpdatedBooks = updateBooksTitle.ExecuteNonQuery();

            //    Console.WriteLine("number of updated books:" + numberOfUpdatedBooks);

            //    Console.WriteLine("Read all books:");
            //    SqlCommand readAllBooks = new SqlCommand("SELECT * FROM books", connection);
            //    SqlDataReader allBooks = readAllBooks.ExecuteReader();
            //    List<Book> books = new List<Book>();
            //    while (allBooks.Read())
            //    {
            //        Console.WriteLine($"{allBooks["Id"]}, {allBooks["Title"]}, {allBooks[2]}");
            //        Book book = new Book
            //        {
            //            Id = (int)allBooks["Id"],
            //            Title = (string)allBooks["Title"],
            //            YearOfPublishing = (int)allBooks["YearOfPublishing"],
            //            NumberOfPages = (int)allBooks["NumberOfPages"],
            //            IsHardCover = (bool)allBooks["IsHardCover"]
            //        };

            //        books.Add(book);
            //    }

            //    Console.WriteLine("title of books: ");
            //    foreach (Book b in books)
            //    {
            //        Console.WriteLine(b.Title);
            //    }
        //}
    }
        
}
