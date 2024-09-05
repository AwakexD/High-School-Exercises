using System;

namespace AnimalShelterExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter<Dog> dogShelter = new AnimalShelter<Dog>();
            AnimalShelter<Cat> catShelter = new AnimalShelter<Cat>();

            string[] dogsData = Console.ReadLine().Split(';');
            string[] catsData = Console.ReadLine().Split(' ');

            foreach (var dogData in dogsData)
            {
                string[] tokens = dogData.Split('-');
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Dog dog = new Dog(name, age);
                dogShelter.AddAnimal(dog);
            }

            foreach (var catData in catsData)
            {
                string[] tokens = catData.Split('=');
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Cat cat = new Cat(name, age);
                catShelter.AddAnimal(cat);
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] tokens = command.Split();
                string animalType = tokens[0];
                string animalName = tokens[1];

                if (animalType == "Dog")
                {
                    if (dogShelter.ReleaseAnimal(animalName))
                    {
                        Console.WriteLine($"You successfully released {animalName}.");
                    }
                }
                else if (animalType == "Cat")
                {
                    if (catShelter.ReleaseAnimal(animalName))
                    {
                        Console.WriteLine($"You successfully released {animalName}.");
                    }
                }
            }

            Console.WriteLine($"We have {dogShelter.Count()} dogs and {catShelter.Count()} cats.");
        }
    }
}
