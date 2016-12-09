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
                new Cat("Mistigrette", 1),
                new Dog("Toby", 2, "Chat"),
                new Dog("Pilou", 3, "Humain"),
                new Cat("Mistigrie", 1),
                new Cat("Tigrou", 2),
                new Cat("Garfield", 3),
                new Dog("Tigrou", 33, "Humain"),
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

            Animals.Sort(new AnimalComparer());
            foreach (var ani in Animals)
            {
                Console.WriteLine(ani);
            }

            Console.ReadLine();
        }
        static List<Dog> GetAllDogs()
        {
            return Animals.Where(anim => anim.GetType() == typeof (Dog))
                          .Select(anim => anim as Dog).ToList();
        }
        static List<Cat> GetAllCats()
        {
            return Animals.Where(a => a.GetType() == typeof (Cat))
                          .Select(a => a as Cat).ToList();
        }
        static List<Animal> GetEvenAgedOnes()
        {
            return Animals.Where(anim => anim.Age % 2 == 0).ToList();
        }
        static Animal GetRandom()
        {
            return Animals[rng.Next(Animals.Count)];
        }
        static List<Animal> Search(string query)
        {
            return Animals.Where(anim => anim.Name.Contains(query)).ToList();
        }
        static List<Dog> GetPuppies()
        {
            return Animals.Where(anim => anim.GetType() == typeof(Dog) && anim.Age <= 2)
                          .Select(anim => anim as Dog).ToList();
        }
    }
}
