using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AskValues();
            }
            catch (System.Exception e)
            {
               Console.WriteLine(e.Message);
               Main(args);

            }

            Console.ReadLine();
        }

        static void AskValues()
        {
            float f1;
            float f2;
            int operateur;

            Console.Write("Entrez un premier nombre : ");
            if (float.TryParse(Console.ReadLine(), out f1))
            {
                Console.Write("Entrez un deuxieme nombre : ");
                if (float.TryParse(Console.ReadLine(), out f2))
                {
                    Console.Write("Entrez un operateur (0: '+', 1: '-', 2: 'x', 3: '/') :");
                    if (int.TryParse(Console.ReadLine(), out operateur))
                    {
                        if ( operateur >= 0 && operateur < 4)
                        {
                            if (operateur == 3 && f2 == 0.0f)
                                throw new System.Exception("Division par 0");
                            Console.WriteLine(Compute(f1, f2, operateur));
                        }
                        else throw new System.Exception("Operateur n'est pas '+', '-', 'x', '/'");
                    }
                    else throw new System.Exception("Operateur non compris");
                }
                else throw new System.Exception("Deuxieme nombre non compris");
            }
            else throw new System.Exception("Premier nombre non compris");
        }

        static float Compute(float n1, float n2, int operation)
        {
            switch (operation)
            {
                case 0:
                    return n1 + n2;
                case 1:
                    return n1 - n2;
                case 2:
                    return n1 * n2;
                case 3:
                    return n1 / n2;
                default:
                    throw new System.Exception("Probleme de switch");
            }
        }
    }
}
