using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teme.OOP.W2
{
    public class Book
    {
        private string title;
        private string author;
        private int pageCount;
        private int currentPage = 1;

        public Book(string title, string author, int pageCount)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int PageCount { get; set; }
        public int CurrentPage { get; set; }

        public string GetTitle()
        {
            return title;
        }
        public string GetAuthor()
        {
            return author;
        }
        public int GetPageCount()
        {
            return pageCount;
        }
        public int GetCurrentPage()
        {
            return currentPage;
        }
        public void NextPage()
        {
            currentPage++;
        }
        public void PreviousPage()
        {
            currentPage--;
        }
    }
}
