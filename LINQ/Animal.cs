using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Dog : Animal
    {
        
        public string FavoriteBone { get; set; }
        public override string ToString()
        {
            return string.Format("{0} says 'woof' I am {1} and like " +
              "{2} bones", Name, Age, FavoriteBone);
        }
        public Dog(string name, int age, string bone)
        {
            Name = name;
            Age = age;
            FavoriteBone = bone;
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format("{0} says 'meow' I am {1}", Name, Age);
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void HaveBirthday() { Age += 1; }
    }

    public static class Utilities
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

}
