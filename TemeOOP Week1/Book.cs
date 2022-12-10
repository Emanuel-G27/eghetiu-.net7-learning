using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemeOOP_Week1
{
    public class Book
    {

        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
        public string GetTitle()
        {
            return Title;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetTitle()
        {
            Title = "Anna Karenina";
            Console.WriteLine(Title);
        }
        public void SetAuthor()
        {
            Author = "Leo Tolstoi";
            Console.WriteLine(Author);
        }
        public void SetYear()
        {
            Year = 1877;
            Console.WriteLine(Year);
        }
            


    }
}
