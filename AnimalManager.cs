using System;

namespace ex1
{
    public class AnimalManager
    {
        public Animal[] animals = new Animal[0];

        public void Add(Animal animal)
        {
            Animal[] temp = new Animal[animals.Length + 1];
            for (int i = 0; i < animals.Length; i++)
                temp[i] = animals[i];
            temp[^1] = animal;
            animals = temp;
        }

        public void DoReport()
        {
            Animal animal;
            for (int i = 0; i < animals.Length; i++)
            {
                animal = animals[i];
                Console.WriteLine($"Nome: {animal.Name}");
                Console.WriteLine($"Dono: {animal.Owner}");
                Console.WriteLine($"Categoria: {animal.Category}\n");
            }
        }
    }
}
