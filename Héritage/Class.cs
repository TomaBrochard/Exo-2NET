using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    #region Class
        class Cat : Animal, IRollable, IWalkable, IAlive
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Breath()
            {
                Console.WriteLine(GetType() + " Breathing");
            }

            public void Walk()
            {
                Console.WriteLine(GetType() + " Walking");
            }

            public void Roll()
            {
                Console.WriteLine(GetType() + " Rolling");
            }
        }
        class Shark : Animal, ISwimmable, IAlive
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Breath()
            {
                Console.WriteLine(GetType() + " Breathing");
            }

            public void Swim()
            {
                Console.WriteLine(GetType() + " Swimming");
            }
        }
        class Bird : Animal, IFlyable, IAlive
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Breath()
            {
                Console.WriteLine(GetType() + " Breathing");
            }

            public void Fly()
            {
                Console.WriteLine(GetType() + " Flying");
            }
        }
        class Stone : MineralVegetal, IRollable
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Roll()
            {
                Console.WriteLine(GetType() + " Rolling");
            }
        }
        class Plane : Vehicule, IFlyable
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Fly()
            {
                Console.WriteLine(GetType() + " Flying");
            }
        }
        class Boat : Vehicule, ISwimmable
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Swim()
            {
                Console.WriteLine(GetType() + " Swimming");
            }
        }
        class Tree : MineralVegetal, IAlive
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Breath()
            {
                Console.WriteLine(GetType() + " Breathing");
            }
        }
        class Newspaper : IRollable
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Roll()
            {
                Console.WriteLine(GetType() + " Rolling");
            }
        }
        class Superman : Animal, IFlyable, ISwimmable, IRollable, IWalkable, IAlive
        {
            public override string ToString()
            {
                return "Je suis un " + GetType();
            }

            public void Breath()
            {
                Console.WriteLine(GetType() + " Breathing");
            }

            public void Walk()
            {
                Console.WriteLine(GetType() + " Walking");
            }

            public void Roll()
            {
                Console.WriteLine(GetType() + " Rolling");
            }

            public void Swim()
            {
                Console.WriteLine(GetType() + " Swimming");
            }

            public void Fly()
            {
                Console.WriteLine(GetType() + " Flying");
            }
        }
    #endregion
}
