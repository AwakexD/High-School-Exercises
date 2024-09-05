using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterExtended
{
    public class AnimalShelter<T> where T : Animal
    {
        private List<T> animals;

        public AnimalShelter()
        {
            this.animals = new List<T>();
        }

        public void AddAnimal(T animal)
        {
            this.animals.Add(animal);
        }

        public bool ReleaseAnimal(string animalName)
        {
            T animal = this.animals.FirstOrDefault(a => a.Name == animalName);

            if (animal != null)
            {
                this.animals.Remove(animal);
                return true;
            }

            return false;
        }

        public int Count()
        {
            return this.animals.Count;
        }
    }
}
