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

        public string Title
        {
            get => title;

            set => title = value;
        }

       public int Pages
       {
           get => this.pages;
           set
           {
               if (pages < 1)
               {
                   pages = 1;
               }
               else
               {
                   pages = value;
               }
           }
       }

       public string Category
       {
           get => category;

           set => category = value;
        }

       public string Author
       {
           get => author;

           set => author = value;
        }

       public int ReleaseDate
       {
           get => this.releaseDate;
           set
           {
               if (releaseDate < 1450 || releaseDate > 2020)
               {
                   releaseDate = -1;
               }
               else
               {
                   releaseDate = value;
               }
           }
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
