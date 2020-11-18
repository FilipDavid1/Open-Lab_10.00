using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
           Book Lotr = new Book();
           
           Lotr.SetTitle("Vychytávky Ladi Hrusky");
           Lotr.SetPages(800);
           Lotr.SetCategory("vychytavky");
           Lotr.SetAuthor("Lada Hruska");
           Lotr.SetReleaseDate(2018);

           Lotr.Show();

        }
    }
}
