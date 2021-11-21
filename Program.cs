using InterfaceAnimal.AquaticAnimals;
using InterfaceAnimal.LandAnimals;
using System;

namespace InterfaceAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.AquaticAnimals = new Crab();

            animal.AquaticAnimals.Swim();

            animal.LandAnimals = new Monkey();
            animal.LandAnimals.Walk();
        }
    }
}
