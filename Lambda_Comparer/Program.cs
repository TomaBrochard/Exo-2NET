using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Comparer
{
    class Program
    {
        private static List<Animal> Animals;

        private static Random rng = new Random();

        static void Main(string[] args)
        {
            Animals = new List<Animal>
            {
                new Dog("Rex", 1, "Poulet"),
                new Dog("Toby", 2, "Chat"),
                new Dog("Pilou", 3, "Humain"),
                new Cat("Mistigrie", 1),
                new Cat("Tigrou", 2),
                new Cat("Garfield", 3)
            };

            Console.WriteLine("GetAllDogs :");
            foreach (var dog in GetAllDogs())
                Console.WriteLine(dog);

            Console.WriteLine(Environment.NewLine + "GetAllCats :");
            foreach (var cat in GetAllCats())
                Console.WriteLine(cat);

            Console.WriteLine(Environment.NewLine + "GetEvenAgedOnes :");
            foreach (var ani in GetEvenAgedOnes())
                Console.WriteLine(ani);

            Console.WriteLine(Environment.NewLine + "Search(a) :");
            foreach (var ani in Search("a"))
                Console.WriteLine(ani);

            Console.WriteLine(Environment.NewLine + "GetPuppies(a) :");
            foreach (var dog in GetPuppies())
                Console.WriteLine(dog);


            Console.WriteLine(Environment.NewLine + "GetRandom X 10 :");
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());

            Console.ReadLine();
        }
        static List<Dog> GetAllDogs()
        {
            var results = from anim in Animals
                          where anim.GetType() == typeof(Dog)
                          select anim as Dog;
            return results.ToList();
        }
        static List<Cat> GetAllCats()
        {
            var results = from anim in Animals
                          where anim.GetType() == typeof(Cat)
                          select anim as Cat;
            return results.ToList();
        }
        static List<Animal> GetEvenAgedOnes()
        {
            var results = from anim in Animals
                          where anim.Age % 2 == 0
                          select anim;
            return results.ToList();
        }
        static Animal GetRandom()
        {
            return Animals[rng.Next(Animals.Count)];
        }
        static List<Animal> Search(string query)
        {
            var results = from anim in Animals
                          where anim.Name.Contains(query)
                          select anim;
            return results.ToList();
        }
        static List<Dog> GetPuppies()
        {
            var results = from anim in Animals
                          where anim.GetType() == typeof(Dog)
                                && anim.Age <= 2
                          select anim as Dog;
            return results.ToList();
        }
    }
}
