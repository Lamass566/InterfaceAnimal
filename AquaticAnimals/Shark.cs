using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimal.AquaticAnimals
{
    public class Shark : IAquaticAnimals
    {
        public int Weight { get; }
        public string Says { get; }
        public Shark()
        {
            Weight = 122;
            Says = "Shark say aaaa";
        }
        public void Swim()
        {
            Console.WriteLine("Shark is swim and " + Says);
        }
    }
}
