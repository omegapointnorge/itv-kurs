using System.Collections.Generic;
using Exercises;
using Solutions;

namespace Tests
{
    public class TestMethodData
    {
        public static List<Person> TestMethodPersons => new()
        {
            new Person
            {
                Name = "Allison",
                Age = 25,
                Height = 185,
                Weight = 70,
                DogId = 1
            },
            new Person
            {
                Name = "Carl",
                Age = 28,
                Height = 195,
                Weight = 90,
                DogId = 2
            },
            new Person
            {
                Name = "Ken",
                Age = 28,
                Height = 192,
                Weight = 110
            },
            new Person
            {
                Name = "John",
                Age = 22,
                Height = 192,
                Weight = 60
            }

        };

        public static List<Dog> TestMethodDogs => new List<Dog>
        {
            new()
            {
                Name = "Alex",
                DogId = 1
            },
            new()
            {
                Name = "Bota",
                DogId = 2
            },
            new()
            {
                Name = "Beef",
                DogId = 3
            },
            new()
            {
                Name = "Hendricks",
                DogId = 4
            }
        };
    }
}