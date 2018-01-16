using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes = new List<Snake>();


            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                if (input[0] == "I'm" && input[1] == "your" && input[2] == "Huckleberry")
                {
                    break;
                }

                if (input.Length > 2)
                {
                    var clas = input[0];
                    var nam = input[1];
                    var age = int.Parse(input[2]);
                    var iq =int.Parse(input[3]);

                    if (clas == "Dog")
                    {
                        var newDog = new Dog()
                        {
                            Name = nam,
                            Age = age,
                            NumberOfLegs = iq
                        };
                        dogs.Add(newDog);
                    }
                    else if (clas == "Cat")
                    {
                        var newCat = new Cat()
                        {
                            Name = nam,
                            Age = age,
                            IntelligenceQuotient = iq
                        };
                        cats.Add(newCat);
                    }
                    else if (clas == "Snake")
                    {
                        var newSnake = new Snake()
                        {
                            Name = nam,
                            Age = age,
                            CrueltyCoefficient = iq
                        };
                        snakes.Add(newSnake);
                    }
                }
                else
                {
                    foreach (var dog in dogs)
                    {
                        if (input[1].Contains(dog.Name))
                        {
                            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
                            break;
                        }
                    }
                    foreach (var cat in cats)
                    {
                        if (input[1].Contains(cat.Name))
                        {
                            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
                            break;
                        }
                    }
                    foreach (var snake in snakes)
                    {
                        if (input[1].Contains(snake.Name))
                        {
                            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
                        }
                    }
                }
            }
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
    }
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }
    }
    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }
    }
}

