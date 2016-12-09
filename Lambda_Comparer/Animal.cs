using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Comparer
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

    public class AnimalComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x.GetType() == typeof(Dog) && y.GetType() == typeof(Cat))
                return -1;

            else if (x.GetType() == typeof(Cat) && y.GetType() == typeof(Dog))
                return 1;

            else
            {
                if (x.Age != y.Age)
                    return x.Age - y.Age;
                else
                {
                    return string.CompareOrdinal(x.Name, y.Name);
                }
            }
        }
    }
}
