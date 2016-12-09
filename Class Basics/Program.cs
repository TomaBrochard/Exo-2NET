using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Exo_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.Name = "LSDR";
            m1.Genre = "Fantasy";
            m1.ReleaseDate = new DateTime(2001, 01, 01);

            Movie m2 = new Movie()
            {
                Name = "StarWars",
                Genre = "ScFi",
                ReleaseDate = new DateTime(1986, 01, 01)
            };
            Movie m3 = new Movie()
            {
                Name = "Mon Voisin Totoro",
                Genre = "Fantastique",
                ReleaseDate = new DateTime(1988, 04, 16)
            };

            Console.WriteLine(m1);
            Console.WriteLine(m2.ToString());
            Console.WriteLine(m3.ToString());
            Console.ReadLine();

        }
    }
}
