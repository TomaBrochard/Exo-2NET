using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "James", "John", "Katie", "Mark", "Patrick",
                "Bob", "Rupert", "Brian", "Kevin", "Walter"
             };

            foreach (string n in names.SortByLastLetter())
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
