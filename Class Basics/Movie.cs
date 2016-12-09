using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Exo_Movie
{
    class Movie
    {
        public string Name;
        public string Genre;
        public DateTime ReleaseDate;
        

        public override string ToString()
        {
            return "Movie named " + Name + " released the " + ReleaseDate + " : " + Genre;
        }
    }
}
