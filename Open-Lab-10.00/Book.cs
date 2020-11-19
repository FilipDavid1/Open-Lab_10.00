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
        /// <summary>
        /// Creates list of categories for books.
        /// </summary>
        public static List<string> categoryList = new List<string>(){ "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

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
               if (value< 1)
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
               if (value < 1450 || value > 2020)
               {
                   releaseDate = -1;
               }
               else
               {
                   releaseDate = value;
               }
           }
       }
       
       public Book()
       {
           title = "-1";
           pages = -1;
           category = "-1";
           author = "-1";
           releaseDate = -1;
       }

       public Book(string title, int pages)
       {
           Title = title;
           Pages = pages;
           category = "-1";
           author = "-1";
           releaseDate = -1;
        }

       public Book(string title, int pages, string category, string author, int releaseDate)
       {
           Title = title;
           Pages = pages;
           Category = category;
           Author = author;
           ReleaseDate = releaseDate;
       }


        public void Show()
        {
            Console.WriteLine("title:" + title);
            Console.WriteLine("pages:" + pages);
            Console.WriteLine("category:" + category);
            Console.WriteLine("author:" + author);
            Console.WriteLine("releaseDate:" + releaseDate);
            Console.WriteLine(" ");
        }

    }
}
