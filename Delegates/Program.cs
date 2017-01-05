using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice.DelWelcome well = Exercice.Welcome;
            Exercice.DelSum somme = Exercice.Sum;
            well();
            Console.WriteLine(somme(4, 5));
            Console.Read();
        }
    }
}
