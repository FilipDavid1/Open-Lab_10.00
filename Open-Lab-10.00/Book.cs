using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public void SetTitle(string t)
        { 
            title = t;
        }
        public void SetPages(int p)
        {
            pages = p;
        }
        public void SetCategory(string c)
        {
            category = c;
        }
        public void SetAuthor(string a)
        {
            author = a;
        }
        public void SetReleaseDate(int r)
        {
            releaseDate = r;
        }

        public void Show()
        {
            Console.WriteLine("title:" + title);
            Console.WriteLine("pages:" + pages);
            Console.WriteLine("category:" + category);
            Console.WriteLine("author:" + author);
            Console.WriteLine("releaseDate:" + releaseDate);
        }

    }
}
