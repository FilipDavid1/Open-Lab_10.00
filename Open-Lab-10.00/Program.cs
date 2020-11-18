using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
           Book Lotr = new Book();
           
           Lotr.Title = "Vychytávky Ladi Hrusky";
           Lotr.Pages = 800;
           Lotr.Category = "vychytavky";
           Lotr.Author = "Lada Hruska";
           Lotr.ReleaseDate = 2018;

           Lotr.Show();

        }
    }
}
