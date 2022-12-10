using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemeOOP_Week1
{
    public class Book
    {

        public string Title = "War and Peace";
        public string Author = "Leo Tolstoi";
        public int Year = 1869 ;

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
        public string SetTitle(string tit)
        {
            return Title = tit;
            Console.WriteLine(tit);
        }
        public string SetAuthor(string aut)
        {
            return Author = aut;
            Console.WriteLine(aut);
            
        }
        public int SetYear(int y)
        {
            return Year = y;
            Console.WriteLine(y);
        }
            


    }
}
