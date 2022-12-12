using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Ex1
{
    public class Book
    {
        public string Title = "War and Peace";
        public string Author = "Leo Tolstoi";
        public int Year = 1869;

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
        public void SetTitle(string title)
        {
            Title = title;           
        }
        public void SetAuthor(string author)
        {
             Author = author;        
        }
        public void SetYear(int year)
        {
            Year = year;           
        }
    }
}
