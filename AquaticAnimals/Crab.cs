using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimal.AquaticAnimals
{
    public class Crab : IAquaticAnimals
    {
        public int Weight { get; set; }
        public string Says { get; set; }

        public Crab()
        {
            Weight = 21;
            Says = "Crab says Money Money Money";
        }
        public void Swim()
        {
            Console.WriteLine("Crab is swim and "+Says);
        }
    }
}
