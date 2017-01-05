using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Exercice
    {
        public delegate void DelWelcome();

        public delegate double DelSum(double x, double y);

        public static void Welcome()
        {
            Console.WriteLine("Welcome");
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
