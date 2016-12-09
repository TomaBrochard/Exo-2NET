using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Shark shark = new Shark();
            Bird bird = new Bird();
            Stone stone = new Stone();
            Plane plane = new Plane();
            Boat boate = new Boat();
            Tree tree = new Tree();
            Newspaper newspaper = new Newspaper();
            Superman superman = new Superman();

            Console.WriteLine(cat);
            shark.Swim();
            bird.Breath();
            stone.Roll();
            plane.Fly();
            superman.Walk();
            Console.ReadLine();
        }
    }
}
